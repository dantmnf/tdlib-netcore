using System;
using System.Buffers;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace TDLib.JsonClient
{
    internal sealed class ArrayPoolBufferWriter<T> : IBufferWriter<T>, IDisposable
    {
        private T[] _buffer;
        private int _index;

        private const int DefaultInitialBufferSize = 256;

        /// <summary>
        /// Creates an instance of an <see cref="ArrayPoolBufferWriter{T}"/>, in which data can be written to,
        /// with the default initial capacity.
        /// </summary>
        public ArrayPoolBufferWriter()
        {
            _buffer = Array.Empty<T>();
            _index = 0;
        }

        /// <summary>
        /// Creates an instance of an <see cref="ArrayPoolBufferWriter{T}"/>, in which data can be written to,
        /// with an initial capacity specified.
        /// </summary>
        /// <param name="initialCapacity">The minimum capacity with which to initialize the underlying buffer.</param>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="initialCapacity"/> is not positive (i.e. less than or equal to 0).
        /// </exception>
        public ArrayPoolBufferWriter(int initialCapacity)
        {
            if (initialCapacity <= 0)
                throw new ArgumentException(null, nameof(initialCapacity));

            _buffer = ArrayPool<T>.Shared.Rent(initialCapacity);
            _index = 0;
        }

        /// <summary>
        /// Returns the data written to the underlying buffer so far, as a <see cref="Memory{T}"/>.
        /// </summary>
        public Memory<T> WrittenMemory => _buffer.AsMemory(0, _index);

        /// <summary>
        /// Returns the data written to the underlying buffer so far, as a <see cref="Span{T}"/>.
        /// </summary>
        public Span<T> WrittenSpan
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get => _buffer.AsSpan(0, _index);
        }

        /// <summary>
        /// Returns the amount of data written to the underlying buffer so far.
        /// </summary>
        public int WrittenCount => _index;

        /// <summary>
        /// Returns the total amount of space within the underlying buffer.
        /// </summary>
        public int Capacity => _buffer.Length;

        /// <summary>
        /// Returns the amount of space available that can still be written into without forcing the underlying buffer to grow.
        /// </summary>
        public int FreeCapacity => _buffer.Length - _index;

        /// <summary>
        /// Clears the data written to the underlying buffer.
        /// </summary>
        /// <remarks>
        /// You must clear the <see cref="ArrayPoolBufferWriter{T}"/> before trying to re-use it.
        /// </remarks>
        public void Clear()
        {
            Debug.Assert(_buffer.Length >= _index);
            _buffer.AsSpan(0, _index).Clear();
            _index = 0;
        }

        /// <summary>
        /// Resets written length without touching the underlying buffer.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Reset()
        {
            Debug.Assert(_buffer.Length >= _index);
            _index = 0;
        }

        /// <summary>
        /// Notifies <see cref="IBufferWriter{T}"/> that <paramref name="count"/> amount of data was written to the output <see cref="Span{T}"/>/<see cref="Memory{T}"/>
        /// </summary>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="count"/> is negative.
        /// </exception>
        /// <exception cref="InvalidOperationException">
        /// Thrown when attempting to advance past the end of the underlying buffer.
        /// </exception>
        /// <remarks>
        /// You must request a new buffer after calling Advance to continue writing more data and cannot write to a previously acquired buffer.
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Advance(int count)
        {
            if (count < 0)
                throw new ArgumentException(null, nameof(count));

            if (_index > _buffer.Length - count)
                ThrowInvalidOperationException_AdvancedTooFar(_buffer.Length);

            _index += count;
        }

        /// <summary>
        /// Returns a <see cref="Memory{T}"/> to write to that is at least the requested length (specified by <paramref name="sizeHint"/>).
        /// If no <paramref name="sizeHint"/> is provided (or it's equal to <code>0</code>), some non-empty buffer is returned.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="sizeHint"/> is negative.
        /// </exception>
        /// <remarks>
        /// This will never return an empty <see cref="Memory{T}"/>.
        /// </remarks>
        /// <remarks>
        /// There is no guarantee that successive calls will return the same buffer or the same-sized buffer.
        /// </remarks>
        /// <remarks>
        /// You must request a new buffer after calling Advance to continue writing more data and cannot write to a previously acquired buffer.
        /// </remarks>
        public Memory<T> GetMemory(int sizeHint = 0)
        {
            CheckAndResizeBuffer(sizeHint);
            Debug.Assert(_buffer.Length > _index);
            return _buffer.AsMemory(_index);
        }

        /// <summary>
        /// Returns a <see cref="Span{T}"/> to write to that is at least the requested length (specified by <paramref name="sizeHint"/>).
        /// If no <paramref name="sizeHint"/> is provided (or it's equal to <code>0</code>), some non-empty buffer is returned.
        /// </summary>
        /// <exception cref="ArgumentException">
        /// Thrown when <paramref name="sizeHint"/> is negative.
        /// </exception>
        /// <remarks>
        /// This will never return an empty <see cref="Span{T}"/>.
        /// </remarks>
        /// <remarks>
        /// There is no guarantee that successive calls will return the same buffer or the same-sized buffer.
        /// </remarks>
        /// <remarks>
        /// You must request a new buffer after calling Advance to continue writing more data and cannot write to a previously acquired buffer.
        /// </remarks>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Span<T> GetSpan(int sizeHint = 0)
        {
            CheckAndResizeBuffer(sizeHint);
            Debug.Assert(_buffer.Length > _index);
            return _buffer.AsSpan(_index);
        }

        [MethodImpl(MultiTargetHelper.MethodImplOptions_AggressiveOptimization)]
        private void CheckAndResizeBuffer(int sizeHint)
        {
            if (sizeHint < 0)
                throw new ArgumentException(nameof(sizeHint));

            if (sizeHint == 0)
            {
                sizeHint = 1;
            }

            if (sizeHint > FreeCapacity)
            {
                int currentLength = _buffer.Length;
                int growBy = sizeHint > currentLength ? sizeHint : currentLength;

                if (currentLength == 0)
                {
                    growBy = growBy > DefaultInitialBufferSize ? growBy : DefaultInitialBufferSize;
                }

                int newSize = currentLength + growBy;

                if ((uint)newSize > int.MaxValue)
                {
                    newSize = currentLength + sizeHint;
                    if ((uint)newSize > int.MaxValue)
                    {
                        ThrowOutOfMemoryException((uint)newSize);
                    }
                }

                var newarray = ArrayPool<T>.Shared.Rent(newSize);
                _buffer.CopyTo(newarray, 0);
                ArrayPool<T>.Shared.Return(_buffer);
                _buffer = newarray;
            }

            Debug.Assert(FreeCapacity > 0 && FreeCapacity >= sizeHint);
        }

        private static void ThrowInvalidOperationException_AdvancedTooFar(int capacity)
        {
            throw new InvalidOperationException("advanced too far");
        }

        private static void ThrowOutOfMemoryException(uint capacity)
        {
            throw new OutOfMemoryException();
        }

        /// <summary>
        /// Invalidates <see cref="WrittenMemory"/> and <see cref="WrittenSpan"/>.
        /// </summary>
        public void Dispose()
        {
            if (_buffer.Length != 0)
            {
                ArrayPool<T>.Shared.Return(_buffer);
            }
        }
    }
}

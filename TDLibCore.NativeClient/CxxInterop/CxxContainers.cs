using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using TDLibCore.Api;
using static TDLibCore.NativeClient.Native;

namespace TDLibCore.NativeClient.CxxInterop
{


    /// <summary>
    /// std::string*
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct CxxString
    {
        public CxxBytes bytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public CxxString(IntPtr x)
        {
            bytes = new CxxBytes(x);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string Fetch() => ToString();
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Set(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                bytes.Set(default(ReadOnlySpan<byte>));
                return;
            }
            var x = Encoding.UTF8.GetBytes(s);
            bytes.Set(x.AsSpan());
        }

        public static implicit operator string(CxxString x) => x.ToString();

        public static implicit operator IntPtr(CxxString x) => x.bytes.ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public unsafe override string ToString() => SpanToUTF8String(bytes.AsSpan());
    }

    /// <summary>
    /// std::string*
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal unsafe struct CxxBytes
    {
        public IntPtr ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public CxxBytes(IntPtr x)
        {
            ptr = x;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte[] Fetch() => ToArray();
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Set(ReadOnlySpan<byte> value)
        {
            if (value.IsEmpty)
            {
                td_bridge_string_setdata(ptr, null, 0);
            }
            fixed (byte* x = value)
                td_bridge_string_setdata(ptr, x, value.Length);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Set(ReadOnlyMemory<byte> value) => Set(value.Span);

        public static implicit operator byte[](CxxBytes x) => x.ToArray();
        public static implicit operator ReadOnlySpan<byte>(CxxBytes x) => x.AsSpan();
        public static implicit operator IntPtr(CxxBytes x) => x.ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ReadOnlySpan<byte> AsSpan()
        {
            var data = td_bridge_string_data(ptr, out var len);
            return new Span<byte>(data, (int)len).ToArray();
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public byte[] ToArray() => AsSpan().ToArray();
    }

    /// <summary>
    /// object_ptr&lt;T>* = std::unique_ptr&lt;T>*
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal unsafe struct CxxTLObject<T> where T : TLObject
    {
        public IntPtr ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public CxxTLObject(IntPtr x)
        {
            ptr = x;
        }

        public static implicit operator IntPtr(CxxTLObject<T> x) => x.ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T Fetch()
        {
            // var objptr = *(IntPtr*)ptr;
            //T obj = null;
            //td_bridge_object_ptr_fetch(ptr, (objptr, _)=> {
            //    if (objptr != IntPtr.Zero)
            //        obj = (T)TLObjectFactory.FetchCxxObject(objptr);
            //});
            var objptr = td_bridge_object_ptr_get(ptr);
            return objptr == IntPtr.Zero ? null : (T)TLObjectFactory.FetchCxxObject(objptr);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Set(T obj)
        {
            td_bridge_object_ptr_reset(ptr, TLObjectFactory.CreateCxxObject(obj));
            //var oldobj = *(IntPtr*)ptr;
            //if (oldobj != IntPtr.Zero)
            //    CxxAbi.FreeCxxTLObject(oldobj);
            //*(IntPtr*)ptr = obj == null ? IntPtr.Zero : obj.TdCreateCxxObject();
        }
    }

    /// <summary>
    /// std::vector&lt;int32_t>*
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal unsafe struct CxxVectorInt32
    {
        public IntPtr ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public CxxVectorInt32(IntPtr x)
        {
            ptr = x;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int[] Fetch() => ToArray();
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Set(ReadOnlySpan<int> value)
        {
            if (value.IsEmpty)
            {
                td_bridge_vector_int32_assign(ptr, null, 0);
                return;
            }
            fixed (int* x = value)
                td_bridge_vector_int32_assign(ptr, x, value.Length);
        }

        public static implicit operator int[](CxxVectorInt32 x) => x.ToArray();
        public static implicit operator ReadOnlySpan<int>(CxxVectorInt32 x) => x.AsSpan();
        public static implicit operator IntPtr(CxxVectorInt32 x) => x.ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Span<int> AsSpan()
        {
            var data = td_bridge_vector_int32_data(ptr, out var len);
            return new Span<int>(data, (int)len);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public int[] ToArray() => AsSpan().ToArray();
    }

    /// <summary>
    /// std::vector&lt;int64_t>*
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal unsafe struct CxxVectorInt64
    {
        public IntPtr ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public CxxVectorInt64(IntPtr x)
        {
            ptr = x;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long[] Fetch() => ToArray();
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Set(ReadOnlySpan<long> value)
        {
            if (value.IsEmpty)
            {
                td_bridge_vector_int64_assign(ptr, null, 0);
                return;
            }
            fixed (long* x = value)
                td_bridge_vector_int64_assign(ptr, x, value.Length);
        }

        public static implicit operator IntPtr(CxxVectorInt64 x) => x.ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Span<long> AsSpan()
        {
            var data = td_bridge_vector_int64_data(ptr, out var len);
            return new Span<long>(data, (int)len);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public long[] ToArray() => AsSpan().ToArray();
    }

    /// <summary>
    /// std::vector&lt;object_ptr&lt;T>>*
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal unsafe struct CxxVectorObject<T> where T : TLObject
    {
        public IntPtr ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public CxxVectorObject(IntPtr x)
        {
            ptr = x;
        }

        public static implicit operator IntPtr(CxxVectorObject<T> x) => x.ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T[] Fetch() => ToArray();
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Set(IEnumerable<T> data)
        {
            Clear();
            if (data != null)
                foreach (var x in data) Add(x);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Add(TLObject obj)
        {
            td_bridge_vector_object_emplace_back(ptr, TLObjectFactory.CreateCxxObject(obj));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Clear()
        {
            td_bridge_vector_object_clear(ptr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T[] ToArray()
        {
            var len = td_bridge_vector_object_size(ptr);
            var result = new T[len];
            for (long i = 0; i < len; i++)
            {
                result[i] = new CxxTLObject<T>(td_bridge_vector_object_at(ptr, i)).Fetch();
            }
            return result;
        }
    }

    /// <summary>
    /// std::vector&lt;std::string>*
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal unsafe struct CxxVectorString
    {
        public CxxVectorBytes vecbytes;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public CxxVectorString(IntPtr x)
        {
            vecbytes = new CxxVectorBytes(x);
        }

        public static implicit operator IntPtr(CxxVectorString x) => x.vecbytes.ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string[] Fetch() => ToArray();
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Set(IEnumerable<string> data)
        {
            Clear();
            if (data != null)
                foreach (var x in data) Add(x);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Clear() => vecbytes.Clear();

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Add(string value) => vecbytes.Add(Encoding.UTF8.GetBytes(value));

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public string[] ToArray()
        {
            var len = vecbytes.Length;
            var result = new string[len];
            for (long i = 0; i < len; i++)
            {
                result[i] = SpanToUTF8String(vecbytes.SpanAt(i));
            }
            return result;
        }
    }

    /// <summary>
    /// std::vector&lt;std::string>*
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal unsafe struct CxxVectorBytes
    {
        public IntPtr ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public CxxVectorBytes(IntPtr x)
        {
            ptr = x;
        }


        public static implicit operator IntPtr(CxxVectorBytes x) => x.ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Memory<byte>[] Fetch() => ToArray();
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Set(IEnumerable<Memory<byte>> data)
        {
            Clear();
            if (data != null)
                foreach (var x in data) Add(x.Span);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Add(ReadOnlySpan<byte> value)
        {
            fixed (byte* x = value)
                td_bridge_vector_string_emplace_back(ptr, x, value.Length);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Clear()
        {
            td_bridge_vector_string_clear(ptr);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public ReadOnlySpan<byte> SpanAt(long index)
        {
            if (index < 0 || index >= Length)
                throw new IndexOutOfRangeException();
            return td_bridge_vector_string_at(ptr, index).AsSpan();
        }

        public long Length => td_bridge_vector_string_size(ptr);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Memory<byte>[] ToArray()
        {
            var len = Length;
            var result = new Memory<byte>[len];
            for (long i = 0; i < len; i++)
            {
                result[i] = td_bridge_vector_string_at(ptr, i).ToArray();
            }
            return result;
        }
    }

    /// <summary>
    /// std::vector&lt;std::vector&lt;object_ptr&lt;T>>>*
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct CxxVectorVectorObject<T> where T : TLObject
    {
        public IntPtr ptr;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public CxxVectorVectorObject(IntPtr x)
        {
            ptr = x;
        }

        public static implicit operator IntPtr(CxxVectorVectorObject<T> x) => x.ptr;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T[][] Fetch() => ToArray();
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Set(IEnumerable<IEnumerable<T>> data)
        {
            Clear();
            if (data != null)
                foreach (var x in data) Add(x);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Clear()
        {
            td_bridge_vector_vector_object_clear(ptr);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public void Add(IEnumerable<T> value)
        {
            var vec = new CxxVectorObject<T>(td_bridge_vector_vector_object_emplace_back(ptr));
            if (value == null) return;
            foreach (var obj in value)
            {
                vec.Add(obj);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public T[][] ToArray()
        {
            var len = td_bridge_vector_vector_object_size(ptr);
            var result = new T[len][];
            for (long i = 0; i < len; i++)
            {
                result[i] = new CxxVectorObject<T>(td_bridge_vector_vector_object_at(ptr, i)).ToArray();
            }
            return result;
        }
    }
}

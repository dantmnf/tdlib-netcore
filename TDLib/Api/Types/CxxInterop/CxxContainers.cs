using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.InteropServices;


namespace TDLib.Api.Types.CxxInterop
{
    using System.Security;
    using static Native;

    [SuppressUnmanagedCodeSecurity]
    internal unsafe static class Native
    {
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr td_bridge_vector_vector_object_at(IntPtr ptr, long index);
        public static CxxVectorObject<T> td_bridge_vector_vector_object_at<T>(IntPtr ptr, long index) where T : TLObject
        {
            return new CxxVectorObject<T>(td_bridge_vector_vector_object_at(ptr, index));
        }

        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern long td_bridge_vector_vector_object_size(IntPtr ptr);
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr td_bridge_vector_vector_object_emplace_back(IntPtr ptr);
        public static CxxVectorObject<T> td_bridge_vector_vector_object_emplace_back<T>(IntPtr ptr) where T : TLObject
        {
            return new CxxVectorObject<T>(td_bridge_vector_vector_object_emplace_back(ptr));
        }
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern void td_bridge_vector_vector_object_clear(IntPtr ptr);
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern byte* td_bridge_string_data(IntPtr ptr, out long len);
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern void td_bridge_string_setdata(IntPtr ptr, byte* data, long len);
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern int* td_bridge_vector_int32_data(IntPtr ptr, out long len);
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern void td_bridge_vector_int32_assign(IntPtr ptr, int* data, long len);
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern int* td_bridge_vector_int64_data(IntPtr ptr, out long len);
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern void td_bridge_vector_int64_assign(IntPtr ptr, long* data, long len);
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr* td_bridge_vector_object_data(IntPtr ptr, out long len);
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern void td_bridge_vector_object_emplace_back(IntPtr ptr, IntPtr obj);
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern void td_bridge_vector_object_clear(IntPtr ptr);
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern CxxBytes td_bridge_vector_string_at(IntPtr ptr, long index);
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern long td_bridge_vector_string_size(IntPtr ptr);
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern void td_bridge_vector_string_emplace_back(IntPtr ptr, byte* data, long len);
        [DllImport("tdbridge", CallingConvention = CallingConvention.Cdecl)]
        public static extern void td_bridge_vector_string_clear(IntPtr ptr);
    }

    /// <summary>
    /// std::string*
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal struct CxxString
    {
        public CxxBytes bytes;

        public CxxString(IntPtr x)
        {
            bytes = new CxxBytes(x);
        }

        public string Fetch() => ToString();
        public void Set(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                bytes.Set(default);
                return;
            }
            var x = Encoding.UTF8.GetBytes(s);
            bytes.Set(x);
        }

        public static implicit operator string(CxxString x) => x.ToString();

        public static implicit operator IntPtr(CxxString x) => x.bytes.ptr;

        public override string ToString() => Encoding.UTF8.GetString(bytes.AsSpan());
    }

    /// <summary>
    /// std::string*
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal unsafe struct CxxBytes
    {
        public IntPtr ptr;

        public CxxBytes(IntPtr x)
        {
            ptr = x;
        }

        public byte[] Fetch() => ToArray();
        public void Set(ReadOnlySpan<byte> value)
        {
            if (value.IsEmpty)
            {
                td_bridge_string_setdata(ptr, null, 0);
            }
            fixed (byte* x = value)
                td_bridge_string_setdata(ptr, x, value.Length);
        }

        public static implicit operator byte[] (CxxBytes x) => x.ToArray();
        public static implicit operator ReadOnlySpan<byte>(CxxBytes x) => x.AsSpan();
        public static implicit operator IntPtr(CxxBytes x) => x.ptr;

        public ReadOnlySpan<byte> AsSpan()
        {
            var data = td_bridge_string_data(ptr, out var len);
            return new Span<byte>(data, (int)len).ToArray();
        }

        public byte[] ToArray() => AsSpan().ToArray();
    }

    /// <summary>
    /// object_ptr&lt;T>* = std::unique_ptr&lt;T>*
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal unsafe struct CxxTLObject<T> where T : TLObject
    {
        public IntPtr ptr;
        public CxxTLObject(IntPtr x)
        {
            ptr = x;
        }

        public static implicit operator IntPtr(CxxTLObject<T> x) => x.ptr;

        public T Fetch()
        {
            var objptr = *(IntPtr*)ptr;
            return objptr == IntPtr.Zero ? null : (T)TLObjectFactory.FetchCxxObject(objptr);
        }
        public void Set(T obj)
        {
            var oldobj = *(IntPtr*)ptr;
            if (oldobj != IntPtr.Zero)
                CxxAbi.FreeCxxTLObject(oldobj);
            *(IntPtr*)ptr = obj == null ? IntPtr.Zero : obj.TdCreateCxxObject();
        }
    }

    /// <summary>
    /// std::vector&lt;int32_t>*
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal unsafe struct CxxVectorInt32
    {
        public IntPtr ptr;

        public CxxVectorInt32(IntPtr x)
        {
            ptr = x;
        }

        public int[] Fetch() => ToArray();
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

        public static implicit operator int[] (CxxVectorInt32 x) => x.ToArray();
        public static implicit operator ReadOnlySpan<int>(CxxVectorInt32 x) => x.AsSpan();
        public static implicit operator IntPtr(CxxVectorInt32 x) => x.ptr;

        public ReadOnlySpan<int> AsSpan()
        {
            var data = td_bridge_vector_int32_data(ptr, out var len);
            return new ReadOnlySpan<int>(data, (int)len).ToArray();
        }

        public int[] ToArray() => AsSpan().ToArray();
    }

    /// <summary>
    /// std::vector&lt;int64_t>*
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal unsafe struct CxxVectorInt64
    {
        public IntPtr ptr;

        public CxxVectorInt64(IntPtr x)
        {
            ptr = x;
        }

        public long[] Fetch() => ToArray();
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

        public ReadOnlySpan<long> AsSpan()
        {
            var data = td_bridge_vector_int64_data(ptr, out var len);
            return new Span<long>(data, (int)len).ToArray();
        }

        public long[] ToArray() => AsSpan().ToArray();
    }

    /// <summary>
    /// std::vector&lt;object_ptr&lt;T>>*
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal unsafe struct CxxVectorObject<T> where T : TLObject
    {
        public IntPtr ptr;

        public CxxVectorObject(IntPtr x)
        {
            ptr = x;
        }

        public static implicit operator IntPtr(CxxVectorObject<T> x) => x.ptr;

        public T[] Fetch() => ToArray();
        public void Set(IEnumerable<T> data)
        {
            Clear();
            if (data != null)
                foreach (var x in data) Add(x);
        }
        public void Add(TLObject obj)
        {
            td_bridge_vector_object_emplace_back(ptr, obj.TdCreateCxxObject());
        }

        public void Clear()
        {
            td_bridge_vector_object_clear(ptr);
        }

        public T[] ToArray()
        {
            var data = td_bridge_vector_object_data(ptr, out var len);
            var span = new ReadOnlySpan<IntPtr>(data, (int)len).ToArray();
            return span.Select(x => (T)TLObjectFactory.FetchCxxObject(x)).ToArray();
        }
    }

    /// <summary>
    /// std::vector&lt;std::string>*
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    internal unsafe struct CxxVectorString
    {
        public CxxVectorBytes vecbytes;

        public CxxVectorString(IntPtr x)
        {
            vecbytes = new CxxVectorBytes(x);
        }

        public static implicit operator IntPtr(CxxVectorString x) => x.vecbytes.ptr;

        public string[] Fetch() => ToArray();
        public void Set(IEnumerable<string> data)
        {
            Clear();
            if (data != null)
                foreach (var x in data) Add(x);
        }
        public void Clear() => vecbytes.Clear();

        public void Add(string value) => vecbytes.Add(Encoding.UTF8.GetBytes(value));

        public string[] ToArray()
        {
            var len = vecbytes.Length;
            var result = new string[len];
            for (long i = 0; i < len; i++)
            {
                result[i] = Encoding.UTF8.GetString(vecbytes.SpanAt(i));
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

        public CxxVectorBytes(IntPtr x)
        {
            ptr = x;
        }


        public static implicit operator IntPtr(CxxVectorBytes x) => x.ptr;

        public byte[][] Fetch() => ToArray();
        public void Set(IEnumerable<byte[]> data)
        {
            Clear();
            if (data != null)
                foreach (var x in data) Add(x);
        }
        public void Add(ReadOnlySpan<byte> value)
        {
            fixed (byte* x = value)
                td_bridge_vector_string_emplace_back(ptr, x, value.Length);
        }
        public void Clear()
        {
            td_bridge_vector_string_clear(ptr);
        }

        public ReadOnlySpan<byte> SpanAt(long index)
        {
            if (index < 0 || index >= Length)
                throw new IndexOutOfRangeException();
            return td_bridge_vector_string_at(ptr, index).AsSpan();
        }

        public long Length => td_bridge_vector_string_size(ptr);

        public byte[][] ToArray()
        {
            var len = Length;
            var result = (byte[][])Array.CreateInstance(typeof(byte[]), len);
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

        public CxxVectorVectorObject(IntPtr x)
        {
            ptr = x;
        }

        public static implicit operator IntPtr(CxxVectorVectorObject<T> x) => x.ptr;
        public T[][] Fetch() => ToArray();
        public void Set(IEnumerable<IEnumerable<T>> data)
        {
            Clear();
            if (data != null)
                foreach (var x in data) Add(x);
        }
        public void Clear()
        {
            td_bridge_vector_vector_object_clear(ptr);
        }
        public void Add(IEnumerable<T> value)
        {
            var vec = td_bridge_vector_vector_object_emplace_back<T>(ptr);
            if (value == null) return;
            foreach (var obj in value)
            {
                vec.Add(obj);
            }
        }

        public T[][] ToArray()
        {
            var len = td_bridge_vector_vector_object_size(ptr);
            var result = (T[][])Array.CreateInstance(typeof(T[]), len);
            for (long i = 0; i < len; i++)
            {
                result[i] = td_bridge_vector_vector_object_at<T>(ptr, i).ToArray();
            }
            return result;
        }
    }
}

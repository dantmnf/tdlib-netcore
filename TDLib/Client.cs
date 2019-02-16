using System;
using System.Collections.Generic;
using System.Collections.Concurrent;
using System.Text;
using System.Runtime.InteropServices;
using Newtonsoft.Json;
using TDLib.Api;
using TDLib.Api.Types;
using static TDLib.Native;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace TDLib
{
    public class Client : IDisposable
    {
        private readonly IntPtr unmanaged_client;
        //private readonly static JsonSerializerSettings jsonSerializerSetting;
        //private readonly JsonSerializer serializer;
        //private readonly JsonConverter converter;
        private readonly ConcurrentDictionary<long, TaskCompletionSource<TLObject>> invokes;
        private readonly CancellationTokenSource cts;
        private readonly CancellationToken ct;
        private Task loopTask;
        private long invoke_sequence;

        public event EventHandler<Update> Update;

        //static Client()
        //{
        //    jsonSerializerSetting = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };
        //}

        public Client()
        {
            unmanaged_client = td_json_client_create();
            //converter = new TLObjectConverter();
            //serializer = JsonSerializer.Create(jsonSerializerSetting);
            //serializer.Formatting = Formatting.None;
            //serializer.Converters.Add(converter);
            invokes = new ConcurrentDictionary<long, TaskCompletionSource<TLObject>>();
            cts = new CancellationTokenSource();
            ct = cts.Token;
        }

        //public byte[] TLObjectToBytes(TLObject obj)
        //{
        //    var json = JsonConvert.SerializeObject(obj, Formatting.None, jsonSerializerSetting);
        //    var utf8bytes = new byte[Encoding.UTF8.GetByteCount(json) + 1];
        //    Encoding.UTF8.GetBytes(json, 0, json.Length, utf8bytes, 0);
        //    return utf8bytes;
        //}

        //public TLObject CStringToTLObject(ReadOnlySpan<byte> cstr)
        //{
        //    if (cstr.IsEmpty || cstr.Length == 0) return null;

        //    var json = Encoding.UTF8.GetString(cstr);
        //    return JsonConvert.DeserializeObject<TLObject>(json, converter);

        //}

        public static TLObject CStringToTLObject(ReadOnlySpan<byte> cstr)
        {
            if (cstr.IsEmpty || cstr.Length == 0) return null;

            TdJsonReader parser = new TdJsonReader(cstr);
            var obj = (TLObject)parser.ReadValue();
            return obj;
        }

        public static ArraySegment<byte> TLObjectToBytes(TLObject obj)
        {
            var s = new MemoryStream(128);
            var writer = new TdJsonWriter(s);
            writer.WriteValue(obj);
            s.WriteByte(0);
            if (s.TryGetBuffer(out var buf))
            {
                return buf;
            }
            else
            {
                return s.ToArray();
            }
        }

        /// <summary>
        /// Execute function <paramref name="func"/> synchronously.
        /// <seealso cref="Execute(Function)"/>
        /// </summary>
        /// <typeparam name="T">The return type of <paramref name="func"/>.</typeparam>
        /// <param name="func">The function and parameters.</param>
        /// <returns>The return value of <paramref name="func"/>.</returns>
        /// <exception cref="TDLibError">Thrown if the function returns an <see cref="error"/></exception>
        public T Execute<T>(Function<T> func) where T : TLObject
        {
            var obj = Execute((Function)func);
            if (obj is Error e)
            {
                throw new TDLibError(e);
            }
            return obj as T;
        }

        /// <summary>
        /// Execute function <paramref name="func"/> synchronously, cast the return value to <typeparamref name="T"/> or null.
        /// <seealso cref="Execute(Function)"/>
        /// </summary>
        /// <typeparam name="T">The expected return type.</typeparam>
        /// <param name="func">The function and parameters.</param>
        /// <returns>The return value of <paramref name="func"/>.</returns>
        /// <exception cref="TDLibError">Thrown if the function returns an <see cref="error"/></exception>
        public T Execute<T>(Function func) where T : class
        {
            var obj = Execute((Function)func);
            if (obj is Error e)
            {
                throw new TDLibError(e);
            }
            return obj as T;
        }
        /// <summary>
        /// Synchronously executes TDLib request. May be called from any thread.
        /// Only a few requests can be executed synchronously.
        /// </summary>
        /// <param name="func">The function and parameters.</param>
        /// <returns>The return value of <paramref name="func"/>.</returns>
        public unsafe TLObject Execute(Function func)
        {
            var requestbytes = TLObjectToBytes(func);
            byte* result;
            fixed (byte* str = requestbytes.Array)
                result = td_json_client_execute(unmanaged_client, str + requestbytes.Offset);
            if (result == null) return null;
            var obj = CStringToTLObject(new ReadOnlySpan<byte>(result, strlen(result)));
            return obj;
        }

        /// <summary>
        /// Sends request to the TDLib client. May be called from any thread.
        /// </summary>
        /// <param name="func">The function and parameters.</param>
        public unsafe void Send(Function func)
        {
            var requestbytes = TLObjectToBytes(func);
            fixed (byte* str = requestbytes.Array)
                td_json_client_send(unmanaged_client, str + requestbytes.Offset);
        }

        /// <summary>
        /// Receives incoming updates and request responses from the TDLib client.
        /// May be called from any thread, but shouldn't be called simultaneously from two different threads.
        /// </summary>
        /// <param name="timeout">Maximum number of seconds allowed for this function to wait for new data.</param>
        /// <returns>The object received.</returns>
        public unsafe TLObject Receive(double timeout)
        {
            var result = (byte*)td_json_client_receive(unmanaged_client, timeout);
            if (result == null) return null;
            return CStringToTLObject(new ReadOnlySpan<byte>(result, strlen(result)));
        }

        private long AddInvoke(TaskCompletionSource<TLObject> tsc)
        {
            while (true)
            {
                Interlocked.Increment(ref invoke_sequence);
                var seq = invoke_sequence;
                if (invokes.TryAdd(seq, tsc))
                    return seq;
            }
        }

        /// <summary>
        /// Invokes function <paramref name="func"/> asynchronously.
        /// </summary>
        /// <param name="func">The function and parameters to be invoked.</param>
        /// <returns>A Task that will resolve to the return value of <paramref name="func"/>.</returns>
        public Task<TLObject> InvokeAsync(Function func)
        {
            var tsc = new TaskCompletionSource<TLObject>();
            var seq = AddInvoke(tsc);
            var oldextra = func.Extra;
            func.Extra = seq;
            Send(func);
            func.Extra = oldextra;

            return tsc.Task;
        }

        /// <summary>
        /// <seealso cref="InvokeAsync(Function)"/>.
        /// This overload returns the result as type <typeparamref name="T"/>,
        /// or throws if the invocation returns an <see cref="error"/>.
        /// </summary>
        /// <typeparam name="T">The return type of <paramref name="func"/></typeparam>
        /// <param name="func">The function and parameters to be invoked.</param>
        /// <returns>A Task that will resolve to the return value of <paramref name="func"/> or null.</returns>
        /// <exception cref="TDLibError">Thrown if the function returns an <see cref="error"/></exception>
        public async Task<T> InvokeAsync<T>(Function func) where T : TLObject
        {
            var result = await InvokeAsync((Function)func);
            if (result is Error e)
            {
                throw new TDLibError(e);
            }
            return result as T;
        }

        /// <summary>
        /// <seealso cref="InvokeAsync(Function)"/>.
        /// This overload returns the type defined by <paramref name="func"/>,
        /// or throws if the invocation returns an <see cref="error"/>.
        /// </summary>
        /// <typeparam name="T">The return type of <paramref name="func"/></typeparam>
        /// <param name="func">The function and parameters to be invoked.</param>
        /// <returns>A Task that will resolve to the return value of <paramref name="func"/>.</returns>
        /// <exception cref="TDLibError">Thrown if the function returns an <see cref="error"/></exception>
        public async Task<T> InvokeAsync<T>(Function<T> func) where T : TLObject
        {
            var result = await InvokeAsync((Function)func);
            if (result is Error e)
            {
                throw new TDLibError(e);
            }
            return result as T;
        }


        public Task<Update> WaitForUpdate(Func<Update, bool> criterion, CancellationToken ct = default(CancellationToken))
        {
            var tsc = new TaskCompletionSource<Update>();
            EventHandler<Update> handler = null;
            handler = (sender, u) =>
            {
                if (criterion(u))
                {
                    Update -= handler;
                    tsc.TrySetResult(u);
                }
            };
            Update += handler;
            ct.Register(() =>
            {
                Update -= handler;
                tsc.TrySetCanceled(ct);
            });
            return tsc.Task;
        }


        private void RunLoop()
        {
            TLObject obj;
            while (!ct.IsCancellationRequested)
            {
                obj = Receive(1.0);
                if (obj == null) continue;
                if (obj is Update u)
                {
                    Update?.Invoke(this, u);
                    // TODO
                }
                if (obj.Extra is long seq)
                {
                    if (invokes.TryRemove(seq, out var tsc))
                    {
                        obj.Extra = null;
                        tsc.SetResult(obj);
                    }
                }
            }
        }

        /// <summary>
        /// Starts the tdlib event loop. Required for <see cref="InvokeAsync(Function)"/>, <see cref="InvokeAsync{T}(Function)"/>, <see cref="InvokeAsync{T}(Function{T})"/>.
        /// </summary>
        /// <returns>The event loop Task.</returns>
        public Task Run()
        {
            if (loopTask == null)
            {
                loopTask = Task.Run(() =>
                {
                    RunLoop();
                });
            }
            return loopTask;
        }

        /// <summary>
        /// Requests the event loop to stop.
        /// </summary>
        /// <returns>The event loop Task, which can be awaited for stop, or a canceled Task if the event loop is not started.</returns>
        public Task StopAsync()
        {
            cts.Cancel();
            if (loopTask != null)
            {
                return loopTask;
            }
            return Task.FromCanceled(default);
        }

        #region IDisposable Support
        private bool disposed = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.
                if (unmanaged_client != IntPtr.Zero)
                    td_json_client_destroy(unmanaged_client);

                disposed = true;
            }
        }

        ~Client()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}

using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TDLib.Api;
using TDLib.Api.Types;
using File = System.IO.File;
using System.Diagnostics;
using System.Reflection;

namespace ConsoleApp2
{
    unsafe class Program
    {
#if DEBUG
        const int count = 1;
#else
        const int count = 1919;
#endif



        static void Main()
        {
            TDLib.Logging.LogLevel = 0;
            var client = new TDLib.Client();
            client.Dispose();

            var jdocs = new List<IntPtr>();

            using (var f = File.OpenRead("json.log"))
            using (var sr = new StreamReader(f, Encoding.UTF8))
            {
                while (!sr.EndOfStream)
                {
                    var json = sr.ReadLine();
                    var utf8bytes = new byte[Encoding.UTF8.GetByteCount(json) + 1];
                    Encoding.UTF8.GetBytes(json, 0, json.Length, utf8bytes, 0);
                    var ptr = Marshal.AllocHGlobal(utf8bytes.Length);
                    Marshal.Copy(utf8bytes, 0, ptr, utf8bytes.Length);
                    jdocs.Add(ptr);
                }
            }
            var jda = jdocs.ToArray();


            TestEquality(client, jda);

            var sw = Stopwatch.StartNew();
            for(int i = 0; i < count; i++)
            {
                BenchNewtonsoft(client, jda);
            }
            sw.Stop();
            var t = sw.Elapsed;
            Console.WriteLine("BenchNewtonsoft: {0}", t);

            sw.Restart();
            for (int i = 0; i < count; i++)
            {
                BenchTdJson(client, jda);
            }
            sw.Stop();
            var t2 = sw.Elapsed;
            Console.WriteLine("BenchTdJson: {0}", t2);
            Console.WriteLine("{0}x", t.TotalMilliseconds / t2.TotalMilliseconds);
            foreach (var ptr in jdocs)
            {
                Marshal.FreeHGlobal(ptr);
                
            }

        }

        [DllImport("kernel32", EntryPoint = "SetHandleCount")]
        private extern static void dummy(void* x);

        public static unsafe int strlen(byte* str)
        {
            int result = 0;
            while (*str++ != 0) result++;
            return result;
        }

        static void BenchNewtonsoft(TDLib.Client client, IntPtr[] jdocs)
        {
            foreach (var iptr in jdocs)
            {
                byte* ptr = (byte*)iptr;
                var obj = TDLib.Client.CStringToTLObject(new ReadOnlySpan<byte>(ptr, strlen(ptr)));
                var json = TDLib.Client.TLObjectToBytes(obj);
                Debug.WriteIf(false, json);
            }
        }

        static void BenchTdJson(TDLib.Client client, IntPtr[] jdocs)
        {
            //for (int i = 0; i < jdocs.Length; i++)
            //{
            //    var ptr = (byte*)jdocs[i];
            //    var obj = TDLib.Client.CStringToTLObjectTd(new ReadOnlySpan<byte>(ptr, strlen(ptr)));
            //    var json = TDLib.Client.TLObjectToBytesTd(obj);
            //    Debug.WriteIf(false, json);
            //}
        }

        static void TestEquality(TDLib.Client client, IntPtr[] jdocs)
        {
            //for (int i = 0; i < jdocs.Length; i++)
            //{
            //    var ptr = (byte*)jdocs[i];
            //    var span = new ReadOnlySpan<byte>(ptr, strlen(ptr));
            //    var obj1 = TDLib.Client.CStringToTLObjectTd(span);
            //    var json1 = TDLib.Client.TLObjectToBytesTd(obj1);
            //    var objx = client.CStringToTLObject(json1);
            //    var jsonx = client.TLObjectToBytes(objx);

            //    var obj2 = client.CStringToTLObject(span);
            //    var json2 = client.TLObjectToBytes(obj2);
            //    var eql = jsonx.SequenceEqual(json2);
            //    Debug.WriteLineIf(!eql, Encoding.UTF8.GetString(jsonx));
            //    Debug.WriteLineIf(!eql, "");
            //    Debug.WriteLineIf(!eql, Encoding.UTF8.GetString(json2));
            //    Debug.WriteLineIf(!eql, "");
            //}
        }
    }
}

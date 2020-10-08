using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using TDLib.Api;
using TDLib.JsonClient;

namespace bench
{
    class Program
    {

        static async Task<TimeSpan> BenchAsynchronous(TDLib.Client client, Function func)
        {
            TLObject result = null;
            Console.WriteLine($"200000 asynchronous invocations of {func.GetType().Name} using {client.GetType().Name}");
            client.RunEventLoop();

            Console.WriteLine("warm up");
            for (int i = 0; i < 300; i++)
            {
                result = await client.InvokeAsync(func).ConfigureAwait(false);
            }
            Console.WriteLine("start benchmark");

            var sw = Stopwatch.StartNew();
            for (int i = 0; i < 200000; i++)
            {
                result = await client.InvokeAsync(func).ConfigureAwait(false);
            }
            sw.Stop();
            await client.StopEventLoop();
            Console.WriteLine("Time elapsed: {0}", sw.Elapsed);
            return sw.Elapsed;
        }

        public static T CreateInstance<T>() where T : class, new() => new T();

        static TimeSpan BenchSynchronous(TDLib.Client client, Function func, int count)
        {
            TLObject result = null;
            Console.WriteLine($"{count} synchronous invocations of {func.GetType().Name} using {client.GetType().Name}");

            var sw = Stopwatch.StartNew();
            for (int i = 0; i < count; i++)
            {
                result = client.Execute(func);
            }
            sw.Stop();
            Console.WriteLine("Time elapsed: {0}", sw.Elapsed);
            return sw.Elapsed;
        }

        static void Main(string[] args)
        {

            //var json = Encoding.UTF8.GetBytes("\"abcdefghijk\":1,\"fff\":\"gggg\"}");
            //var reader = new Utf8JsonReader(json);
            //if (reader.Read())
            //{
            //    if (reader.TokenType == JsonTokenType.String || reader.TokenType == JsonTokenType.PropertyName)
            //    {
            //        var s = reader.GetString();
            //        Debug.WriteLine(s);
            //        Debug.WriteLine(reader.BytesConsumed);
            //    }
            //}


            var func = new GetTextEntities("/ban_shanye@lgjjbot #山野 @shanye https://github.com/ShanYe/ shanye@shanye.com 少发点山野对大家都好");
            //var func = new TestSquareInt(2);
            TimeSpan jsonts, cxxts;
            var tss = new List<TimeSpan>();
            JsonClient.Logging.VerbosityLevel = 1;
            using (var client = new JsonClient())
            {
                jsonts = BenchSynchronous(client, func, 1000);
                tss.Add(BenchSynchronous(client, func, 800000));
                //BenchAsynchronous(client, func).GetAwaiter().GetResult();

            }
            //var mean = tss.Average(x=>x.TotalSeconds);
            //var stddev = Math.Sqrt(tss.Average(x => Math.Pow(x.TotalSeconds - mean, 2)));
            //Console.WriteLine($"Min = {tss.Min().TotalSeconds}, Max = {tss.Max().TotalSeconds}, Mean = {mean}, stddev = {stddev}");
            //CxxClient.Logging.VerbosityLevel = 1;
            //using (var client = new CxxClient())
            //{
            //    cxxts = BenchSynchronous(client, func);
            //    //BenchAsynchronous(client, func).GetAwaiter().GetResult();
            //}

            //Console.WriteLine("JSON serialization/deserialization overhead: {0}%", (jsonts.Ticks - cxxts.Ticks) / (double)cxxts.Ticks * 100);
        }
    }
}

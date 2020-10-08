using System;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class AsyncConsole
    {
        private static object readlock = new object();
        public static Task<string> ReadLine()
        {
            return Task.Run(() =>
            {
                lock (readlock)
                    return Console.ReadLine();
            });
        }

        public static Task Write(string x)
        {
            return Task.Run(() => Console.Write(x));
        }

        public static Task WriteLine(string x)
        {
            return Task.Run(() => Console.WriteLine(x));
        }
    }
}

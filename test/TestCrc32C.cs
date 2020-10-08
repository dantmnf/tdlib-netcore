using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using TDLib.JsonClient;

namespace TDLib.Test
{
    [TestClass]
    public class TestCrc32C
    {
        [TestMethod]
        public unsafe void Run()
        {
            var sizes = new int[] { 3, 16, 512, 513, 65537 };
            int seed = 0;
            var rng1 = RandomNumberGenerator.Create();
            rng1.GetBytes(new Span<byte>(&seed, 4));
            var rng = new Random(seed);

            foreach (var len in sizes)
            {
                var input = new byte[len];
                rng.NextBytes(input);

                var crc1 = Crc32C.UpdateManaged(0, input);
                var crc2 = Crc32C.UpdateX86(0, input);
                var crc3 = Crc32C.UpdateX86_64(0, input);

                Assert.AreEqual(crc1, crc2);
                Assert.AreEqual(crc1, crc3);
            }
        }
    }
}

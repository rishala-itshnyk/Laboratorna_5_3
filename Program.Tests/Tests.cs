using System;
using NUnit.Framework;

namespace Program.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            double x = 3.0;
            double expected = (Math.Exp(x) + Math.Sin(x)) / ((Math.Pow(Math.Cos(x), 2) + 1));
            double actual = Program.k(x);
                Assert.AreEqual(expected, actual, 0.001);
        }
    }
}
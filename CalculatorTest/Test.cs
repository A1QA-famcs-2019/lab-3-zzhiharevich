using System;

namespace CalculatorTest
{
    using Calculator;
    using NUnit.Framework;

    [TestFixture]
    public class Test
    {
        [Test]
        public void TestMin()
        {
            int min;
            min = CalculatorClass.Min(3, 4, 5);
            Assert.AreEqual(2, min);
        }
    }
}

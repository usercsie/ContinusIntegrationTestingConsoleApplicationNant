using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Calculator.testing
{
    [TestFixture]
    class CalculatorTests
    {
        [Test]
        public void Add_OneAndOne_Return2()
        {
            Calculator p = new Calculator();
            int result = p.Add(1, 1);

            Assert.AreEqual(2, result);
        }

        [Test]
        public void Sub_OneAndOne_Return0()
        {
            Calculator p = new Calculator();
            int result = p.Sub(1, 1);

            Assert.AreEqual(0, result);
        }
    }
}

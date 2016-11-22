using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProjectCalc
{
    [TestClass]
    public class MathOperationTest
    {
        [TestMethod]
        public void Add()
        {
            Assert.IsTrue(2 + 2 == 4);
        }

        [TestMethod]
        public void Subtract()
        {
            Assert.IsTrue(4-4 == 0);
        }


        [TestMethod]
        public void Multiplication()
        {
            Assert.IsTrue(4 * 4 == 15,"Multiplication failed.");
        }

        [TestMethod]
        public void Division()
        {
            Assert.IsTrue(4 / 4 == 1);
        }

    }
}

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_04_array;

namespace Lab_04_array_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arange (setup)
            var arrayInstance = new Lab_04_array.Array();
            var expectedOutPut = 285;
            // (run code)
            var actualOutput = arrayInstance.CreateArray();
            //assert (see if test pass/fail)
            Assert.AreEqual(expectedOutPut, actualOutput);
        }
    }
}

using Lab_16_NUnit_XUnit_Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace lab_16_MSTest
{
    [TestClass]
    public class lab_16_Test_class
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arrange
            var expected01 = 64;
            var instance01 = new TestMenow();

            //act
            var actual = instance01.TestThisMethodWorks(2, 2, 3);

            //assert
            Assert.AreEqual(expected01, actual);
        }
    }
}

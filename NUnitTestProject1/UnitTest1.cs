using Lab_16_NUnit_XUnit_Tests;
using NUnit.Framework;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var expected = 36.0;

            var instance02 = new TestMenow();

            var actual = instance02.TestThisMethodWorks(2, 3, 2);

            Assert.AreEqual(expected, actual);
        }
    }
}
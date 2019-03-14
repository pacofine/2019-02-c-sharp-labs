using System;
using Xunit;
using Lab_16_NUnit_XUnit_Tests;

namespace lab_16_XUnit
{
    public class Lab_16_Test_Math_Power
    {
        [Fact]
        public void Test1()
        {
            //arrange
            var instance01 = new TestMenow();
            var expected01 = 9765625.0;

            //act
            var actual = instance01.TestThisMethodWorks(5, 5, 5);

            //assert
            Assert.Equal(expected01, actual);
        }
    }
}

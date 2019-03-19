using NUnit.Framework;
using lab_121_hash_set_to_excel;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }
        /*
         * start a stop watch 
         * not part of the test
         * Output all values to .csv text file and append to existing file 
         * dateTime stamp
         * input 4 params 
         * output 4 params 
         * finnally launch excel to read this file using process.start
        */

        [TestCase(10, 20, 30, 1000)]
        public void HashSetToExcelTest1(int a, int b, int c, long d)
        {
            //arange
            var instance = new HashSetToExcel();
            //act
            Custom actual = instance.HashSetToExcelTest(a, b, c);
            //assert
            Assert.LessOrEqual(actual.time, d);
            Assert.AreEqual(actual.first, 165);
            Assert.AreEqual(actual.second, 285);
            Assert.AreEqual(actual.third, 405);

        }
    }
}
using NUnit.Framework;
using lab_118_array_of_tests;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            //any setup code eg generate fresh database 
            //any initialization before run any test
        }

        [TestCase(1000, 7000)]
        [TestCase(10000, 60000)]
        [TestCase(1000, 500)]
        public void TestFileSynchronousReadWrite(int NumberOfFiles, long MaxTime)
        {
            //Arrange 
            var instance = new FileOperationSynchronous();
            //Act
            long timetaken = instance.FileReadWrite(NumberOfFiles);
            System.Console.WriteLine($"Time taken : {timetaken} milliseconds");
            //Assert
            Assert.Less(timetaken, MaxTime);
        }
    }
}
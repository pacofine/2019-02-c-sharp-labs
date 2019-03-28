//using System;   
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using lab_201._1_PhilsLab;
//using System.Linq;
//using lab_202_PhilsLab_Test;


//namespace lab_202_PhilsLab_Test
//{
//    [TestClass]
//    public class SumTests
//    {
//        [TestMethod]
//        public void SumOfaMil()
//        {
//            // arrange
//            var range = 1000000;
//            var testInstance = new Sum();
//            var expected = new SumAndTime()
//            {
//                TotalSum = 1783293664,
//                TimeTaken = 1000
//            };

//            // act
//            var actual = testInstance.SumOfaMill(range);

//            // assert
//            Assert.AreEqual(actual.TotalSum, expected.TotalSum);
//            Assert.IsTrue(actual.TimeTaken < expected.TimeTaken);

//            //using (var db = new lab_200._2_PhilsLab_Test.NorthwindEntities())
//            //{
//            //    TestResultsNew resultToCreate = new TestResultsNew
//            //    {
//            //        TestName = "SumOfaMil",
//            //        Range = 1000000,
//            //        TotalSum = actual.TimeTaken,
//            //        TimeElapsed = actual.TimeTaken
//            //    };

//            //}
//        }

//        [TestMethod]
//        public void MyArr()
//        {
//            //Arrange
//            var range = 1000000;
//            var testInstance = new Sum();
//            var expected = new SumAndTime()
//            {
//                TotalSum = 1783293664,
//                TimeTaken = 17
//            };
//            //Act
//            var actual = testInstance.MyArr(range);

//            //Assert
//            Assert.AreEqual(actual.TotalSum, expected.TotalSum);
//            Assert.IsTrue(actual.TimeTaken < expected.TimeTaken);
//        }

//        [TestMethod]
//        public void MyList()
//        {
//            //Arrange
//            var range = 1000000;
//            var testInstance = new Sum();
//            var expected = new SumAndTime()
//            {
//                TotalSum = 1784293664,
//                TimeTaken = 150
//            };

//            //Act
//            var actual = testInstance.MyList(range);

//            //Assert
//            Assert.AreEqual(actual.TotalSum, expected.TotalSum);
//            Assert.IsTrue(actual.TimeTaken < expected.TimeTaken);
//        }

//        [TestMethod]
//        public void MyQueue()
//        {
//            //Arrange
//            var range = 1000000;
//            var testInstance = new Sum();
//            var expected = new SumAndTime()
//            {
//                TotalSum = 1783293664,
//                TimeTaken = 28
//            };

//            //Act
//            var actual = testInstance.MyQueue(range);

//            //Assert
//            Assert.AreEqual(actual.TotalSum, expected.TotalSum);
//            Assert.IsTrue(actual.TimeTaken < expected.TimeTaken);
//        }

//        [TestMethod]
//        public void MyStack()
//        {
//            //Arrange
//            var range = 1000000;
//            var testInstance = new Sum();
//            var expected = new SumAndTime()
//            {
//                TotalSum = 1783293664,
//                TimeTaken = 18
//            };

//            //Act
//            var actual = testInstance.MyStack(range);

//            //Assert
//            Assert.AreEqual(actual.TotalSum, expected.TotalSum);
//            Assert.IsTrue(actual.TimeTaken < expected.TimeTaken);
//        }

//        [TestMethod]
//        public void MyDictionary()
//        {
//            //Arrange
//            var range = 1000000;
//            var testInstance = new Sum();
//            var expected = new SumAndTime()
//            {
//                TotalSum = 1783293664,
//                TimeTaken = 63
//            };

//            //Act
//            var actual = testInstance.MyDictionary(range);

//            //Assert
//            Assert.AreEqual(actual.TotalSum, expected.TotalSum);
//            Assert.IsTrue(actual.TimeTaken < expected.TimeTaken);
//        }

//        [TestMethod]
//        public void MyArrList()
//        {
//            //Arrange
//            var range = 1000000;
//            var testInstance = new Sum();
//            var expected = new SumAndTime()
//            {
//                TotalSum = 1783293664,
//                TimeTaken = 200
//            };

//            //Act
//            var actual = testInstance.MyArrList(range);

//            //Assert
//            Assert.AreEqual(actual.TotalSum, expected.TotalSum);
//            Assert.IsTrue(actual.TimeTaken < expected.TimeTaken);
//        }

//        [TestMethod]
//        public void MyHashSet()
//        {
//            //Arrange
//            var range = 1000000;
//            var testInstance = new Sum();
//            var expected = new SumAndTime()
//            {
//                TotalSum = 1783293664,
//                TimeTaken = 210
//            };

//            //Act
//            var actual = testInstance.MyHashSet(range);

//            //Assert
//            Assert.AreEqual(actual.TotalSum, expected.TotalSum);
//            Assert.IsTrue(actual.TimeTaken < expected.TimeTaken);
//        }

//        [TestMethod]
//        public void MyLinkedList()
//        {
//            //Arrange
//            var range = 1000000;
//            var testInstance = new Sum();
//            var expected = new SumAndTime()
//            {
//                TotalSum = 1783293664,
//                TimeTaken = 150
//            };

//            //Act
//            var actual = testInstance.MyLinkedList(range);

//            //Assert
//            Assert.AreEqual(actual.TotalSum, expected.TotalSum);
//            Assert.IsTrue(actual.TimeTaken < expected.TimeTaken);
//        }
//    }
//}

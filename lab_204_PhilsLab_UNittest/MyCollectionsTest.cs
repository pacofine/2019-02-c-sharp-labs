using System;
using lab_203_PhilsLab;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace lab_204_PhilsLab_UNittest
{
    [TestClass]
    public class MyCollectionsTest
    {
        [TestMethod]
        public void SumOfaMil()
        {
            // arrange
            var range = 1000000;
            var testInstance = new Sum();
            var expected = new SumAndTime()
            {
                TotalSum = 1783293664,
                TimeTaken = 1000
            };

            // act
            var actual = testInstance.SumOfaMill(range);

            // assert
            Assert.AreEqual(actual.TotalSum, expected.TotalSum);
            Assert.IsTrue(actual.TimeTaken < expected.TimeTaken);

            using (var db = new NorthwindEntities())
            {
                TestResultsNew resultToCreate = new TestResultsNew
                {
                    TestName = "SumOfaMil",
                    Range = range,
                    TotalSum = actual.TotalSum,
                    TimeElapsed = actual.TimeTaken
                };

                db.TestResultsNews.Add(resultToCreate);
                db.SaveChanges();
            }

        }


        [TestMethod]
        public void MyArr()
        {
            //Arrange
            var range = 1000000;
            var testInstance = new Sum();
            var expected = new SumAndTime()
            {
                TotalSum = 1783293664,
                TimeTaken = 17
            };
            //Act
            var actual = testInstance.MyArr(range);

            //Assert
            Assert.AreEqual(actual.TotalSum, expected.TotalSum);
            Assert.IsTrue(actual.TimeTaken < expected.TimeTaken);

            using (var db = new NorthwindEntities())
            {
                TestResultsNew resultToCreate = new TestResultsNew
                {
                    TestName = "MyArr",
                    Range = range,
                    TotalSum = actual.TotalSum,
                    TimeElapsed = actual.TimeTaken
                };
                
                db.TestResultsNews.Add(resultToCreate);
                db.SaveChanges();
            }
        }


        [TestMethod]
        public void MyList()
        {
            //Arrange
            var range = 1000000;
            var testInstance = new Sum();
            var expected = new SumAndTime()
            {
                TotalSum = 1784293664,
                TimeTaken = 150
            };

            //Act
            var actual = testInstance.MyList(range);

            //Assert
            Assert.AreEqual(actual.TotalSum, expected.TotalSum);
            Assert.IsTrue(actual.TimeTaken < expected.TimeTaken);

            using (var db = new NorthwindEntities())
            {
                TestResultsNew resultToCreate = new TestResultsNew
                {
                    TestName = "MyList",
                    Range = range,
                    TotalSum = actual.TotalSum,
                    TimeElapsed = actual.TimeTaken
                };
                
                db.TestResultsNews.Add(resultToCreate);
                db.SaveChanges();
            }
        }


        [TestMethod]
        public void MyQueue()
        {
            //Arrange
            var range = 1000000;
            var testInstance = new Sum();
            var expected = new SumAndTime()
            {
                TotalSum = 1783293664,
                TimeTaken = 28
            };

            //Act
            var actual = testInstance.MyQueue(range);

            //Assert
            Assert.AreEqual(actual.TotalSum, expected.TotalSum);
            Assert.IsTrue(actual.TimeTaken < expected.TimeTaken);

            using (var db = new NorthwindEntities())
            {
                TestResultsNew resultToCreate = new TestResultsNew
                {
                    TestName = "MyQueue",
                    Range = range,
                    TotalSum = actual.TotalSum,
                    TimeElapsed = actual.TimeTaken
                };

                db.TestResultsNews.Add(resultToCreate);
                db.SaveChanges();
            }
        }


        [TestMethod]
        public void MyStack()
        {
            //Arrange
            var range = 1000000;
            var testInstance = new Sum();
            var expected = new SumAndTime()
            {
                TotalSum = 1783293664,
                TimeTaken = 20
            };

            //Act
            var actual = testInstance.MyStack(range);

            //Assert
            Assert.AreEqual(actual.TotalSum, expected.TotalSum);
            Assert.IsTrue(actual.TimeTaken < expected.TimeTaken);

            using (var db = new NorthwindEntities())
            {
                TestResultsNew resultToCreate = new TestResultsNew
                {
                    TestName = "MyStack",
                    Range = range,
                    TotalSum = actual.TotalSum,
                    TimeElapsed = actual.TimeTaken
                };

                db.TestResultsNews.Add(resultToCreate);
                db.SaveChanges();
            }
        }


        [TestMethod]
        public void MyDictionary()
        {
            //Arrange
            var range = 1000000;
            var testInstance = new Sum();
            var expected = new SumAndTime()
            {
                TotalSum = 1783293664,
                TimeTaken = 63
            };

            //Act
            var actual = testInstance.MyDictionary(range);

            //Assert
            Assert.AreEqual(actual.TotalSum, expected.TotalSum);
            Assert.IsTrue(actual.TimeTaken < expected.TimeTaken);

            using (var db = new NorthwindEntities())
            {
                TestResultsNew resultToCreate = new TestResultsNew
                {
                    TestName = "MyDictionary",
                    Range = range,
                    TotalSum = actual.TotalSum,
                    TimeElapsed = actual.TimeTaken
                };

                db.TestResultsNews.Add(resultToCreate);
                db.SaveChanges();
            }
        }


        [TestMethod]
        public void MyArrList()
        {
            //Arrange
            var range = 1000000;
            var testInstance = new Sum();
            var expected = new SumAndTime()
            {
                TotalSum = 1783293664,
                TimeTaken = 200
            };

            //Act
            var actual = testInstance.MyArrList(range);

            //Assert
            Assert.AreEqual(actual.TotalSum, expected.TotalSum);
            Assert.IsTrue(actual.TimeTaken < expected.TimeTaken);

            using (var db = new NorthwindEntities())
            {
                TestResultsNew resultToCreate = new TestResultsNew
                {
                    TestName = "ArrList",
                    Range = range,
                    TotalSum = actual.TotalSum,
                    TimeElapsed = actual.TimeTaken
                };

                db.TestResultsNews.Add(resultToCreate);
                db.SaveChanges();
            }
        }


        [TestMethod]
        public void MyHashSet()
        {
            //Arrange
            var range = 1000000;
            var testInstance = new Sum();
            var expected = new SumAndTime()
            {
                TotalSum = 1783293664,
                TimeTaken = 210
            };

            //Act
            var actual = testInstance.MyHashSet(range);

            //Assert
            Assert.AreEqual(actual.TotalSum, expected.TotalSum);
            Assert.IsTrue(actual.TimeTaken < expected.TimeTaken);

            using (var db = new NorthwindEntities())
            {
                TestResultsNew resultToCreate = new TestResultsNew
                {
                    TestName = "MyHashSet",
                    Range = range,
                    TotalSum = actual.TotalSum,
                    TimeElapsed = actual.TimeTaken
                };

                db.TestResultsNews.Add(resultToCreate);
                db.SaveChanges();
            }
        }


        [TestMethod]
        public void MyLinkedList()
        {
            //Arrange
            var range = 1000000;
            var testInstance = new Sum();
            var expected = new SumAndTime()
            {
                TotalSum = 1783293664,
                TimeTaken = 150
            };

            //Act
            var actual = testInstance.MyLinkedList(range);

            //Assert
            Assert.AreEqual(actual.TotalSum, expected.TotalSum);
            Assert.IsTrue(actual.TimeTaken < expected.TimeTaken);

            using (var db = new NorthwindEntities())
            {
                TestResultsNew resultToCreate = new TestResultsNew
                {
                    TestName = "MyLinkedList",
                    Range = range,
                    TotalSum = actual.TotalSum,
                    TimeElapsed = actual.TimeTaken
                };

                db.TestResultsNews.Add(resultToCreate);
                db.SaveChanges();
            }
        }
    }
}

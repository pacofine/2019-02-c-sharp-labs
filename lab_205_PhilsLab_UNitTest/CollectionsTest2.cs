using System;
using lab_203_PhilsLab;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace lab_205_PhilsLab_UNitTest
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
                TimeTaken = 0
            };

            // act
            var actual = testInstance.SumOfaMill(range);

            // assert
            Assert.AreEqual(actual.TotalSum, expected.TotalSum);
            Assert.IsTrue(actual.TimeTaken < expected.TimeTaken);

            bool testPassed;
            if (actual.TotalSum == expected.TotalSum && actual.TimeTaken <= expected.TimeTaken)
            {
                testPassed = true;
                using (var db = new NorthwindEntities())
                {
                    TestResultsRemastered resultToCreate = new TestResultsRemastered
                    {
                        TestName = "SumOfaMil",
                        TestPassed = testPassed,
                        Range = range,
                        TotalSum = actual.TotalSum,
                        TimeElapsed = actual.TimeTaken
                    };

                    db.TestResultsRemastereds.Add(resultToCreate);
                    db.SaveChanges();
                }
            }
            else if (actual.TotalSum != expected.TotalSum || actual.TimeTaken > expected.TimeTaken)
            {
                testPassed = false;
                using (var db = new NorthwindEntities())
                {
                    TestResultsRemastered resultToCreate = new TestResultsRemastered
                    {
                        TestName = "SumOfaMil",
                        TestPassed = testPassed,
                        Range = range,
                        TotalSum = null,
                        TimeElapsed = null
                    };

                    db.TestResultsRemastereds.Add(resultToCreate);
                    db.SaveChanges();
                }
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
                TimeTaken = 200
            };
            //Act
            var actual = testInstance.MyArr(range);

            //Assert
            Assert.AreEqual(actual.TotalSum, expected.TotalSum);
            Assert.IsTrue(actual.TimeTaken < expected.TimeTaken);

            bool testPassed;
            if (actual.TotalSum == expected.TotalSum && actual.TimeTaken <= expected.TimeTaken)
            {
                testPassed = true;
            }
            else
            {
                testPassed = false;
            }

            using (var db = new NorthwindEntities())
            {
                TestResultsRemastered resultToCreate = new TestResultsRemastered
                {
                    TestName = "MyArr",
                    TestPassed = testPassed,
                    Range = range,
                    TotalSum = actual.TotalSum,
                    TimeElapsed = actual.TimeTaken
                };

                db.TestResultsRemastereds.Add(resultToCreate);
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

            bool testPassed;
            if (actual.TotalSum == expected.TotalSum && actual.TimeTaken <= expected.TimeTaken)
            {
                testPassed = true;
            }
            else
            {
                testPassed = false;
            }

            using (var db = new NorthwindEntities())
            {
                TestResultsRemastered resultToCreate = new TestResultsRemastered
                {
                    TestName = "MyList",
                    TestPassed = testPassed,
                    Range = range,
                    TotalSum = actual.TotalSum,
                    TimeElapsed = actual.TimeTaken
                };

                db.TestResultsRemastereds.Add(resultToCreate);
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
                TimeTaken = 200
            };

            //Act
            var actual = testInstance.MyQueue(range);

            //Assert
            Assert.AreEqual(actual.TotalSum, expected.TotalSum);
            Assert.IsTrue(actual.TimeTaken < expected.TimeTaken);

            bool testPassed;
            if (actual.TotalSum == expected.TotalSum && actual.TimeTaken <= expected.TimeTaken)
            {
                testPassed = true;
            }
            else
            {
                testPassed = false;
            }

            using (var db = new NorthwindEntities())
            {
                TestResultsRemastered resultToCreate = new TestResultsRemastered
                {
                    TestName = "MyQueue",
                    TestPassed = testPassed,
                    Range = range,
                    TotalSum = actual.TotalSum,
                    TimeElapsed = actual.TimeTaken
                };

                db.TestResultsRemastereds.Add(resultToCreate);
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
                TimeTaken = 200
            };

            //Act
            var actual = testInstance.MyStack(range);

            //Assert
            Assert.AreEqual(actual.TotalSum, expected.TotalSum);
            Assert.IsTrue(actual.TimeTaken < expected.TimeTaken);

            bool testPassed;
            if (actual.TotalSum == expected.TotalSum && actual.TimeTaken <= expected.TimeTaken)
            {
                testPassed = true;
            }
            else
            {
                testPassed = false;
            }

            using (var db = new NorthwindEntities())
            {
                TestResultsRemastered resultToCreate = new TestResultsRemastered
                {
                    TestName = "MyStack",
                    TestPassed = testPassed,
                    Range = range,
                    TotalSum = actual.TotalSum,
                    TimeElapsed = actual.TimeTaken
                };

                db.TestResultsRemastereds.Add(resultToCreate);
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
                TimeTaken = 200
            };

            //Act
            var actual = testInstance.MyDictionary(range);

            //Assert
            Assert.AreEqual(actual.TotalSum, expected.TotalSum);
            Assert.IsTrue(actual.TimeTaken < expected.TimeTaken);

            bool testPassed;
            if (actual.TotalSum == expected.TotalSum && actual.TimeTaken <= expected.TimeTaken)
            {
                testPassed = true;
            }
            else
            {
                testPassed = false;
            }

            using (var db = new NorthwindEntities())
            {
                TestResultsRemastered resultToCreate = new TestResultsRemastered
                {
                    TestName = "MyDictionary",
                    TestPassed = testPassed,
                    Range = range,
                    TotalSum = actual.TotalSum,
                    TimeElapsed = actual.TimeTaken
                };

                db.TestResultsRemastereds.Add(resultToCreate);
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
            bool testPassed;

            if (actual.TotalSum == expected.TotalSum && actual.TimeTaken <= expected.TimeTaken)
            {
                testPassed = true;
            }
            else
            {
                testPassed = false;
            }

            using (var db = new NorthwindEntities())
            {
                TestResultsRemastered resultToCreate = new TestResultsRemastered
                {
                    TestName = "ArrList",
                    TestPassed = testPassed,
                    Range = range,
                    TotalSum = actual.TotalSum,
                    TimeElapsed = actual.TimeTaken
                };

                db.TestResultsRemastereds.Add(resultToCreate);
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

            bool testPassed;
            if (actual.TotalSum == expected.TotalSum && actual.TimeTaken <= expected.TimeTaken)
            {
                testPassed = true;
            }
            else
            {
                testPassed = false;
            }

            using (var db = new NorthwindEntities())
            {
                TestResultsRemastered resultToCreate = new TestResultsRemastered
                {
                    TestName = "MyHashSet",
                    TestPassed = testPassed,
                    Range = range,
                    TotalSum = actual.TotalSum,
                    TimeElapsed = actual.TimeTaken
                };

                db.TestResultsRemastereds.Add(resultToCreate);
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
                TimeTaken = 200
            };

            //Act
            var actual = testInstance.MyLinkedList(range);

            //Assert
            Assert.AreEqual(actual.TotalSum, expected.TotalSum);
            Assert.IsTrue(actual.TimeTaken < expected.TimeTaken);

            bool testPassed;
            if (actual.TotalSum == expected.TotalSum && actual.TimeTaken <= expected.TimeTaken)
            {
                testPassed = true;
            }
            else
            {
                testPassed = false;
            }

            using (var db = new NorthwindEntities())
            {
                TestResultsRemastered resultToCreate = new TestResultsRemastered
                {
                    TestName = "MyLinkedList",
                    TestPassed = false,
                    Range = range,
                    TotalSum = actual.TotalSum,
                    TimeElapsed = actual.TimeTaken
                };

                db.TestResultsRemastereds.Add(resultToCreate);
                db.SaveChanges();
            }
        }
    }
}

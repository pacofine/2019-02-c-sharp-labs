using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab_112_collections;
using lab_113_arraylist;

namespace labs_Test
{
    [TestClass]
    public class LabsTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //arange 
            var expected01 = -1;
            var expected02 = -1;
            
            var instanceLab11Collection = new Collections();

            //act
            var actual01 = instanceLab11Collection.Collections20MinuteLab(10, 20, 30);
            var actual02 = instanceLab11Collection.Collections20MinuteLab(11, 12, 13);

            //Assert
            Assert.AreEqual(expected01, actual01);
            Assert.AreEqual(expected02, actual02);
        }

        [TestMethod]
        public void lab112ArrayListTest()
        {
            //arrange
            var expected = -10;
            var instanceLab113 = new arraylist();
            //act
            var actual = instanceLab113.arraylistMethod(10, 20, 30, 40);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}

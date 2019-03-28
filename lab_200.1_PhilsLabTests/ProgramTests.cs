using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab_200._1_PhilsLab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_200._1_PhilsLab.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void SumOfaMillTest()
        {
            Assert.AreEqual(1783293664, Tests.SumOfaMil(1000000));
        }
    }
}
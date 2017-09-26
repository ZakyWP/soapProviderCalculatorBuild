using Microsoft.VisualStudio.TestTools.UnitTesting;
using SoapCalculatorBuild;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoapCalculatorBuild.Tests
{
    [TestClass()]
    public class Service1Tests
    {

        [TestMethod()]
        public void Add()
        {
            Service1 add = new Service1();
            Assert.AreEqual(3,add.Add(1,2));
        }

        [TestMethod()]
        public void SubtractTest()
        {
            Service1 subtract = new Service1();
            Assert.AreEqual(5, subtract.Subtract(10,5));
        }

        [TestMethod()]
        public void MultiplyTest()
        {
            Service1 multiply = new Service1();
            Assert.AreEqual(10, multiply.Multiply(2,5));
        }

        [TestMethod()]
        public void DivideTest()
        {
            Service1 divide = new Service1();
            Assert.AreEqual(2, divide.Divide(10,5));
        }
    }
}
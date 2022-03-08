using Microsoft.VisualStudio.TestTools.UnitTesting;
using Obl_Opgave1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obl_Opgave1.Tests
{
    [TestClass()]
    public class CarTests
    {
        private Car _car;
        [TestInitialize]
        public void Init()
        {
            _car = new Car(1,"Tesla",1000000,"ABC");
        }
        [TestMethod()]
        public void TestConstructor()
        {
            Assert.AreEqual(1,_car.Id);
            Assert.AreEqual("Tesla", _car.Model);
            Assert.AreEqual(1000000, _car.Price);
            Assert.AreEqual("ABC", _car.LicensePlate);
        }

        [TestMethod]
        public void TestModel()
        { 
            Assert.AreEqual("Tesla",_car.Model);
            Assert.ThrowsException<ArgumentNullException>(() => _car.Model = null);
            Assert.ThrowsException<ArgumentException>(() => _car.Model = "MKL");
        }

        [TestMethod]
        public void TestPrice()
        {
            Assert.AreEqual(1000000, _car.Price);
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => _car.Price = -1);
            Assert.ThrowsException<ArgumentNullException>(() => _car.Price = 0);
        }

        [TestMethod]
        public void TestLicensePlate()
        {
            Assert.ThrowsException<ArgumentNullException>(() => _car.LicensePlate = null);
            Assert.ThrowsException<ArgumentException>(() => _car.LicensePlate = "F");
            Assert.ThrowsException<ArgumentException>(() => _car.LicensePlate = "QWERTYUI");
        }
    }
}
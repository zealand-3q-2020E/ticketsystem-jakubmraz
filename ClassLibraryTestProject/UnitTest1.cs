using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace ClassLibraryTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCarPrice240()
        {
            //Arrange
            Car car = new Car("0");
            //Act
            var actualPrice = car.Price();
            //Assert
            Assert.AreEqual(240, actualPrice);
        }

        [TestMethod]
        public void TestCarVehicleType()
        {
            //Arrange
            Car car = new Car("0");
            //Act
            var actualVehicleType = car.VehicleType();
            //Assert
            Assert.AreEqual("Car", actualVehicleType);
        }

        [TestMethod]
        public void TestMCPrice125()
        {
            //Arrange
            MC mc = new MC("0");
            //Act
            var actualPrice = mc.Price();
            //Assert
            Assert.AreEqual(125, actualPrice);
        }

        [TestMethod]
        public void TestMCVehicleType()
        {
            //Arrange
            MC mc = new MC("0");
            //Act
            var actualVehicleType = mc.VehicleType();
            //Assert
            Assert.AreEqual("MC", actualVehicleType);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestLicensePlateOver7CharsException()
        {
            //Arrange
            Car car = new Car("00000000");
            //Act
            var licensePlate = car.LicensePlate;
            //Assert
            Assert.AreEqual("00000000", licensePlate);
        }
    }
}

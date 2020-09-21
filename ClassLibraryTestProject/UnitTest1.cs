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
            Car car = new Car();
            //Act
            var actualPrice = car.Price();
            //Assert
            Assert.AreEqual(240, actualPrice);
        }

        [TestMethod]
        public void TestCarVehicleType()
        {
            //Arrange
            Car car = new Car();
            //Act
            var actualVehicleType = car.VehicleType();
            //Assert
            Assert.AreEqual("Car", actualVehicleType);
        }

        [TestMethod]
        public void TestMCPrice125()
        {
            //Arrange
            MC mc = new MC();
            //Act
            var actualPrice = mc.Price();
            //Assert
            Assert.AreEqual(125, actualPrice);
        }

        [TestMethod]
        public void TestMCVehicleType()
        {
            //Arrange
            MC mc = new MC();
            //Act
            var actualVehicleType = mc.VehicleType();
            //Assert
            Assert.AreEqual("MC", actualVehicleType);
        }
    }
}

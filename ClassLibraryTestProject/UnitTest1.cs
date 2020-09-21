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
    }
}

using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using ClassLibrary;
using StorebaeltTicketLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassLibraryTestProject
{
    [TestClass]
    public class UnitTestStorebaelt
    {
        [TestMethod]
        public void TestCarWeekendDiscountWithoutBrobizz()
        {
            //Arrange
            Car car = new Car("0", false);
            car.Date = new DateTime(2020, 09, 20, 15, 00, 00);
            Ticket ticket = new Ticket(car);
            //Act
            var actualPrice = ticket.Price();
            //Assert
            Assert.AreEqual(192, actualPrice,1);
        }

        [TestMethod]
        public void TestCarWeekendDiscountWithBrobizz()
        {
            //Arrange
            Car car = new Car("0", true);
            car.Date = new DateTime(2020, 09, 20, 15, 00, 00);
            Ticket ticket = new Ticket(car);
            //Act
            var actualPrice = ticket.Price();
            //Assert
            Assert.AreEqual(182.4, actualPrice, 1);
        }
    }
}

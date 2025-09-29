using ClassLibraryBridge;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StoreBaeltTicketLibrary;
namespace TestProjectTicket
{
    [TestClass]
    public sealed class StoreBaeltCarTests
    {
        [TestMethod]
        public void Car_Weekday_NoBrobizz_FullPrice()
        {
            //Arrange
            var car = new StoreBaeltCar("test", new DateTime(2025, 9, 22), false);

            //Act
            var price = car.Price();

            //Assert
            Assert.AreEqual(230.0, price, 0.001); 

        }
        [TestMethod]
        public void Car_Weekday_WithBrobizz_10ProcentOff()
        {
            //Arrange
            var car = new StoreBaeltCar("test", new DateTime(2025, 9, 22), true);
            //Act
            var price = car.Price();
            //Assert
            Assert.AreEqual(207.0, price, 0.001);
        }
        [TestMethod]
        public void Car_Weekend_NoBrobizz_15PercentOff()
        {
            // Arrange
            var car = new StoreBaeltCar("ABC123", new DateTime(2025, 9, 21), false); // Sunday

            // Act
            var price = car.Price();

            // Assert
            Assert.AreEqual(195.5, price, 0.001); // 230 * 0.85
        }
        
        [TestMethod]
        public void Car_Weekend_WithBrobizz_15PercentThen10Percent()
        {
            // Arrange
            var car = new StoreBaeltCar("test", new DateTime(2025, 9, 21), true); // Sunday

            // Act
            var price = car.Price();

            // Assert
            Assert.AreEqual(175.95, price, 0.001); // (230 * 0.85) * 0.9
        }

        //[TestMethod]
        //public void MC_Weekend_NoDiscount()
        //{
        //    // Arrange
        //    var mc = new MC("test", new DateTime(2025, 9, 21), false); // Sunday

        //    // Act
        //    var price = mc.Price();

        //    // Assert
        //    Assert.AreEqual(120.0, price, 0.001); // MC full price, no weekend discount
        //}

        //[TestMethod]
        //public void MC_Weekend_WithBrobizz_OnlyBrobizzDiscount()
        //{
        //    // Arrange
        //    var mc = new MC("test", new DateTime(2025, 9, 21), true); // Sunday

        //    // Act
        //    var price = mc.Price();

        //    // Assert
        //    Assert.AreEqual(108.0, price, 0.001); // 120 * 0.9, only Brobizz
        //}
    }
}

 

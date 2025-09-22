using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryBridge;
namespace TestProjectBrigde
{
    [TestClass]
    public sealed class BridgeunitTests
    {
        [TestMethod]

        public void Price_ReturnsFixedValue()
        {
            //Arange
            var car = new Car("ABC123", DateTime.Now);
            //Act
            var price = car.Price();
            //Assert
            Assert.AreEqual(230.0, price);
        }

        [TestMethod]
        public void VehicleType_ReturnsCar()
        {
            //Arange
            var car = new Car("ABC123", DateTime.Now);
            //Act
            var vehicleType = car.VehicleType();
            //Assert
            Assert.AreEqual("Car", vehicleType);
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryBridge;
namespace TestProjectVehicle
{
    [TestClass]
    public sealed class VehicleunitTests
    {
        [TestMethod]
        ///summary>
        // Test polymorphic behavior of VehicleBase, Car, and MC classes
        public void VehicleBase_polymorphicTests()
  
        {
            // Arrange, Act, Assert combined in one test method
            //to verify that both Car and MC classes return correct prices and types

            //Arange
            var car = new Car("ABC123", DateTime.Now);
            var mc = new MC("ABCM", DateTime.Now);

            //Act
            var carPrice = car.Price();
            var mcPrice = mc.Price();
            var carType = car.VehicleType();
            var mcType = mc.VehicleType();

            //Assert
            Assert.AreEqual(230.0, carPrice);
            Assert.AreEqual(120.0, mcPrice);
            Assert.AreEqual("Car", carType);
            Assert.AreEqual("MC", mcType);
        }
    }
}


 
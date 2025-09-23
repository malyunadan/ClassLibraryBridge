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
        [TestMethod]
        public void Car_withBrobizz_Aplies10PocentDiscount()
        {
            //Arrange 
            var car = new Car(true); //Brobizz is active
            //Act
            var price = car.GetPrice();
            //Assert
            Assert.AreEqual(216.0, price, 0.001); // 240 - 10% discount

        }
        [TestMethod]
        public void Car_WithoutBrobizz_NoDiscountApplied()
        {
            var car = new Car(false); // no Brobizz
            var price = car.GetPrice();
            Assert.AreEqual(240.0, price, 0.001); // Full price
        }


        [TestMethod]
        public void MC_withBrobizz_Applies10PercentDiscount()
        {
            // Arrange
            var mc = new MC(true); // Brobizz is active

            // Act
            var price = mc.GetPrice();

            // Assert
            Assert.AreEqual(112.5, price, 0.001); // 125 - 10% discount
        }


        [TestMethod]
        public void MC_withoutBrobizz_NoDiscountApplied()
        {
            //Arrange 
            var mc = new MC(false); //No Brobizz
            //Act
            var price = mc.GetPrice();
            //Assert
            Assert.AreEqual(125.0, price, 0.001); //Full price
        }
    }
}


 
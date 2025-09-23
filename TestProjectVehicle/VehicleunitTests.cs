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
            var car = new Car("ABC123", DateTime.Now,false); //no Brobizz
            var mc = new MC("ABCM", DateTime.Now,false);//no Brobizz

            //Act
            var carPrice = car.Price();
            var mcPrice = mc.Price();
            var carType = car.VehicleType();
            var mcType = mc.VehicleType();

            //Assert
            Assert.AreEqual(230.0, carPrice, 0.001);// full price
            Assert.AreEqual(120.0, mcPrice, 0.001);
            Assert.AreEqual("Car", carType);
            Assert.AreEqual("MC", mcType);
        }
        [TestMethod]
        public void Car_withBrobizz_Aplies10PocentDiscount()
        {
            //Arrange 
            var car = new Car("test", DateTime.Now,true); //Brobizz is active
            //Act
            var price = car.Price();
            //Assert
            Assert.AreEqual(207.0, price, 0.001); // 230 - 10% discount

        }
        [TestMethod]
        public void Car_WithoutBrobizz_NoDiscountApplied()
        {
            var car = new Car("test", DateTime.Now, false); // no Brobizz
            var price = car.Price();
            Assert.AreEqual(230.0, price, 0.001); // Full price
        }


        [TestMethod]
        public void MC_withBrobizz_Applies10PercentDiscount()
        {
            // Arrange
            var mc = new MC("test", DateTime.Now, true); // Brobizz is active

            // Act
            var price = mc.Price();

            // Assert
            Assert.AreEqual(108.0, price, 0.001); // 120 - 10% discount
        }


        [TestMethod]
        public void MC_withoutBrobizz_NoDiscountApplied()
        {
            //Arrange 
            var mc = new MC("test", DateTime.Now, false); //No Brobizz
            //Act
            var price = mc.Price();
            //Assert
            Assert.AreEqual(120.0, price, 0.001); //Full price
        }
    }
}


 
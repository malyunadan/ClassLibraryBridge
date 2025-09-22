using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryBridge;
namespace TestProjectBrigde
{
    [TestClass]
    public sealed class CarunitTests
    {
        [TestMethod]
        /// <summary>
        /// a test method to verify that the Price method returns the fixed value 230.0 for a Car instance
        /// 
        public void Price_ReturnsFixedValue()
        {
            //Arange
            var car = new Car("ABC123", DateTime.Now);
            //Act
            var price = car.Price();
            //Assert
            Assert.AreEqual(230.0, price);
        }
        /// <summary>
        /// a test method to verify that the VehicleType method returns "Car" for a Car instance
        /// summary>

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
        
        public class VehicleValidationTests
        {
            [TestMethod]
            [ExpectedException(typeof(ArgumentException))]
            public void LicensePlate_TooLong_ThrowsArgumentException()
            {
                // Arrange & Act
                var car = new Car("TOOLONG123", DateTime.Now);
                // Assert is handled by ExpectedException
            }
        }
    }
}

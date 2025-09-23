using ClassLibraryBridge;
namespace TestProjectMC
{
    [TestClass]
    public sealed class MCUnitTests
    {
        /// <summary>
        /// a test method to verify that the Price method returns the fixed value 120.0 for an MC instance
        [TestMethod]
        public void Price_ReturnsFixedValue()
        {
            //Arange
            var mc = new MC("ABCM", DateTime.Now,false);
            //Act
            var price = mc.Price();
            //Assert
            Assert.AreEqual(120.0, price);
        }
        [TestMethod]
        /// a test method to verify that the VehicleType method returns "MC" for an MC instance
        /// summary>
        public void Vehicle_ReturnsMC()
        {
            //Arange
            var mc = new MC("ABCM", DateTime.Now, false);
            //Act
            var vehicleType = mc.VehicleType();
            //Assert
            Assert.AreEqual("MC", vehicleType);
        }
    }
}

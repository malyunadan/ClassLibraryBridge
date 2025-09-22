using ClassLibraryBridge;
namespace TestProjectMC
{
    [TestClass]
    public sealed class MCUnitTests
    {
        [TestMethod]
        public void Price_ReturnsFixedValue()
        {
            //Arange
            var mc = new MC("ABCM", DateTime.Now);
            //Act
            var price = mc.Price();
            //Assert
            Assert.AreEqual(120.0, price);
        }
        [TestMethod]
        public void Vehicle_ReturnsMC()
        {
            //Arange
            var mc = new MC("ABCM", DateTime.Now);
            //Act
            var vehicleType = mc.Vehicle();
            //Assert
            Assert.AreEqual("MC", vehicleType);
        }
    }
}

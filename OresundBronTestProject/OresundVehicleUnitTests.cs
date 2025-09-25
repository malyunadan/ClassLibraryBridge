using OresundBronLibrary;
namespace OresundBronTestProject
{
    [TestClass]
    public sealed class OresundVehicleUnitTests
    {
        [TestMethod]
        public void OresundCar_NoBrobizz_FullPrice()
        {
            
            var car = new OresundCar("Cartest", DateTime.Now, false);
            Assert.AreEqual(460.0, car.Price(), 0.001);
        }

        [TestMethod]
        public void OresundCar_WithBrobizz_DiscountedPrice()
        {
            var car = new OresundCar("Cartest", DateTime.Now, true);
            Assert.AreEqual(178.0, car.Price(), 0.001);
        }

        [TestMethod]
        public void OresundCar_Type()
        {
            var car = new OresundCar("Cartest", DateTime.Now, false);
            Assert.AreEqual("Oresund car", car.VehicleType());
        }

        [TestMethod]
        public void OresundMC_NoBrobizz_FullPrice()
        {
            var mc = new OresundMC("MCtest", DateTime.Now, false);
            Assert.AreEqual(235.0, mc.Price(), 0.001);
        }

        [TestMethod]
        public void OresundMC_WithBrobizz_DiscountedPrice()
        {
            var mc = new OresundMC("MCtest", DateTime.Now, true);
            Assert.AreEqual(92.0, mc.Price(), 0.001);
        }

        [TestMethod]
        public void OresundMC_Type()
        {
            var mc = new OresundMC("MCtest", DateTime.Now, false);
            Assert.AreEqual("Oresund MC", mc.VehicleType());
        }
    }
}
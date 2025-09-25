using StoreBaeltTicketLibrary;

namespace StoreBaeltTicketTests
{
    [TestClass]
    public class StorebaeltRepositoryTests
    {
        private IStorebaeltRepository repo;

        [TestInitialize]
        public void Setup()
        {
            repo = new StorebaeltRepository();
        }

        [TestMethod]
        public void AddVehicle_ShouldIncreaseCount()
        {
            repo.AddVehicle(new StoreBaeltCar("AB12345", DateTime.Now, true));
            var all = repo.GetAllVehicles();
            Assert.AreEqual(1, all.Count);
        }

        [TestMethod]
        public void GetAllVehicles_ShouldReturnAllAdded()
        {
            repo.AddVehicle(new StoreBaeltCar("AB12345", DateTime.Now, true));
            repo.AddVehicle(new StoreBaeltCar("CD67890", DateTime.Now, false));
            var all = repo.GetAllVehicles();
            Assert.AreEqual(2, all.Count);
        }

        [TestMethod]
        public void GetVehiclesByLicensePlate_ShouldReturnOnlyMatching()
        {
            repo.AddVehicle(new StoreBaeltCar("AB12345", DateTime.Now, true));
            repo.AddVehicle(new StoreBaeltCar("AB12345", DateTime.Now.AddDays(1), false));
            repo.AddVehicle(new StoreBaeltCar("CD67890", DateTime.Now, false));

            var ab12345Tickets = repo.GetVehiclesByLicensePlate("AB12345");
            Assert.AreEqual(2, ab12345Tickets.Count);
            Assert.IsTrue(ab12345Tickets.All(v => v.Licenseplate == "AB12345"));
        }
    }
}
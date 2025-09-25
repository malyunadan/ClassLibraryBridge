using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryBridge;

namespace StoreBaeltTicketLibrary
{
    public class StorebaeltRepository : IStorebaeltRepository
    {
        
    private readonly List<StoreBaeltCar> _vehicles = new List<StoreBaeltCar>();

        public void AddVehicle(StoreBaeltCar car)
        {
            _vehicles.Add(car);
        }

        public List<StoreBaeltCar> GetAllVehicles()
        {
            return _vehicles.ToList(); // return a copy
        }

        public List<StoreBaeltCar> GetVehiclesByLicensePlate(string licenseplate)
        {
            return _vehicles.Where(v => v.Licenseplate == licenseplate).ToList();
        }
    }
}
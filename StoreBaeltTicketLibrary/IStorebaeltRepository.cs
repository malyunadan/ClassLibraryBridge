using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryBridge;

namespace StoreBaeltTicketLibrary
{
    public interface IStorebaeltRepository
    {
        void AddVehicle(StoreBaeltCar car);
        List<StoreBaeltCar> GetAllVehicles();
        List<StoreBaeltCar> GetVehiclesByLicensePlate(string licenseplate);
    }
}

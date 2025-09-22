using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClassLibraryBridge;
/// <summary>
/// abstract class Vehicle, the base class for Car and MC
/// summary>
public abstract class Vehicle
/// <summary>
/// properties for license plate and date, that are initialized in the constructor
/// summary>
{
    public string Licenseplate { get; set; }
    public DateTime Date { get;  set; }

    public Vehicle(string licenseplate, DateTime date)
    {
        if (licenseplate.Length > 7)
        {
            throw new ArgumentException("License plate cannot be longer than 7 characters");
        }
        Licenseplate = licenseplate;
        Date = date;
    }
    /// <summary>
    /// abstract method to return price, implemented in derived classes
    /// summary>
    public abstract double Price();
    /// <summary>
    /// method to return vehicle type, implemented in derived classes
    public abstract string VehicleType();
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ClassLibraryBridge;
/// <summary>
/// Abstract base class for all vehicle types.
/// Contains shared logic for Brobizz discount and price calculation.
/// </summary>
public abstract class Vehicle
{
    /// <summary>
    /// properties for license plate, date and Brobizz, that are initialized in the constructor
    /// summary>
    public bool HasBrobizz { get; }
    public string Licenseplate { get; set; }
    public DateTime Date { get;  set; }
    
    public Vehicle(string licenseplate, DateTime date, bool hasBrobizz)
    {
        if (licenseplate.Length > 7)
        {
            throw new ArgumentException("License plate cannot be longer than 7 characters");
        }
        
        Licenseplate = licenseplate;
        Date = date;
        HasBrobizz = hasBrobizz;
    }
    /// <summary>
    /// Applies Brobizz discount if applicable (10%).
    /// </summary>
    protected double ApplyBrobizzDiscount(double price)
    {
        return HasBrobizz ? price * 0.9 : price;
    }

    /// <summary>
    /// Must be implemented in derived classes to return base ticket price.
    /// </summary>
    public abstract double Price();
   
    /// <summary>
    /// method to return vehicle type, implemented in derived classes
    public abstract string VehicleType();
}

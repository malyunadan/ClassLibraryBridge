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

{
    /// <summary>
    /// Abstract base class for all vehicle types.
    /// Contains shared logic for Brobizz discount and price calculation.
    /// </summary>
    public bool HasBrobizz { get; }
    protected Vehicle(bool hasBrobizz)
    {
        HasBrobizz = hasBrobizz;
    }
    public virtual double GetPrice()
    {
        return 0.0; // overidden in subclasses
    }
    /// <summary>
    /// this method is protected that means only accessible to class itself and its subclasses - (like Car or MC). 
    /// </summary>
    /// - If HasBrobizz is true → return price * 0.9
    ///Otherwise → return price unchanged.
    /// <param name="price"></param>
    /// <returns> 10% discout if true</returns>
    protected double ApplyBrobizzDiscount(double price)
    {
        return HasBrobizz ? price * 0.9 : price;

    }
    /// <summary>
    /// properties for license plate and date, that are initialized in the constructor
    /// summary>
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

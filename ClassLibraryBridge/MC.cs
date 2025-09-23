using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBridge
{
    /// <summary>
    /// class for MC, inherits from Vehicle
    public class MC : Vehicle
    {
        /// <summary>
        /// Represents a MC with a fixed base price.
        /// Applies Brobizz discount if enabled
        /// </summary>
        /// <param name="hasBrobizz"></param>
        public MC(bool hasBrobizz) : base(hasBrobizz) { }
        /// <summary>
        /// here it applies the discount to the baseprice.
        /// </summary>
        /// <returns></returns>
        public override double GetPrice()
        {
            double basePrice = 125.0;
            return ApplyBrobizzDiscount(basePrice);
        }

        /// <summary>
        /// apply base constructor to initialize license plate and date
        /// summary>
        public MC(string licenseplate, DateTime date)
            : base(licenseplate, date) { }
        /// <summary>
        /// abstract method to return price, overridden here
        /// summary>
        public override double Price()
        {
            return 120.0;
        }
        /// <summary>
        /// abstract method to return vehicle type, overridden here
        /// summary>
        public override string VehicleType()
        {
            return "MC";
        }
    }
}

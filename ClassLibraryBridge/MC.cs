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

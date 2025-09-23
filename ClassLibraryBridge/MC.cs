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

        public MC(string licenseplate, DateTime date, bool hasBrobizz)
            : base(licenseplate, date, hasBrobizz)
        {
        }

        public override double Price()
        {
            double basePrice = 120; // standard MC price
            return ApplyBrobizzDiscount(basePrice);
        }

        public override string VehicleType()
        {
            return "MC";
        }
    }
}
    
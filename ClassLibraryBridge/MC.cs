using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryBridge
{
    public class MC
    {
        /// <summary>
        /// property for license plate
        /// property for date
        /// summary>
        public string Licenseplate { get; set; }
        public DateTime Date { get; set; }
        /// <summary>
        /// constructor for license plate and date
        public MC(string licenseplate, DateTime date)
        {
            Licenseplate = licenseplate;
            Date = date;
        }
        /// <summary>
        /// method to return price
        /// method to return vehicle type
        public double Price()
        {
            return 120.0;
        }
        public string Vehicle()
        {
            return "MC";
        }
    }
}

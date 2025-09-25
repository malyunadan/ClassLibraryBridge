using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryBridge;

namespace OresundBronLibrary
{
    public class OresundMC : Vehicle
    {
        public OresundMC(string licenseplate, DateTime date, bool hasBrobizz)
            : base(licenseplate, date, hasBrobizz) { }
        public override double Price()
        {
            return HasBrobizz ? 92 : 235;
        }

        public override string VehicleType()
        {
            return "Oresund MC";
        }
    }
}
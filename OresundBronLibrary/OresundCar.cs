using ClassLibraryBridge;

namespace OresundBronLibrary
{
    public class OresundCar : Vehicle
    {
        public OresundCar(string licenseplate, DateTime date, bool hasBrobizz)
            : base(licenseplate, date, hasBrobizz) { }
        public override double Price()
        {
            return HasBrobizz ? 178 : 460;
        }

        public override string VehicleType()
        {
            return "Oresund car";
        }
    }
}
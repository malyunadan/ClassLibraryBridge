using ClassLibraryBridge;
namespace StoreBaeltTicketLibrary
{
    public class StoreBaeltCar : Car
    {
        public StoreBaeltCar(string licenseplate, DateTime date, bool hasBrobizz)
            : base(licenseplate, date, hasBrobizz)
        {
        }

        public override double Price()
        {
            double basePrice = 230;

            if (Date.DayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday)
            {
                basePrice *= 0.85; // 15% off
            }

            // Apply Brobizz afterwards
            return ApplyBrobizzDiscount(basePrice);
        }

        public override string VehicleType()
        {
            return "Car";
        }
    }
}

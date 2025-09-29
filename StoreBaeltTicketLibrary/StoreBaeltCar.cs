using ClassLibraryBridge;
namespace StoreBaeltTicketLibrary
{
    public class StoreBaeltCar : Car
    {
        /// </summary>
        /// <param name="licenseplate"></param>
        /// <param name="date"></param>
        /// <param name="hasBrobizz"></param>
        public StoreBaeltCar(string licenseplate, DateTime date, bool hasBrobizz)
            : base(licenseplate, date, hasBrobizz)
        {
        }
        /// <summary>
        /// method discount on saturdays and sundays.
        /// </summary>
        /// <returns></returns>
        public override double Price()
        {
            double basePrice = 230;

            if (Date.DayOfWeek == DayOfWeek.Saturday || Date.DayOfWeek == DayOfWeek.Sunday)
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

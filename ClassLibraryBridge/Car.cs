namespace ClassLibraryBridge
{
    /// <summary>
    /// class for car inheriting from vehicle
    /// <summary>
    public class Car : Vehicle
    {
        public Car(string licenseplate, DateTime date, bool hasBrobizz)
            : base(licenseplate, date, hasBrobizz)
        {
        }

        public override double Price()
        {
            double basePrice = 230; // standard car price
            return ApplyBrobizzDiscount(basePrice);
        }

        public override string VehicleType()
        {
            return "Car";
        }
    }
}
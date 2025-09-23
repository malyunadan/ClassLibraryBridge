namespace ClassLibraryBridge
{
    /// <summary>
    /// class for car inheriting from vehicle
    /// summary>
    public class Car : Vehicle
    {
        /// <summary>
        /// Represents a car with a fixed base price.
        /// Applies Brobizz discount if enabled.
        /// </summary>
        /// <param name="hasBrobizz"></param>
        public Car(bool hasBrobizz) : base(hasBrobizz) { }
        /// <summary>
        /// here it applies the discount to the baseprice.
        /// </summary>
        /// <returns></returns>
        public override double GetPrice()
        {
            double basePrice = 240.0;
            return ApplyBrobizzDiscount(basePrice);
        }

        /// <summary>
        /// initialize license plate and date in base class
        /// summary>
        public Car(string licenseplate, DateTime date)
        : base(licenseplate, date) { }
        /// <summary>
        /// abstract method to return price, that is overridden here
        public override double Price()
        {
            return 230.0;
        }
        /// <summary>
        /// abstract method to return vehicle type, that is overridden here
        public override string VehicleType()
        {
            return "Car";
        }
    }
}

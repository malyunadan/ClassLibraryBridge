namespace ClassLibraryBridge
{
    public class Car
    {
        /// <summary>
        /// property for license plate
        /// property for date
        /// </summary>
        public string Licenseplate { get; set; }
        public DateTime Date { get; set; }
        /// <summary>
        /// constructor for license plate and date
        public Car(string licenseplate, DateTime date)
        {
            Licenseplate = licenseplate;
            Date = date;
        }
        /// <summary>
        /// method to return price
        /// <returns> 230.0 </returns>
        /// </summary>
        public double Price()
        {
            return 230.0;
        }
        /// <summary>
        /// method to return vehicle type
        /// returns "Car"
        /// </summary>

        public string VehicleType()
        {
            return "Car";
        }

    }
}

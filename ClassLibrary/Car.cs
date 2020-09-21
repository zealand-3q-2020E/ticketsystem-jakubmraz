using System;

namespace ClassLibrary
{
    /// <summary>
    /// Car class, contains an empty constructor and the Price and VehicleType methods
    /// </summary>
    public class Car
    {
        public string LicensePlate { get; set; }
        public DateTime Date { get; set; }

        /// <summary>
        /// Returns the price of the car
        /// </summary>
        /// <returns>double</returns>
        public double Price()
        {
            return 240;
        }

        /// <summary>
        /// Returns the type of the vehicle
        /// </summary>
        /// <returns>string</returns>
        public string VehicleType()
        {
            return "Car";
        }
    }
}

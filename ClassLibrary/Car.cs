using System;

namespace ClassLibrary
{
    /// <summary>
    /// Car class, contains an empty constructor and the Price and VehicleType methods
    /// </summary>
    public class Car:Vehicle
    {
        public Car(string licensePlate) : base(licensePlate)
        {
        }

        /// <summary>
        /// Returns the price of the car
        /// </summary>
        /// <returns>double</returns>
        public override double Price()
        {
            return 240;
        }

        /// <summary>
        /// Returns the type of the vehicle
        /// </summary>
        /// <returns>string</returns>
        public override string VehicleType()
        {
            return "Car";
        }
    }
}

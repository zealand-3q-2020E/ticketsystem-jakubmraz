using System;

namespace ClassLibrary
{
    /// <summary>
    /// Car class, contains a constructor and the Price and VehicleType methods
    /// </summary>
    public class Car:Vehicle
    {
        public Car(string licensePlate, bool brobizz) : base(licensePlate, brobizz)
        {
            this.basePrice = 240;
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

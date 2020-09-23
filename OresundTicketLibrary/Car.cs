using System;
using ClassLibrary;

namespace OresundTicketLibrary
{
    public class Car : Vehicle
    {
        public Car(string licensePlate, bool brobizz) : base(licensePlate, brobizz)
        {
            basePrice = 410;
        }

        public override double Price()
        {
            if (brobizz)
                return 161;
            return basePrice;
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

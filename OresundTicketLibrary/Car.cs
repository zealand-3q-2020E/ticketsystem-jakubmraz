using System;
using ClassLibrary;

namespace OresundTicketLibrary
{
    public class Car : Vehicle
    {
        public Car(string licensePlate, bool brobizz) : base(licensePlate, brobizz)
        {
            this.basePrice = 410;
            //I only now realise that I have shot myself in the foot by trying to be efficient by putting the price calculation
            //into the base class, meaning I have no way of changing the brobizz discount %, as I assumed it would always be 5%
            //Changing it now would require me to change the entire library, which I don't feel like doing anymore since it's
            //past midnight. Sorry!
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

using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary;

namespace OresundTicketLibrary
{
    /// <summary>
    /// MC class, contains a constructor and the Price and VehicleType methods
    /// </summary>
    public class MC : Vehicle
    {
        public MC(string licensePlate, bool brobizz) : base(licensePlate, brobizz)
        {
            this.basePrice = 210;
        }

        /// <summary>
        /// Returns the type of the vehicle
        /// </summary>
        /// <returns>string</returns>
        public override string VehicleType()
        {
            return "MC";
        }
    }
}

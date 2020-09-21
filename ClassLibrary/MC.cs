using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    /// <summary>
    /// MC class, contains an empty constructor and the Price and VehicleType methods
    /// </summary>
    public class MC: Vehicle
    {
        /// <summary>
        /// Returns the price of the MC
        /// </summary>
        /// <returns>double</returns>
        public override double Price()
        {
            return 125;
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

using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    /// <summary>
    /// Abstract Vehicle class, contains a constructor and the virtual Price and VehicleType methods
    /// </summary>
    public abstract class Vehicle
    {
        protected bool brobizz;
        protected int basePrice;

        /// <summary>
        /// Constructor that takes two parameters, also sets the Date to the current time and sets the base price of the vehicle
        /// </summary>
        /// <param name="licensePlate">string - cannot be longer than 7 characters</param>
        /// <param name="brobizz">bool - specifies if 5% discount is applied</param>
        protected Vehicle(string licensePlate, bool brobizz)
        {
            if (licensePlate.Length > 7)
            {
                throw new Exception("License plate cannot be longer than 7 characters.");
            }

            this.LicensePlate = licensePlate;
            this.Date = DateTime.Now;
            this.brobizz = brobizz;

            this.basePrice = 200;
        }

        public string LicensePlate { get; set; }
        public DateTime Date { get; set; }

        /// <summary>
        /// Returns the price of the vehicle. Applies a 5% discount if the vehicle has the brobizz attribute.
        /// </summary>
        /// <returns>double</returns>
        public virtual double Price()
        {
            if (brobizz)
                return basePrice * 0.95;
            return basePrice;
        }

        /// <summary>
        /// Returns the type of the vehicle
        /// </summary>
        /// <returns>string</returns>
        public abstract string VehicleType();
    }
}

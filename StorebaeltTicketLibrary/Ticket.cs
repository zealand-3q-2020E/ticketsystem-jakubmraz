using System;
using ClassLibrary;

namespace StorebaeltTicketLibrary
{
    /// <summary>
    /// Ticket class with a constructor and a Price method
    /// </summary>
    public class Ticket
    {
        private Vehicle vehicle;
        
        /// <summary>
        /// Constructor that takes the Vehicle parameter
        /// </summary>
        /// <param name="vehicle"></param>
        public Ticket(Vehicle vehicle)
        {
            this.vehicle = vehicle;
        }

        /// <summary>
        /// Applies the 20% discount to cars whose tickets have been purchased during the weekend
        /// </summary>
        /// <returns>double</returns>
        public double Price()
        {
            if (vehicle.VehicleType() == "Car" &&
                (vehicle.Date.DayOfWeek == DayOfWeek.Saturday || vehicle.Date.DayOfWeek == DayOfWeek.Sunday))
            { 
                //Brobizz discount has already been applied in the .dll; however, this does not matter
                //as the order of operations is not a thing for multiplication, meaning the result will be
                //the same no matter which discount is applied first
                return vehicle.Price() * 0.80;
            }
            else
            {
                return vehicle.Price();
            }
        
}
    }
}

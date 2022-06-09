using System;
using System.Collections.Generic;
using System.Text;

namespace CabReservation
{
    public class Ride
    {
        public double distance;
        public double time;
        public Ride(double distance, double time)
        {
            this.distance = distance;
            this.time = time;
        }
    }
}

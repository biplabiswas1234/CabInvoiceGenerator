using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
namespace CabReservation
{
    public class InvoiceGenerator
    {
        readonly int priceperKilimeter;
        readonly int pricePerMinute;
        public double totalFare;
        readonly int miniMumFare;
        public int numberOfrides;
        public InvoiceGenerator()
        {
            this.priceperKilimeter = 10;
            this.pricePerMinute = 1;
            this.miniMumFare = 5;
        }

        public double TotalFareForSingleRide(Ride ride)
        {
            if (ride.distance < 0)
            {
                throw new InvoiceGeneratorException(InvoiceGeneratorException.ExceptionType.INVALID_DISTANCE, "Invalid distance");
            }
            if (ride.time < 0)
            {
                throw new InvoiceGeneratorException(InvoiceGeneratorException.ExceptionType.INVALID_TIME, "Invalid time");
            }
            return Math.Max(miniMumFare, ride.distance * priceperKilimeter + ride.time * pricePerMinute);
        }

    }
}

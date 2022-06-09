using System;
using System.Collections.Generic;
using System.Text;

namespace CabReservation
{
    public class InvoiceGeneratorException:Exception
    {
        
          
            public enum ExceptionType
            {
                INVALID_DISTANCE, INVALID_RIDE_TYPE, INVALID_TIME, INVALID_USER_ID, NULL_RIDES
            }

            public ExceptionType type;

          
            public InvoiceGeneratorException(ExceptionType type, string message) : base(message)
            {
                this.type = type;
            }
        
    }
}

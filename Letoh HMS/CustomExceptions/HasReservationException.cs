using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Letoh_HMS
{
    class HasReservationException : Exception
    {
        private static String msg = " has a reservation. Please cancel before removing.";

        public HasReservationException(int id) : base (String.Format("{0} {1:000} {2}", "Error: ", id, msg))
        {
        }
    }
}

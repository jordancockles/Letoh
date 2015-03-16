//Letoh Hotel Reservation Program
//Prototype Version 1.0
//Developed By: Jordan Cockles

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Letoh_HMS
{
    class AlreadyBookedException : Exception
    {
        //When a user tries to book into a room that
        //is already booked.
        private static String msg = " is already booked";

        public AlreadyBookedException(int id)
            : base("Error: Room " + id + msg)
        { 
        }
    }
}

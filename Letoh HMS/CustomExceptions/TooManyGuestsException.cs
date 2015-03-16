using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Letoh_HMS
{
    class TooManyGuestsException : Exception
    {
        //When a user tries to book too
        //many guests into a room
        private static String msg = " room capacity is ";

        public TooManyGuestsException(int number, int capcaity)
            : base("Error: " + number + msg + capcaity)
        {
        }
    }
}

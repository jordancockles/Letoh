//Letoh Hotel Reservation Program
//Prototype Version 1.0
//Developed By: Jordan Cockles

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Letoh_HMS
{
    [Serializable]
    public class ReservationList
    {
        //List of Reservations
        public List<Reservation> Reservations;

        //Constructor
        public ReservationList()
        {
            Reservations = new List<Reservation>();
        }

        //Find Reservation
        public Reservation FindItem(int searchID)
        {
            Reservation reservation = null;
            foreach (Reservation r in Reservations)
            {
                if (r.ReservationID == searchID)
                {
                    reservation = r;
                }
            }

            return reservation;
        }
    }
}

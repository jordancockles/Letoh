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
    public class GuestList
    {
        //List of Guests
        public List<Guest> Guests;

        //Constructor
        public GuestList()
        {
            Guests = new List<Guest>();
        }

        //Register New Guest
        public void RegisterGuest(Guest guest)
        {
            
            Guests.Add(guest);
        }

        //Remove Guest
        public void RemoveGuest(Guest guest)
        {
            if (guest.ReservedRooms.Count != 0)
            {
                HasReservationException hre = new HasReservationException(guest.ID);
                throw hre;
            }

            else
            {
                Guests.Remove(guest);
            }
        }

        //Find Guest
        public Guest FindItem(int searchID)
        {
            //Search Start
            Guest guest = null;

            //Searches through the list
            foreach (Guest g in Guests)
            {
                if (g.ID == searchID)
                {
                    guest = g;
                }
            }

            //If guest had not been found
            if (guest == null)
            {
                Exception notfoundexception = new Exception();
                throw (notfoundexception);
            }

            else
            {
                return guest;
            }
        }
    }
}

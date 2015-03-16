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
    public class Guest : IDisplay
    {
        //Set Properties
        public int ID { get; set; }
        public String Title { get; set; }
        public String Forename { get; set; }
        public String Surname { get; set; }
        public String Email { get; set; }
        public String PhoneNumber { get; set; }
        public List<Room> ReservedRooms { get; set; }

        //Constructor
        public Guest(int id, String title, String forename, String surname, String email, String phonenumber)
        {
            ID = id;
            Title = title;
            Forename = forename;
            Surname = surname;
            Email = email;
            PhoneNumber = phonenumber;
            ReservedRooms = new List<Room>();
        }

        //ToString (Return ID, Forename and Surname of a Guest)
        public override string ToString()
        {
            String FullName = Forename + " " + Surname; //Concatenate names
            return String.Format("{0:000} {1}", ID, FullName);
        }

        //Display All Guest Data
        public String Display()
        {
            String msg;
            String NL = Environment.NewLine;

            msg = String.Format("ID: {0:000} {1}", ID, NL);
            msg += String.Format("Forename: {0} {1}", Forename, NL);
            msg += String.Format("Surname: {0} {1}", Surname, NL);
            msg += String.Format("Email: {0} {1}", Email, NL);
            msg += String.Format("PhoneNumber: {0} {1}", PhoneNumber, NL);
            msg += String.Format("Rooms Booked: {0}", NL);
            if (ReservedRooms.Count == 0)
            {
                msg += "No Reservations";
            }

            else
            {
                foreach (Room r in ReservedRooms)
                {
                    msg += String.Format("{0} {1}", r.ToString(), NL); 
                }
            }
            return msg;
        }
    } 
}

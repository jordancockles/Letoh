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
    public class Reservation : IDisplay
    {
        //Properties
        public int ReservationID { get; set; }
        public Guest rGuest { get; set; }
        public Room rRoom { get; set; }
        public int NumGuests { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int NumDays { get; set; }
        public double TotalPrice { get; set; }

        //Constructor
        public Reservation(int reservationid, Guest rguest, Room rroom, int numguests, DateTime startdate, DateTime enddate)
        {
            ReservationID = reservationid;
            rGuest = rguest;
            rRoom = rroom;
            NumGuests = numguests;
            StartDate = startdate;
            EndDate = enddate;
            NumDays = Convert.ToInt32((enddate - startdate).TotalDays);
            TotalPrice = rroom.Price * NumDays;
        }

        //ToString
        public override string ToString()
        {
            return String.Format("{0:000} || {1} || {2}",
                                 ReservationID, rGuest, rRoom);
        }

        //Display Method
        public String Display()
        {
            String msg;
            String NL = Environment.NewLine;

            msg = String.Format("Reservation ID: {0:000} {1}", ReservationID, NL);
            msg += String.Format("Guest Name: {0} {1}", rGuest, NL);
            msg += String.Format("Room Booked: {0} {1}", rRoom, NL);
            msg += String.Format("Number of Guests: {0} {1}", NumGuests, NL);
            msg += String.Format("Start Date: {0: dd/MM/yyyy} {1}", StartDate.Date, NL);
            msg += String.Format("End Date: {0: dd/MM/yyyy} {1}", EndDate.Date, NL);
            msg += String.Format("Total Price: £{0:0.00} {1}", TotalPrice, NL);
            return msg;
        }
    }
}

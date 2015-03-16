//Letoh Hotel Reservation Program
//Prototype Version 1.0
//Developed By: Jordan Cockles

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Letoh_HMS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Instantiate List Objects
            GuestList guestList = new GuestList();
            RoomList roomList = new RoomList();
            ReservationList reservationList = new ReservationList();
            SerializeFileHandler serializeFileHandler = new SerializeFileHandler();

            Application.Run(new FormBasedUI(guestList, roomList, reservationList, serializeFileHandler));
        }
    }
}

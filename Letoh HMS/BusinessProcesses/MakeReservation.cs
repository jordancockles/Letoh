//Letoh Hotel Reservation Program
//Prototype Version 1.0
//Developed By: Jordan Cockles

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Letoh_HMS
{
    public class MakeReservation
    {
        //Properties for creating a reservation
        private readonly ReservationList reservationList;
        private readonly Guest guest;
        private readonly Room room;
        private int reservationID;
        private int numGuests;
        private DateTime startDate;
        private DateTime endDate;

        /// <summary>
        /// MakeReservation Constructor
        /// </summary>
        /// <param name="reservationList">reservationList object</param>
        /// <param name="guest">guest Object</param>
        /// <param name="room">room Object</param>
        /// <param name="numguests">numGuests int</param>
        /// <param name="startdate">startDate DateTime</param>
        /// <param name="enddate">endDate DateTime</param>
        public MakeReservation(ReservationList reservationList, Guest guest, Room room, int numguests, DateTime startdate, DateTime enddate)
        {
            this.reservationList = reservationList;
            this.guest = guest;
            this.room = room;
            this.numGuests = numguests;
            this.startDate = startdate;
            this.endDate = enddate;
        }

        /// <summary>
        /// Master Code for making a reservation
        /// </summary>
        public void MakeReservationOperations()
        {
            if (numGuests > room.MaxGuests)
            {
                TooManyGuestsException tmg = new TooManyGuestsException(room.Number, room.MaxGuests);
                throw tmg;
            }

            else if (room.HasReservation == true)
            {
                //For every reservation the room has check if the reservation dates
                //and the intended dates overlap and if so throw an error.
                foreach (Reservation r in room.Reservations)
                {
                    bool overlap = startDate < r.EndDate && r.StartDate < endDate;

                    if (overlap)
                    {
                        AlreadyBookedException ab = new AlreadyBookedException(room.Number);
                        throw (ab);
                    }
                }
            }

            #region ############ New Reservation Code ############

            #region ############ Automate ID #############
            //Check if the reservation list is empty
            bool isEmpty = !reservationList.Reservations.Any();

            //If the list is empty then automatically set to 1
            if (isEmpty)
            {
                reservationID = 001;
            }

            //If list has values find the last value then add one
            else
            {
                Reservation lastreservation = reservationList.Reservations.Last();
                reservationID = lastreservation.ReservationID + 1;
            }
            #endregion

            //Make a new reservation object
            Reservation reservation = new Reservation(reservationID, guest, room, numGuests, startDate, endDate);

            #endregion

            #region ############ ReservationList Code ############

            reservationList.Reservations.Add(reservation); //Add reservation object to List

            #endregion

            #region ############ Guest Code ############

            guest.ReservedRooms.Add(room); //Add room to reserved rooms

            #endregion

            #region ############ Room Code ############

            room.Reservations.Add(reservation); //Add reservation object to list
            room.HasReservation = true;

            #endregion
        }
    }
}

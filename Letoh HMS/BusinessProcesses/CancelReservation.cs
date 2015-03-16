using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Letoh_HMS
{
    class CancelReservation
    {
        Reservation reservation;
        ReservationList reservationList;

        public CancelReservation(Reservation rsv, ReservationList reservationlist)
        {
            reservation = rsv;
            reservationList = reservationlist;
        }

        public void CancelReservationOperations()
        {
            Room room = reservation.rRoom;
            Guest guest = reservation.rGuest;

            //ROOM CODE
            room.Reservations.Remove(reservation);
            if (room.Reservations.Count == 0)
            {
                room.HasReservation = false;
            }

            //GUEST CODE
            guest.ReservedRooms.Remove(room);

            //RESERVATIONLIST CODE
            reservationList.Reservations.Remove(reservation);
        }
    }
}

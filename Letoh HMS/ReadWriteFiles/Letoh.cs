using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Letoh_HMS
{
    [Serializable]
    public class Letoh
    {
        public GuestList guestList { get; set; }
        public RoomList roomList { get; set; }
        public ReservationList reservationList { get; set; }
    }
}

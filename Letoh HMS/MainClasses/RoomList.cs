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
    public class RoomList
    {
        //List of Rooms
        public List<Room> Rooms;

        //Constructor
        public RoomList()
        {
            Rooms = new List<Room>();
        }

        //Add New Room
        public bool AddRoom(Room room)
        {
            bool success = true;

            //Data Validation (Duplicate Room Numbers)
            foreach (Room r in Rooms)
            {
                if (room == null)
                {
                    success = false;
                }
                
                else if (r.Number == room.Number)
                {
                    success = false;
                }
            }

            if (success)
            {
                Rooms.Add(room);
            }

            return success;
        }
    
        //Remove Room
        public void RemoveRoom(Room room)
        {
            if (room.HasReservation == true)
            {
                HasReservationException hre = new HasReservationException(room.Number);
                throw hre;
            }

            else
            {
                Rooms.Remove(room);
            }
        }

        //Find A Room
        public Room FindItem (int searchNumber)
        {
            Room room = null;
            foreach (Room r in Rooms)
            {
                if (r.Number == searchNumber)
                {
                    room = r;
                }
            }

            if (room == null)
            {
                NullReferenceException nullref = new NullReferenceException();
                throw (nullref);
            }

            else
            {
                return room;
            }
        }
    }
}

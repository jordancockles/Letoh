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
    public abstract class Room : IDisplay
    {
        //Set Properties
        public int Number { get; set; }
        public String Type { get; set; }
        public double Price { get; set; }
        public int MaxGuests { get; set; }
        public bool HasReservation { get; set; }
        public List<Reservation> Reservations;

        public Room(int number, String type)
        {
            this.Number = number;
            this.Type = type;
            this.Reservations = new List<Reservation>();
        }

        //ToString (Return Number, Type, Price and Booked)
        public override string ToString()
        {
            return String.Format("{0} {1}", Number, Type);
        }

        public virtual string Display()
        {
            String msg;
            String NL = Environment.NewLine;

            msg = String.Format("Number: {0} {1}", Number, NL);
            msg += String.Format("Type: {0} {1}", Type, NL);
            msg += String.Format("Price: £{0: 0.00} {1}", Price, NL); 
            msg += String.Format("Reservations: {0}", NL);

            if (Reservations.Count != 0)
            {
                foreach (Reservation r in Reservations)
                {
                    msg += String.Format("{0} {1}", r.ToString(), NL);
                }
            }
            else
            {
                msg += "No Reservations";
            }

            return msg;
        }
    }

    [Serializable]
    public class SingleRoom : Room
    {
        private const double price = 10.99;
        private const int maxguests = 1;

        public SingleRoom(int number, String type)
            : base(number, type)
        {
            this.Price = price;
            this.MaxGuests = maxguests;
            this.HasReservation = false;
            this.Reservations = new List<Reservation>();
        }

        public override string ToString()
        {
            return base.ToString() + " Single";
        }

        public override string Display()
        {
            return base.Display();
        }
    }

    [Serializable]
    public class DoubleRoom : Room
    {
        const double price = 15.99;
        const int maxguests = 2;

        public DoubleRoom(int number, String type)
            : base(number, type)
        {
            this.Price = price;
            this.MaxGuests = maxguests;
            this.HasReservation = false;
            this.Reservations = new List<Reservation>();
        }


        public override string ToString()
        {
            return base.ToString() + " Double";
        }

        public override string Display()
        {
            return base.Display();
        }
    }
}

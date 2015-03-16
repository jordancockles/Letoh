//Letoh Hotel Reservation Program
//Prototype Version 1.0
//Developed By: Jordan Cockles

///TODO: TextReportGenerators

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;

namespace Letoh_HMS
{
    public partial class FormBasedUI : Form
    {
        //Properties for handling each list
        public GuestList guestList;
        RoomList roomList;
        ReservationList reservationList;

        TextReportGenerator textReportGenerator = new TextReportGenerator();

        SerializeFileHandler serializeFileHandler;

        #region ############ Setup ############

        /// <summary>
        /// FormBasedUI Constructor
        /// </summary>
        /// <param name="gue">guestList object</param>
        /// <param name="rml">roomList object</param>
        /// <param name="rsv">reservationList object</param>
        public FormBasedUI(GuestList gue, RoomList rml, ReservationList rsv, SerializeFileHandler sfh)
        {
            //Show Splash Screen before initialisation
            SplashScreen sp = new SplashScreen();
            sp.ShowDialog();

            InitializeComponent();
            guestList = gue;
            roomList = rml;
            reservationList = rsv;
            serializeFileHandler = sfh;
        }

        /// <summary>
        /// Initialisation of Form
        /// </summary>
        private void FormBasedUI_Load(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to load data from file?",
                "Load data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                bool success = LoadLetohData();

                if (success)
                {
                    MessageBox.Show("Data Loaded Successfully");
                }

                else
                {
                    MessageBox.Show("Error Loading Data, Generating Test Data");
                    GenerateTestData();
                }
            }

            else
            {
                GenerateTestData();
            }
        }

        /// <summary>
        /// Code to generate data without data file
        /// </summary>
        public void GenerateTestData()
        {
            //Instantiate Guests
            Guest g1 = new Guest(001, "Mr", "Jordan", "Cockles", "jordan.cockles@gmail.com", "07450939483");
            Guest g2 = new Guest(002, "Mr", "Daniel", "Coggin", "daniel.coggin@hotmail.co.uk", "07896513785");
            Guest g3 = new Guest(003, "Mrs", "Vicky", "Knott", "v.knott@yahoo.com", "07891746762");
            Guest g4 = new Guest(004, "Mr", "Daniel", "Gray", "d.gray@gmail.com", "07891654910");
            Guest g5 = new Guest(005, "Miss", "Emma", "Goodchild", "e.goodchild@hotmail.co.uk", "07891546890");

            guestList.RegisterGuest(g1);
            guestList.RegisterGuest(g2);
            guestList.RegisterGuest(g3);
            guestList.RegisterGuest(g4);
            guestList.RegisterGuest(g5);

            //Instantiate Rooms
            SingleRoom r1 = new SingleRoom(101, "Standard");
            SingleRoom r2 = new SingleRoom(102, "Standard");
            SingleRoom r3 = new SingleRoom(103, "River View");
            SingleRoom r4 = new SingleRoom(104, "River View");
            DoubleRoom r5 = new DoubleRoom(105, "Standard");
            DoubleRoom r6 = new DoubleRoom(106, "Standard");
            DoubleRoom r7 = new DoubleRoom(107, "River View");
            DoubleRoom r8 = new DoubleRoom(108, "River View");

            roomList.AddRoom(r1);
            roomList.AddRoom(r2);
            roomList.AddRoom(r3);
            roomList.AddRoom(r4);
            roomList.AddRoom(r5);
            roomList.AddRoom(r6);
            roomList.AddRoom(r7);
            roomList.AddRoom(r8);
        }

        #endregion

        #region ############ Form Code ############

        private void btnReservations_Click(object sender, EventArgs e)
        {
            ReservationFormUI reservationformui = new ReservationFormUI(reservationList, guestList, roomList, textReportGenerator); //All lists are necesary if a reservation is to be made
            reservationformui.ShowDialog();
        }

        private void btnGuests_Click(object sender, EventArgs e)
        {
            GuestFormUI guestformui = new GuestFormUI(guestList, textReportGenerator); //Only the guestList will be altered in this form
            guestformui.ShowDialog();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            RoomFormUI roomformui = new RoomFormUI(roomList, textReportGenerator);
            roomformui.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to save the data file?",
                     "Save data", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                SaveLetohData();
            }

            Application.Exit();
        }

        private void SaveLetohData()
        {
            Letoh letohFile = new Letoh();

            letohFile.guestList = guestList;
            letohFile.roomList = roomList;
            letohFile.reservationList = reservationList;

            serializeFileHandler.SaveLetohFile(letohFile, AppData.Letoh);

            MessageBox.Show("Data has been saved");
        }

        public bool LoadLetohData()
        {
            bool success = false;

            try
            {
                Letoh letohFile = new Letoh();

                letohFile = serializeFileHandler.LoadLetohFile(AppData.Letoh);

                guestList = letohFile.guestList;
                roomList = letohFile.roomList;
                reservationList = letohFile.reservationList;

                success = true;
            }

            catch (FileNotFoundException ex)
            {
                MessageBox.Show(ex.Message);
                success = false;
            }

            return success;
        }
      
        #endregion
    }
}

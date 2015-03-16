//Letoh Hotel Reservation Program
//Prototype Version 1.0
//Developed By: Jordan Cockles

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Letoh_HMS
{
    public partial class MakeReservationForm : Form
    {
        //Properties for making a new reservation
        GuestList guestList;
        RoomList roomList;
        ReservationList reservationList;

        #region ############ Setup ############

        /// <summary>
        /// MakeReservationForm Constructor
        /// </summary>
        /// <param name="guestlist">gl Object</param>
        /// <param name="roomlist">rml Object</param>
        /// <param name="reservationlist">rsl Object</param>
        public MakeReservationForm(GuestList gl, RoomList rl, ReservationList rsv)
        {
            InitializeComponent();
            guestList = gl;
            roomList = rl;
            reservationList = rsv;
        }

        /// <summary>
        /// Initialisation of form
        /// </summary>
        private void MakeReservationForm_Load(object sender, EventArgs e)
        {
            foreach (Guest g in guestList.Guests)
            {
                lstGuests.Items.Add(g);
            }

            lstGuests.Sorted = true;

            foreach (Room r in roomList.Rooms)
            {
                lstRooms.Items.Add(r);
            }

            lstRooms.Sorted = true;
        }

        #endregion

        #region ############ Form Code ############

        private void btnMakeReservation_Click(object sender, EventArgs e)
        {
            #region ############ Validating User Input ############
            if (lstGuests.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please Select a Guest", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (lstRooms.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please Select a Room", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (txtNumGuests.Text == "")
            {
                MessageBox.Show("Please Enter Number of Guests", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (Convert.ToDateTime(dtpStartDate.Text) >= Convert.ToDateTime(dtpEndDate.Text))
            {
                MessageBox.Show("Start date cannot be the same as or before end date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (Convert.ToDateTime(dtpStartDate.Text) < DateTime.Now)
            {
                MessageBox.Show("Cannot book room that is in the past", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #endregion

            else
            {
                GetReservationData();
                this.DialogResult = DialogResult.OK;
            }
        }

        /// <summary>
        /// Get selected Item from lstGuests
        /// </summary>
        private void lstGuests_SelectedIndexChanged(object sender, EventArgs e)
        {
            IDisplay guest = GetItem("guest");
            DisplayAll(guest);
        }

        /// <summary>
        /// Get selected Item from lstRooms
        /// </summary>
        private void lstRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            IDisplay room = GetItem("room");
            DisplayAll(room);
        }

        /// <summary>
        /// Gathers all data together make a MakeReservation Object
        /// </summary>
        /// <returns>MakeReservation Object</returns>
        public MakeReservation GetReservationData()
        {
            Guest resguest = (Guest)lstGuests.SelectedItem;
            Room resroom = (Room)lstRooms.SelectedItem;
            int resnumguests = Convert.ToInt32(txtNumGuests.Text);
            DateTime resstartdate = Convert.ToDateTime(dtpStartDate.Text);
            DateTime resenddate = Convert.ToDateTime(dtpEndDate.Text);

            MakeReservation makeres = new MakeReservation(reservationList, resguest, resroom, resnumguests, resstartdate.Date, resenddate.Date);
            return makeres;
        }
        #endregion

        /// <summary>
        /// Searches for object from collection and returns it
        /// </summary>
        /// <param name="nType">String to check data type</param>
        /// <returns></returns>
        public IDisplay GetItem(String sType)
        {
            if (sType == "guest")
            {
                return (Guest)lstGuests.SelectedItem;
            }

            else
            {
                return (Room)lstRooms.SelectedItem;
            }
        }

        /// <summary>
        /// Display formatted data for the object passed in as parameter
        /// </summary>
        /// <param name="nType">String to check data type</param>
        /// <param name="displayObject"></param>
        public void DisplayAll(IDisplay displayObject)
        {
            if(displayObject is Guest)
            {
                string guestsearch = lstGuests.SelectedItem.ToString();

                txtSelectedGuest.Clear();
                try
                {
                    txtSelectedGuest.Text = displayObject.Display();
                }

                catch (NullReferenceException)
                {
                    MessageBox.Show("Please select guest", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                txtSelectedRoom.Clear();
                try
                {
                    txtSelectedRoom.Text = displayObject.Display();
                }

                catch (NullReferenceException)
                {
                    MessageBox.Show("Load Error: Please Try Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

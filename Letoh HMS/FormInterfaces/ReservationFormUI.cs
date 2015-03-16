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
    public partial class ReservationFormUI : Form, IUserInterface
    {
        //Properties for handling each list
        ReservationList reservationList;
        GuestList guestList;
        RoomList roomList;
        TextReportGenerator textReportGenerator;

        #region ############ Setup ############

        /// <summary>
        /// ReservationFormUI Constructor
        /// </summary>
        /// <param name="rsv">reservationList object</param>
        /// <param name="gue">guestList object</param>
        /// <param name="rm">roomList object</param>
        public ReservationFormUI(ReservationList rsv, GuestList gue, RoomList rm, TextReportGenerator trg)
        {
            InitializeComponent();
            reservationList = rsv;
            guestList = gue;
            roomList = rm;
            textReportGenerator = trg;
        }

        /// <summary>
        /// Initialisation of form
        /// </summary>
        private void ReservationFormUI_Load(object sender, EventArgs e)
        {
            lstReservations.Items.Clear(); //Clear listbox

            foreach (Reservation r in reservationList.Reservations) //Populate listbox
            {
                lstReservations.Items.Add(r);
            }
        }

        #endregion

        #region ############ Form Code ############

        private void btnMakeReservation_Click(object sender, EventArgs e)
        {
            //Create new MakeReservationForm Object to Retrieve User Data
            MakeReservationForm makeres = new MakeReservationForm(guestList, roomList, reservationList);

            if (makeres.ShowDialog() == DialogResult.OK) //If the Dialog Result returns as OK
            {
                try
                {
                    MakeReservation newRes = makeres.GetReservationData(); //New MakeReservation using Data From Form
                    newRes.MakeReservationOperations(); //Run The Code to Make Reservation
                    lstReservations.Items.Clear(); //Clear the ListBox Ready for Fresh Input

                    //Clarification Message
                    MessageBox.Show("Reservation Made", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    //Repopulate ListBox Including new Reservation
                    foreach (Reservation r in reservationList.Reservations)
                    {
                        lstReservations.Items.Add(r);
                    }
                }

                //Catch an alreadybooked exception
                catch (AlreadyBookedException ab)
                {
                    MessageBox.Show(ab.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                catch (TooManyGuestsException tmg)
                {
                    MessageBox.Show(tmg.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCancelReservation_Click(object sender, EventArgs e)
        {
            try
            {
                //Create new CancelReservation Object to handle removal
                CancelReservation cancelres = new CancelReservation((Reservation)lstReservations.SelectedItem, reservationList);
                cancelres.CancelReservationOperations();

                lstReservations.Items.Clear();
                txtSelectedReservation.Clear();

                MessageBox.Show("Reservation Cancelled", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                foreach (Reservation r in reservationList.Reservations)
                {
                    lstReservations.Items.Add(r);
                }

                lstReservations.Sorted = true;
            }

            catch (NullReferenceException)
            {
                MessageBox.Show("Please selet a reservation to remove", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerateTextReport_Click(object sender, EventArgs e)
        {
            IDisplay iDisp = (Reservation)lstReservations.SelectedItem;
            GenerateTextReport(iDisp);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Get the currently selected item from listbox
        /// </summary>
        private void lstReservations_SelectedIndexChanged(object sender, EventArgs e)
        {
            IDisplay reservation = GetItem("Res"); //Use function to create new IDisplay object
            DisplayAll(reservation); //Use interface to pull information from object
        }

        #endregion

        #region ############ IUserInterface Methods ############

        /// <summary>
        /// Searches for object from collection and returns it
        /// </summary>
        /// <returns>IDisplay object</returns>
        public IDisplay GetItem(String sType)
        {
            return (Reservation)lstReservations.SelectedItem;
        }

        /// <summary>
        /// Display formatted data for the object passed in as parameter
        /// </summary>
        /// <param name="displayObject">IDisplay object</param>
        public void DisplayAll(IDisplay displayObject)
        {
            txtSelectedReservation.Clear();

            try
            {
                txtSelectedReservation.Text = displayObject.Display();
            }

            catch (NullReferenceException) //Prevents user selecting nothing
            {
                MessageBox.Show("Please select reservation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GenerateTextReport(IDisplay iDisp)
        {
            String filename = "";

            if (iDisp == null)
            {
                MessageBox.Show("First select reservation to have report made", "No item selected");
            }

            else
            {
                Reservation r = (Reservation)iDisp;
                filename = "Reservation_" + Convert.ToString(r.ReservationID);

                textReportGenerator.GenerateReport(iDisp, filename + ".txt");
                MessageBox.Show("Text report " + filename + ".txt" + " created.");
            }
        }

        #endregion
    }
}

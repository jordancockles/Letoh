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
    public partial class GuestFormUI : Form, IUserInterface
    {
        //Property for handling GuestList
        GuestList guestList;
        TextReportGenerator textReportGenerator;

        #region ############ Setup ############

        /// <summary>
        /// GuestFormUI Constructor
        /// </summary>
        /// <param name="gue">guestList object</param>
        public GuestFormUI(GuestList gue, TextReportGenerator trg)
        {
            InitializeComponent();
            guestList = gue;
            textReportGenerator = trg;
        }

        /// <summary>
        /// Initialisation of form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GuestFormUI_Load(object sender, EventArgs e)
        {
            lstGuests.Items.Clear(); //Clear listbox

            foreach (Guest g in guestList.Guests) //Populate listbox
            {
                lstGuests.Items.Add(g);
            }
        }

        #endregion

        #region ############ Form Code ############

        private void btnRegisterGuest_Click(object sender, EventArgs e)
        {
            AddNewDataForm addForm = new AddNewDataForm("guest", guestList, null);
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                //Get Data from Form
                Guest newGuest = addForm.GetGuestData();

                //Add To The List
                guestList.RegisterGuest(newGuest);

                //Add to the List
                lstGuests.Items.Add(newGuest);
                lstGuests.Sorted = true;

                //Show Clarification
                MessageBox.Show(String.Format("{0: 000}", newGuest.ID) + " has been added to the list");

            }
        }

        private void btnRemoveGuest_Click(object sender, EventArgs e)
        {
            Guest guestRemove = (Guest)lstGuests.SelectedItem;

            try
            {
                guestList.RemoveGuest(guestRemove);

                //Clear and Repopulate List
                lstGuests.Items.Clear();
                foreach (Guest g in guestList.Guests)
                {
                    lstGuests.Items.Add(g);
                }

                //Clear Secondary Display Box
                txtSelectedGuest.Clear();

                //Show Clarification
                MessageBox.Show(String.Format("{0:000}", guestRemove.ID) + " has been removed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            catch (HasReservationException he)
            {
                MessageBox.Show(he.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (NullReferenceException)
            {
                MessageBox.Show("Please selet a guest to remove", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerateTextReport_Click(object sender, EventArgs e)
        {
            IDisplay iDisp = (Guest)lstGuests.SelectedItem;
            GenerateTextReport(iDisp);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //TO DO: Add Code to SAVE data and pass it back to main form
            this.Close();
        }

        /// <summary>
        /// Get the currently selected item from the listbox
        /// </summary>

        private void lstGuests_SelectedIndexChanged(object sender, EventArgs e)
        {            
            IDisplay guest = GetItem("Guest");
            DisplayAll(guest);
        }

        #endregion

        #region ############ IUserInterface Methods ############

        /// <summary>
        /// Searches for object from collection and returns it
        /// </summary>
        /// <returns>IDisplay object</returns>
        public IDisplay GetItem(String sType)
        {
            return (Guest)lstGuests.SelectedItem;
        }

        /// <summary>
        /// Display formatted data for the object passed in as a parameter
        /// </summary>
        /// <param name="displayObject">IDisplay object</param>
        public void DisplayAll(IDisplay displayObject)
        {
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

        public void GenerateTextReport(IDisplay iDisp)
        {
            String filename = "";

            if (iDisp == null)
            {
                MessageBox.Show("First select guest to have report made", "No item selected");
            }

            else
            {
                Guest g = (Guest)iDisp;
                filename = "Guest_" + Convert.ToString(g.ID);

                textReportGenerator.GenerateReport(iDisp, filename + ".txt");
                MessageBox.Show("Text report " + filename + ".txt" + " created.");
            }
        }

        #endregion
    }
}

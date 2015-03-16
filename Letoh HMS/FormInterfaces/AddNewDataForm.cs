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
    public partial class AddNewDataForm : Form
    {
        //Properties for handling data
        public String newType;
        public GuestList guestList;
        public RoomList roomList;

        private int guestID;

        #region ############ Setup ############

        /// <summary>
        /// AddNewDataForm Constructor
        /// </summary>
        /// <param name="nType">newType String (Checks data type)</param>
        /// <param name="guestlist">guestList object</param>
        /// <param name="roomlist">roomList object</param>
        public AddNewDataForm(String nType, GuestList gl, RoomList rl)
        {
            InitializeComponent();
            newType = nType;
            guestList = gl;
            roomList = rl;
        }

        /// <summary>
        /// Initialisation of form
        /// </summary>
        private void AddNewDataForm_Load(object sender, EventArgs e)
        {
            if (newType == "guest") //Code for newType == "guest"
            {
                //Change text on form dialogue box
                this.Text = "Letoh: Hotel Management System - Register New Guest";

                #region ############ Automation of GuestID ############

                txtFirst.ReadOnly = true;             
               
                //Check if the reservation list is empty
                bool isEmpty = !guestList.Guests.Any();

                //If the list is empty then automatically set to 1
                if (isEmpty)
                {
                    guestID = 001;
                }

                //If list has values find the last value then add one
                else
                {
                    Guest lastguest = guestList.Guests.Last();
                    guestID = lastguest.ID + 1;
                }

                txtFirst.Text = String.Format("{0: 000}", guestID);

                #endregion

                #region ############ Display appropriate labels ############

                lblTitle.Text = "Guest Registration";
                lblFirst.Text = "ID";
                lblSecond.Text = "Title";
                lblThird.Text = "Enter Forename";
                lblFourth.Text = "Enter Surname";
                lblFifth.Text = "Enter Email";
                lblSixth.Text = "Enter PhoneNumber";
                cboRoomSize.Visible = false;

                #endregion
            }

            else //Code for newType == "room"
            {
                //Change text on form dialogue box
                this.Text = "Letoh: Hotel Management System - Add New Room";

                #region ############ Display appropriate labels and text boxes ###########

                lblTitle.Text = "Add a New Room";
                lblFirst.Text = "Enter Room Number";
                lblSecond.Text = "Select Size";
                lblThird.Text = "Enter Room Type";
                lblFourth.Visible = false;
                lblFifth.Visible = false;
                lblSixth.Visible = false;
                txtSecond.Visible = false;
                txtFourth.Visible = false;
                txtFifth.Visible = false;
                txtSixth.Visible = false;

                #endregion
            }
        }

        #endregion

        #region ############ Form Code ############

        private void btnOK_Click(object sender, EventArgs e)
        {
            #region ############ Guest ############
            if (newType == "guest") //Code for handling retrieval of Guest Data
            {
                try
                {
                    #region ############ Form Validation ############

                    //Validate Empty Fields
                    if (txtSecond.TextLength == 0 || txtThird.TextLength == 0 || txtFourth.TextLength == 0 || txtFifth.TextLength == 0 || txtSixth.TextLength == 0)
                    {
                        NoNullAllowedException nna = new NoNullAllowedException();
                        throw nna;
                    }

                    int validateint = Convert.ToInt32(txtSixth.Text);

                    #endregion

                    GetGuestData();
                    this.DialogResult = DialogResult.OK;
                }

                catch (FormatException)
                {
                    MessageBox.Show("Phone number must be numerical", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                catch (NoNullAllowedException nna)
                {
                    MessageBox.Show(nna.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            #endregion

            #region ############ Room ############
            else //Code for handling Retrieval of Room Data
            {
                try
                {
                    #region ########### Form Validation ############
                    if (txtFirst.TextLength == 0 || txtThird.TextLength == 0)
                    {
                        NoNullAllowedException nna = new NoNullAllowedException();
                        throw nna;
                    }

                    int validateint = Convert.ToInt32(txtFirst.Text);
                    #endregion

                    GetRoomData();
                    this.DialogResult = DialogResult.OK;
                }

                catch (FormatException)
                {
                    MessageBox.Show("Please ensure all inputs are correct format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                catch (NoNullAllowedException nna)
                {
                    MessageBox.Show(nna.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            #endregion
        }

        #endregion

        /// <summary>
        /// Create a new Room Object
        /// </summary>
        /// <returns>Room object</returns>
        public Room GetRoomData()
        {
            if (cboRoomSize.Text == "Single") //If the user has selected a double
            {
                SingleRoom newSingleRoom = new SingleRoom(Convert.ToInt32(txtFirst.Text), txtThird.Text);
                return newSingleRoom;
            }

            else if (cboRoomSize.Text == "Double")
            {
                DoubleRoom newDoubleRoom = new DoubleRoom(Convert.ToInt32(txtFirst.Text), txtThird.Text);
                return newDoubleRoom;
            }

            else
            {
                NoNullAllowedException nna = new NoNullAllowedException();
                throw nna;
            }
        }

        /// <summary>
        /// Create a new Guest Object
        /// </summary>
        /// <returns>Guest object</returns>
        public Guest GetGuestData()
        {
            Guest newGuest = new Guest(Convert.ToInt32(txtFirst.Text), txtSecond.Text, txtThird.Text, txtFourth.Text, txtFifth.Text, txtSixth.Text);
            return newGuest;
        }
    }
}

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
    public partial class RoomFormUI : Form, IUserInterface
    {
        //Property for handling room list
        RoomList roomList;
        TextReportGenerator textReportGenerator;

        #region ############ Setup ############

        /// <summary>
        /// RoomFormUI constructor
        /// </summary>
        /// <param name="rml">roomList object</param>
        public RoomFormUI(RoomList rml, TextReportGenerator trg)
        {
            InitializeComponent();
            roomList = rml;
            textReportGenerator = trg;
        }

        /// <summary>
        /// Initialisation of form
        /// </summary>
        private void RoomFormUI_Load(object sender, EventArgs e)
        {
            lstRooms.Items.Clear();

            foreach (Room r in roomList.Rooms)
            {
                lstRooms.Items.Add(r);
            }

            lstRooms.Sorted = true;
        }

        #endregion

        #region ############ Form Code ############

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            AddNewDataForm addForm = new AddNewDataForm("room", null, roomList);
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                //Get Data from Form
                Room newRoom = addForm.GetRoomData();

                //Check success
                bool success = roomList.AddRoom(newRoom);
                if (success)
                {
                    //Add to the List
                    lstRooms.Items.Add(newRoom);
                    lstRooms.Sorted = true;

                    //Show Clarification
                    MessageBox.Show(String.Format("{0: 000}", newRoom.Number) + " has been added to the list");
                }

                else
                {
                    MessageBox.Show("\nUnable to add. Room number is already in use");
                }
            }
        }

        private void btnRemoveRoom_Click(object sender, EventArgs e)
        {
            Room roomRemove = (Room)lstRooms.SelectedItem;

            try
            {
                //Clear secondary display box
                txtSelectedRoom.Clear();

                //Run remove room method
                roomList.RemoveRoom(roomRemove);

                //Clear and repopulate list
                lstRooms.Items.Clear();
                foreach (Room r in roomList.Rooms)
                {
                    lstRooms.Items.Add(r);
                }

                //Sort list
                lstRooms.Sorted = true;

                //Show Clarification
                MessageBox.Show(String.Format("{0:000}", roomRemove.Number) + " has been removed");
            }

            catch (HasReservationException he)
            {
                MessageBox.Show(he.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (NullReferenceException)
            {
                MessageBox.Show("Please selet a room to remove", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGenerateTextReport_Click(object sender, EventArgs e)
        {
            IDisplay iDisp = (Room)lstRooms.SelectedItem;
            GenerateTextReport(iDisp);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Get currently selected item from listbox
        /// </summary>
        private void lstRooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            IDisplay room = GetItem("Room");
            DisplayAll(room);
        }

        #endregion

        #region ############ IUserInterface Methods ############

        /// <summary>
        /// Searches for object from collection and returns it
        /// </summary>
        /// <returns>IDisplay object</returns>
        public IDisplay GetItem(String sType)
        {
            return (Room)lstRooms.SelectedItem;
        }

        /// <summary>
        /// Display formatted data for the object passed in as parameter
        /// </summary>
        /// <param name="displayObject">IDisplay object</param>
        public void DisplayAll(IDisplay displayObject)
        {
            txtSelectedRoom.Clear();
            try
            {
                txtSelectedRoom.Text = displayObject.Display();
            }

            catch (NullReferenceException)
            {
                MessageBox.Show("Please select room", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Room r = (Room)iDisp;
                filename = "Room_" + Convert.ToString(r.Number);

                textReportGenerator.GenerateReport(iDisp, filename + ".txt");
                MessageBox.Show("Text report " + filename + ".txt" + " created.");
            }
        }

        #endregion

    }
}

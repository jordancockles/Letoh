namespace Letoh_HMS
{
    partial class MakeReservationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancel = new System.Windows.Forms.Button();
            this.lstGuests = new System.Windows.Forms.ListBox();
            this.txtSelectedGuest = new System.Windows.Forms.TextBox();
            this.lstRooms = new System.Windows.Forms.ListBox();
            this.txtSelectedRoom = new System.Windows.Forms.TextBox();
            this.btnMakeReservation = new System.Windows.Forms.Button();
            this.lblSelectedRoom = new System.Windows.Forms.Label();
            this.lblSelectedGuest = new System.Windows.Forms.Label();
            this.lblSelectGuest = new System.Windows.Forms.Label();
            this.lblSelectRoom = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblNumGuests = new System.Windows.Forms.Label();
            this.txtNumGuests = new System.Windows.Forms.TextBox();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(761, 385);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(133, 62);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // lstGuests
            // 
            this.lstGuests.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstGuests.FormattingEnabled = true;
            this.lstGuests.ItemHeight = 16;
            this.lstGuests.Location = new System.Drawing.Point(44, 59);
            this.lstGuests.Margin = new System.Windows.Forms.Padding(4);
            this.lstGuests.Name = "lstGuests";
            this.lstGuests.Size = new System.Drawing.Size(228, 324);
            this.lstGuests.TabIndex = 1;
            this.lstGuests.SelectedIndexChanged += new System.EventHandler(this.lstGuests_SelectedIndexChanged);
            // 
            // txtSelectedGuest
            // 
            this.txtSelectedGuest.Location = new System.Drawing.Point(516, 59);
            this.txtSelectedGuest.Margin = new System.Windows.Forms.Padding(4);
            this.txtSelectedGuest.Multiline = true;
            this.txtSelectedGuest.Name = "txtSelectedGuest";
            this.txtSelectedGuest.ReadOnly = true;
            this.txtSelectedGuest.Size = new System.Drawing.Size(378, 139);
            this.txtSelectedGuest.TabIndex = 2;
            // 
            // lstRooms
            // 
            this.lstRooms.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRooms.FormattingEnabled = true;
            this.lstRooms.ItemHeight = 16;
            this.lstRooms.Location = new System.Drawing.Point(280, 59);
            this.lstRooms.Margin = new System.Windows.Forms.Padding(4);
            this.lstRooms.Name = "lstRooms";
            this.lstRooms.Size = new System.Drawing.Size(228, 324);
            this.lstRooms.TabIndex = 3;
            this.lstRooms.SelectedIndexChanged += new System.EventHandler(this.lstRooms_SelectedIndexChanged);
            // 
            // txtSelectedRoom
            // 
            this.txtSelectedRoom.Location = new System.Drawing.Point(516, 238);
            this.txtSelectedRoom.Margin = new System.Windows.Forms.Padding(4);
            this.txtSelectedRoom.Multiline = true;
            this.txtSelectedRoom.Name = "txtSelectedRoom";
            this.txtSelectedRoom.ReadOnly = true;
            this.txtSelectedRoom.Size = new System.Drawing.Size(378, 139);
            this.txtSelectedRoom.TabIndex = 4;
            // 
            // btnMakeReservation
            // 
            this.btnMakeReservation.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeReservation.Location = new System.Drawing.Point(761, 454);
            this.btnMakeReservation.Margin = new System.Windows.Forms.Padding(4);
            this.btnMakeReservation.Name = "btnMakeReservation";
            this.btnMakeReservation.Size = new System.Drawing.Size(133, 62);
            this.btnMakeReservation.TabIndex = 5;
            this.btnMakeReservation.Text = "Make Reservation";
            this.btnMakeReservation.UseVisualStyleBackColor = true;
            this.btnMakeReservation.Click += new System.EventHandler(this.btnMakeReservation_Click);
            // 
            // lblSelectedRoom
            // 
            this.lblSelectedRoom.AutoSize = true;
            this.lblSelectedRoom.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedRoom.Location = new System.Drawing.Point(516, 214);
            this.lblSelectedRoom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedRoom.Name = "lblSelectedRoom";
            this.lblSelectedRoom.Size = new System.Drawing.Size(106, 16);
            this.lblSelectedRoom.TabIndex = 6;
            this.lblSelectedRoom.Text = "Selected Room";
            // 
            // lblSelectedGuest
            // 
            this.lblSelectedGuest.AutoSize = true;
            this.lblSelectedGuest.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedGuest.Location = new System.Drawing.Point(516, 36);
            this.lblSelectedGuest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedGuest.Name = "lblSelectedGuest";
            this.lblSelectedGuest.Size = new System.Drawing.Size(109, 16);
            this.lblSelectedGuest.TabIndex = 7;
            this.lblSelectedGuest.Text = "Selected Guest";
            // 
            // lblSelectGuest
            // 
            this.lblSelectGuest.AutoSize = true;
            this.lblSelectGuest.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectGuest.Location = new System.Drawing.Point(40, 36);
            this.lblSelectGuest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectGuest.Name = "lblSelectGuest";
            this.lblSelectGuest.Size = new System.Drawing.Size(106, 16);
            this.lblSelectGuest.TabIndex = 8;
            this.lblSelectGuest.Text = "Select a Guest";
            // 
            // lblSelectRoom
            // 
            this.lblSelectRoom.AutoSize = true;
            this.lblSelectRoom.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectRoom.Location = new System.Drawing.Point(276, 36);
            this.lblSelectRoom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectRoom.Name = "lblSelectRoom";
            this.lblSelectRoom.Size = new System.Drawing.Size(103, 16);
            this.lblSelectRoom.TabIndex = 9;
            this.lblSelectRoom.Text = "Select a Room";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(39, 11);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(170, 20);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Make a Reservation";
            // 
            // lblNumGuests
            // 
            this.lblNumGuests.AutoSize = true;
            this.lblNumGuests.Location = new System.Drawing.Point(399, 414);
            this.lblNumGuests.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumGuests.Name = "lblNumGuests";
            this.lblNumGuests.Size = new System.Drawing.Size(131, 16);
            this.lblNumGuests.TabIndex = 11;
            this.lblNumGuests.Text = "Number of Guests:";
            // 
            // txtNumGuests
            // 
            this.txtNumGuests.Location = new System.Drawing.Point(637, 411);
            this.txtNumGuests.Name = "txtNumGuests";
            this.txtNumGuests.Size = new System.Drawing.Size(100, 23);
            this.txtNumGuests.TabIndex = 12;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(537, 440);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 23);
            this.dtpStartDate.TabIndex = 13;
            // 
            // lblStartDate
            // 
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Location = new System.Drawing.Point(399, 445);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(84, 16);
            this.lblStartDate.TabIndex = 14;
            this.lblStartDate.Text = "Start Date:";
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(537, 470);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 23);
            this.dtpEndDate.TabIndex = 15;
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Location = new System.Drawing.Point(399, 475);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(74, 16);
            this.lblEndDate.TabIndex = 16;
            this.lblEndDate.Text = "End Date:";
            // 
            // MakeReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(928, 546);
            this.ControlBox = false;
            this.Controls.Add(this.lblEndDate);
            this.Controls.Add(this.dtpEndDate);
            this.Controls.Add(this.lblStartDate);
            this.Controls.Add(this.dtpStartDate);
            this.Controls.Add(this.txtNumGuests);
            this.Controls.Add(this.lblNumGuests);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblSelectRoom);
            this.Controls.Add(this.lblSelectGuest);
            this.Controls.Add(this.lblSelectedGuest);
            this.Controls.Add(this.lblSelectedRoom);
            this.Controls.Add(this.btnMakeReservation);
            this.Controls.Add(this.txtSelectedRoom);
            this.Controls.Add(this.lstRooms);
            this.Controls.Add(this.txtSelectedGuest);
            this.Controls.Add(this.lstGuests);
            this.Controls.Add(this.btnCancel);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MakeReservationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Letoh: Hotel Management Service - Make a Reservation";
            this.Load += new System.EventHandler(this.MakeReservationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ListBox lstGuests;
        private System.Windows.Forms.TextBox txtSelectedGuest;
        private System.Windows.Forms.ListBox lstRooms;
        private System.Windows.Forms.TextBox txtSelectedRoom;
        private System.Windows.Forms.Button btnMakeReservation;
        private System.Windows.Forms.Label lblSelectedRoom;
        private System.Windows.Forms.Label lblSelectedGuest;
        private System.Windows.Forms.Label lblSelectGuest;
        private System.Windows.Forms.Label lblSelectRoom;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblNumGuests;
        private System.Windows.Forms.TextBox txtNumGuests;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lblEndDate;
    }
}
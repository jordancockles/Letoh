namespace Letoh_HMS
{
    partial class ReservationFormUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationFormUI));
            this.lstReservations = new System.Windows.Forms.ListBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMakeReservation = new System.Windows.Forms.Button();
            this.btnCancelReservation = new System.Windows.Forms.Button();
            this.txtSelectedReservation = new System.Windows.Forms.TextBox();
            this.btnGenerateTextReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstReservations
            // 
            this.lstReservations.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstReservations.FormattingEnabled = true;
            this.lstReservations.ItemHeight = 15;
            this.lstReservations.Location = new System.Drawing.Point(31, 13);
            this.lstReservations.Name = "lstReservations";
            this.lstReservations.Size = new System.Drawing.Size(349, 214);
            this.lstReservations.TabIndex = 0;
            this.lstReservations.SelectedIndexChanged += new System.EventHandler(this.lstReservations_SelectedIndexChanged);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(555, 177);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 50);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnMakeReservation
            // 
            this.btnMakeReservation.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMakeReservation.Location = new System.Drawing.Point(31, 233);
            this.btnMakeReservation.Name = "btnMakeReservation";
            this.btnMakeReservation.Size = new System.Drawing.Size(100, 50);
            this.btnMakeReservation.TabIndex = 2;
            this.btnMakeReservation.Text = "&Make Reservation";
            this.btnMakeReservation.UseVisualStyleBackColor = true;
            this.btnMakeReservation.Click += new System.EventHandler(this.btnMakeReservation_Click);
            // 
            // btnCancelReservation
            // 
            this.btnCancelReservation.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelReservation.Location = new System.Drawing.Point(137, 233);
            this.btnCancelReservation.Name = "btnCancelReservation";
            this.btnCancelReservation.Size = new System.Drawing.Size(100, 50);
            this.btnCancelReservation.TabIndex = 3;
            this.btnCancelReservation.Text = "Cancel &Reservation";
            this.btnCancelReservation.UseVisualStyleBackColor = true;
            this.btnCancelReservation.Click += new System.EventHandler(this.btnCancelReservation_Click);
            // 
            // txtSelectedReservation
            // 
            this.txtSelectedReservation.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelectedReservation.Location = new System.Drawing.Point(386, 13);
            this.txtSelectedReservation.Multiline = true;
            this.txtSelectedReservation.Name = "txtSelectedReservation";
            this.txtSelectedReservation.ReadOnly = true;
            this.txtSelectedReservation.Size = new System.Drawing.Size(269, 158);
            this.txtSelectedReservation.TabIndex = 4;
            // 
            // btnGenerateTextReport
            // 
            this.btnGenerateTextReport.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateTextReport.Location = new System.Drawing.Point(387, 178);
            this.btnGenerateTextReport.Name = "btnGenerateTextReport";
            this.btnGenerateTextReport.Size = new System.Drawing.Size(100, 50);
            this.btnGenerateTextReport.TabIndex = 5;
            this.btnGenerateTextReport.Text = "&Generate Report";
            this.btnGenerateTextReport.UseVisualStyleBackColor = true;
            this.btnGenerateTextReport.Click += new System.EventHandler(this.btnGenerateTextReport_Click);
            // 
            // ReservationFormUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(694, 332);
            this.ControlBox = false;
            this.Controls.Add(this.btnGenerateTextReport);
            this.Controls.Add(this.txtSelectedReservation);
            this.Controls.Add(this.btnCancelReservation);
            this.Controls.Add(this.btnMakeReservation);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lstReservations);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReservationFormUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Letoh: Hotel Management Software - Reservations";
            this.Load += new System.EventHandler(this.ReservationFormUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstReservations;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMakeReservation;
        private System.Windows.Forms.Button btnCancelReservation;
        private System.Windows.Forms.TextBox txtSelectedReservation;
        private System.Windows.Forms.Button btnGenerateTextReport;
    }
}
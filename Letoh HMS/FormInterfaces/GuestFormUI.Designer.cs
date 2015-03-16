namespace Letoh_HMS
{
    partial class GuestFormUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GuestFormUI));
            this.lstGuests = new System.Windows.Forms.ListBox();
            this.btnRegisterGuest = new System.Windows.Forms.Button();
            this.btnRemoveGuest = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtSelectedGuest = new System.Windows.Forms.TextBox();
            this.btnGenerateTextReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstGuests
            // 
            this.lstGuests.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstGuests.FormattingEnabled = true;
            this.lstGuests.ItemHeight = 16;
            this.lstGuests.Location = new System.Drawing.Point(26, 13);
            this.lstGuests.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.lstGuests.Name = "lstGuests";
            this.lstGuests.Size = new System.Drawing.Size(242, 228);
            this.lstGuests.TabIndex = 0;
            this.lstGuests.SelectedIndexChanged += new System.EventHandler(this.lstGuests_SelectedIndexChanged);
            // 
            // btnRegisterGuest
            // 
            this.btnRegisterGuest.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterGuest.Location = new System.Drawing.Point(26, 247);
            this.btnRegisterGuest.Name = "btnRegisterGuest";
            this.btnRegisterGuest.Size = new System.Drawing.Size(100, 50);
            this.btnRegisterGuest.TabIndex = 1;
            this.btnRegisterGuest.Text = "&Register Guest";
            this.btnRegisterGuest.UseVisualStyleBackColor = true;
            this.btnRegisterGuest.Click += new System.EventHandler(this.btnRegisterGuest_Click);
            // 
            // btnRemoveGuest
            // 
            this.btnRemoveGuest.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveGuest.Location = new System.Drawing.Point(168, 247);
            this.btnRemoveGuest.Name = "btnRemoveGuest";
            this.btnRemoveGuest.Size = new System.Drawing.Size(100, 50);
            this.btnRemoveGuest.TabIndex = 2;
            this.btnRemoveGuest.Text = "Remove Guest";
            this.btnRemoveGuest.UseVisualStyleBackColor = true;
            this.btnRemoveGuest.Click += new System.EventHandler(this.btnRemoveGuest_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(470, 247);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 50);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtSelectedGuest
            // 
            this.txtSelectedGuest.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSelectedGuest.Location = new System.Drawing.Point(306, 13);
            this.txtSelectedGuest.Multiline = true;
            this.txtSelectedGuest.Name = "txtSelectedGuest";
            this.txtSelectedGuest.ReadOnly = true;
            this.txtSelectedGuest.Size = new System.Drawing.Size(264, 228);
            this.txtSelectedGuest.TabIndex = 4;
            // 
            // btnGenerateTextReport
            // 
            this.btnGenerateTextReport.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateTextReport.Location = new System.Drawing.Point(306, 248);
            this.btnGenerateTextReport.Name = "btnGenerateTextReport";
            this.btnGenerateTextReport.Size = new System.Drawing.Size(100, 50);
            this.btnGenerateTextReport.TabIndex = 5;
            this.btnGenerateTextReport.Text = "&Generate Report";
            this.btnGenerateTextReport.UseVisualStyleBackColor = true;
            this.btnGenerateTextReport.Click += new System.EventHandler(this.btnGenerateTextReport_Click);
            // 
            // GuestFormUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(610, 322);
            this.ControlBox = false;
            this.Controls.Add(this.btnGenerateTextReport);
            this.Controls.Add(this.txtSelectedGuest);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnRemoveGuest);
            this.Controls.Add(this.btnRegisterGuest);
            this.Controls.Add(this.lstGuests);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "GuestFormUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Letoh: Hotel Management Software - Guests";
            this.Load += new System.EventHandler(this.GuestFormUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstGuests;
        private System.Windows.Forms.Button btnRegisterGuest;
        private System.Windows.Forms.Button btnRemoveGuest;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtSelectedGuest;
        private System.Windows.Forms.Button btnGenerateTextReport;
    }
}
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
    public partial class SplashScreen : Form
    {
        private int counter = 0;

        public SplashScreen()
        {
            InitializeComponent();
            timSplashScreen.Start();
        }

        private void timSplashScreen_Tick(object sender, EventArgs e)
        {
            counter++;
            if (counter == 26)
            {
                timSplashScreen.Stop();
                this.Close();
            }
        }
    }
}

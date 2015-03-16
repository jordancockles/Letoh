//Letoh Hotel Reservation Program
//Prototype Version 1.0
//Developed By: Jordan Cockles

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Letoh_HMS
{
    interface IUserInterface
    {
        IDisplay GetItem(String s);
        void DisplayAll(IDisplay obj);
        void GenerateTextReport(IDisplay obj);
    }
}

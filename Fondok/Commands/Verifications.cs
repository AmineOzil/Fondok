﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Fondok.Commands
{
    class Verifications
    {

        public void JustChar(object sender, KeyEventArgs e)
        {
            if ((e.Key >= Key.A && e.Key <= Key.Z) || (e.Key == Key.Back))
            {
            }
            else
            {
                e.Handled = true;
            }


        }


        public void JustNum(object sender, KeyEventArgs e)
        {

            if ( (e.Key == Key.Back) || (e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9))

            {
               
            }
            else e.Handled = true;
        }

        //holahola xD 
        


    }
}

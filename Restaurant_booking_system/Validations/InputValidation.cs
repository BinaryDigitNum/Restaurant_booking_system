﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Restaurant_booking_system.InputValidations
{
    public static class InputValidation
    {
        // This method compare the email input with Regex expression pattern to check
        // if the input is the valid email address or not
        public static bool ValidateEmail(TextBox textbox)
        {
            if(textbox.Text == null) return false;

            Regex emailSignature = new Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");

            if (!emailSignature.IsMatch(textbox.Text))
            {

                MessageBox.Show("Invalid Input", "Please check the input value",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                textbox.Focus();
                return false;
            }

            return true;
        }

        // This method checks whether the textbox values is null or empty
        public static bool ValidateNullOrEmpty(TextBox textbox)
        {
            if(textbox.Text == null || textbox.Text == "") 
            {
                MessageBox.Show("Invalid Input", "Please check the input value",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                textbox.Focus();

                return false; 
            }
            return true;
        }

    }
}

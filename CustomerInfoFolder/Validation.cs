using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;

namespace Vistainn_Kiosk.CustomerInfoFolder
{
    internal class Validation
    {
        public static bool ValidateDates(DateTime checkIn, DateTime checkOut)
        {
            if (checkIn < DateTime.Today)
            {
                MessageBox.Show("Check-in date cannot be in the past. Please select a valid date.");
                return false;
            }

            if (checkOut <= checkIn)
            {
                MessageBox.Show("Check-out date must be later than check-in date. Please select a valid date.");
                return false;
            }

            return true;
        }

        public static bool ValidateEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("The email is empty. Please provide a valid email address.");
                return false;
            }

            if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Invalid email format. Please enter a valid email.");
                return false;
            }

            return true;
        }

        public static bool ValidatePhoneNumber(string phoneNo)
        {
            if (string.IsNullOrEmpty(phoneNo))
            {
                MessageBox.Show("The phone number is missing. Please provide a phone number.");
                return false;
            }

            string phonePattern = @"^(\+?[0-9]{1,4})?[\s\-]?[0-9]{1,4}[\s\-]?[0-9]{1,4}[\s\-]?[0-9]{1,4}$";

            if (!Regex.IsMatch(phoneNo, phonePattern))
            {
                MessageBox.Show("Invalid phone number. Please enter a valid phone number (e.g., +123 456-7890).");
                return false;
            }

            return true;
        }

        public static bool ValidateName(string name)
        {
            string pattern = @"^[a-zA-Z\s.'-]+$";

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Name cannot be empty.");
                return false;
            }

            if (!Regex.IsMatch(name, pattern))
            {
                MessageBox.Show("Name can only contain letters, spaces, apostrophes, hyphens, and periods.");
                return false;
            }

            return true;
        }
    }
}

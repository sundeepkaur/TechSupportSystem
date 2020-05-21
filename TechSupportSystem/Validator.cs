using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechSupportSystem
{
    class Validator
    {
        private static String title = "Entry Error";
        public static String Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        public static bool IsPresent(TextBox textBox)
        {
            if (textBox.Text == "")
            {
                MessageBox.Show(textBox.Tag + " is a required field.", Title);
                textBox.Clear();
                textBox.Focus();
                return false;
            }
            return true;
        }

        public static bool IsDecimal(TextBox textBox)
        {
            decimal number = 0m;
            if (Decimal.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be a decimal value.", Title);
                textBox.Clear();
                textBox.Focus();
                return false;
            }
        }

        public static bool IsNumeric(TextBox textBox)
        {
            int number = 0;

            if (int.TryParse(textBox.Text, out number))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be a numeric value.", Title);
                textBox.Clear();
                textBox.Focus();
                return false;
            }
        }

        public static bool Reset(TextBox textBox)
        {
            textBox.Clear();
            return true;
        }

        public static bool IsInRange(TextBox textBox)
        {
            if (textBox.Text.Length <= 10)
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be a unique 10 chars long value only.", Title);
                textBox.Clear();
                textBox.Focus();
                return false;
            }
        }

        public static bool IsInDateFormat(TextBox textBox)
        {
            DateTime dt;
            if (DateTime.TryParse(textBox.Text, out dt))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be in correct date format, ie mm-dd-yyyy", Title);
                textBox.Clear();
                textBox.Focus();
                return false;
            }
        }

        public static bool IsInEmailFormat(TextBox textBox)
        {
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (regex.IsMatch(textBox.Text))
            {
                return true;
            }
            else
            {
                MessageBox.Show(textBox.Tag + " must be in correct Email format, joe@gmail.com", Title);
                textBox.Clear();
                textBox.Focus();
                return false;
            }
        }

        public static bool IsInPhoneFormat(TextBox textBox)
        {
            Regex r = new Regex("^\\(\\d{3}\\)\\d{3}[-]\\d{4}$");
            if (r.IsMatch(textBox.Text)) { return true; }
            else
            {
                MessageBox.Show(textBox.Tag + " should match the phone format, ie (999)999-9999", Title);
                textBox.Clear();
                textBox.Focus();
                return false;
            }
        }

        public static bool IsInPostalCodeFormat(TextBox textBox)
        {
            Regex r = new Regex("^([A-Za-z]\\d[A-Za-z][-]?\\d[A-Za-z]\\d)");
            if (r.IsMatch(textBox.Text)) { return true; }
            else
            {
                MessageBox.Show(textBox.Tag + " should match the phone format, ie K4T3G5", Title);
                textBox.Clear();
                textBox.Focus();
                return false;
            }
        }


        public static bool IsAlphabetic(TextBox textBox)
        {
            if (textBox.Text.All(char.IsLetter)) { return true; }
            else
            {
                MessageBox.Show(textBox.Tag + " should only be Alphabetic, ie only letters are allowed without spaces", Title);
                textBox.Clear();
                textBox.Focus();
                return false;
            }
        }


        public static bool IsAlphaNumeric(TextBox textBox)
        {
            if (textBox.Text.All(char.IsLetterOrDigit)) { return true; }
            else
            {
                MessageBox.Show(textBox.Tag + " should only be alphanumeric, ie only letters or digits are allowed without spaces.", Title);
                textBox.Clear();
                textBox.Focus();
                return false;
            }
        }

        public static bool IsUniqueEntry(TextBox textBox)
        {
            bool success = true;
            if ("Product Code".Equals(textBox.Tag))
            {
                Product[] products = ProductDB.GetProducts();
                if (products != null)
                    for (int i = 0; i < ProductDB.count; i++)
                    {
                        if (products[i].Code.Equals(int.Parse(textBox.Text)))
                        {
                            MessageBox.Show(textBox.Tag + " already exists, please enter new unique value.", Title);
                            textBox.Clear();
                            textBox.Focus();
                            success = false;
                        }
                    }
            }

            if ("Technician ID".Equals(textBox.Tag))
            {
                Technician[] technicians = TechnicianDB.GetTechnicians();
                if (technicians != null)
                    for (int i = 0; i < TechnicianDB.count; i++)
                    {
                        if (technicians[i].ID.Equals(int.Parse(textBox.Text)))
                        {
                            MessageBox.Show(textBox.Tag + " already exists, please enter new unique value.", Title);
                            textBox.Clear();
                            textBox.Focus();
                            success = false;
                        }
                    }
            }

            if ("Customer ID".Equals(textBox.Tag))
            {
                Customer[] customers = CustomerDB.GetCustomers();
                if (customers != null)
                    for (int i = 0; i < CustomerDB.count; i++)
                    {
                        if (customers[i].ID.Equals(int.Parse(textBox.Text)))
                        {
                            MessageBox.Show(textBox.Tag + " already exists, please enter new unique value.", Title);
                            textBox.Clear();
                            textBox.Focus();
                            success = false;
                        }
                    }
            }
            return success;
        }
    }
}

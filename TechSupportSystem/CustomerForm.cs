using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechSupportSystem
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private Customer customer = null;

        public Customer GetNewCustomer()
        {
            this.ShowDialog();
            if (customer != null)
                return customer;
            else
                return null;
        }

        private void btnCustSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                customer = new Customer(Convert.ToInt32(txtCustId.Text), txtCustName.Text, txtCustStreetName.Text, Convert.ToInt32(txtCustStreetNumber.Text), txtCustCity.Text, txtCustProvince.Text, txtCustPostalCode.Text, txtCustPhone.Text, txtCustEmail.Text);
                this.Close();
            }
        }
        private bool IsValidData()
        {
            return Validator.IsPresent(txtCustId) &&
                   Validator.IsNumeric(txtCustId) &&
                   Validator.IsUniqueEntry(txtCustId) &&

                   Validator.IsPresent(txtCustName) &&
                   Validator.IsAlphabetic(txtCustName) &&

                   Validator.IsPresent(txtCustStreetName) &&
                   Validator.IsAlphabetic(txtCustStreetName) &&

                   Validator.IsPresent(txtCustStreetNumber) &&
                   Validator.IsNumeric(txtCustStreetNumber) &&

                   Validator.IsPresent(txtCustCity) &&
                   Validator.IsAlphabetic(txtCustCity) &&

                   Validator.IsPresent(txtCustProvince) &&
                   Validator.IsAlphabetic(txtCustProvince) &&

                   Validator.IsPresent(txtCustPostalCode) &&
                   Validator.IsAlphaNumeric(txtCustPostalCode) &&
                   Validator.IsInPostalCodeFormat(txtCustPostalCode) &&

                   Validator.IsPresent(txtCustPhone) &&
                   Validator.IsInPhoneFormat(txtCustPhone) &&

                   Validator.IsPresent(txtCustEmail) &&
                   Validator.IsInEmailFormat(txtCustEmail);
        }

        private void ResetAll()
        {
            txtCustId.Clear();
            txtCustName.Clear();
            txtCustStreetName.Clear();
            txtCustStreetNumber.Clear();
            txtCustCity.Clear();
            txtCustProvince.Clear();
            txtCustPostalCode.Clear();
            txtCustPhone.Clear();
            txtCustEmail.Clear();
        }

        private void btnCustCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

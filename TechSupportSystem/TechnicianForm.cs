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
    public partial class TechnicianForm : Form
    {
        public TechnicianForm()
        {
            InitializeComponent();
        }

        private Technician technician = null;

        public Technician GetNewTechnician()
        {
            this.ShowDialog();
            if (technician != null)
                return technician;
            else
                return null;
        }

        private void btnTechSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                technician = new Technician(Convert.ToInt32(txtTechID.Text), txtTechName.Text, txtTechPhone.Text, txtTechEmail.Text);
                this.Close();
            }
        }

        private bool IsValidData()
        {
            return Validator.IsPresent(txtTechID) &&
                   Validator.IsNumeric(txtTechID) &&
                   Validator.IsUniqueEntry(txtTechID) &&

                   Validator.IsPresent(txtTechName) &&
                   Validator.IsAlphabetic(txtTechName) &&

                   Validator.IsPresent(txtTechEmail) &&
                   Validator.IsInEmailFormat(txtTechEmail) &&

                   Validator.IsPresent(txtTechPhone) &&
                   Validator.IsInPhoneFormat(txtTechPhone);
        }

        private void ResetAll()
        {
            txtTechID.Clear();
            txtTechName.Clear();
            txtTechEmail.Clear();
            txtTechPhone.Clear();
        }

        public void SetTechFormFields(Technician tech)
        {
            txtTechID.Text = tech.ID.ToString();
            txtTechName.Text = tech.Name;
            txtTechEmail.Text = tech.Email;
            txtTechPhone.Text = tech.Phone;
        }

        private void btnTechCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}

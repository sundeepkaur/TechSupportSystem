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
    public partial class MaintainCustomer : Form
    {
        public MaintainCustomer()
        {
            InitializeComponent();
        }

        private Customer[] custs = null;

        private void MaintainCustomer_Load(object sender, EventArgs e)
        {
            custs = CustomerDB.GetCustomers();
            if (custs != null)
                FillCustomerListBox();
        }

        private void FillCustomerListBox()
        {
            lstCustomer.Items.Clear();
            foreach (Customer c in custs)
            {
                if (c != null)
                    lstCustomer.Items.Add(c.GetDisplayCustomer("\t"));
            }
        }

        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerForm customer = new CustomerForm();
                Customer c = customer.GetNewCustomer();
                if (c != null)
                {
                    if (CustomerDB.AddCustomer(c))
                    {
                        MessageBox.Show("Customer added successfully !");
                        FillCustomerListBox();
                    }
                    else
                        MessageBox.Show("Failed to add Customer");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnCustomerSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yet to be Implemented");
        }

        private void btnCustomerModify_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yet to be implemented.");
        }

        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yet to be Implemented");
        }
    }
}

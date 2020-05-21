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
    public partial class frmTechSupportSystem : Form
    {
        public frmTechSupportSystem()
        {
            InitializeComponent();
        }

        private void btnMaintainCustomer_Click(object sender, EventArgs e)
        {
            MaintainCustomer maintainCustomer = new MaintainCustomer();
            maintainCustomer.MdiParent = this;
            maintainCustomer.Show();
        }

        private void btnMaintainProduct_Click(object sender, EventArgs e)
        {
            MaintainProducts maintainProducts = new MaintainProducts();
            maintainProducts.MdiParent = this;
            maintainProducts.Show();
        }

        private void btnMaintainTechnician_Click(object sender, EventArgs e)
        {
            MaintainTechnician maintainTechnician = new MaintainTechnician();
            maintainTechnician.MdiParent = this;
            maintainTechnician.Show();
        }

        private void btnMaintainIncident_Click(object sender, EventArgs e)
        {
            MaintainIncident maintainIncident = new MaintainIncident();
            maintainIncident.MdiParent = this;
            maintainIncident.Show();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yet to be implemented.");
        }
    }
}

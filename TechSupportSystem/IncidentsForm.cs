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
    public partial class IncidentsForm : Form
    {
        public IncidentsForm()
        {
            InitializeComponent();
        }

        private void btnIncidentCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private Incident incident = null;

        public Incident GetNewIncident()
        {
            this.ShowDialog();
            if (incident != null)
                return incident;
            else
                return null;
        }
        private void btnIncSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yet to be implemented");
        }

        private bool IsValidData()
        {
            return true;
        }

        private void ResetAll()
        {

        }
    }
}

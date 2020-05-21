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
    public partial class MaintainIncident : Form
    {
        public MaintainIncident()
        {
            InitializeComponent();
        }

        private Incident[] incs = null;

        private void MaintainIncident_Load(object sender, EventArgs e)
        {
            incs = IncidentsDB.GetIncidents();
            if (incs != null)
                FillIncidentListBox();
        }

        private void FillIncidentListBox()
        {
            lstIncidents.Items.Clear();
            foreach (Incident i in incs)
            {
                if (i != null)
                    lstIncidents.Items.Add(i.GetDisplayIncidents("\t"));
            }
        }

        private void btnMaintainCloseIncidents_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yet to be Implemented");
        }

        private void btnAddIncident_Click(object sender, EventArgs e)
        {
            IncidentsForm inc = new IncidentsForm();
            inc.Show();
        }
    }
}

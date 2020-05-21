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
    public partial class MaintainTechnician : Form
    {
        public MaintainTechnician()
        {
            InitializeComponent();
        }

        private Technician[] techs = null;

        private void MaintainTechnician_Load(object sender, EventArgs e)
        {
            techs = TechnicianDB.GetTechnicians();
            if (techs != null)
                FillTechnicianListBox();
        }

        private void FillTechnicianListBox()
        {
            lstTechnician.Items.Clear();
            foreach (Technician t in techs)
            {
                if (t != null)
                    lstTechnician.Items.Add(t.GetDisplayTechnician("\t"));
            }
        }

        private void btnTechnicianAdd_Click(object sender, EventArgs e)
        {
            try
            {
                TechnicianForm tech = new TechnicianForm();
                Technician t = tech.GetNewTechnician();
                if (t != null)
                {
                    if (TechnicianDB.AddTechnician(t))
                    {
                        MessageBox.Show("Technician added successfully !");
                        FillTechnicianListBox();
                    }
                    else
                        MessageBox.Show("Failed to add Technician");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnTechnicianSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yet to be implemented.");
        }

        private void btnTechnicianModify_Click(object sender, EventArgs e)
        {
            try
            {
                int i = lstTechnician.SelectedIndex;
                TechnicianForm techForm = new TechnicianForm();

                if (i != -1)
                {
                    Technician technician = techs[i];
                    techForm.SetTechFormFields(technician);
                    technician.ID = 0;
                    technician.Name = null;
                    technician.Email = null;
                    technician.Phone = null;
                    MessageBox.Show("Modify the record and click save !");
                    FillTechnicianListBox();
                    technician = techForm.GetNewTechnician();
                    if (technician != null)
                    {
                        if (TechnicianDB.AddTechnician(technician))
                        {
                            MessageBox.Show("Technician added successfully !");
                            FillTechnicianListBox();
                        }
                        else
                            MessageBox.Show("Failed to add Technician");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnTechnicianDelete_Click(object sender, EventArgs e)
        {
            int i = lstTechnician.SelectedIndex;

            if (i != -1)
            {
                Technician technician = techs[i];
                String message = "Are you sure you want to delete " + technician.Name + " ?";
                DialogResult button = MessageBox.Show(message, "Confirm Delete", MessageBoxButtons.YesNo);

                if (button == DialogResult.Yes)
                {
                    technician.ID = 0;
                    technician.Name = null;
                    technician.Email = null;
                    technician.Phone = null;
                    FillTechnicianListBox();
                }
            }
        }
    }
}

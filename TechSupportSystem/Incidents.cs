﻿using System;
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
    public partial class Incidents : Form
    {
        public Incidents()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIncAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.Tag.ToString() + " is added.");
        }
    }
}

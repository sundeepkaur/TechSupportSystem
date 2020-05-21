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
    public partial class ProductForm : Form
    {
        public ProductForm()
        {
            InitializeComponent();
        }

        private Product product = null;

        public Product GetNewProduct()
        {
            this.ShowDialog();
            if (product != null)
                return product;
            else
                return null;
        }
        private void btnProdSave_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                product = new Product(int.Parse(txtProdCode.Text), txtProdName.Text, Math.Round(Convert.ToDecimal(txtProdVersion.Text), 1), txtProdDate.Text);
                this.Close();
            }
        }

        private bool IsValidData()
        {
            return Validator.IsPresent(txtProdCode) &&
                   Validator.IsNumeric(txtProdCode) &&
                   Validator.IsInRange(txtProdCode) &&
                   Validator.IsUniqueEntry(txtProdCode) &&

                   Validator.IsPresent(txtProdName) &&
                   Validator.IsAlphabetic(txtProdName) &&

                   Validator.IsPresent(txtProdVersion) &&
                   Validator.IsDecimal(txtProdVersion) &&

                   Validator.IsPresent(txtProdDate) &&
                   Validator.IsInDateFormat(txtProdDate);
        }

        public void SetProdFormFields(Product prod)
        {
            txtProdCode.Text = prod.Code.ToString();
            txtProdName.Text = prod.Name;
            txtProdVersion.Text = prod.Version.ToString();
            txtProdDate.Text = prod.Date;
        }

        private void ResetAll()
        {
            txtProdCode.Clear();
            txtProdName.Clear();
            txtProdVersion.Clear();
            txtProdDate.Clear();
        }

        private void btnProdCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}


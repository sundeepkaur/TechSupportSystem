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
    public partial class MaintainProducts : Form
    {
        public MaintainProducts()
        {
            InitializeComponent();
        }

        private Product[] prods = null;

        private void MaintainProducts_Load(object sender, EventArgs e)
        {
            prods = ProductDB.GetProducts();
            if (prods != null)
                FillProductListBox();
        }

        private void FillProductListBox()
        {
            lstMaintainProduct.Items.Clear();
            foreach (Product p in prods)
            {
                if (p != null)
                    lstMaintainProduct.Items.Add(p.GetDisplayProduct("\t"));
            }
        }

        private void btnProductAdd_Click(object sender, EventArgs e)
        {
            try
            {
                ProductForm product = new ProductForm();
                Product p = product.GetNewProduct();
                if (p != null)
                {
                    if (ProductDB.AddProduct(p))
                    {
                        MessageBox.Show("Product added successfully !");
                        FillProductListBox();
                    }
                    else
                        MessageBox.Show("Failed to add Product");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void btnProductSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yet to be implemented.");
        }

        private void btnProductModify_Click(object sender, EventArgs e)
        {
            try
            {
                int i = lstMaintainProduct.SelectedIndex;
                ProductForm prodForm = new ProductForm();

                if (i != -1)
                {
                    Product product = prods[i];
                    prodForm.SetProdFormFields(product);
                    product.Code = 0;
                    product.Name = null;
                    product.Version = 0;
                    product.Date = null;
                    MessageBox.Show("Modify the record and click save !");
                    FillProductListBox();
                    product = prodForm.GetNewProduct();
                  
                    if (product != null)
                    {
                        if (ProductDB.AddProduct(product))
                        {
              
                            MessageBox.Show("Product added successfully !");
                            FillProductListBox();
                        }
                        else
                            MessageBox.Show("Failed to add Product");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnProductDelete_Click(object sender, EventArgs e)
        {
            int i = lstMaintainProduct.SelectedIndex;
            if (i != -1)
            {
                Product product = prods[i];
                String message = "Are you sure you want to delete " + product.Name + " ?";
                DialogResult button = MessageBox.Show(message, "Confirm Delete", MessageBoxButtons.YesNo);

                if (button == DialogResult.Yes)
                {
                    prods = prods.Where((source, index) => index != i).ToArray();
                    //product.Code = 0;
                    //product.Name = null;
                    //product.Version = 0;
                    //product.Date = null;
                    FillProductListBox();
                }
            }
        }
    }
}

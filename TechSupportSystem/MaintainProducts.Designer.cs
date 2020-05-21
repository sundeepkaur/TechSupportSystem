namespace TechSupportSystem
{
    partial class MaintainProducts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstMaintainProduct = new System.Windows.Forms.ListBox();
            this.btnProductAdd = new System.Windows.Forms.Button();
            this.btnProductSave = new System.Windows.Forms.Button();
            this.btnProductModify = new System.Windows.Forms.Button();
            this.btnProductDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstMaintainProduct
            // 
            this.lstMaintainProduct.FormattingEnabled = true;
            this.lstMaintainProduct.ItemHeight = 16;
            this.lstMaintainProduct.Location = new System.Drawing.Point(28, 28);
            this.lstMaintainProduct.Name = "lstMaintainProduct";
            this.lstMaintainProduct.Size = new System.Drawing.Size(496, 308);
            this.lstMaintainProduct.TabIndex = 0;
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.Location = new System.Drawing.Point(566, 47);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(126, 43);
            this.btnProductAdd.TabIndex = 1;
            this.btnProductAdd.Text = "&Add New";
            this.btnProductAdd.UseVisualStyleBackColor = true;
            this.btnProductAdd.Click += new System.EventHandler(this.btnProductAdd_Click);
            // 
            // btnProductSave
            // 
            this.btnProductSave.Location = new System.Drawing.Point(566, 119);
            this.btnProductSave.Name = "btnProductSave";
            this.btnProductSave.Size = new System.Drawing.Size(126, 45);
            this.btnProductSave.TabIndex = 2;
            this.btnProductSave.Text = "&Save";
            this.btnProductSave.UseVisualStyleBackColor = true;
            this.btnProductSave.Click += new System.EventHandler(this.btnProductSave_Click);
            // 
            // btnProductModify
            // 
            this.btnProductModify.Location = new System.Drawing.Point(566, 193);
            this.btnProductModify.Name = "btnProductModify";
            this.btnProductModify.Size = new System.Drawing.Size(126, 47);
            this.btnProductModify.TabIndex = 3;
            this.btnProductModify.Text = "&Modify";
            this.btnProductModify.UseVisualStyleBackColor = true;
            this.btnProductModify.Click += new System.EventHandler(this.btnProductModify_Click);
            // 
            // btnProductDelete
            // 
            this.btnProductDelete.Location = new System.Drawing.Point(566, 267);
            this.btnProductDelete.Name = "btnProductDelete";
            this.btnProductDelete.Size = new System.Drawing.Size(126, 47);
            this.btnProductDelete.TabIndex = 4;
            this.btnProductDelete.Text = "&Delete";
            this.btnProductDelete.UseVisualStyleBackColor = true;
            this.btnProductDelete.Click += new System.EventHandler(this.btnProductDelete_Click);
            // 
            // MaintainProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 357);
            this.Controls.Add(this.btnProductDelete);
            this.Controls.Add(this.btnProductModify);
            this.Controls.Add(this.btnProductSave);
            this.Controls.Add(this.btnProductAdd);
            this.Controls.Add(this.lstMaintainProduct);
            this.Name = "MaintainProducts";
            this.Tag = "Product";
            this.Text = "MaintainProducts";
            this.Load += new System.EventHandler(this.MaintainProducts_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstMaintainProduct;
        private System.Windows.Forms.Button btnProductAdd;
        private System.Windows.Forms.Button btnProductSave;
        private System.Windows.Forms.Button btnProductModify;
        private System.Windows.Forms.Button btnProductDelete;
    }
}
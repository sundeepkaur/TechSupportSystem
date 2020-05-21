namespace TechSupportSystem
{
    partial class ProductForm
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
            this.lblProdCode = new System.Windows.Forms.Label();
            this.lblProdName = new System.Windows.Forms.Label();
            this.lblProdVersion = new System.Windows.Forms.Label();
            this.lblProdDate = new System.Windows.Forms.Label();
            this.txtProdCode = new System.Windows.Forms.TextBox();
            this.txtProdName = new System.Windows.Forms.TextBox();
            this.txtProdVersion = new System.Windows.Forms.TextBox();
            this.txtProdDate = new System.Windows.Forms.TextBox();
            this.btnProdCancel = new System.Windows.Forms.Button();
            this.btnProdSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProdCode
            // 
            this.lblProdCode.AutoSize = true;
            this.lblProdCode.Location = new System.Drawing.Point(56, 41);
            this.lblProdCode.Name = "lblProdCode";
            this.lblProdCode.Size = new System.Drawing.Size(94, 17);
            this.lblProdCode.TabIndex = 10;
            this.lblProdCode.Text = "Product Code";
            // 
            // lblProdName
            // 
            this.lblProdName.AutoSize = true;
            this.lblProdName.Location = new System.Drawing.Point(56, 89);
            this.lblProdName.Name = "lblProdName";
            this.lblProdName.Size = new System.Drawing.Size(45, 17);
            this.lblProdName.TabIndex = 11;
            this.lblProdName.Text = "Name";
            // 
            // lblProdVersion
            // 
            this.lblProdVersion.AutoSize = true;
            this.lblProdVersion.Location = new System.Drawing.Point(56, 136);
            this.lblProdVersion.Name = "lblProdVersion";
            this.lblProdVersion.Size = new System.Drawing.Size(56, 17);
            this.lblProdVersion.TabIndex = 12;
            this.lblProdVersion.Text = "Version";
            // 
            // lblProdDate
            // 
            this.lblProdDate.AutoSize = true;
            this.lblProdDate.Location = new System.Drawing.Point(56, 179);
            this.lblProdDate.Name = "lblProdDate";
            this.lblProdDate.Size = new System.Drawing.Size(94, 17);
            this.lblProdDate.TabIndex = 13;
            this.lblProdDate.Text = "Release Date";
            // 
            // txtProdCode
            // 
            this.txtProdCode.Location = new System.Drawing.Point(167, 41);
            this.txtProdCode.Name = "txtProdCode";
            this.txtProdCode.Size = new System.Drawing.Size(191, 22);
            this.txtProdCode.TabIndex = 4;
            this.txtProdCode.Tag = "Product Code";
            // 
            // txtProdName
            // 
            this.txtProdName.Location = new System.Drawing.Point(167, 84);
            this.txtProdName.Name = "txtProdName";
            this.txtProdName.Size = new System.Drawing.Size(191, 22);
            this.txtProdName.TabIndex = 5;
            this.txtProdName.Tag = "Product Name";
            // 
            // txtProdVersion
            // 
            this.txtProdVersion.Location = new System.Drawing.Point(167, 136);
            this.txtProdVersion.Name = "txtProdVersion";
            this.txtProdVersion.Size = new System.Drawing.Size(191, 22);
            this.txtProdVersion.TabIndex = 6;
            this.txtProdVersion.Tag = "Product Version";
            // 
            // txtProdDate
            // 
            this.txtProdDate.Location = new System.Drawing.Point(167, 179);
            this.txtProdDate.Name = "txtProdDate";
            this.txtProdDate.Size = new System.Drawing.Size(191, 22);
            this.txtProdDate.TabIndex = 7;
            this.txtProdDate.Tag = "Product Release Date";
            // 
            // btnProdCancel
            // 
            this.btnProdCancel.Location = new System.Drawing.Point(232, 267);
            this.btnProdCancel.Name = "btnProdCancel";
            this.btnProdCancel.Size = new System.Drawing.Size(116, 39);
            this.btnProdCancel.TabIndex = 9;
            this.btnProdCancel.Text = "&Cancel";
            this.btnProdCancel.UseVisualStyleBackColor = true;
            this.btnProdCancel.Click += new System.EventHandler(this.btnProdCancel_Click);
            // 
            // btnProdSave
            // 
            this.btnProdSave.Location = new System.Drawing.Point(59, 267);
            this.btnProdSave.Name = "btnProdSave";
            this.btnProdSave.Size = new System.Drawing.Size(108, 39);
            this.btnProdSave.TabIndex = 8;
            this.btnProdSave.Text = "&Save";
            this.btnProdSave.UseVisualStyleBackColor = true;
            this.btnProdSave.Click += new System.EventHandler(this.btnProdSave_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 371);
            this.Controls.Add(this.btnProdSave);
            this.Controls.Add(this.btnProdCancel);
            this.Controls.Add(this.txtProdDate);
            this.Controls.Add(this.txtProdVersion);
            this.Controls.Add(this.txtProdName);
            this.Controls.Add(this.txtProdCode);
            this.Controls.Add(this.lblProdDate);
            this.Controls.Add(this.lblProdVersion);
            this.Controls.Add(this.lblProdName);
            this.Controls.Add(this.lblProdCode);
            this.Name = "Product";
            this.Tag = "Product";
            this.Text = "Product";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProdCode;
        private System.Windows.Forms.Label lblProdName;
        private System.Windows.Forms.Label lblProdVersion;
        private System.Windows.Forms.Label lblProdDate;
        private System.Windows.Forms.TextBox txtProdCode;
        private System.Windows.Forms.TextBox txtProdName;
        private System.Windows.Forms.TextBox txtProdVersion;
        private System.Windows.Forms.TextBox txtProdDate;
        private System.Windows.Forms.Button btnProdCancel;
        private System.Windows.Forms.Button btnProdSave;
    }
}
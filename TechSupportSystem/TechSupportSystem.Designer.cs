namespace TechSupportSystem
{
    partial class frmTechSupportSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTechSupportSystem));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnFile = new System.Windows.Forms.ToolStripButton();
            this.btnMaintainCustomer = new System.Windows.Forms.ToolStripButton();
            this.btnMaintainProduct = new System.Windows.Forms.ToolStripButton();
            this.btnMaintainTechnician = new System.Windows.Forms.ToolStripButton();
            this.btnMaintainIncident = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFile,
            this.btnMaintainCustomer,
            this.btnMaintainProduct,
            this.btnMaintainTechnician,
            this.btnMaintainIncident});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1067, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnFile
            // 
            this.btnFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnFile.Image = ((System.Drawing.Image)(resources.GetObject("btnFile.Image")));
            this.btnFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(36, 24);
            this.btnFile.Text = "&File";
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // btnMaintainCustomer
            // 
            this.btnMaintainCustomer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnMaintainCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnMaintainCustomer.Image")));
            this.btnMaintainCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMaintainCustomer.Name = "btnMaintainCustomer";
            this.btnMaintainCustomer.Size = new System.Drawing.Size(138, 24);
            this.btnMaintainCustomer.Text = "Maintain &Customer";
            this.btnMaintainCustomer.Click += new System.EventHandler(this.btnMaintainCustomer_Click);
            // 
            // btnMaintainProduct
            // 
            this.btnMaintainProduct.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnMaintainProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnMaintainProduct.Image")));
            this.btnMaintainProduct.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMaintainProduct.Name = "btnMaintainProduct";
            this.btnMaintainProduct.Size = new System.Drawing.Size(126, 24);
            this.btnMaintainProduct.Text = "Maintain &Product";
            this.btnMaintainProduct.Click += new System.EventHandler(this.btnMaintainProduct_Click);
            // 
            // btnMaintainTechnician
            // 
            this.btnMaintainTechnician.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnMaintainTechnician.Image = ((System.Drawing.Image)(resources.GetObject("btnMaintainTechnician.Image")));
            this.btnMaintainTechnician.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMaintainTechnician.Name = "btnMaintainTechnician";
            this.btnMaintainTechnician.Size = new System.Drawing.Size(144, 24);
            this.btnMaintainTechnician.Text = "Maintain &Technician";
            this.btnMaintainTechnician.Click += new System.EventHandler(this.btnMaintainTechnician_Click);
            // 
            // btnMaintainIncident
            // 
            this.btnMaintainIncident.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnMaintainIncident.Image = ((System.Drawing.Image)(resources.GetObject("btnMaintainIncident.Image")));
            this.btnMaintainIncident.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnMaintainIncident.Name = "btnMaintainIncident";
            this.btnMaintainIncident.Size = new System.Drawing.Size(134, 24);
            this.btnMaintainIncident.Text = "Maintain &Incidents";
            this.btnMaintainIncident.Click += new System.EventHandler(this.btnMaintainIncident_Click);
            // 
            // frmTechSupportSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 563);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "frmTechSupportSystem";
            this.Text = "TechSupportSystem";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnFile;
        private System.Windows.Forms.ToolStripButton btnMaintainCustomer;
        private System.Windows.Forms.ToolStripButton btnMaintainProduct;
        private System.Windows.Forms.ToolStripButton btnMaintainTechnician;
        private System.Windows.Forms.ToolStripButton btnMaintainIncident;
    }
}


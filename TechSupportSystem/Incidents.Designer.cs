namespace TechSupportSystem
{
    partial class Incidents
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
            this.lblIncId = new System.Windows.Forms.Label();
            this.lblIncCustId = new System.Windows.Forms.Label();
            this.lblIncTechId = new System.Windows.Forms.Label();
            this.lblIncProdId = new System.Windows.Forms.Label();
            this.txtIncId = new System.Windows.Forms.TextBox();
            this.txtIncCustId = new System.Windows.Forms.TextBox();
            this.txtIncTechId = new System.Windows.Forms.TextBox();
            this.txtIncProdId = new System.Windows.Forms.TextBox();
            this.btnIncAdd = new System.Windows.Forms.Button();
            this.lblIncDateOpn = new System.Windows.Forms.Label();
            this.lblIncDateClose = new System.Windows.Forms.Label();
            this.txtIncDateOpen = new System.Windows.Forms.TextBox();
            this.txtIncDateClose = new System.Windows.Forms.TextBox();
            this.txtIncTitle = new System.Windows.Forms.TextBox();
            this.lblIncTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblIncId
            // 
            this.lblIncId.AutoSize = true;
            this.lblIncId.Location = new System.Drawing.Point(45, 26);
            this.lblIncId.Name = "lblIncId";
            this.lblIncId.Size = new System.Drawing.Size(21, 17);
            this.lblIncId.TabIndex = 0;
            this.lblIncId.Text = "ID";
            // 
            // lblIncCustId
            // 
            this.lblIncCustId.AutoSize = true;
            this.lblIncCustId.Location = new System.Drawing.Point(45, 65);
            this.lblIncCustId.Name = "lblIncCustId";
            this.lblIncCustId.Size = new System.Drawing.Size(83, 17);
            this.lblIncCustId.TabIndex = 1;
            this.lblIncCustId.Text = "Customer Id";
            // 
            // lblIncTechId
            // 
            this.lblIncTechId.AutoSize = true;
            this.lblIncTechId.Location = new System.Drawing.Point(45, 101);
            this.lblIncTechId.Name = "lblIncTechId";
            this.lblIncTechId.Size = new System.Drawing.Size(92, 17);
            this.lblIncTechId.TabIndex = 2;
            this.lblIncTechId.Text = "Technician Id";
            // 
            // lblIncProdId
            // 
            this.lblIncProdId.AutoSize = true;
            this.lblIncProdId.Location = new System.Drawing.Point(45, 142);
            this.lblIncProdId.Name = "lblIncProdId";
            this.lblIncProdId.Size = new System.Drawing.Size(72, 17);
            this.lblIncProdId.TabIndex = 3;
            this.lblIncProdId.Text = "Product Id";
            // 
            // txtIncId
            // 
            this.txtIncId.Location = new System.Drawing.Point(193, 26);
            this.txtIncId.Name = "txtIncId";
            this.txtIncId.Size = new System.Drawing.Size(100, 22);
            this.txtIncId.TabIndex = 4;
            this.txtIncId.Tag = "Incidents ID";
            // 
            // txtIncCustId
            // 
            this.txtIncCustId.Location = new System.Drawing.Point(193, 65);
            this.txtIncCustId.Name = "txtIncCustId";
            this.txtIncCustId.Size = new System.Drawing.Size(100, 22);
            this.txtIncCustId.TabIndex = 5;
            this.txtIncCustId.Tag = "Customer ID";
            // 
            // txtIncTechId
            // 
            this.txtIncTechId.Location = new System.Drawing.Point(193, 101);
            this.txtIncTechId.Name = "txtIncTechId";
            this.txtIncTechId.Size = new System.Drawing.Size(100, 22);
            this.txtIncTechId.TabIndex = 6;
            this.txtIncTechId.Tag = "Technician ID";
            // 
            // txtIncProdId
            // 
            this.txtIncProdId.Location = new System.Drawing.Point(193, 142);
            this.txtIncProdId.Name = "txtIncProdId";
            this.txtIncProdId.Size = new System.Drawing.Size(100, 22);
            this.txtIncProdId.TabIndex = 7;
            this.txtIncProdId.Tag = "Product ID";
            // 
            // btnIncAdd
            // 
            this.btnIncAdd.Location = new System.Drawing.Point(135, 327);
            this.btnIncAdd.Name = "btnIncAdd";
            this.btnIncAdd.Size = new System.Drawing.Size(114, 36);
            this.btnIncAdd.TabIndex = 8;
            this.btnIncAdd.Text = "Add";
            this.btnIncAdd.UseVisualStyleBackColor = true;
            this.btnIncAdd.Click += new System.EventHandler(this.btnIncAdd_Click);
            // 
            // lblIncDateOpn
            // 
            this.lblIncDateOpn.AutoSize = true;
            this.lblIncDateOpn.Location = new System.Drawing.Point(45, 177);
            this.lblIncDateOpn.Name = "lblIncDateOpn";
            this.lblIncDateOpn.Size = new System.Drawing.Size(97, 17);
            this.lblIncDateOpn.TabIndex = 9;
            this.lblIncDateOpn.Text = "Date Opened ";
            // 
            // lblIncDateClose
            // 
            this.lblIncDateClose.AutoSize = true;
            this.lblIncDateClose.Location = new System.Drawing.Point(45, 217);
            this.lblIncDateClose.Name = "lblIncDateClose";
            this.lblIncDateClose.Size = new System.Drawing.Size(85, 17);
            this.lblIncDateClose.TabIndex = 10;
            this.lblIncDateClose.Text = "Date Closed";
            // 
            // txtIncDateOpen
            // 
            this.txtIncDateOpen.Location = new System.Drawing.Point(193, 174);
            this.txtIncDateOpen.Name = "txtIncDateOpen";
            this.txtIncDateOpen.Size = new System.Drawing.Size(100, 22);
            this.txtIncDateOpen.TabIndex = 11;
            this.txtIncDateOpen.Tag = "Date opened";
            // 
            // txtIncDateClose
            // 
            this.txtIncDateClose.Location = new System.Drawing.Point(193, 217);
            this.txtIncDateClose.Name = "txtIncDateClose";
            this.txtIncDateClose.Size = new System.Drawing.Size(100, 22);
            this.txtIncDateClose.TabIndex = 12;
            this.txtIncDateClose.Tag = "Date Closed";
            // 
            // txtIncTitle
            // 
            this.txtIncTitle.Location = new System.Drawing.Point(193, 263);
            this.txtIncTitle.Name = "txtIncTitle";
            this.txtIncTitle.Size = new System.Drawing.Size(100, 22);
            this.txtIncTitle.TabIndex = 13;
            this.txtIncTitle.Tag = "Incidents Title";
            // 
            // lblIncTitle
            // 
            this.lblIncTitle.AutoSize = true;
            this.lblIncTitle.Location = new System.Drawing.Point(45, 254);
            this.lblIncTitle.Name = "lblIncTitle";
            this.lblIncTitle.Size = new System.Drawing.Size(35, 17);
            this.lblIncTitle.TabIndex = 14;
            this.lblIncTitle.Text = "Title";
            // 
            // Incidents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 418);
            this.Controls.Add(this.lblIncTitle);
            this.Controls.Add(this.txtIncTitle);
            this.Controls.Add(this.txtIncDateClose);
            this.Controls.Add(this.txtIncDateOpen);
            this.Controls.Add(this.lblIncDateClose);
            this.Controls.Add(this.lblIncDateOpn);
            this.Controls.Add(this.btnIncAdd);
            this.Controls.Add(this.txtIncProdId);
            this.Controls.Add(this.txtIncTechId);
            this.Controls.Add(this.txtIncCustId);
            this.Controls.Add(this.txtIncId);
            this.Controls.Add(this.lblIncProdId);
            this.Controls.Add(this.lblIncTechId);
            this.Controls.Add(this.lblIncCustId);
            this.Controls.Add(this.lblIncId);
            this.Name = "Incidents";
            this.Tag = "Incident";
            this.Text = "Incidents";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIncId;
        private System.Windows.Forms.Label lblIncCustId;
        private System.Windows.Forms.Label lblIncTechId;
        private System.Windows.Forms.Label lblIncProdId;
        private System.Windows.Forms.TextBox txtIncId;
        private System.Windows.Forms.TextBox txtIncCustId;
        private System.Windows.Forms.TextBox txtIncTechId;
        private System.Windows.Forms.TextBox txtIncProdId;
        private System.Windows.Forms.Button btnIncAdd;
        private System.Windows.Forms.Label lblIncDateOpn;
        private System.Windows.Forms.Label lblIncDateClose;
        private System.Windows.Forms.TextBox txtIncDateOpen;
        private System.Windows.Forms.TextBox txtIncDateClose;
        private System.Windows.Forms.TextBox txtIncTitle;
        private System.Windows.Forms.Label lblIncTitle;
    }
}
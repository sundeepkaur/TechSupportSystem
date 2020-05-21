namespace TechSupportSystem
{
    partial class Customer
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
            this.lblCustId = new System.Windows.Forms.Label();
            this.lblCustName = new System.Windows.Forms.Label();
            this.lblCustAddress = new System.Windows.Forms.Label();
            this.lblCustPhone = new System.Windows.Forms.Label();
            this.lblCustEmail = new System.Windows.Forms.Label();
            this.txtCustId = new System.Windows.Forms.TextBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.txtCustAddress = new System.Windows.Forms.TextBox();
            this.txtCustPhone = new System.Windows.Forms.TextBox();
            this.txtCustEmail = new System.Windows.Forms.TextBox();
            this.btnCustAdd = new System.Windows.Forms.Button();
            this.btnCustSave = new System.Windows.Forms.Button();
            this.btnCustModify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCustId
            // 
            this.lblCustId.AutoSize = true;
            this.lblCustId.Location = new System.Drawing.Point(57, 38);
            this.lblCustId.Name = "lblCustId";
            this.lblCustId.Size = new System.Drawing.Size(21, 17);
            this.lblCustId.TabIndex = 0;
            this.lblCustId.Text = "ID";
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(57, 84);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(45, 17);
            this.lblCustName.TabIndex = 1;
            this.lblCustName.Text = "Name";
            // 
            // lblCustAddress
            // 
            this.lblCustAddress.AutoSize = true;
            this.lblCustAddress.Location = new System.Drawing.Point(57, 131);
            this.lblCustAddress.Name = "lblCustAddress";
            this.lblCustAddress.Size = new System.Drawing.Size(60, 17);
            this.lblCustAddress.TabIndex = 2;
            this.lblCustAddress.Text = "Address";
            // 
            // lblCustPhone
            // 
            this.lblCustPhone.AutoSize = true;
            this.lblCustPhone.Location = new System.Drawing.Point(57, 174);
            this.lblCustPhone.Name = "lblCustPhone";
            this.lblCustPhone.Size = new System.Drawing.Size(49, 17);
            this.lblCustPhone.TabIndex = 3;
            this.lblCustPhone.Text = "Phone";
            // 
            // lblCustEmail
            // 
            this.lblCustEmail.AutoSize = true;
            this.lblCustEmail.Location = new System.Drawing.Point(57, 219);
            this.lblCustEmail.Name = "lblCustEmail";
            this.lblCustEmail.Size = new System.Drawing.Size(42, 17);
            this.lblCustEmail.TabIndex = 4;
            this.lblCustEmail.Text = "Email";
            // 
            // txtCustId
            // 
            this.txtCustId.Location = new System.Drawing.Point(155, 38);
            this.txtCustId.Name = "txtCustId";
            this.txtCustId.Size = new System.Drawing.Size(197, 22);
            this.txtCustId.TabIndex = 5;
            this.txtCustId.Tag = "Customer ID";
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(155, 84);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(197, 22);
            this.txtCustName.TabIndex = 6;
            this.txtCustName.Tag = "Customer Name";
            // 
            // txtCustAddress
            // 
            this.txtCustAddress.Location = new System.Drawing.Point(155, 131);
            this.txtCustAddress.Name = "txtCustAddress";
            this.txtCustAddress.Size = new System.Drawing.Size(197, 22);
            this.txtCustAddress.TabIndex = 7;
            this.txtCustAddress.Tag = "Customer Address";
            // 
            // txtCustPhone
            // 
            this.txtCustPhone.Location = new System.Drawing.Point(155, 174);
            this.txtCustPhone.Name = "txtCustPhone";
            this.txtCustPhone.Size = new System.Drawing.Size(197, 22);
            this.txtCustPhone.TabIndex = 8;
            this.txtCustPhone.Tag = "Customer Phone";
            // 
            // txtCustEmail
            // 
            this.txtCustEmail.Location = new System.Drawing.Point(155, 219);
            this.txtCustEmail.Name = "txtCustEmail";
            this.txtCustEmail.Size = new System.Drawing.Size(197, 22);
            this.txtCustEmail.TabIndex = 9;
            this.txtCustEmail.Tag = "Customer Email";
            // 
            // btnCustAdd
            // 
            this.btnCustAdd.Location = new System.Drawing.Point(12, 291);
            this.btnCustAdd.Name = "btnCustAdd";
            this.btnCustAdd.Size = new System.Drawing.Size(90, 37);
            this.btnCustAdd.TabIndex = 10;
            this.btnCustAdd.Text = "Add";
            this.btnCustAdd.UseVisualStyleBackColor = true;
            this.btnCustAdd.Click += new System.EventHandler(this.btnCustAdd_Click);
            // 
            // btnCustSave
            // 
            this.btnCustSave.Location = new System.Drawing.Point(137, 291);
            this.btnCustSave.Name = "btnCustSave";
            this.btnCustSave.Size = new System.Drawing.Size(90, 37);
            this.btnCustSave.TabIndex = 11;
            this.btnCustSave.Text = "Save";
            this.btnCustSave.UseVisualStyleBackColor = true;
            this.btnCustSave.Click += new System.EventHandler(this.btnCustSave_Click);
            // 
            // btnCustModify
            // 
            this.btnCustModify.Location = new System.Drawing.Point(261, 291);
            this.btnCustModify.Name = "btnCustModify";
            this.btnCustModify.Size = new System.Drawing.Size(91, 37);
            this.btnCustModify.TabIndex = 12;
            this.btnCustModify.Text = "Modify";
            this.btnCustModify.UseVisualStyleBackColor = true;
            this.btnCustModify.Click += new System.EventHandler(this.btnCustModify_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 385);
            this.Controls.Add(this.btnCustModify);
            this.Controls.Add(this.btnCustSave);
            this.Controls.Add(this.btnCustAdd);
            this.Controls.Add(this.txtCustEmail);
            this.Controls.Add(this.txtCustPhone);
            this.Controls.Add(this.txtCustAddress);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.txtCustId);
            this.Controls.Add(this.lblCustEmail);
            this.Controls.Add(this.lblCustPhone);
            this.Controls.Add(this.lblCustAddress);
            this.Controls.Add(this.lblCustName);
            this.Controls.Add(this.lblCustId);
            this.Name = "Customer";
            this.Tag = "Customer";
            this.Text = "Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCustId;
        private System.Windows.Forms.Label lblCustName;
        private System.Windows.Forms.Label lblCustAddress;
        private System.Windows.Forms.Label lblCustPhone;
        private System.Windows.Forms.Label lblCustEmail;
        private System.Windows.Forms.TextBox txtCustId;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.TextBox txtCustAddress;
        private System.Windows.Forms.TextBox txtCustPhone;
        private System.Windows.Forms.TextBox txtCustEmail;
        private System.Windows.Forms.Button btnCustAdd;
        private System.Windows.Forms.Button btnCustSave;
        private System.Windows.Forms.Button btnCustModify;
    }
}
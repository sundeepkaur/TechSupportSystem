namespace TechSupportSystem
{
    partial class CustomerForm
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
            this.lblCustStreetName = new System.Windows.Forms.Label();
            this.lblCustPhone = new System.Windows.Forms.Label();
            this.lblCustEmail = new System.Windows.Forms.Label();
            this.txtCustId = new System.Windows.Forms.TextBox();
            this.txtCustName = new System.Windows.Forms.TextBox();
            this.txtCustStreetName = new System.Windows.Forms.TextBox();
            this.txtCustPhone = new System.Windows.Forms.TextBox();
            this.txtCustEmail = new System.Windows.Forms.TextBox();
            this.btnCustCancel = new System.Windows.Forms.Button();
            this.btnCustSave = new System.Windows.Forms.Button();
            this.lblCustStreetNumber = new System.Windows.Forms.Label();
            this.lblCustCity = new System.Windows.Forms.Label();
            this.lblCustProvince = new System.Windows.Forms.Label();
            this.lblCustPostalCode = new System.Windows.Forms.Label();
            this.txtCustStreetNumber = new System.Windows.Forms.TextBox();
            this.txtCustPostalCode = new System.Windows.Forms.TextBox();
            this.txtCustProvince = new System.Windows.Forms.TextBox();
            this.txtCustCity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblCustId
            // 
            this.lblCustId.AutoSize = true;
            this.lblCustId.Location = new System.Drawing.Point(57, 38);
            this.lblCustId.Name = "lblCustId";
            this.lblCustId.Size = new System.Drawing.Size(21, 17);
            this.lblCustId.TabIndex = 16;
            this.lblCustId.Text = "ID";
            // 
            // lblCustName
            // 
            this.lblCustName.AutoSize = true;
            this.lblCustName.Location = new System.Drawing.Point(60, 84);
            this.lblCustName.Name = "lblCustName";
            this.lblCustName.Size = new System.Drawing.Size(45, 17);
            this.lblCustName.TabIndex = 17;
            this.lblCustName.Text = "Name";
            // 
            // lblCustStreetName
            // 
            this.lblCustStreetName.AutoSize = true;
            this.lblCustStreetName.Location = new System.Drawing.Point(57, 131);
            this.lblCustStreetName.Name = "lblCustStreetName";
            this.lblCustStreetName.Size = new System.Drawing.Size(87, 17);
            this.lblCustStreetName.TabIndex = 18;
            this.lblCustStreetName.Text = "Street Name";
            // 
            // lblCustPhone
            // 
            this.lblCustPhone.AutoSize = true;
            this.lblCustPhone.Location = new System.Drawing.Point(64, 378);
            this.lblCustPhone.Name = "lblCustPhone";
            this.lblCustPhone.Size = new System.Drawing.Size(49, 17);
            this.lblCustPhone.TabIndex = 23;
            this.lblCustPhone.Text = "Phone";
            // 
            // lblCustEmail
            // 
            this.lblCustEmail.AutoSize = true;
            this.lblCustEmail.Location = new System.Drawing.Point(64, 429);
            this.lblCustEmail.Name = "lblCustEmail";
            this.lblCustEmail.Size = new System.Drawing.Size(42, 17);
            this.lblCustEmail.TabIndex = 24;
            this.lblCustEmail.Text = "Email";
            // 
            // txtCustId
            // 
            this.txtCustId.Location = new System.Drawing.Point(179, 38);
            this.txtCustId.Name = "txtCustId";
            this.txtCustId.Size = new System.Drawing.Size(197, 22);
            this.txtCustId.TabIndex = 5;
            this.txtCustId.Tag = "Customer ID";
            // 
            // txtCustName
            // 
            this.txtCustName.Location = new System.Drawing.Point(179, 84);
            this.txtCustName.Name = "txtCustName";
            this.txtCustName.Size = new System.Drawing.Size(197, 22);
            this.txtCustName.TabIndex = 6;
            this.txtCustName.Tag = "Customer Name";
            // 
            // txtCustStreetName
            // 
            this.txtCustStreetName.Location = new System.Drawing.Point(179, 131);
            this.txtCustStreetName.Name = "txtCustStreetName";
            this.txtCustStreetName.Size = new System.Drawing.Size(197, 22);
            this.txtCustStreetName.TabIndex = 7;
            this.txtCustStreetName.Tag = "Customer Street Name";
            // 
            // txtCustPhone
            // 
            this.txtCustPhone.Location = new System.Drawing.Point(179, 373);
            this.txtCustPhone.Name = "txtCustPhone";
            this.txtCustPhone.Size = new System.Drawing.Size(197, 22);
            this.txtCustPhone.TabIndex = 12;
            this.txtCustPhone.Tag = "Customer Phone";
            // 
            // txtCustEmail
            // 
            this.txtCustEmail.Location = new System.Drawing.Point(179, 424);
            this.txtCustEmail.Name = "txtCustEmail";
            this.txtCustEmail.Size = new System.Drawing.Size(197, 22);
            this.txtCustEmail.TabIndex = 13;
            this.txtCustEmail.Tag = "Customer Email";
            // 
            // btnCustCancel
            // 
            this.btnCustCancel.Location = new System.Drawing.Point(232, 487);
            this.btnCustCancel.Name = "btnCustCancel";
            this.btnCustCancel.Size = new System.Drawing.Size(90, 37);
            this.btnCustCancel.TabIndex = 15;
            this.btnCustCancel.Text = "&Cancel";
            this.btnCustCancel.UseVisualStyleBackColor = true;
            this.btnCustCancel.Click += new System.EventHandler(this.btnCustCancel_Click);
            // 
            // btnCustSave
            // 
            this.btnCustSave.Location = new System.Drawing.Point(70, 487);
            this.btnCustSave.Name = "btnCustSave";
            this.btnCustSave.Size = new System.Drawing.Size(90, 37);
            this.btnCustSave.TabIndex = 14;
            this.btnCustSave.Text = "&Save";
            this.btnCustSave.UseVisualStyleBackColor = true;
            this.btnCustSave.Click += new System.EventHandler(this.btnCustSave_Click);
            // 
            // lblCustStreetNumber
            // 
            this.lblCustStreetNumber.AutoSize = true;
            this.lblCustStreetNumber.Location = new System.Drawing.Point(60, 184);
            this.lblCustStreetNumber.Name = "lblCustStreetNumber";
            this.lblCustStreetNumber.Size = new System.Drawing.Size(100, 17);
            this.lblCustStreetNumber.TabIndex = 19;
            this.lblCustStreetNumber.Text = "Street Number";
            // 
            // lblCustCity
            // 
            this.lblCustCity.AutoSize = true;
            this.lblCustCity.Location = new System.Drawing.Point(64, 234);
            this.lblCustCity.Name = "lblCustCity";
            this.lblCustCity.Size = new System.Drawing.Size(31, 17);
            this.lblCustCity.TabIndex = 20;
            this.lblCustCity.Text = "City";
            // 
            // lblCustProvince
            // 
            this.lblCustProvince.AutoSize = true;
            this.lblCustProvince.Location = new System.Drawing.Point(64, 277);
            this.lblCustProvince.Name = "lblCustProvince";
            this.lblCustProvince.Size = new System.Drawing.Size(63, 17);
            this.lblCustProvince.TabIndex = 21;
            this.lblCustProvince.Text = "Province";
            // 
            // lblCustPostalCode
            // 
            this.lblCustPostalCode.AutoSize = true;
            this.lblCustPostalCode.Location = new System.Drawing.Point(64, 329);
            this.lblCustPostalCode.Name = "lblCustPostalCode";
            this.lblCustPostalCode.Size = new System.Drawing.Size(84, 17);
            this.lblCustPostalCode.TabIndex = 22;
            this.lblCustPostalCode.Text = "Postal Code";
            // 
            // txtCustStreetNumber
            // 
            this.txtCustStreetNumber.Location = new System.Drawing.Point(179, 179);
            this.txtCustStreetNumber.Name = "txtCustStreetNumber";
            this.txtCustStreetNumber.Size = new System.Drawing.Size(197, 22);
            this.txtCustStreetNumber.TabIndex = 8;
            this.txtCustStreetNumber.Tag = "Customer Street Number";
            // 
            // txtCustPostalCode
            // 
            this.txtCustPostalCode.Location = new System.Drawing.Point(179, 324);
            this.txtCustPostalCode.Name = "txtCustPostalCode";
            this.txtCustPostalCode.Size = new System.Drawing.Size(197, 22);
            this.txtCustPostalCode.TabIndex = 11;
            this.txtCustPostalCode.Tag = "Customer Postal Code";
            // 
            // txtCustProvince
            // 
            this.txtCustProvince.Location = new System.Drawing.Point(179, 277);
            this.txtCustProvince.Name = "txtCustProvince";
            this.txtCustProvince.Size = new System.Drawing.Size(197, 22);
            this.txtCustProvince.TabIndex = 10;
            this.txtCustProvince.Tag = "Customer Province";
            // 
            // txtCustCity
            // 
            this.txtCustCity.Location = new System.Drawing.Point(179, 229);
            this.txtCustCity.Name = "txtCustCity";
            this.txtCustCity.Size = new System.Drawing.Size(197, 22);
            this.txtCustCity.TabIndex = 9;
            this.txtCustCity.Tag = "Customer City";
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 553);
            this.Controls.Add(this.txtCustCity);
            this.Controls.Add(this.txtCustProvince);
            this.Controls.Add(this.txtCustPostalCode);
            this.Controls.Add(this.txtCustStreetNumber);
            this.Controls.Add(this.lblCustPostalCode);
            this.Controls.Add(this.lblCustProvince);
            this.Controls.Add(this.lblCustCity);
            this.Controls.Add(this.lblCustStreetNumber);
            this.Controls.Add(this.btnCustSave);
            this.Controls.Add(this.btnCustCancel);
            this.Controls.Add(this.txtCustEmail);
            this.Controls.Add(this.txtCustPhone);
            this.Controls.Add(this.txtCustStreetName);
            this.Controls.Add(this.txtCustName);
            this.Controls.Add(this.txtCustId);
            this.Controls.Add(this.lblCustEmail);
            this.Controls.Add(this.lblCustPhone);
            this.Controls.Add(this.lblCustStreetName);
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
        private System.Windows.Forms.Label lblCustStreetName;
        private System.Windows.Forms.Label lblCustPhone;
        private System.Windows.Forms.Label lblCustEmail;
        private System.Windows.Forms.TextBox txtCustId;
        private System.Windows.Forms.TextBox txtCustName;
        private System.Windows.Forms.TextBox txtCustStreetName;
        private System.Windows.Forms.TextBox txtCustPhone;
        private System.Windows.Forms.TextBox txtCustEmail;
        private System.Windows.Forms.Button btnCustCancel;
        private System.Windows.Forms.Button btnCustSave;
        private System.Windows.Forms.Label lblCustStreetNumber;
        private System.Windows.Forms.Label lblCustCity;
        private System.Windows.Forms.Label lblCustProvince;
        private System.Windows.Forms.Label lblCustPostalCode;
        private System.Windows.Forms.TextBox txtCustStreetNumber;
        private System.Windows.Forms.TextBox txtCustPostalCode;
        private System.Windows.Forms.TextBox txtCustProvince;
        private System.Windows.Forms.TextBox txtCustCity;
    }
}
namespace TechSupportSystem
{
    partial class Technician
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
            this.lblTechID = new System.Windows.Forms.Label();
            this.lblTechName = new System.Windows.Forms.Label();
            this.txtTechID = new System.Windows.Forms.TextBox();
            this.txtTechName = new System.Windows.Forms.TextBox();
            this.btnTechAdd = new System.Windows.Forms.Button();
            this.btnTechSave = new System.Windows.Forms.Button();
            this.btnTechModify = new System.Windows.Forms.Button();
            this.lblTechEmail = new System.Windows.Forms.Label();
            this.lblTechPhone = new System.Windows.Forms.Label();
            this.txtTechEmail = new System.Windows.Forms.TextBox();
            this.txtTechPhone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblTechID
            // 
            this.lblTechID.AutoSize = true;
            this.lblTechID.Location = new System.Drawing.Point(22, 26);
            this.lblTechID.Name = "lblTechID";
            this.lblTechID.Size = new System.Drawing.Size(21, 17);
            this.lblTechID.TabIndex = 0;
            this.lblTechID.Text = "ID";
            // 
            // lblTechName
            // 
            this.lblTechName.AutoSize = true;
            this.lblTechName.Location = new System.Drawing.Point(22, 79);
            this.lblTechName.Name = "lblTechName";
            this.lblTechName.Size = new System.Drawing.Size(45, 17);
            this.lblTechName.TabIndex = 1;
            this.lblTechName.Text = "Name";
            // 
            // txtTechID
            // 
            this.txtTechID.Location = new System.Drawing.Point(106, 26);
            this.txtTechID.Name = "txtTechID";
            this.txtTechID.Size = new System.Drawing.Size(188, 22);
            this.txtTechID.TabIndex = 2;
            this.txtTechID.Tag = "Technician ID";
            // 
            // txtTechName
            // 
            this.txtTechName.Location = new System.Drawing.Point(106, 79);
            this.txtTechName.Name = "txtTechName";
            this.txtTechName.Size = new System.Drawing.Size(188, 22);
            this.txtTechName.TabIndex = 3;
            this.txtTechName.Tag = "Technician Name";
            // 
            // btnTechAdd
            // 
            this.btnTechAdd.Location = new System.Drawing.Point(12, 238);
            this.btnTechAdd.Name = "btnTechAdd";
            this.btnTechAdd.Size = new System.Drawing.Size(91, 41);
            this.btnTechAdd.TabIndex = 4;
            this.btnTechAdd.Tag = "Technician";
            this.btnTechAdd.Text = "Add";
            this.btnTechAdd.UseVisualStyleBackColor = true;
            this.btnTechAdd.Click += new System.EventHandler(this.btnTechAdd_Click);
            // 
            // btnTechSave
            // 
            this.btnTechSave.Location = new System.Drawing.Point(131, 238);
            this.btnTechSave.Name = "btnTechSave";
            this.btnTechSave.Size = new System.Drawing.Size(85, 41);
            this.btnTechSave.TabIndex = 5;
            this.btnTechSave.Text = "Save";
            this.btnTechSave.UseVisualStyleBackColor = true;
            this.btnTechSave.Click += new System.EventHandler(this.btnTechSave_Click);
            // 
            // btnTechModify
            // 
            this.btnTechModify.Location = new System.Drawing.Point(240, 238);
            this.btnTechModify.Name = "btnTechModify";
            this.btnTechModify.Size = new System.Drawing.Size(86, 41);
            this.btnTechModify.TabIndex = 6;
            this.btnTechModify.Text = "Modify";
            this.btnTechModify.UseVisualStyleBackColor = true;
            this.btnTechModify.Click += new System.EventHandler(this.btnTechModify_Click);
            // 
            // lblTechEmail
            // 
            this.lblTechEmail.AutoSize = true;
            this.lblTechEmail.Location = new System.Drawing.Point(22, 128);
            this.lblTechEmail.Name = "lblTechEmail";
            this.lblTechEmail.Size = new System.Drawing.Size(42, 17);
            this.lblTechEmail.TabIndex = 7;
            this.lblTechEmail.Text = "Email";
            // 
            // lblTechPhone
            // 
            this.lblTechPhone.AutoSize = true;
            this.lblTechPhone.Location = new System.Drawing.Point(22, 179);
            this.lblTechPhone.Name = "lblTechPhone";
            this.lblTechPhone.Size = new System.Drawing.Size(49, 17);
            this.lblTechPhone.TabIndex = 8;
            this.lblTechPhone.Text = "Phone";
            // 
            // txtTechEmail
            // 
            this.txtTechEmail.Location = new System.Drawing.Point(106, 123);
            this.txtTechEmail.Name = "txtTechEmail";
            this.txtTechEmail.Size = new System.Drawing.Size(188, 22);
            this.txtTechEmail.TabIndex = 9;
            this.txtTechEmail.Tag = "Technician Email";
            // 
            // txtTechPhone
            // 
            this.txtTechPhone.Location = new System.Drawing.Point(106, 174);
            this.txtTechPhone.Name = "txtTechPhone";
            this.txtTechPhone.Size = new System.Drawing.Size(188, 22);
            this.txtTechPhone.TabIndex = 10;
            this.txtTechPhone.Tag = "Technician Phone";
            // 
            // Technician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 291);
            this.Controls.Add(this.txtTechPhone);
            this.Controls.Add(this.txtTechEmail);
            this.Controls.Add(this.lblTechPhone);
            this.Controls.Add(this.lblTechEmail);
            this.Controls.Add(this.btnTechModify);
            this.Controls.Add(this.btnTechSave);
            this.Controls.Add(this.btnTechAdd);
            this.Controls.Add(this.txtTechName);
            this.Controls.Add(this.txtTechID);
            this.Controls.Add(this.lblTechName);
            this.Controls.Add(this.lblTechID);
            this.Name = "Technician";
            this.Tag = "Technician";
            this.Text = "Technician";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTechID;
        private System.Windows.Forms.Label lblTechName;
        private System.Windows.Forms.TextBox txtTechID;
        private System.Windows.Forms.TextBox txtTechName;
        private System.Windows.Forms.Button btnTechAdd;
        private System.Windows.Forms.Button btnTechSave;
        private System.Windows.Forms.Button btnTechModify;
        private System.Windows.Forms.Label lblTechEmail;
        private System.Windows.Forms.Label lblTechPhone;
        private System.Windows.Forms.TextBox txtTechEmail;
        private System.Windows.Forms.TextBox txtTechPhone;
    }
}
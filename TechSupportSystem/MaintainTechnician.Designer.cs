namespace TechSupportSystem
{
    partial class MaintainTechnician
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
            this.lstTechnician = new System.Windows.Forms.ListBox();
            this.btnTechnicianAdd = new System.Windows.Forms.Button();
            this.btnTechnicianSave = new System.Windows.Forms.Button();
            this.btnTechnicianModify = new System.Windows.Forms.Button();
            this.btnTechnicianDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstTechnician
            // 
            this.lstTechnician.FormattingEnabled = true;
            this.lstTechnician.ItemHeight = 16;
            this.lstTechnician.Location = new System.Drawing.Point(12, 31);
            this.lstTechnician.Name = "lstTechnician";
            this.lstTechnician.Size = new System.Drawing.Size(513, 276);
            this.lstTechnician.TabIndex = 0;
            // 
            // btnTechnicianAdd
            // 
            this.btnTechnicianAdd.Location = new System.Drawing.Point(573, 41);
            this.btnTechnicianAdd.Name = "btnTechnicianAdd";
            this.btnTechnicianAdd.Size = new System.Drawing.Size(126, 44);
            this.btnTechnicianAdd.TabIndex = 1;
            this.btnTechnicianAdd.Text = "&Add New";
            this.btnTechnicianAdd.UseVisualStyleBackColor = true;
            this.btnTechnicianAdd.Click += new System.EventHandler(this.btnTechnicianAdd_Click);
            // 
            // btnTechnicianSave
            // 
            this.btnTechnicianSave.Location = new System.Drawing.Point(573, 106);
            this.btnTechnicianSave.Name = "btnTechnicianSave";
            this.btnTechnicianSave.Size = new System.Drawing.Size(126, 48);
            this.btnTechnicianSave.TabIndex = 2;
            this.btnTechnicianSave.Text = "&Save";
            this.btnTechnicianSave.UseVisualStyleBackColor = true;
            this.btnTechnicianSave.Click += new System.EventHandler(this.btnTechnicianSave_Click);
            // 
            // btnTechnicianModify
            // 
            this.btnTechnicianModify.Location = new System.Drawing.Point(573, 175);
            this.btnTechnicianModify.Name = "btnTechnicianModify";
            this.btnTechnicianModify.Size = new System.Drawing.Size(126, 52);
            this.btnTechnicianModify.TabIndex = 3;
            this.btnTechnicianModify.Text = "&Modify";
            this.btnTechnicianModify.UseVisualStyleBackColor = true;
            this.btnTechnicianModify.Click += new System.EventHandler(this.btnTechnicianModify_Click);
            // 
            // btnTechnicianDelete
            // 
            this.btnTechnicianDelete.Location = new System.Drawing.Point(573, 257);
            this.btnTechnicianDelete.Name = "btnTechnicianDelete";
            this.btnTechnicianDelete.Size = new System.Drawing.Size(126, 50);
            this.btnTechnicianDelete.TabIndex = 4;
            this.btnTechnicianDelete.Text = "&Delete";
            this.btnTechnicianDelete.UseVisualStyleBackColor = true;
            this.btnTechnicianDelete.Click += new System.EventHandler(this.btnTechnicianDelete_Click);
            // 
            // MaintainTechnician
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 340);
            this.Controls.Add(this.btnTechnicianDelete);
            this.Controls.Add(this.btnTechnicianModify);
            this.Controls.Add(this.btnTechnicianSave);
            this.Controls.Add(this.btnTechnicianAdd);
            this.Controls.Add(this.lstTechnician);
            this.Name = "MaintainTechnician";
            this.Tag = "Technician";
            this.Text = "MaintainTechnician";
            this.Load += new System.EventHandler(this.MaintainTechnician_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstTechnician;
        private System.Windows.Forms.Button btnTechnicianAdd;
        private System.Windows.Forms.Button btnTechnicianSave;
        private System.Windows.Forms.Button btnTechnicianModify;
        private System.Windows.Forms.Button btnTechnicianDelete;
    }
}
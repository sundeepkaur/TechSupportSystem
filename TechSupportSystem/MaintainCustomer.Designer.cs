namespace TechSupportSystem
{
    partial class MaintainCustomer
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
            this.lstCustomer = new System.Windows.Forms.ListBox();
            this.btnCustomerAdd = new System.Windows.Forms.Button();
            this.btnCustomerSave = new System.Windows.Forms.Button();
            this.btnCustomerModify = new System.Windows.Forms.Button();
            this.btnCustomerDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstCustomer
            // 
            this.lstCustomer.FormattingEnabled = true;
            this.lstCustomer.ItemHeight = 16;
            this.lstCustomer.Location = new System.Drawing.Point(12, 51);
            this.lstCustomer.Name = "lstCustomer";
            this.lstCustomer.Size = new System.Drawing.Size(881, 292);
            this.lstCustomer.TabIndex = 0;
            // 
            // btnCustomerAdd
            // 
            this.btnCustomerAdd.Location = new System.Drawing.Point(65, 379);
            this.btnCustomerAdd.Name = "btnCustomerAdd";
            this.btnCustomerAdd.Size = new System.Drawing.Size(127, 49);
            this.btnCustomerAdd.TabIndex = 1;
            this.btnCustomerAdd.Text = "&Add New";
            this.btnCustomerAdd.UseVisualStyleBackColor = true;
            this.btnCustomerAdd.Click += new System.EventHandler(this.btnCustomerAdd_Click);
            // 
            // btnCustomerSave
            // 
            this.btnCustomerSave.Location = new System.Drawing.Point(303, 377);
            this.btnCustomerSave.Name = "btnCustomerSave";
            this.btnCustomerSave.Size = new System.Drawing.Size(127, 51);
            this.btnCustomerSave.TabIndex = 2;
            this.btnCustomerSave.Tag = "";
            this.btnCustomerSave.Text = "&Save";
            this.btnCustomerSave.UseVisualStyleBackColor = true;
            this.btnCustomerSave.Click += new System.EventHandler(this.btnCustomerSave_Click);
            // 
            // btnCustomerModify
            // 
            this.btnCustomerModify.Location = new System.Drawing.Point(533, 376);
            this.btnCustomerModify.Name = "btnCustomerModify";
            this.btnCustomerModify.Size = new System.Drawing.Size(127, 53);
            this.btnCustomerModify.TabIndex = 3;
            this.btnCustomerModify.Text = "&Modify";
            this.btnCustomerModify.UseVisualStyleBackColor = true;
            this.btnCustomerModify.Click += new System.EventHandler(this.btnCustomerModify_Click);
            // 
            // btnCustomerDelete
            // 
            this.btnCustomerDelete.Location = new System.Drawing.Point(740, 370);
            this.btnCustomerDelete.Name = "btnCustomerDelete";
            this.btnCustomerDelete.Size = new System.Drawing.Size(127, 62);
            this.btnCustomerDelete.TabIndex = 4;
            this.btnCustomerDelete.Text = "&Delete";
            this.btnCustomerDelete.UseVisualStyleBackColor = true;
            this.btnCustomerDelete.Click += new System.EventHandler(this.btnCustomerDelete_Click);
            // 
            // MaintainCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 457);
            this.Controls.Add(this.btnCustomerDelete);
            this.Controls.Add(this.btnCustomerModify);
            this.Controls.Add(this.btnCustomerSave);
            this.Controls.Add(this.btnCustomerAdd);
            this.Controls.Add(this.lstCustomer);
            this.Name = "MaintainCustomer";
            this.Tag = "Customer";
            this.Text = "MaintainCustomer";
            this.Load += new System.EventHandler(this.MaintainCustomer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCustomer;
        private System.Windows.Forms.Button btnCustomerAdd;
        private System.Windows.Forms.Button btnCustomerSave;
        private System.Windows.Forms.Button btnCustomerModify;
        private System.Windows.Forms.Button btnCustomerDelete;
    }
}
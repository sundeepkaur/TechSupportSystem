namespace TechSupportSystem
{
    partial class MaintainIncident
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
            this.lstIncidents = new System.Windows.Forms.ListBox();
            this.btnAddIncident = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.btnMaintainCloseIncidents = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstIncidents
            // 
            this.lstIncidents.FormattingEnabled = true;
            this.lstIncidents.ItemHeight = 16;
            this.lstIncidents.Location = new System.Drawing.Point(15, 12);
            this.lstIncidents.Name = "lstIncidents";
            this.lstIncidents.Size = new System.Drawing.Size(719, 308);
            this.lstIncidents.TabIndex = 0;
            // 
            // btnAddIncident
            // 
            this.btnAddIncident.Location = new System.Drawing.Point(521, 342);
            this.btnAddIncident.Name = "btnAddIncident";
            this.btnAddIncident.Size = new System.Drawing.Size(203, 52);
            this.btnAddIncident.TabIndex = 1;
            this.btnAddIncident.Text = "&Add Incidents";
            this.btnAddIncident.UseVisualStyleBackColor = true;
            this.btnAddIncident.Click += new System.EventHandler(this.btnAddIncident_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 345);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Open Customer Incidents: Select ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 388);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Open Product Incidents: Select ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "OpenTechnician Incidents: Select ID";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(281, 438);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(203, 24);
            this.comboBox1.TabIndex = 9;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(281, 388);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(203, 24);
            this.comboBox3.TabIndex = 10;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(281, 342);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(203, 24);
            this.comboBox4.TabIndex = 11;
            // 
            // btnMaintainCloseIncidents
            // 
            this.btnMaintainCloseIncidents.Location = new System.Drawing.Point(521, 409);
            this.btnMaintainCloseIncidents.Name = "btnMaintainCloseIncidents";
            this.btnMaintainCloseIncidents.Size = new System.Drawing.Size(203, 53);
            this.btnMaintainCloseIncidents.TabIndex = 2;
            this.btnMaintainCloseIncidents.Text = "&Close Incidents";
            this.btnMaintainCloseIncidents.UseVisualStyleBackColor = true;
            this.btnMaintainCloseIncidents.Click += new System.EventHandler(this.btnMaintainCloseIncidents_Click);
            // 
            // MaintainIncident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 474);
            this.Controls.Add(this.btnMaintainCloseIncidents);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddIncident);
            this.Controls.Add(this.lstIncidents);
            this.Name = "MaintainIncident";
            this.Text = "MaintainIncident";
            this.Load += new System.EventHandler(this.MaintainIncident_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstIncidents;
        private System.Windows.Forms.Button btnAddIncident;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Button btnMaintainCloseIncidents;
    }
}
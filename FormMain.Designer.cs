namespace KaratePresentationLayer
{
    partial class FormMain
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
            this.dgvAllData = new System.Windows.Forms.DataGridView();
            this.btnGetAllMembers = new System.Windows.Forms.Button();
            this.btnGetAllInstructors = new System.Windows.Forms.Button();
            this.btnGetAllBeltRanks = new System.Windows.Forms.Button();
            this.btnGetAllPayments = new System.Windows.Forms.Button();
            this.btnSupscriptionPeriods = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllData
            // 
            this.dgvAllData.AllowUserToAddRows = false;
            this.dgvAllData.AllowUserToDeleteRows = false;
            this.dgvAllData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllData.Location = new System.Drawing.Point(324, 26);
            this.dgvAllData.Name = "dgvAllData";
            this.dgvAllData.ReadOnly = true;
            this.dgvAllData.RowHeadersWidth = 51;
            this.dgvAllData.RowTemplate.Height = 24;
            this.dgvAllData.Size = new System.Drawing.Size(972, 412);
            this.dgvAllData.TabIndex = 0;
            // 
            // btnGetAllMembers
            // 
            this.btnGetAllMembers.Location = new System.Drawing.Point(12, 26);
            this.btnGetAllMembers.Name = "btnGetAllMembers";
            this.btnGetAllMembers.Size = new System.Drawing.Size(282, 65);
            this.btnGetAllMembers.TabIndex = 1;
            this.btnGetAllMembers.Text = "Get All Members";
            this.btnGetAllMembers.UseVisualStyleBackColor = true;
            this.btnGetAllMembers.Click += new System.EventHandler(this.btnGetAllMembers_Click);
            // 
            // btnGetAllInstructors
            // 
            this.btnGetAllInstructors.Location = new System.Drawing.Point(12, 115);
            this.btnGetAllInstructors.Name = "btnGetAllInstructors";
            this.btnGetAllInstructors.Size = new System.Drawing.Size(282, 65);
            this.btnGetAllInstructors.TabIndex = 2;
            this.btnGetAllInstructors.Text = "Get All Instructors";
            this.btnGetAllInstructors.UseVisualStyleBackColor = true;
            this.btnGetAllInstructors.Click += new System.EventHandler(this.btnGetAllInstructors_Click);
            // 
            // btnGetAllBeltRanks
            // 
            this.btnGetAllBeltRanks.Location = new System.Drawing.Point(12, 199);
            this.btnGetAllBeltRanks.Name = "btnGetAllBeltRanks";
            this.btnGetAllBeltRanks.Size = new System.Drawing.Size(282, 65);
            this.btnGetAllBeltRanks.TabIndex = 3;
            this.btnGetAllBeltRanks.Text = "Get All Belt Ranks";
            this.btnGetAllBeltRanks.UseVisualStyleBackColor = true;
            this.btnGetAllBeltRanks.Click += new System.EventHandler(this.btnGetAllBeltRanks_Click);
            // 
            // btnGetAllPayments
            // 
            this.btnGetAllPayments.Location = new System.Drawing.Point(12, 286);
            this.btnGetAllPayments.Name = "btnGetAllPayments";
            this.btnGetAllPayments.Size = new System.Drawing.Size(282, 65);
            this.btnGetAllPayments.TabIndex = 4;
            this.btnGetAllPayments.Text = "Get All Payments";
            this.btnGetAllPayments.UseVisualStyleBackColor = true;
            this.btnGetAllPayments.Click += new System.EventHandler(this.btnGetAllPayments_Click);
            // 
            // btnSupscriptionPeriods
            // 
            this.btnSupscriptionPeriods.Location = new System.Drawing.Point(12, 373);
            this.btnSupscriptionPeriods.Name = "btnSupscriptionPeriods";
            this.btnSupscriptionPeriods.Size = new System.Drawing.Size(282, 65);
            this.btnSupscriptionPeriods.TabIndex = 5;
            this.btnSupscriptionPeriods.Text = "Get All Subscription Periods";
            this.btnSupscriptionPeriods.UseVisualStyleBackColor = true;
            this.btnSupscriptionPeriods.Click += new System.EventHandler(this.btnSupscriptionPeriods_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 450);
            this.Controls.Add(this.btnSupscriptionPeriods);
            this.Controls.Add(this.btnGetAllPayments);
            this.Controls.Add(this.btnGetAllBeltRanks);
            this.Controls.Add(this.btnGetAllInstructors);
            this.Controls.Add(this.btnGetAllMembers);
            this.Controls.Add(this.dgvAllData);
            this.Name = "FormMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllData;
        private System.Windows.Forms.Button btnGetAllMembers;
        private System.Windows.Forms.Button btnGetAllInstructors;
        private System.Windows.Forms.Button btnGetAllBeltRanks;
        private System.Windows.Forms.Button btnGetAllPayments;
        private System.Windows.Forms.Button btnSupscriptionPeriods;
    }
}


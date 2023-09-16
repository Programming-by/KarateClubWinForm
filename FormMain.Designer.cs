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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvAllData = new System.Windows.Forms.DataGridView();
            this.btnGetAllMembers = new System.Windows.Forms.Button();
            this.btnGetAllInstructors = new System.Windows.Forms.Button();
            this.btnGetAllPayments = new System.Windows.Forms.Button();
            this.btnGetAllSubscriptionPeriods = new System.Windows.Forms.Button();
            this.btnGetAllBeltRanks = new System.Windows.Forms.Button();
            this.btnFindMember = new System.Windows.Forms.Button();
            this.btnFindInstructor = new System.Windows.Forms.Button();
            this.btnFindBeltRank = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllData
            // 
            this.dgvAllData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllData.Location = new System.Drawing.Point(273, 29);
            this.dgvAllData.Name = "dgvAllData";
            this.dgvAllData.RowHeadersWidth = 51;
            this.dgvAllData.RowTemplate.Height = 24;
            this.dgvAllData.Size = new System.Drawing.Size(1126, 369);
            this.dgvAllData.TabIndex = 0;
            // 
            // btnGetAllMembers
            // 
            this.btnGetAllMembers.Location = new System.Drawing.Point(12, 29);
            this.btnGetAllMembers.Name = "btnGetAllMembers";
            this.btnGetAllMembers.Size = new System.Drawing.Size(228, 51);
            this.btnGetAllMembers.TabIndex = 1;
            this.btnGetAllMembers.Text = "Get All Members";
            this.btnGetAllMembers.UseVisualStyleBackColor = true;
            this.btnGetAllMembers.Click += new System.EventHandler(this.btnGetAllMembers_Click);
            // 
            // btnGetAllInstructors
            // 
            this.btnGetAllInstructors.Location = new System.Drawing.Point(12, 96);
            this.btnGetAllInstructors.Name = "btnGetAllInstructors";
            this.btnGetAllInstructors.Size = new System.Drawing.Size(228, 51);
            this.btnGetAllInstructors.TabIndex = 2;
            this.btnGetAllInstructors.Text = "Get All Instructors";
            this.btnGetAllInstructors.UseVisualStyleBackColor = true;
            this.btnGetAllInstructors.Click += new System.EventHandler(this.btnGetAllInstructors_Click);
            // 
            // btnGetAllPayments
            // 
            this.btnGetAllPayments.Location = new System.Drawing.Point(12, 234);
            this.btnGetAllPayments.Name = "btnGetAllPayments";
            this.btnGetAllPayments.Size = new System.Drawing.Size(228, 51);
            this.btnGetAllPayments.TabIndex = 3;
            this.btnGetAllPayments.Text = "Get All Payments";
            this.btnGetAllPayments.UseVisualStyleBackColor = true;
            this.btnGetAllPayments.Click += new System.EventHandler(this.btnGetAllPayments_Click);
            // 
            // btnGetAllSubscriptionPeriods
            // 
            this.btnGetAllSubscriptionPeriods.Location = new System.Drawing.Point(12, 303);
            this.btnGetAllSubscriptionPeriods.Name = "btnGetAllSubscriptionPeriods";
            this.btnGetAllSubscriptionPeriods.Size = new System.Drawing.Size(228, 51);
            this.btnGetAllSubscriptionPeriods.TabIndex = 4;
            this.btnGetAllSubscriptionPeriods.Text = "Get All Subscription Periods";
            this.btnGetAllSubscriptionPeriods.UseVisualStyleBackColor = true;
            this.btnGetAllSubscriptionPeriods.Click += new System.EventHandler(this.btnSupscriptionPeriods_Click);
            // 
            // btnGetAllBeltRanks
            // 
            this.btnGetAllBeltRanks.Location = new System.Drawing.Point(12, 165);
            this.btnGetAllBeltRanks.Name = "btnGetAllBeltRanks";
            this.btnGetAllBeltRanks.Size = new System.Drawing.Size(228, 51);
            this.btnGetAllBeltRanks.TabIndex = 5;
            this.btnGetAllBeltRanks.Text = "Get All Belt Ranks";
            this.btnGetAllBeltRanks.UseVisualStyleBackColor = true;
            this.btnGetAllBeltRanks.Click += new System.EventHandler(this.btnGetAllBeltRanks_Click);
            // 
            // btnFindMember
            // 
            this.btnFindMember.Location = new System.Drawing.Point(12, 416);
            this.btnFindMember.Name = "btnFindMember";
            this.btnFindMember.Size = new System.Drawing.Size(228, 51);
            this.btnFindMember.TabIndex = 6;
            this.btnFindMember.Text = "Find Member";
            this.btnFindMember.UseVisualStyleBackColor = true;
            this.btnFindMember.Click += new System.EventHandler(this.btnFindMember_Click);
            // 
            // btnFindInstructor
            // 
            this.btnFindInstructor.Location = new System.Drawing.Point(273, 416);
            this.btnFindInstructor.Name = "btnFindInstructor";
            this.btnFindInstructor.Size = new System.Drawing.Size(228, 51);
            this.btnFindInstructor.TabIndex = 7;
            this.btnFindInstructor.Text = "Find Instructor";
            this.btnFindInstructor.UseVisualStyleBackColor = true;
            this.btnFindInstructor.Click += new System.EventHandler(this.btnFindInstructor_Click);
            // 
            // btnFindBeltRank
            // 
            this.btnFindBeltRank.Location = new System.Drawing.Point(531, 416);
            this.btnFindBeltRank.Name = "btnFindBeltRank";
            this.btnFindBeltRank.Size = new System.Drawing.Size(228, 51);
            this.btnFindBeltRank.TabIndex = 8;
            this.btnFindBeltRank.Text = "Find Belt Rank";
            this.btnFindBeltRank.UseVisualStyleBackColor = true;
            this.btnFindBeltRank.Click += new System.EventHandler(this.btnFindBeltRank_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 537);
            this.Controls.Add(this.btnFindBeltRank);
            this.Controls.Add(this.btnFindInstructor);
            this.Controls.Add(this.btnFindMember);
            this.Controls.Add(this.btnGetAllBeltRanks);
            this.Controls.Add(this.btnGetAllSubscriptionPeriods);
            this.Controls.Add(this.btnGetAllPayments);
            this.Controls.Add(this.btnGetAllInstructors);
            this.Controls.Add(this.btnGetAllMembers);
            this.Controls.Add(this.dgvAllData);
            this.Name = "FormMain";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgvAllData;
        private System.Windows.Forms.Button btnGetAllMembers;
        private System.Windows.Forms.Button btnGetAllInstructors;
        private System.Windows.Forms.Button btnGetAllPayments;
        private System.Windows.Forms.Button btnGetAllSubscriptionPeriods;
        private System.Windows.Forms.Button btnGetAllBeltRanks;
        private System.Windows.Forms.Button btnFindMember;
        private System.Windows.Forms.Button btnFindInstructor;
        private System.Windows.Forms.Button btnFindBeltRank;
    }
}


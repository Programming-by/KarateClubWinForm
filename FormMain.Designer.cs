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
            this.btnFindPayments = new System.Windows.Forms.Button();
            this.btnSubscriptionPeriod = new System.Windows.Forms.Button();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnAddInstructor = new System.Windows.Forms.Button();
            this.btnAddBeltRank = new System.Windows.Forms.Button();
            this.btnAddPayment = new System.Windows.Forms.Button();
            this.btnAddSubscriptionPeriod = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllData
            // 
            this.dgvAllData.AllowUserToDeleteRows = false;
            this.dgvAllData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllData.Location = new System.Drawing.Point(273, 29);
            this.dgvAllData.Name = "dgvAllData";
            this.dgvAllData.ReadOnly = true;
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
            // btnFindPayments
            // 
            this.btnFindPayments.Location = new System.Drawing.Point(791, 416);
            this.btnFindPayments.Name = "btnFindPayments";
            this.btnFindPayments.Size = new System.Drawing.Size(228, 51);
            this.btnFindPayments.TabIndex = 9;
            this.btnFindPayments.Text = "Find Payment";
            this.btnFindPayments.UseVisualStyleBackColor = true;
            this.btnFindPayments.Click += new System.EventHandler(this.btnFindPayments_Click);
            // 
            // btnSubscriptionPeriod
            // 
            this.btnSubscriptionPeriod.Location = new System.Drawing.Point(1025, 416);
            this.btnSubscriptionPeriod.Name = "btnSubscriptionPeriod";
            this.btnSubscriptionPeriod.Size = new System.Drawing.Size(228, 51);
            this.btnSubscriptionPeriod.TabIndex = 10;
            this.btnSubscriptionPeriod.Text = "Find Subscription Period";
            this.btnSubscriptionPeriod.UseVisualStyleBackColor = true;
            this.btnSubscriptionPeriod.Click += new System.EventHandler(this.btnSubscriptionPeriod_Click);
            // 
            // btnAddMember
            // 
            this.btnAddMember.Location = new System.Drawing.Point(12, 487);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(228, 51);
            this.btnAddMember.TabIndex = 11;
            this.btnAddMember.Text = "Add Member";
            this.btnAddMember.UseVisualStyleBackColor = true;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // btnAddInstructor
            // 
            this.btnAddInstructor.Location = new System.Drawing.Point(273, 487);
            this.btnAddInstructor.Name = "btnAddInstructor";
            this.btnAddInstructor.Size = new System.Drawing.Size(228, 51);
            this.btnAddInstructor.TabIndex = 12;
            this.btnAddInstructor.Text = "Add Instructor";
            this.btnAddInstructor.UseVisualStyleBackColor = true;
            this.btnAddInstructor.Click += new System.EventHandler(this.btnAddInstructor_Click);
            // 
            // btnAddBeltRank
            // 
            this.btnAddBeltRank.Location = new System.Drawing.Point(531, 487);
            this.btnAddBeltRank.Name = "btnAddBeltRank";
            this.btnAddBeltRank.Size = new System.Drawing.Size(228, 51);
            this.btnAddBeltRank.TabIndex = 13;
            this.btnAddBeltRank.Text = "Add Belt Rank";
            this.btnAddBeltRank.UseVisualStyleBackColor = true;
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.Location = new System.Drawing.Point(791, 487);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Size = new System.Drawing.Size(228, 51);
            this.btnAddPayment.TabIndex = 14;
            this.btnAddPayment.Text = "Add Payment";
            this.btnAddPayment.UseVisualStyleBackColor = true;
            this.btnAddPayment.Click += new System.EventHandler(this.btnAddPayment_Click);
            // 
            // btnAddSubscriptionPeriod
            // 
            this.btnAddSubscriptionPeriod.Location = new System.Drawing.Point(1025, 487);
            this.btnAddSubscriptionPeriod.Name = "btnAddSubscriptionPeriod";
            this.btnAddSubscriptionPeriod.Size = new System.Drawing.Size(228, 51);
            this.btnAddSubscriptionPeriod.TabIndex = 15;
            this.btnAddSubscriptionPeriod.Text = "Add Subscription Period";
            this.btnAddSubscriptionPeriod.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 537);
            this.Controls.Add(this.btnAddSubscriptionPeriod);
            this.Controls.Add(this.btnAddPayment);
            this.Controls.Add(this.btnAddBeltRank);
            this.Controls.Add(this.btnAddInstructor);
            this.Controls.Add(this.btnAddMember);
            this.Controls.Add(this.btnSubscriptionPeriod);
            this.Controls.Add(this.btnFindPayments);
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
        private System.Windows.Forms.Button btnFindPayments;
        private System.Windows.Forms.Button btnSubscriptionPeriod;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnAddInstructor;
        private System.Windows.Forms.Button btnAddBeltRank;
        private System.Windows.Forms.Button btnAddPayment;
        private System.Windows.Forms.Button btnAddSubscriptionPeriod;
    }
}


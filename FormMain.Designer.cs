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
            this.components = new System.ComponentModel.Container();
            this.dgvAllData = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.btnUpdateMember = new System.Windows.Forms.Button();
            this.btnUpdateInstructor = new System.Windows.Forms.Button();
            this.btnBeltRank = new System.Windows.Forms.Button();
            this.btnUpdatePayment = new System.Windows.Forms.Button();
            this.btnUpdateSubscriptionPeriod = new System.Windows.Forms.Button();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip4 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllData)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.contextMenuStrip4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAllData
            // 
            this.dgvAllData.AllowUserToDeleteRows = false;
            this.dgvAllData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllData.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvAllData.Location = new System.Drawing.Point(273, 29);
            this.dgvAllData.Name = "dgvAllData";
            this.dgvAllData.ReadOnly = true;
            this.dgvAllData.RowHeadersWidth = 51;
            this.dgvAllData.RowTemplate.Height = 24;
            this.dgvAllData.Size = new System.Drawing.Size(1126, 369);
            this.dgvAllData.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 52);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
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
            this.btnAddSubscriptionPeriod.Click += new System.EventHandler(this.btnAddSubscriptionPeriod_Click);
            // 
            // btnUpdateMember
            // 
            this.btnUpdateMember.Location = new System.Drawing.Point(12, 558);
            this.btnUpdateMember.Name = "btnUpdateMember";
            this.btnUpdateMember.Size = new System.Drawing.Size(228, 51);
            this.btnUpdateMember.TabIndex = 16;
            this.btnUpdateMember.Text = "Update Member";
            this.btnUpdateMember.UseVisualStyleBackColor = true;
            // 
            // btnUpdateInstructor
            // 
            this.btnUpdateInstructor.Location = new System.Drawing.Point(273, 558);
            this.btnUpdateInstructor.Name = "btnUpdateInstructor";
            this.btnUpdateInstructor.Size = new System.Drawing.Size(228, 51);
            this.btnUpdateInstructor.TabIndex = 17;
            this.btnUpdateInstructor.Text = "Update Instructor";
            this.btnUpdateInstructor.UseVisualStyleBackColor = true;
            // 
            // btnBeltRank
            // 
            this.btnBeltRank.Location = new System.Drawing.Point(531, 558);
            this.btnBeltRank.Name = "btnBeltRank";
            this.btnBeltRank.Size = new System.Drawing.Size(228, 51);
            this.btnBeltRank.TabIndex = 18;
            this.btnBeltRank.Text = "Update Belt Rank";
            this.btnBeltRank.UseVisualStyleBackColor = true;
            // 
            // btnUpdatePayment
            // 
            this.btnUpdatePayment.Location = new System.Drawing.Point(791, 558);
            this.btnUpdatePayment.Name = "btnUpdatePayment";
            this.btnUpdatePayment.Size = new System.Drawing.Size(228, 51);
            this.btnUpdatePayment.TabIndex = 19;
            this.btnUpdatePayment.Text = "Update Payment";
            this.btnUpdatePayment.UseVisualStyleBackColor = true;
            // 
            // btnUpdateSubscriptionPeriod
            // 
            this.btnUpdateSubscriptionPeriod.Location = new System.Drawing.Point(1025, 558);
            this.btnUpdateSubscriptionPeriod.Name = "btnUpdateSubscriptionPeriod";
            this.btnUpdateSubscriptionPeriod.Size = new System.Drawing.Size(228, 51);
            this.btnUpdateSubscriptionPeriod.TabIndex = 20;
            this.btnUpdateSubscriptionPeriod.Text = "Update Subscription Period";
            this.btnUpdateSubscriptionPeriod.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.contextMenuStrip2.Name = "contextMenuStrip1";
            this.contextMenuStrip2.Size = new System.Drawing.Size(211, 80);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(210, 24);
            this.toolStripMenuItem1.Text = "Edit";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(210, 24);
            this.toolStripMenuItem2.Text = "Delete";
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.contextMenuStrip3.Name = "contextMenuStrip1";
            this.contextMenuStrip3.Size = new System.Drawing.Size(123, 52);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(122, 24);
            this.toolStripMenuItem3.Text = "Edit";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(122, 24);
            this.toolStripMenuItem4.Text = "Delete";
            // 
            // contextMenuStrip4
            // 
            this.contextMenuStrip4.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
            this.contextMenuStrip4.Name = "contextMenuStrip1";
            this.contextMenuStrip4.Size = new System.Drawing.Size(123, 52);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(122, 24);
            this.toolStripMenuItem5.Text = "Edit";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(122, 24);
            this.toolStripMenuItem6.Text = "Delete";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1483, 635);
            this.Controls.Add(this.btnUpdateSubscriptionPeriod);
            this.Controls.Add(this.btnUpdatePayment);
            this.Controls.Add(this.btnBeltRank);
            this.Controls.Add(this.btnUpdateInstructor);
            this.Controls.Add(this.btnUpdateMember);
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
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.contextMenuStrip3.ResumeLayout(false);
            this.contextMenuStrip4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
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
        private System.Windows.Forms.Button btnUpdateMember;
        private System.Windows.Forms.Button btnUpdateInstructor;
        private System.Windows.Forms.Button btnBeltRank;
        private System.Windows.Forms.Button btnUpdatePayment;
        private System.Windows.Forms.Button btnUpdateSubscriptionPeriod;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
    }
}


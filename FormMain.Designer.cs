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
            this.contextMenuStripForMembers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItemForMembers = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItemForMembers = new System.Windows.Forms.ToolStripMenuItem();
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
            this.btnAddPayment = new System.Windows.Forms.Button();
            this.btnAddSubscriptionPeriod = new System.Windows.Forms.Button();
            this.btnUpdateMember = new System.Windows.Forms.Button();
            this.btnUpdateInstructor = new System.Windows.Forms.Button();
            this.btnUpdatePayment = new System.Windows.Forms.Button();
            this.btnUpdateSubscriptionPeriod = new System.Windows.Forms.Button();
            this.contextMenuStripForInstructors = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemForInstructors = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStripMenuItemForInstructors = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripForPayments = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemForPayments = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStripMenuItemForPayments = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripForSubscriptionPeriods = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemForSubscriptionPeriods = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteStripMenuItemForSubscriptionPeriods = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDeleteInstructor = new System.Windows.Forms.Button();
            this.btnDeleteSubscriptionPeriod = new System.Windows.Forms.Button();
            this.btnDeletePayment = new System.Windows.Forms.Button();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.btnGetAllBeltTests = new System.Windows.Forms.Button();
            this.btnFindBeltTest = new System.Windows.Forms.Button();
            this.btnAddBeltTest = new System.Windows.Forms.Button();
            this.btnUpdateBeltTest = new System.Windows.Forms.Button();
            this.btnDeleteBeltTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllData)).BeginInit();
            this.contextMenuStripForMembers.SuspendLayout();
            this.contextMenuStripForInstructors.SuspendLayout();
            this.contextMenuStripForPayments.SuspendLayout();
            this.contextMenuStripForSubscriptionPeriods.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAllData
            // 
            this.dgvAllData.AllowUserToDeleteRows = false;
            this.dgvAllData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllData.ContextMenuStrip = this.contextMenuStripForMembers;
            this.dgvAllData.Location = new System.Drawing.Point(273, 29);
            this.dgvAllData.Name = "dgvAllData";
            this.dgvAllData.ReadOnly = true;
            this.dgvAllData.RowHeadersWidth = 51;
            this.dgvAllData.RowTemplate.Height = 24;
            this.dgvAllData.Size = new System.Drawing.Size(1126, 369);
            this.dgvAllData.TabIndex = 0;
            // 
            // contextMenuStripForMembers
            // 
            this.contextMenuStripForMembers.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripForMembers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItemForMembers,
            this.deleteToolStripMenuItemForMembers});
            this.contextMenuStripForMembers.Name = "contextMenuStrip1";
            this.contextMenuStripForMembers.Size = new System.Drawing.Size(123, 52);
            // 
            // editToolStripMenuItemForMembers
            // 
            this.editToolStripMenuItemForMembers.Name = "editToolStripMenuItemForMembers";
            this.editToolStripMenuItemForMembers.Size = new System.Drawing.Size(122, 24);
            this.editToolStripMenuItemForMembers.Text = "Edit";
            this.editToolStripMenuItemForMembers.Click += new System.EventHandler(this.editToolStripMenuItemForMembers_Click);
            // 
            // deleteToolStripMenuItemForMembers
            // 
            this.deleteToolStripMenuItemForMembers.Name = "deleteToolStripMenuItemForMembers";
            this.deleteToolStripMenuItemForMembers.Size = new System.Drawing.Size(122, 24);
            this.deleteToolStripMenuItemForMembers.Text = "Delete";
            this.deleteToolStripMenuItemForMembers.Click += new System.EventHandler(this.deleteToolStripMenuItemForMembers_Click);
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
            this.btnGetAllSubscriptionPeriods.Click += new System.EventHandler(this.btnGetAllSupscriptionPeriods_Click);
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
            this.btnUpdateMember.Click += new System.EventHandler(this.btnUpdateMember_Click);
            // 
            // btnUpdateInstructor
            // 
            this.btnUpdateInstructor.Location = new System.Drawing.Point(273, 558);
            this.btnUpdateInstructor.Name = "btnUpdateInstructor";
            this.btnUpdateInstructor.Size = new System.Drawing.Size(228, 51);
            this.btnUpdateInstructor.TabIndex = 17;
            this.btnUpdateInstructor.Text = "Update Instructor";
            this.btnUpdateInstructor.UseVisualStyleBackColor = true;
            this.btnUpdateInstructor.Click += new System.EventHandler(this.btnUpdateInstructor_Click);
            // 
            // btnUpdatePayment
            // 
            this.btnUpdatePayment.Location = new System.Drawing.Point(791, 558);
            this.btnUpdatePayment.Name = "btnUpdatePayment";
            this.btnUpdatePayment.Size = new System.Drawing.Size(228, 51);
            this.btnUpdatePayment.TabIndex = 19;
            this.btnUpdatePayment.Text = "Update Payment";
            this.btnUpdatePayment.UseVisualStyleBackColor = true;
            this.btnUpdatePayment.Click += new System.EventHandler(this.btnUpdatePayment_Click);
            // 
            // btnUpdateSubscriptionPeriod
            // 
            this.btnUpdateSubscriptionPeriod.Location = new System.Drawing.Point(1025, 558);
            this.btnUpdateSubscriptionPeriod.Name = "btnUpdateSubscriptionPeriod";
            this.btnUpdateSubscriptionPeriod.Size = new System.Drawing.Size(228, 51);
            this.btnUpdateSubscriptionPeriod.TabIndex = 20;
            this.btnUpdateSubscriptionPeriod.Text = "Update Subscription Period";
            this.btnUpdateSubscriptionPeriod.UseVisualStyleBackColor = true;
            this.btnUpdateSubscriptionPeriod.Click += new System.EventHandler(this.btnUpdateSubscriptionPeriod_Click);
            // 
            // contextMenuStripForInstructors
            // 
            this.contextMenuStripForInstructors.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripForInstructors.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemForInstructors,
            this.deleteStripMenuItemForInstructors});
            this.contextMenuStripForInstructors.Name = "contextMenuStrip1";
            this.contextMenuStripForInstructors.Size = new System.Drawing.Size(123, 52);
            // 
            // toolStripMenuItemForInstructors
            // 
            this.toolStripMenuItemForInstructors.Name = "toolStripMenuItemForInstructors";
            this.toolStripMenuItemForInstructors.Size = new System.Drawing.Size(122, 24);
            this.toolStripMenuItemForInstructors.Text = "Edit";
            this.toolStripMenuItemForInstructors.Click += new System.EventHandler(this.toolStripMenuItemForInstructors_Click);
            // 
            // deleteStripMenuItemForInstructors
            // 
            this.deleteStripMenuItemForInstructors.Name = "deleteStripMenuItemForInstructors";
            this.deleteStripMenuItemForInstructors.Size = new System.Drawing.Size(122, 24);
            this.deleteStripMenuItemForInstructors.Text = "Delete";
            this.deleteStripMenuItemForInstructors.Click += new System.EventHandler(this.deleteStripMenuItemForInstructors_Click);
            // 
            // contextMenuStripForPayments
            // 
            this.contextMenuStripForPayments.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripForPayments.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemForPayments,
            this.deleteStripMenuItemForPayments});
            this.contextMenuStripForPayments.Name = "contextMenuStrip1";
            this.contextMenuStripForPayments.Size = new System.Drawing.Size(123, 52);
            // 
            // toolStripMenuItemForPayments
            // 
            this.toolStripMenuItemForPayments.Name = "toolStripMenuItemForPayments";
            this.toolStripMenuItemForPayments.Size = new System.Drawing.Size(122, 24);
            this.toolStripMenuItemForPayments.Text = "Edit";
            this.toolStripMenuItemForPayments.Click += new System.EventHandler(this.toolStripMenuItemForPayments_Click);
            // 
            // deleteStripMenuItemForPayments
            // 
            this.deleteStripMenuItemForPayments.Name = "deleteStripMenuItemForPayments";
            this.deleteStripMenuItemForPayments.Size = new System.Drawing.Size(122, 24);
            this.deleteStripMenuItemForPayments.Text = "Delete";
            this.deleteStripMenuItemForPayments.Click += new System.EventHandler(this.deleteStripMenuItemForPayments_Click);
            // 
            // contextMenuStripForSubscriptionPeriods
            // 
            this.contextMenuStripForSubscriptionPeriods.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripForSubscriptionPeriods.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemForSubscriptionPeriods,
            this.deleteStripMenuItemForSubscriptionPeriods});
            this.contextMenuStripForSubscriptionPeriods.Name = "contextMenuStrip1";
            this.contextMenuStripForSubscriptionPeriods.Size = new System.Drawing.Size(211, 80);
            // 
            // toolStripMenuItemForSubscriptionPeriods
            // 
            this.toolStripMenuItemForSubscriptionPeriods.Name = "toolStripMenuItemForSubscriptionPeriods";
            this.toolStripMenuItemForSubscriptionPeriods.Size = new System.Drawing.Size(210, 24);
            this.toolStripMenuItemForSubscriptionPeriods.Text = "Edit";
            this.toolStripMenuItemForSubscriptionPeriods.Click += new System.EventHandler(this.toolStripMenuItemForSubscriptionPeriods_Click);
            // 
            // deleteStripMenuItemForSubscriptionPeriods
            // 
            this.deleteStripMenuItemForSubscriptionPeriods.Name = "deleteStripMenuItemForSubscriptionPeriods";
            this.deleteStripMenuItemForSubscriptionPeriods.Size = new System.Drawing.Size(210, 24);
            this.deleteStripMenuItemForSubscriptionPeriods.Text = "Delete";
            this.deleteStripMenuItemForSubscriptionPeriods.Click += new System.EventHandler(this.deleteStripMenuItemForSubscriptionPeriods_Click);
            // 
            // btnDeleteInstructor
            // 
            this.btnDeleteInstructor.Location = new System.Drawing.Point(273, 636);
            this.btnDeleteInstructor.Name = "btnDeleteInstructor";
            this.btnDeleteInstructor.Size = new System.Drawing.Size(228, 51);
            this.btnDeleteInstructor.TabIndex = 21;
            this.btnDeleteInstructor.Text = "Delete Instructor";
            this.btnDeleteInstructor.UseVisualStyleBackColor = true;
            this.btnDeleteInstructor.Click += new System.EventHandler(this.btnDeleteInstructor_Click);
            // 
            // btnDeleteSubscriptionPeriod
            // 
            this.btnDeleteSubscriptionPeriod.Location = new System.Drawing.Point(1025, 636);
            this.btnDeleteSubscriptionPeriod.Name = "btnDeleteSubscriptionPeriod";
            this.btnDeleteSubscriptionPeriod.Size = new System.Drawing.Size(228, 51);
            this.btnDeleteSubscriptionPeriod.TabIndex = 22;
            this.btnDeleteSubscriptionPeriod.Text = "Delete Subscription Period";
            this.btnDeleteSubscriptionPeriod.UseVisualStyleBackColor = true;
            this.btnDeleteSubscriptionPeriod.Click += new System.EventHandler(this.btnDeleteSubscriptionPeriod_Click);
            // 
            // btnDeletePayment
            // 
            this.btnDeletePayment.Location = new System.Drawing.Point(791, 636);
            this.btnDeletePayment.Name = "btnDeletePayment";
            this.btnDeletePayment.Size = new System.Drawing.Size(228, 51);
            this.btnDeletePayment.TabIndex = 23;
            this.btnDeletePayment.Text = "Delete Payment";
            this.btnDeletePayment.UseVisualStyleBackColor = true;
            this.btnDeletePayment.Click += new System.EventHandler(this.btnDeletePayment_Click);
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.Location = new System.Drawing.Point(12, 636);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(228, 51);
            this.btnDeleteMember.TabIndex = 24;
            this.btnDeleteMember.Text = "Delete Member";
            this.btnDeleteMember.UseVisualStyleBackColor = true;
            this.btnDeleteMember.Click += new System.EventHandler(this.btnDeleteMember_Click);
            // 
            // btnGetAllBeltTests
            // 
            this.btnGetAllBeltTests.Location = new System.Drawing.Point(12, 360);
            this.btnGetAllBeltTests.Name = "btnGetAllBeltTests";
            this.btnGetAllBeltTests.Size = new System.Drawing.Size(228, 51);
            this.btnGetAllBeltTests.TabIndex = 25;
            this.btnGetAllBeltTests.Text = "Get All Belt Tests";
            this.btnGetAllBeltTests.UseVisualStyleBackColor = true;
            this.btnGetAllBeltTests.Click += new System.EventHandler(this.btnGetAllBeltTests_Click);
            // 
            // btnFindBeltTest
            // 
            this.btnFindBeltTest.Location = new System.Drawing.Point(1259, 416);
            this.btnFindBeltTest.Name = "btnFindBeltTest";
            this.btnFindBeltTest.Size = new System.Drawing.Size(228, 51);
            this.btnFindBeltTest.TabIndex = 26;
            this.btnFindBeltTest.Text = "Find Belt Test";
            this.btnFindBeltTest.UseVisualStyleBackColor = true;
            // 
            // btnAddBeltTest
            // 
            this.btnAddBeltTest.Location = new System.Drawing.Point(1259, 487);
            this.btnAddBeltTest.Name = "btnAddBeltTest";
            this.btnAddBeltTest.Size = new System.Drawing.Size(228, 51);
            this.btnAddBeltTest.TabIndex = 27;
            this.btnAddBeltTest.Text = "Add Belt Test";
            this.btnAddBeltTest.UseVisualStyleBackColor = true;
            // 
            // btnUpdateBeltTest
            // 
            this.btnUpdateBeltTest.Location = new System.Drawing.Point(1259, 558);
            this.btnUpdateBeltTest.Name = "btnUpdateBeltTest";
            this.btnUpdateBeltTest.Size = new System.Drawing.Size(228, 51);
            this.btnUpdateBeltTest.TabIndex = 28;
            this.btnUpdateBeltTest.Text = "Update Belt Test";
            this.btnUpdateBeltTest.UseVisualStyleBackColor = true;
            // 
            // btnDeleteBeltTest
            // 
            this.btnDeleteBeltTest.Location = new System.Drawing.Point(1259, 636);
            this.btnDeleteBeltTest.Name = "btnDeleteBeltTest";
            this.btnDeleteBeltTest.Size = new System.Drawing.Size(228, 51);
            this.btnDeleteBeltTest.TabIndex = 29;
            this.btnDeleteBeltTest.Text = "Delete Belt Test";
            this.btnDeleteBeltTest.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1534, 750);
            this.Controls.Add(this.btnDeleteBeltTest);
            this.Controls.Add(this.btnUpdateBeltTest);
            this.Controls.Add(this.btnAddBeltTest);
            this.Controls.Add(this.btnFindBeltTest);
            this.Controls.Add(this.btnGetAllBeltTests);
            this.Controls.Add(this.btnDeleteMember);
            this.Controls.Add(this.btnDeletePayment);
            this.Controls.Add(this.btnDeleteSubscriptionPeriod);
            this.Controls.Add(this.btnDeleteInstructor);
            this.Controls.Add(this.btnUpdateSubscriptionPeriod);
            this.Controls.Add(this.btnUpdatePayment);
            this.Controls.Add(this.btnUpdateInstructor);
            this.Controls.Add(this.btnUpdateMember);
            this.Controls.Add(this.btnAddSubscriptionPeriod);
            this.Controls.Add(this.btnAddPayment);
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
            this.contextMenuStripForMembers.ResumeLayout(false);
            this.contextMenuStripForInstructors.ResumeLayout(false);
            this.contextMenuStripForPayments.ResumeLayout(false);
            this.contextMenuStripForSubscriptionPeriods.ResumeLayout(false);
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
        private System.Windows.Forms.Button btnAddPayment;
        private System.Windows.Forms.Button btnAddSubscriptionPeriod;
        private System.Windows.Forms.Button btnUpdateMember;
        private System.Windows.Forms.Button btnUpdateInstructor;
        private System.Windows.Forms.Button btnUpdatePayment;
        private System.Windows.Forms.Button btnUpdateSubscriptionPeriod;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripForMembers;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItemForMembers;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItemForMembers;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripForInstructors;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemForInstructors;
        private System.Windows.Forms.ToolStripMenuItem deleteStripMenuItemForInstructors;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripForPayments;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemForPayments;
        private System.Windows.Forms.ToolStripMenuItem deleteStripMenuItemForPayments;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripForSubscriptionPeriods;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemForSubscriptionPeriods;
        private System.Windows.Forms.ToolStripMenuItem deleteStripMenuItemForSubscriptionPeriods;
        private System.Windows.Forms.Button btnDeleteInstructor;
        private System.Windows.Forms.Button btnDeleteSubscriptionPeriod;
        private System.Windows.Forms.Button btnDeletePayment;
        private System.Windows.Forms.Button btnDeleteMember;
        private System.Windows.Forms.Button btnGetAllBeltTests;
        private System.Windows.Forms.Button btnFindBeltTest;
        private System.Windows.Forms.Button btnAddBeltTest;
        private System.Windows.Forms.Button btnUpdateBeltTest;
        private System.Windows.Forms.Button btnDeleteBeltTest;
    }
}


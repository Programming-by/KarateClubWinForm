﻿namespace KaratePresentationLayer
{
    partial class FormAddEditMembers
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
            this.lbltest = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.txtContactInfo = new System.Windows.Forms.TextBox();
            this.txtEmergencyContactInfo = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this.rbNotActive = new System.Windows.Forms.RadioButton();
            this.numericLastBeltRank = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericLastBeltRank)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltest
            // 
            this.lbltest.AutoSize = true;
            this.lbltest.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltest.Location = new System.Drawing.Point(896, 180);
            this.lbltest.Name = "lbltest";
            this.lbltest.Size = new System.Drawing.Size(0, 46);
            this.lbltest.TabIndex = 40;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(100, 630);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 72);
            this.btnClose.TabIndex = 39;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(626, 630);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 72);
            this.btnSave.TabIndex = 38;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(541, 152);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(298, 46);
            this.txtName.TabIndex = 37;
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemberID.Location = new System.Drawing.Point(590, 80);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(86, 46);
            this.lblMemberID.TabIndex = 36;
            this.lblMemberID.Text = "???";
            // 
            // txtContactInfo
            // 
            this.txtContactInfo.Location = new System.Drawing.Point(541, 214);
            this.txtContactInfo.Multiline = true;
            this.txtContactInfo.Name = "txtContactInfo";
            this.txtContactInfo.Size = new System.Drawing.Size(298, 46);
            this.txtContactInfo.TabIndex = 35;
            // 
            // txtEmergencyContactInfo
            // 
            this.txtEmergencyContactInfo.Location = new System.Drawing.Point(541, 362);
            this.txtEmergencyContactInfo.Multiline = true;
            this.txtEmergencyContactInfo.Name = "txtEmergencyContactInfo";
            this.txtEmergencyContactInfo.Size = new System.Drawing.Size(298, 46);
            this.txtEmergencyContactInfo.TabIndex = 34;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(541, 300);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(298, 46);
            this.txtAddress.TabIndex = 33;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(67, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(204, 46);
            this.label8.TabIndex = 31;
            this.label8.Text = "MemberID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(67, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 46);
            this.label6.TabIndex = 29;
            this.label6.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(67, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(449, 46);
            this.label5.TabIndex = 28;
            this.label5.Text = "Emergency Contact Info";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(67, 423);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(279, 46);
            this.label4.TabIndex = 27;
            this.label4.Text = "Last Belt Rank";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 46);
            this.label3.TabIndex = 26;
            this.label3.Text = "ContactInfo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 46);
            this.label2.TabIndex = 25;
            this.label2.Text = "Name";
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.Location = new System.Drawing.Point(462, 18);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(338, 46);
            this.lblMode.TabIndex = 24;
            this.lblMode.Text = "Add New Member";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 496);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 46);
            this.label1.TabIndex = 41;
            this.label1.Text = "Is Active";
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.Location = new System.Drawing.Point(541, 522);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(52, 20);
            this.rbActive.TabIndex = 42;
            this.rbActive.TabStop = true;
            this.rbActive.Text = "Yes";
            this.rbActive.UseVisualStyleBackColor = true;
            // 
            // rbNotActive
            // 
            this.rbNotActive.AutoSize = true;
            this.rbNotActive.Location = new System.Drawing.Point(669, 522);
            this.rbNotActive.Name = "rbNotActive";
            this.rbNotActive.Size = new System.Drawing.Size(46, 20);
            this.rbNotActive.TabIndex = 43;
            this.rbNotActive.TabStop = true;
            this.rbNotActive.Text = "No";
            this.rbNotActive.UseVisualStyleBackColor = true;
            // 
            // numericLastBeltRank
            // 
            this.numericLastBeltRank.Location = new System.Drawing.Point(541, 447);
            this.numericLastBeltRank.Maximum = new decimal(new int[] {
            17,
            0,
            0,
            0});
            this.numericLastBeltRank.Name = "numericLastBeltRank";
            this.numericLastBeltRank.Size = new System.Drawing.Size(120, 22);
            this.numericLastBeltRank.TabIndex = 44;
            // 
            // FormAddEditMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1451, 822);
            this.Controls.Add(this.numericLastBeltRank);
            this.Controls.Add(this.rbNotActive);
            this.Controls.Add(this.rbActive);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbltest);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblMemberID);
            this.Controls.Add(this.txtContactInfo);
            this.Controls.Add(this.txtEmergencyContactInfo);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblMode);
            this.Name = "FormAddEditMembers";
            this.Text = "FormAddEditMembers";
            this.Load += new System.EventHandler(this.FormAddEditMembers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericLastBeltRank)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltest;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.TextBox txtContactInfo;
        private System.Windows.Forms.TextBox txtEmergencyContactInfo;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbActive;
        private System.Windows.Forms.RadioButton rbNotActive;
        private System.Windows.Forms.NumericUpDown numericLastBeltRank;
    }
}
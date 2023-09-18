namespace KaratePresentationLayer
{
    partial class FormUpdateMember
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
            this.numericLastBeltRank = new System.Windows.Forms.NumericUpDown();
            this.rbNotActive = new System.Windows.Forms.RadioButton();
            this.rbActive = new System.Windows.Forms.RadioButton();
            this.lblIsActive = new System.Windows.Forms.Label();
            this.lbltest = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtContactInfo = new System.Windows.Forms.TextBox();
            this.txtEmergencyContactInfo = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEmergencyContactInfo = new System.Windows.Forms.Label();
            this.lblLastBeltRank = new System.Windows.Forms.Label();
            this.lblContactInfo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.txtPersonID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericLastBeltRank)).BeginInit();
            this.SuspendLayout();
            // 
            // numericLastBeltRank
            // 
            this.numericLastBeltRank.Location = new System.Drawing.Point(486, 440);
            this.numericLastBeltRank.Maximum = new decimal(new int[] {
            17,
            0,
            0,
            0});
            this.numericLastBeltRank.Name = "numericLastBeltRank";
            this.numericLastBeltRank.Size = new System.Drawing.Size(120, 22);
            this.numericLastBeltRank.TabIndex = 63;
            this.numericLastBeltRank.Visible = false;
            // 
            // rbNotActive
            // 
            this.rbNotActive.AutoSize = true;
            this.rbNotActive.Location = new System.Drawing.Point(614, 515);
            this.rbNotActive.Name = "rbNotActive";
            this.rbNotActive.Size = new System.Drawing.Size(46, 20);
            this.rbNotActive.TabIndex = 62;
            this.rbNotActive.TabStop = true;
            this.rbNotActive.Text = "No";
            this.rbNotActive.UseVisualStyleBackColor = true;
            this.rbNotActive.Visible = false;
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.Location = new System.Drawing.Point(486, 515);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(52, 20);
            this.rbActive.TabIndex = 61;
            this.rbActive.TabStop = true;
            this.rbActive.Text = "Yes";
            this.rbActive.UseVisualStyleBackColor = true;
            this.rbActive.Visible = false;
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsActive.Location = new System.Drawing.Point(12, 489);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(170, 46);
            this.lblIsActive.TabIndex = 60;
            this.lblIsActive.Text = "Is Active";
            this.lblIsActive.Visible = false;
            // 
            // lbltest
            // 
            this.lbltest.AutoSize = true;
            this.lbltest.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltest.Location = new System.Drawing.Point(841, 173);
            this.lbltest.Name = "lbltest";
            this.lbltest.Size = new System.Drawing.Size(0, 46);
            this.lbltest.TabIndex = 59;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(221, 528);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 72);
            this.btnClose.TabIndex = 58;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(839, 528);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 72);
            this.btnSave.TabIndex = 57;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(486, 145);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(298, 46);
            this.txtName.TabIndex = 56;
            this.txtName.Visible = false;
            // 
            // txtContactInfo
            // 
            this.txtContactInfo.Location = new System.Drawing.Point(486, 207);
            this.txtContactInfo.Multiline = true;
            this.txtContactInfo.Name = "txtContactInfo";
            this.txtContactInfo.Size = new System.Drawing.Size(298, 46);
            this.txtContactInfo.TabIndex = 54;
            this.txtContactInfo.Visible = false;
            // 
            // txtEmergencyContactInfo
            // 
            this.txtEmergencyContactInfo.Location = new System.Drawing.Point(486, 355);
            this.txtEmergencyContactInfo.Multiline = true;
            this.txtEmergencyContactInfo.Name = "txtEmergencyContactInfo";
            this.txtEmergencyContactInfo.Size = new System.Drawing.Size(298, 46);
            this.txtEmergencyContactInfo.TabIndex = 53;
            this.txtEmergencyContactInfo.Visible = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(486, 293);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(298, 46);
            this.txtAddress.TabIndex = 52;
            this.txtAddress.Visible = false;
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonID.Location = new System.Drawing.Point(12, 73);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(186, 46);
            this.lblPersonID.TabIndex = 51;
            this.lblPersonID.Text = "PersonID";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(12, 283);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(166, 46);
            this.lblAddress.TabIndex = 50;
            this.lblAddress.Text = "Address";
            this.lblAddress.Visible = false;
            // 
            // lblEmergencyContactInfo
            // 
            this.lblEmergencyContactInfo.AutoSize = true;
            this.lblEmergencyContactInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmergencyContactInfo.Location = new System.Drawing.Point(12, 355);
            this.lblEmergencyContactInfo.Name = "lblEmergencyContactInfo";
            this.lblEmergencyContactInfo.Size = new System.Drawing.Size(449, 46);
            this.lblEmergencyContactInfo.TabIndex = 49;
            this.lblEmergencyContactInfo.Text = "Emergency Contact Info";
            this.lblEmergencyContactInfo.Visible = false;
            // 
            // lblLastBeltRank
            // 
            this.lblLastBeltRank.AutoSize = true;
            this.lblLastBeltRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastBeltRank.Location = new System.Drawing.Point(12, 416);
            this.lblLastBeltRank.Name = "lblLastBeltRank";
            this.lblLastBeltRank.Size = new System.Drawing.Size(279, 46);
            this.lblLastBeltRank.TabIndex = 48;
            this.lblLastBeltRank.Text = "Last Belt Rank";
            this.lblLastBeltRank.Visible = false;
            // 
            // lblContactInfo
            // 
            this.lblContactInfo.AutoSize = true;
            this.lblContactInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactInfo.Location = new System.Drawing.Point(12, 207);
            this.lblContactInfo.Name = "lblContactInfo";
            this.lblContactInfo.Size = new System.Drawing.Size(225, 46);
            this.lblContactInfo.TabIndex = 47;
            this.lblContactInfo.Text = "ContactInfo";
            this.lblContactInfo.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(12, 145);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(126, 46);
            this.lblName.TabIndex = 46;
            this.lblName.Text = "Name";
            this.lblName.Visible = false;
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.Location = new System.Drawing.Point(407, 11);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(304, 46);
            this.lblMode.TabIndex = 45;
            this.lblMode.Text = "Update Member";
            // 
            // txtPersonID
            // 
            this.txtPersonID.Location = new System.Drawing.Point(486, 73);
            this.txtPersonID.Multiline = true;
            this.txtPersonID.Name = "txtPersonID";
            this.txtPersonID.Size = new System.Drawing.Size(298, 46);
            this.txtPersonID.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(971, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(270, 46);
            this.label7.TabIndex = 65;
            this.label7.Text = "IsFoundOrNot";
            this.label7.Visible = false;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(806, 73);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(133, 46);
            this.btnFind.TabIndex = 66;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // FormUpdateMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1292, 704);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPersonID);
            this.Controls.Add(this.numericLastBeltRank);
            this.Controls.Add(this.rbNotActive);
            this.Controls.Add(this.rbActive);
            this.Controls.Add(this.lblIsActive);
            this.Controls.Add(this.lbltest);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtContactInfo);
            this.Controls.Add(this.txtEmergencyContactInfo);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblPersonID);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblEmergencyContactInfo);
            this.Controls.Add(this.lblLastBeltRank);
            this.Controls.Add(this.lblContactInfo);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblMode);
            this.Name = "FormUpdateMember";
            this.Text = "FormUpdateMember";
            this.Load += new System.EventHandler(this.FormUpdateMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericLastBeltRank)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericLastBeltRank;
        private System.Windows.Forms.RadioButton rbNotActive;
        private System.Windows.Forms.RadioButton rbActive;
        private System.Windows.Forms.Label lblIsActive;
        private System.Windows.Forms.Label lbltest;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtContactInfo;
        private System.Windows.Forms.TextBox txtEmergencyContactInfo;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEmergencyContactInfo;
        private System.Windows.Forms.Label lblLastBeltRank;
        private System.Windows.Forms.Label lblContactInfo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.TextBox txtPersonID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnFind;
    }
}
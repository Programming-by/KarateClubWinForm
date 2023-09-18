namespace KaratePresentationLayer
{
    partial class FormUpdatePayment
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
            this.btnFind = new System.Windows.Forms.Button();
            this.lblIsFound = new System.Windows.Forms.Label();
            this.txtPersonID = new System.Windows.Forms.TextBox();
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
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtAmount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericLastBeltRank)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(840, 71);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(133, 46);
            this.btnFind.TabIndex = 87;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lblIsFound
            // 
            this.lblIsFound.AutoSize = true;
            this.lblIsFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsFound.Location = new System.Drawing.Point(1005, 71);
            this.lblIsFound.Name = "lblIsFound";
            this.lblIsFound.Size = new System.Drawing.Size(270, 46);
            this.lblIsFound.TabIndex = 86;
            this.lblIsFound.Text = "IsFoundOrNot";
            this.lblIsFound.Visible = false;
            // 
            // txtPersonID
            // 
            this.txtPersonID.Location = new System.Drawing.Point(520, 71);
            this.txtPersonID.Multiline = true;
            this.txtPersonID.Name = "txtPersonID";
            this.txtPersonID.Size = new System.Drawing.Size(298, 46);
            this.txtPersonID.TabIndex = 85;
            // 
            // numericLastBeltRank
            // 
            this.numericLastBeltRank.Location = new System.Drawing.Point(520, 438);
            this.numericLastBeltRank.Maximum = new decimal(new int[] {
            17,
            0,
            0,
            0});
            this.numericLastBeltRank.Name = "numericLastBeltRank";
            this.numericLastBeltRank.Size = new System.Drawing.Size(120, 22);
            this.numericLastBeltRank.TabIndex = 84;
            this.numericLastBeltRank.Visible = false;
            // 
            // rbNotActive
            // 
            this.rbNotActive.AutoSize = true;
            this.rbNotActive.Location = new System.Drawing.Point(648, 513);
            this.rbNotActive.Name = "rbNotActive";
            this.rbNotActive.Size = new System.Drawing.Size(46, 20);
            this.rbNotActive.TabIndex = 83;
            this.rbNotActive.TabStop = true;
            this.rbNotActive.Text = "No";
            this.rbNotActive.UseVisualStyleBackColor = true;
            this.rbNotActive.Visible = false;
            // 
            // rbActive
            // 
            this.rbActive.AutoSize = true;
            this.rbActive.Location = new System.Drawing.Point(520, 513);
            this.rbActive.Name = "rbActive";
            this.rbActive.Size = new System.Drawing.Size(52, 20);
            this.rbActive.TabIndex = 82;
            this.rbActive.TabStop = true;
            this.rbActive.Text = "Yes";
            this.rbActive.UseVisualStyleBackColor = true;
            this.rbActive.Visible = false;
            // 
            // lblIsActive
            // 
            this.lblIsActive.AutoSize = true;
            this.lblIsActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsActive.Location = new System.Drawing.Point(46, 487);
            this.lblIsActive.Name = "lblIsActive";
            this.lblIsActive.Size = new System.Drawing.Size(170, 46);
            this.lblIsActive.TabIndex = 81;
            this.lblIsActive.Text = "Is Active";
            this.lblIsActive.Visible = false;
            // 
            // lbltest
            // 
            this.lbltest.AutoSize = true;
            this.lbltest.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltest.Location = new System.Drawing.Point(875, 171);
            this.lbltest.Name = "lbltest";
            this.lbltest.Size = new System.Drawing.Size(0, 46);
            this.lbltest.TabIndex = 80;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(309, 654);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 72);
            this.btnClose.TabIndex = 79;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(896, 654);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(133, 72);
            this.btnSave.TabIndex = 78;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(520, 143);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(298, 46);
            this.txtName.TabIndex = 77;
            this.txtName.Visible = false;
            // 
            // txtContactInfo
            // 
            this.txtContactInfo.Location = new System.Drawing.Point(520, 205);
            this.txtContactInfo.Multiline = true;
            this.txtContactInfo.Name = "txtContactInfo";
            this.txtContactInfo.Size = new System.Drawing.Size(298, 46);
            this.txtContactInfo.TabIndex = 76;
            this.txtContactInfo.Visible = false;
            // 
            // txtEmergencyContactInfo
            // 
            this.txtEmergencyContactInfo.Location = new System.Drawing.Point(520, 353);
            this.txtEmergencyContactInfo.Multiline = true;
            this.txtEmergencyContactInfo.Name = "txtEmergencyContactInfo";
            this.txtEmergencyContactInfo.Size = new System.Drawing.Size(298, 46);
            this.txtEmergencyContactInfo.TabIndex = 75;
            this.txtEmergencyContactInfo.Visible = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(520, 291);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(298, 46);
            this.txtAddress.TabIndex = 74;
            this.txtAddress.Visible = false;
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonID.Location = new System.Drawing.Point(46, 71);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(186, 46);
            this.lblPersonID.TabIndex = 73;
            this.lblPersonID.Text = "PersonID";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(46, 281);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(166, 46);
            this.lblAddress.TabIndex = 72;
            this.lblAddress.Text = "Address";
            this.lblAddress.Visible = false;
            // 
            // lblEmergencyContactInfo
            // 
            this.lblEmergencyContactInfo.AutoSize = true;
            this.lblEmergencyContactInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmergencyContactInfo.Location = new System.Drawing.Point(46, 353);
            this.lblEmergencyContactInfo.Name = "lblEmergencyContactInfo";
            this.lblEmergencyContactInfo.Size = new System.Drawing.Size(449, 46);
            this.lblEmergencyContactInfo.TabIndex = 71;
            this.lblEmergencyContactInfo.Text = "Emergency Contact Info";
            this.lblEmergencyContactInfo.Visible = false;
            // 
            // lblLastBeltRank
            // 
            this.lblLastBeltRank.AutoSize = true;
            this.lblLastBeltRank.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastBeltRank.Location = new System.Drawing.Point(46, 414);
            this.lblLastBeltRank.Name = "lblLastBeltRank";
            this.lblLastBeltRank.Size = new System.Drawing.Size(279, 46);
            this.lblLastBeltRank.TabIndex = 70;
            this.lblLastBeltRank.Text = "Last Belt Rank";
            this.lblLastBeltRank.Visible = false;
            // 
            // lblContactInfo
            // 
            this.lblContactInfo.AutoSize = true;
            this.lblContactInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactInfo.Location = new System.Drawing.Point(46, 205);
            this.lblContactInfo.Name = "lblContactInfo";
            this.lblContactInfo.Size = new System.Drawing.Size(225, 46);
            this.lblContactInfo.TabIndex = 69;
            this.lblContactInfo.Text = "ContactInfo";
            this.lblContactInfo.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(46, 143);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(126, 46);
            this.lblName.TabIndex = 68;
            this.lblName.Text = "Name";
            this.lblName.Visible = false;
            // 
            // lblMode
            // 
            this.lblMode.AutoSize = true;
            this.lblMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.Location = new System.Drawing.Point(441, 9);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(316, 46);
            this.lblMode.TabIndex = 67;
            this.lblMode.Text = "Update Payment";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(42, 552);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(158, 46);
            this.lblAmount.TabIndex = 88;
            this.lblAmount.Text = "Amount";
            this.lblAmount.Visible = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(46, 608);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(104, 46);
            this.lblDate.TabIndex = 89;
            this.lblDate.Text = "Date";
            this.lblDate.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(388, 626);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(487, 22);
            this.dateTimePicker1.TabIndex = 90;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(434, 552);
            this.txtAmount.Multiline = true;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(298, 46);
            this.txtAmount.TabIndex = 91;
            this.txtAmount.Visible = false;
            // 
            // FormUpdatePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1493, 810);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.lblIsFound);
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
            this.Name = "FormUpdatePayment";
            this.Text = "FormUpdatePayment";
            ((System.ComponentModel.ISupportInitialize)(this.numericLastBeltRank)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblIsFound;
        private System.Windows.Forms.TextBox txtPersonID;
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
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtAmount;
    }
}
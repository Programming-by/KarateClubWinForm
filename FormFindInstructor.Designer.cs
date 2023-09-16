namespace KaratePresentationLayer
{
    partial class FormFindInstructor
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
            this.lblAddressText = new System.Windows.Forms.Label();
            this.lblContactInfo = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblNameText = new System.Windows.Forms.Label();
            this.lblQualificationsText = new System.Windows.Forms.Label();
            this.lblContactInfoText = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblQualifications = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAddressText
            // 
            this.lblAddressText.AutoSize = true;
            this.lblAddressText.Location = new System.Drawing.Point(305, 210);
            this.lblAddressText.Name = "lblAddressText";
            this.lblAddressText.Size = new System.Drawing.Size(28, 16);
            this.lblAddressText.TabIndex = 61;
            this.lblAddressText.Text = "???";
            this.lblAddressText.Visible = false;
            // 
            // lblContactInfo
            // 
            this.lblContactInfo.AutoSize = true;
            this.lblContactInfo.Location = new System.Drawing.Point(73, 170);
            this.lblContactInfo.Name = "lblContactInfo";
            this.lblContactInfo.Size = new System.Drawing.Size(73, 16);
            this.lblContactInfo.TabIndex = 60;
            this.lblContactInfo.Text = "ContactInfo";
            this.lblContactInfo.Visible = false;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(77, 210);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(58, 16);
            this.lblAddress.TabIndex = 59;
            this.lblAddress.Text = "Address";
            this.lblAddress.Visible = false;
            // 
            // lblNameText
            // 
            this.lblNameText.AutoSize = true;
            this.lblNameText.Location = new System.Drawing.Point(305, 130);
            this.lblNameText.Name = "lblNameText";
            this.lblNameText.Size = new System.Drawing.Size(28, 16);
            this.lblNameText.TabIndex = 58;
            this.lblNameText.Text = "???";
            this.lblNameText.Visible = false;
            // 
            // lblQualificationsText
            // 
            this.lblQualificationsText.AutoSize = true;
            this.lblQualificationsText.Location = new System.Drawing.Point(305, 266);
            this.lblQualificationsText.Name = "lblQualificationsText";
            this.lblQualificationsText.Size = new System.Drawing.Size(28, 16);
            this.lblQualificationsText.TabIndex = 55;
            this.lblQualificationsText.Text = "???";
            this.lblQualificationsText.Visible = false;
            // 
            // lblContactInfoText
            // 
            this.lblContactInfoText.AutoSize = true;
            this.lblContactInfoText.Location = new System.Drawing.Point(305, 170);
            this.lblContactInfoText.Name = "lblContactInfoText";
            this.lblContactInfoText.Size = new System.Drawing.Size(28, 16);
            this.lblContactInfoText.TabIndex = 54;
            this.lblContactInfoText.Text = "???";
            this.lblContactInfoText.Visible = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(73, 130);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(44, 16);
            this.lblName.TabIndex = 53;
            this.lblName.Text = "Name";
            this.lblName.Visible = false;
            // 
            // lblQualifications
            // 
            this.lblQualifications.AutoSize = true;
            this.lblQualifications.Location = new System.Drawing.Point(73, 266);
            this.lblQualifications.Name = "lblQualifications";
            this.lblQualifications.Size = new System.Drawing.Size(87, 16);
            this.lblQualifications.TabIndex = 50;
            this.lblQualifications.Text = "Qualifications";
            this.lblQualifications.Visible = false;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(533, 57);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(86, 37);
            this.btnFind.TabIndex = 49;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(138, 57);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(389, 37);
            this.txtID.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(71, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 29);
            this.label1.TabIndex = 47;
            this.label1.Text = "ID:";
            // 
            // FormFindInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 450);
            this.Controls.Add(this.lblAddressText);
            this.Controls.Add(this.lblContactInfo);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblNameText);
            this.Controls.Add(this.lblQualificationsText);
            this.Controls.Add(this.lblContactInfoText);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblQualifications);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Name = "FormFindInstructor";
            this.Text = "FormFindInstructor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddressText;
        private System.Windows.Forms.Label lblContactInfo;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblNameText;
        private System.Windows.Forms.Label lblQualificationsText;
        private System.Windows.Forms.Label lblContactInfoText;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblQualifications;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
    }
}
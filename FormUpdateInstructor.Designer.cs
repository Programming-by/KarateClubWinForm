namespace KaratePresentationLayer
{
    partial class FormUpdateInstructor
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
            this.lbltest = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtContactInfo = new System.Windows.Forms.TextBox();
            this.txtQualifications = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblQualifications = new System.Windows.Forms.Label();
            this.lblContactInfo = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(820, 71);
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
            this.lblIsFound.Location = new System.Drawing.Point(985, 71);
            this.lblIsFound.Name = "lblIsFound";
            this.lblIsFound.Size = new System.Drawing.Size(270, 46);
            this.lblIsFound.TabIndex = 86;
            this.lblIsFound.Text = "IsFoundOrNot";
            this.lblIsFound.Visible = false;
            // 
            // txtPersonID
            // 
            this.txtPersonID.Location = new System.Drawing.Point(500, 71);
            this.txtPersonID.Multiline = true;
            this.txtPersonID.Name = "txtPersonID";
            this.txtPersonID.Size = new System.Drawing.Size(298, 46);
            this.txtPersonID.TabIndex = 85;
            // 
            // lbltest
            // 
            this.lbltest.AutoSize = true;
            this.lbltest.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltest.Location = new System.Drawing.Point(855, 171);
            this.lbltest.Name = "lbltest";
            this.lbltest.Size = new System.Drawing.Size(0, 46);
            this.lbltest.TabIndex = 80;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(235, 526);
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
            this.btnSave.Location = new System.Drawing.Point(853, 526);
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
            this.txtName.Location = new System.Drawing.Point(500, 143);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(298, 46);
            this.txtName.TabIndex = 77;
            this.txtName.Visible = false;
            // 
            // txtContactInfo
            // 
            this.txtContactInfo.Location = new System.Drawing.Point(500, 205);
            this.txtContactInfo.Multiline = true;
            this.txtContactInfo.Name = "txtContactInfo";
            this.txtContactInfo.Size = new System.Drawing.Size(298, 46);
            this.txtContactInfo.TabIndex = 76;
            this.txtContactInfo.Visible = false;
            // 
            // txtQualifications
            // 
            this.txtQualifications.Location = new System.Drawing.Point(500, 353);
            this.txtQualifications.Multiline = true;
            this.txtQualifications.Name = "txtQualifications";
            this.txtQualifications.Size = new System.Drawing.Size(298, 46);
            this.txtQualifications.TabIndex = 75;
            this.txtQualifications.Visible = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(500, 291);
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
            this.lblPersonID.Location = new System.Drawing.Point(26, 71);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(186, 46);
            this.lblPersonID.TabIndex = 73;
            this.lblPersonID.Text = "PersonID";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(26, 281);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(166, 46);
            this.lblAddress.TabIndex = 72;
            this.lblAddress.Text = "Address";
            this.lblAddress.Visible = false;
            // 
            // lblQualifications
            // 
            this.lblQualifications.AutoSize = true;
            this.lblQualifications.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQualifications.Location = new System.Drawing.Point(26, 353);
            this.lblQualifications.Name = "lblQualifications";
            this.lblQualifications.Size = new System.Drawing.Size(261, 46);
            this.lblQualifications.TabIndex = 71;
            this.lblQualifications.Text = "Qualifications";
            this.lblQualifications.Visible = false;
            // 
            // lblContactInfo
            // 
            this.lblContactInfo.AutoSize = true;
            this.lblContactInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactInfo.Location = new System.Drawing.Point(26, 205);
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
            this.lblName.Location = new System.Drawing.Point(26, 143);
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
            this.lblMode.Location = new System.Drawing.Point(421, 9);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(325, 46);
            this.lblMode.TabIndex = 67;
            this.lblMode.Text = "Update Instructor";
            // 
            // FormUpdateInstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 672);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.lblIsFound);
            this.Controls.Add(this.txtPersonID);
            this.Controls.Add(this.lbltest);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtContactInfo);
            this.Controls.Add(this.txtQualifications);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.lblPersonID);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblQualifications);
            this.Controls.Add(this.lblContactInfo);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblMode);
            this.Name = "FormUpdateInstructor";
            this.Text = "UpdateInstructor";
            this.Load += new System.EventHandler(this.FormUpdateInstructor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblIsFound;
        private System.Windows.Forms.TextBox txtPersonID;
        private System.Windows.Forms.Label lbltest;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtContactInfo;
        private System.Windows.Forms.TextBox txtQualifications;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblPersonID;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblQualifications;
        private System.Windows.Forms.Label lblContactInfo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMode;
    }
}
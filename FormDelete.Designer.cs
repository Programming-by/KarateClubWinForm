﻿namespace KaratePresentationLayer
{
    partial class FormDelete
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblPersonID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(600, 45);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(133, 46);
            this.btnFind.TabIndex = 72;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lblIsFound
            // 
            this.lblIsFound.AutoSize = true;
            this.lblIsFound.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIsFound.Location = new System.Drawing.Point(777, 45);
            this.lblIsFound.Name = "lblIsFound";
            this.lblIsFound.Size = new System.Drawing.Size(270, 46);
            this.lblIsFound.TabIndex = 71;
            this.lblIsFound.Text = "IsFoundOrNot";
            this.lblIsFound.Visible = false;
            // 
            // txtPersonID
            // 
            this.txtPersonID.Location = new System.Drawing.Point(251, 45);
            this.txtPersonID.Multiline = true;
            this.txtPersonID.Name = "txtPersonID";
            this.txtPersonID.Size = new System.Drawing.Size(298, 46);
            this.txtPersonID.TabIndex = 70;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(109, 265);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(133, 72);
            this.btnClose.TabIndex = 69;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(600, 249);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(133, 72);
            this.btnDelete.TabIndex = 68;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblPersonID
            // 
            this.lblPersonID.AutoSize = true;
            this.lblPersonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPersonID.Location = new System.Drawing.Point(25, 45);
            this.lblPersonID.Name = "lblPersonID";
            this.lblPersonID.Size = new System.Drawing.Size(186, 46);
            this.lblPersonID.TabIndex = 67;
            this.lblPersonID.Text = "PersonID";
            // 
            // FormDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 592);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.lblIsFound);
            this.Controls.Add(this.txtPersonID);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblPersonID);
            this.Name = "FormDelete";
            this.Text = "FormDelete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblIsFound;
        private System.Windows.Forms.TextBox txtPersonID;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblPersonID;
    }
}
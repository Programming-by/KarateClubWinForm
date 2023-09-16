namespace KaratePresentationLayer
{
    partial class FormFindBeltRank
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
            this.lblTestFees = new System.Windows.Forms.Label();
            this.lblRankNameText = new System.Windows.Forms.Label();
            this.lblTestFeesText = new System.Windows.Forms.Label();
            this.lblRankName = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTestFees
            // 
            this.lblTestFees.AutoSize = true;
            this.lblTestFees.Location = new System.Drawing.Point(73, 170);
            this.lblTestFees.Name = "lblTestFees";
            this.lblTestFees.Size = new System.Drawing.Size(65, 16);
            this.lblTestFees.TabIndex = 60;
            this.lblTestFees.Text = "TestFees";
            this.lblTestFees.Visible = false;
            // 
            // lblRankNameText
            // 
            this.lblRankNameText.AutoSize = true;
            this.lblRankNameText.Location = new System.Drawing.Point(305, 130);
            this.lblRankNameText.Name = "lblRankNameText";
            this.lblRankNameText.Size = new System.Drawing.Size(28, 16);
            this.lblRankNameText.TabIndex = 58;
            this.lblRankNameText.Text = "???";
            this.lblRankNameText.Visible = false;
            // 
            // lblTestFeesText
            // 
            this.lblTestFeesText.AutoSize = true;
            this.lblTestFeesText.Location = new System.Drawing.Point(305, 170);
            this.lblTestFeesText.Name = "lblTestFeesText";
            this.lblTestFeesText.Size = new System.Drawing.Size(28, 16);
            this.lblTestFeesText.TabIndex = 54;
            this.lblTestFeesText.Text = "???";
            this.lblTestFeesText.Visible = false;
            // 
            // lblRankName
            // 
            this.lblRankName.AutoSize = true;
            this.lblRankName.Location = new System.Drawing.Point(73, 130);
            this.lblRankName.Name = "lblRankName";
            this.lblRankName.Size = new System.Drawing.Size(76, 16);
            this.lblRankName.TabIndex = 53;
            this.lblRankName.Text = "RankName";
            this.lblRankName.Visible = false;
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
            // FormFindBeltRank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 450);
            this.Controls.Add(this.lblTestFees);
            this.Controls.Add(this.lblRankNameText);
            this.Controls.Add(this.lblTestFeesText);
            this.Controls.Add(this.lblRankName);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label1);
            this.Name = "FormFindBeltRank";
            this.Text = "FormFindInstructor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTestFees;
        private System.Windows.Forms.Label lblRankNameText;
        private System.Windows.Forms.Label lblTestFeesText;
        private System.Windows.Forms.Label lblRankName;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
    }
}
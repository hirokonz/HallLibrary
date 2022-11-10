namespace HallLibrary
{
    partial class MemberReportForm
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
            this.txtMembers = new System.Windows.Forms.TextBox();
            this.btnMembersReport = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtMembers
            // 
            this.txtMembers.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMembers.Location = new System.Drawing.Point(129, 112);
            this.txtMembers.Multiline = true;
            this.txtMembers.Name = "txtMembers";
            this.txtMembers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMembers.Size = new System.Drawing.Size(805, 427);
            this.txtMembers.TabIndex = 0;
            // 
            // btnMembersReport
            // 
            this.btnMembersReport.BackColor = System.Drawing.Color.YellowGreen;
            this.btnMembersReport.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembersReport.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMembersReport.Location = new System.Drawing.Point(216, 563);
            this.btnMembersReport.Name = "btnMembersReport";
            this.btnMembersReport.Size = new System.Drawing.Size(168, 56);
            this.btnMembersReport.TabIndex = 1;
            this.btnMembersReport.Text = "Members Report";
            this.btnMembersReport.UseVisualStyleBackColor = false;
            this.btnMembersReport.Click += new System.EventHandler(this.btnMembersReport_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(695, 563);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(169, 56);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(429, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Members Report";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MemberReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1067, 658);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnMembersReport);
            this.Controls.Add(this.txtMembers);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MemberReportForm";
            this.Text = "Members Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMembers;
        private System.Windows.Forms.Button btnMembersReport;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label label1;
    }
}
namespace HallLibrary
{
    partial class BookReportForm
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
            this.txtBooks = new System.Windows.Forms.TextBox();
            this.lblBookReport = new System.Windows.Forms.Label();
            this.btnBooksReport = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBooks
            // 
            this.txtBooks.Location = new System.Drawing.Point(69, 110);
            this.txtBooks.Multiline = true;
            this.txtBooks.Name = "txtBooks";
            this.txtBooks.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBooks.Size = new System.Drawing.Size(910, 402);
            this.txtBooks.TabIndex = 0;
            // 
            // lblBookReport
            // 
            this.lblBookReport.AutoSize = true;
            this.lblBookReport.Font = new System.Drawing.Font("Calibri", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookReport.Location = new System.Drawing.Point(426, 47);
            this.lblBookReport.Name = "lblBookReport";
            this.lblBookReport.Size = new System.Drawing.Size(167, 33);
            this.lblBookReport.TabIndex = 1;
            this.lblBookReport.Text = "Books Report";
            // 
            // btnBooksReport
            // 
            this.btnBooksReport.BackColor = System.Drawing.Color.YellowGreen;
            this.btnBooksReport.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooksReport.Location = new System.Drawing.Point(224, 564);
            this.btnBooksReport.Name = "btnBooksReport";
            this.btnBooksReport.Size = new System.Drawing.Size(177, 61);
            this.btnBooksReport.TabIndex = 2;
            this.btnBooksReport.Text = "Books Report";
            this.btnBooksReport.UseVisualStyleBackColor = false;
            this.btnBooksReport.Click += new System.EventHandler(this.btnBooksReport_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Gray;
            this.btnReturn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(595, 564);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(168, 61);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // BookReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 658);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnBooksReport);
            this.Controls.Add(this.lblBookReport);
            this.Controls.Add(this.txtBooks);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BookReportForm";
            this.Text = "Books Report";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBooks;
        private System.Windows.Forms.Label lblBookReport;
        private System.Windows.Forms.Button btnBooksReport;
        private System.Windows.Forms.Button btnReturn;
    }
}
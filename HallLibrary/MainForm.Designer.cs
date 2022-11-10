namespace HallLibrary
{
    partial class MainForm
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
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnUpdateMember = new System.Windows.Forms.Button();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.btnLoanBook = new System.Windows.Forms.Button();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnMembersReport = new System.Windows.Forms.Button();
            this.btnBooksReport = new System.Windows.Forms.Button();
            this.MainMenu = new System.Windows.Forms.Label();
            this.lblMembers = new System.Windows.Forms.Label();
            this.lblBooks = new System.Windows.Forms.Label();
            this.lblReports = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.oleDbSelectCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbInsertCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbUpdateCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDeleteCommand1 = new System.Data.OleDb.OleDbCommand();
            this.oleDbDataAdapter1 = new System.Data.OleDb.OleDbDataAdapter();
            this.SuspendLayout();
            // 
            // btnAddMember
            // 
            this.btnAddMember.BackColor = System.Drawing.Color.OliveDrab;
            this.btnAddMember.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMember.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddMember.Location = new System.Drawing.Point(111, 196);
            this.btnAddMember.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(216, 56);
            this.btnAddMember.TabIndex = 0;
            this.btnAddMember.Text = "Add Member";
            this.btnAddMember.UseVisualStyleBackColor = false;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            // 
            // btnUpdateMember
            // 
            this.btnUpdateMember.BackColor = System.Drawing.Color.OliveDrab;
            this.btnUpdateMember.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMember.ForeColor = System.Drawing.Color.Transparent;
            this.btnUpdateMember.Location = new System.Drawing.Point(388, 196);
            this.btnUpdateMember.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateMember.Name = "btnUpdateMember";
            this.btnUpdateMember.Size = new System.Drawing.Size(239, 56);
            this.btnUpdateMember.TabIndex = 1;
            this.btnUpdateMember.Text = "Update Member";
            this.btnUpdateMember.UseVisualStyleBackColor = false;
            this.btnUpdateMember.Click += new System.EventHandler(this.btnUpdateMember_Click);
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.BackColor = System.Drawing.Color.OliveDrab;
            this.btnDeleteMember.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMember.ForeColor = System.Drawing.Color.Transparent;
            this.btnDeleteMember.Location = new System.Drawing.Point(657, 196);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(261, 56);
            this.btnDeleteMember.TabIndex = 2;
            this.btnDeleteMember.Text = "Delete Member";
            this.btnDeleteMember.UseVisualStyleBackColor = false;
            this.btnDeleteMember.Click += new System.EventHandler(this.btnDeleteMember_Click);
            // 
            // btnLoanBook
            // 
            this.btnLoanBook.BackColor = System.Drawing.Color.OliveDrab;
            this.btnLoanBook.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoanBook.ForeColor = System.Drawing.Color.Transparent;
            this.btnLoanBook.Location = new System.Drawing.Point(388, 341);
            this.btnLoanBook.Name = "btnLoanBook";
            this.btnLoanBook.Size = new System.Drawing.Size(239, 56);
            this.btnLoanBook.TabIndex = 4;
            this.btnLoanBook.Text = "Loan Book";
            this.btnLoanBook.UseVisualStyleBackColor = false;
            this.btnLoanBook.Click += new System.EventHandler(this.btnLoanBook_Click);
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.BackColor = System.Drawing.Color.OliveDrab;
            this.btnReturnBook.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnBook.ForeColor = System.Drawing.Color.Transparent;
            this.btnReturnBook.Location = new System.Drawing.Point(657, 341);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(261, 54);
            this.btnReturnBook.TabIndex = 5;
            this.btnReturnBook.Text = "Return Book";
            this.btnReturnBook.UseVisualStyleBackColor = false;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.OliveDrab;
            this.btnAddBook.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.ForeColor = System.Drawing.Color.Transparent;
            this.btnAddBook.Location = new System.Drawing.Point(111, 341);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(216, 56);
            this.btnAddBook.TabIndex = 3;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnMembersReport
            // 
            this.btnMembersReport.BackColor = System.Drawing.Color.Olive;
            this.btnMembersReport.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembersReport.ForeColor = System.Drawing.Color.Transparent;
            this.btnMembersReport.Location = new System.Drawing.Point(231, 513);
            this.btnMembersReport.Name = "btnMembersReport";
            this.btnMembersReport.Size = new System.Drawing.Size(218, 56);
            this.btnMembersReport.TabIndex = 6;
            this.btnMembersReport.Text = "Members Report";
            this.btnMembersReport.UseVisualStyleBackColor = false;
            this.btnMembersReport.Click += new System.EventHandler(this.btnMembersReport_Click);
            // 
            // btnBooksReport
            // 
            this.btnBooksReport.BackColor = System.Drawing.Color.Olive;
            this.btnBooksReport.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBooksReport.ForeColor = System.Drawing.Color.Transparent;
            this.btnBooksReport.Location = new System.Drawing.Point(555, 513);
            this.btnBooksReport.Name = "btnBooksReport";
            this.btnBooksReport.Size = new System.Drawing.Size(263, 56);
            this.btnBooksReport.TabIndex = 7;
            this.btnBooksReport.Text = "Books Report";
            this.btnBooksReport.UseVisualStyleBackColor = false;
            this.btnBooksReport.Click += new System.EventHandler(this.btnBooksReport_Click);
            // 
            // MainMenu
            // 
            this.MainMenu.AutoSize = true;
            this.MainMenu.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenu.Location = new System.Drawing.Point(334, 62);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(362, 42);
            this.MainMenu.TabIndex = 8;
            this.MainMenu.Text = "Hall Library Main Menu";
            // 
            // lblMembers
            // 
            this.lblMembers.AutoSize = true;
            this.lblMembers.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMembers.ForeColor = System.Drawing.Color.Black;
            this.lblMembers.Location = new System.Drawing.Point(148, 142);
            this.lblMembers.Name = "lblMembers";
            this.lblMembers.Size = new System.Drawing.Size(110, 29);
            this.lblMembers.TabIndex = 9;
            this.lblMembers.Text = "Members";
            // 
            // lblBooks
            // 
            this.lblBooks.AutoSize = true;
            this.lblBooks.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBooks.ForeColor = System.Drawing.Color.Black;
            this.lblBooks.Location = new System.Drawing.Point(148, 288);
            this.lblBooks.Name = "lblBooks";
            this.lblBooks.Size = new System.Drawing.Size(74, 29);
            this.lblBooks.TabIndex = 10;
            this.lblBooks.Text = "Books";
            // 
            // lblReports
            // 
            this.lblReports.AutoSize = true;
            this.lblReports.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReports.ForeColor = System.Drawing.Color.Black;
            this.lblReports.Location = new System.Drawing.Point(148, 458);
            this.lblReports.Name = "lblReports";
            this.lblReports.Size = new System.Drawing.Size(92, 29);
            this.lblReports.TabIndex = 11;
            this.lblReports.Text = "Reports";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.GrayText;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Transparent;
            this.btnExit.Location = new System.Drawing.Point(834, 609);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(141, 50);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // oleDbDataAdapter1
            // 
            this.oleDbDataAdapter1.DeleteCommand = this.oleDbDeleteCommand1;
            this.oleDbDataAdapter1.InsertCommand = this.oleDbInsertCommand1;
            this.oleDbDataAdapter1.SelectCommand = this.oleDbSelectCommand1;
            this.oleDbDataAdapter1.UpdateCommand = this.oleDbUpdateCommand1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 693);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblReports);
            this.Controls.Add(this.lblBooks);
            this.Controls.Add(this.lblMembers);
            this.Controls.Add(this.MainMenu);
            this.Controls.Add(this.btnBooksReport);
            this.Controls.Add(this.btnMembersReport);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.btnReturnBook);
            this.Controls.Add(this.btnLoanBook);
            this.Controls.Add(this.btnDeleteMember);
            this.Controls.Add(this.btnUpdateMember);
            this.Controls.Add(this.btnAddMember);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnUpdateMember;
        private System.Windows.Forms.Button btnDeleteMember;
        private System.Windows.Forms.Button btnLoanBook;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnMembersReport;
        private System.Windows.Forms.Button btnBooksReport;
        private System.Windows.Forms.Label MainMenu;
        private System.Windows.Forms.Label lblMembers;
        private System.Windows.Forms.Label lblBooks;
        private System.Windows.Forms.Label lblReports;
        private System.Windows.Forms.Button btnExit;
        private System.Data.OleDb.OleDbCommand oleDbSelectCommand1;
        private System.Data.OleDb.OleDbCommand oleDbInsertCommand1;
        private System.Data.OleDb.OleDbCommand oleDbUpdateCommand1;
        private System.Data.OleDb.OleDbCommand oleDbDeleteCommand1;
        private System.Data.OleDb.OleDbDataAdapter oleDbDataAdapter1;
    }
}


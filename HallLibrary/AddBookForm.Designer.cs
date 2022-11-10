namespace HallLibrary
{
    partial class AddBookForm
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
            this.lblAddBook = new System.Windows.Forms.Label();
            this.lblBookID = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPage = new System.Windows.Forms.Label();
            this.lblYearPublished = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtPage = new System.Windows.Forms.TextBox();
            this.txtYearPublished = new System.Windows.Forms.TextBox();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.cboAuthorID = new System.Windows.Forms.ComboBox();
            this.cboLastName = new System.Windows.Forms.ComboBox();
            this.cboFirstName = new System.Windows.Forms.ComboBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblSelectAuthor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAddBook
            // 
            this.lblAddBook.AutoSize = true;
            this.lblAddBook.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddBook.Location = new System.Drawing.Point(382, 40);
            this.lblAddBook.Name = "lblAddBook";
            this.lblAddBook.Size = new System.Drawing.Size(123, 33);
            this.lblAddBook.TabIndex = 0;
            this.lblAddBook.Text = "Add Book";
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Location = new System.Drawing.Point(171, 205);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(63, 19);
            this.lblBookID.TabIndex = 1;
            this.lblBookID.Text = "Book ID:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(192, 250);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(42, 19);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title:";
            // 
            // lblPage
            // 
            this.lblPage.AutoSize = true;
            this.lblPage.Location = new System.Drawing.Point(110, 300);
            this.lblPage.Name = "lblPage";
            this.lblPage.Size = new System.Drawing.Size(124, 19);
            this.lblPage.TabIndex = 3;
            this.lblPage.Text = "Number of Pages:";
            // 
            // lblYearPublished
            // 
            this.lblYearPublished.AutoSize = true;
            this.lblYearPublished.Location = new System.Drawing.Point(126, 346);
            this.lblYearPublished.Name = "lblYearPublished";
            this.lblYearPublished.Size = new System.Drawing.Size(108, 19);
            this.lblYearPublished.TabIndex = 4;
            this.lblYearPublished.Text = "Year Published:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(185, 392);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(53, 19);
            this.lblStatus.TabIndex = 5;
            this.lblStatus.Text = "Status:";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(183, 441);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(51, 19);
            this.lblNote.TabIndex = 7;
            this.lblNote.Text = "Notes:";
            // 
            // txtBookID
            // 
            this.txtBookID.BackColor = System.Drawing.Color.LightGray;
            this.txtBookID.Enabled = false;
            this.txtBookID.Location = new System.Drawing.Point(277, 203);
            this.txtBookID.MaxLength = 8;
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(119, 27);
            this.txtBookID.TabIndex = 8;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(277, 248);
            this.txtTitle.MaxLength = 60;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(360, 27);
            this.txtTitle.TabIndex = 4;
            // 
            // txtPage
            // 
            this.txtPage.Location = new System.Drawing.Point(277, 298);
            this.txtPage.MaxLength = 4;
            this.txtPage.Name = "txtPage";
            this.txtPage.Size = new System.Drawing.Size(100, 27);
            this.txtPage.TabIndex = 5;
            // 
            // txtYearPublished
            // 
            this.txtYearPublished.Location = new System.Drawing.Point(277, 344);
            this.txtYearPublished.MaxLength = 4;
            this.txtYearPublished.Name = "txtYearPublished";
            this.txtYearPublished.Size = new System.Drawing.Size(100, 27);
            this.txtYearPublished.TabIndex = 6;
            // 
            // txtNotes
            // 
            this.txtNotes.Location = new System.Drawing.Point(277, 438);
            this.txtNotes.MaxLength = 100;
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(412, 65);
            this.txtNotes.TabIndex = 8;
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "Available",
            "Damaged",
            "Loaned"});
            this.cboStatus.Location = new System.Drawing.Point(277, 389);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(121, 27);
            this.cboStatus.TabIndex = 7;
            // 
            // cboAuthorID
            // 
            this.cboAuthorID.FormattingEnabled = true;
            this.cboAuthorID.ItemHeight = 19;
            this.cboAuthorID.Location = new System.Drawing.Point(266, 131);
            this.cboAuthorID.Name = "cboAuthorID";
            this.cboAuthorID.Size = new System.Drawing.Size(100, 27);
            this.cboAuthorID.TabIndex = 15;
            // 
            // cboLastName
            // 
            this.cboLastName.FormattingEnabled = true;
            this.cboLastName.ItemHeight = 19;
            this.cboLastName.Location = new System.Drawing.Point(391, 131);
            this.cboLastName.Name = "cboLastName";
            this.cboLastName.Size = new System.Drawing.Size(193, 27);
            this.cboLastName.TabIndex = 16;
            // 
            // cboFirstName
            // 
            this.cboFirstName.FormattingEnabled = true;
            this.cboFirstName.ItemHeight = 19;
            this.cboFirstName.Location = new System.Drawing.Point(609, 131);
            this.cboFirstName.Name = "cboFirstName";
            this.cboFirstName.Size = new System.Drawing.Size(178, 27);
            this.cboFirstName.TabIndex = 17;
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAddBook.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.Location = new System.Drawing.Point(253, 533);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(146, 51);
            this.btnAddBook.TabIndex = 9;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(516, 533);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(124, 51);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblSelectAuthor
            // 
            this.lblSelectAuthor.AutoSize = true;
            this.lblSelectAuthor.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectAuthor.Location = new System.Drawing.Point(113, 77);
            this.lblSelectAuthor.Name = "lblSelectAuthor";
            this.lblSelectAuthor.Size = new System.Drawing.Size(124, 23);
            this.lblSelectAuthor.TabIndex = 20;
            this.lblSelectAuthor.Text = "Select Author:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "New Book Details:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(174, 131);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(60, 19);
            this.lblAuthor.TabIndex = 6;
            this.lblAuthor.Text = "Author: ";
            // 
            // AddBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 627);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSelectAuthor);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.cboFirstName);
            this.Controls.Add(this.cboLastName);
            this.Controls.Add(this.cboAuthorID);
            this.Controls.Add(this.cboStatus);
            this.Controls.Add(this.txtNotes);
            this.Controls.Add(this.txtYearPublished);
            this.Controls.Add(this.txtPage);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblYearPublished);
            this.Controls.Add(this.lblPage);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblBookID);
            this.Controls.Add(this.lblAddBook);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddBookForm";
            this.Text = "Add Book";
            this.Load += new System.EventHandler(this.AddBookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddBook;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Label lblYearPublished;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtPage;
        private System.Windows.Forms.TextBox txtYearPublished;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.ComboBox cboAuthorID;
        private System.Windows.Forms.ComboBox cboLastName;
        private System.Windows.Forms.ComboBox cboFirstName;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblSelectAuthor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAuthor;
    }
}
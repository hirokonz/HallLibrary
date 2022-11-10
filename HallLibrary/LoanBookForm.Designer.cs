namespace HallLibrary
{
    partial class LoanBookForm
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
            this.components = new System.ComponentModel.Container();
            this.memberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hallLIbraryDataSet1 = new HallLibrary.HallLIbraryDataSet1();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.dgvLoans = new System.Windows.Forms.DataGridView();
            this.memberTableAdapter = new HallLibrary.HallLIbraryDataSet1TableAdapters.MemberTableAdapter();
            this.lblLoanDate = new System.Windows.Forms.Label();
            this.btnLoanBook = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblLoanBook = new System.Windows.Forms.Label();
            this.dtpLoanDate = new System.Windows.Forms.DateTimePicker();
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hallLIbraryDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // memberBindingSource
            // 
            this.memberBindingSource.DataMember = "Member";
            this.memberBindingSource.DataSource = this.hallLIbraryDataSet1;
            // 
            // hallLIbraryDataSet1
            // 
            this.hallLIbraryDataSet1.DataSetName = "HallLIbraryDataSet1";
            this.hallLIbraryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvBooks
            // 
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(45, 314);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.RowHeadersWidth = 51;
            this.dgvBooks.Size = new System.Drawing.Size(551, 150);
            this.dgvBooks.TabIndex = 1;
            // 
            // dgvLoans
            // 
            this.dgvLoans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoans.Location = new System.Drawing.Point(45, 489);
            this.dgvLoans.Name = "dgvLoans";
            this.dgvLoans.RowHeadersWidth = 51;
            this.dgvLoans.Size = new System.Drawing.Size(551, 118);
            this.dgvLoans.TabIndex = 2;
            // 
            // memberTableAdapter
            // 
            this.memberTableAdapter.ClearBeforeFill = true;
            // 
            // lblLoanDate
            // 
            this.lblLoanDate.AutoSize = true;
            this.lblLoanDate.Location = new System.Drawing.Point(728, 320);
            this.lblLoanDate.Name = "lblLoanDate";
            this.lblLoanDate.Size = new System.Drawing.Size(104, 24);
            this.lblLoanDate.TabIndex = 3;
            this.lblLoanDate.Text = "Loan Date: ";
            // 
            // btnLoanBook
            // 
            this.btnLoanBook.BackColor = System.Drawing.Color.YellowGreen;
            this.btnLoanBook.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoanBook.Location = new System.Drawing.Point(670, 489);
            this.btnLoanBook.Name = "btnLoanBook";
            this.btnLoanBook.Size = new System.Drawing.Size(141, 58);
            this.btnLoanBook.TabIndex = 5;
            this.btnLoanBook.Text = "Loan Book";
            this.btnLoanBook.UseVisualStyleBackColor = false;
            this.btnLoanBook.Click += new System.EventHandler(this.btnLoanBook_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Gray;
            this.btnReturn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.ForeColor = System.Drawing.Color.White;
            this.btnReturn.Location = new System.Drawing.Point(847, 489);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(141, 58);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblLoanBook
            // 
            this.lblLoanBook.AutoSize = true;
            this.lblLoanBook.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoanBook.Location = new System.Drawing.Point(465, 46);
            this.lblLoanBook.Name = "lblLoanBook";
            this.lblLoanBook.Size = new System.Drawing.Size(164, 41);
            this.lblLoanBook.TabIndex = 7;
            this.lblLoanBook.Text = "Loan Book";
            // 
            // dtpLoanDate
            // 
            this.dtpLoanDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpLoanDate.Location = new System.Drawing.Point(817, 314);
            this.dtpLoanDate.Name = "dtpLoanDate";
            this.dtpLoanDate.Size = new System.Drawing.Size(128, 32);
            this.dtpLoanDate.TabIndex = 1;
            // 
            // dgvMembers
            // 
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembers.Location = new System.Drawing.Point(45, 108);
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.RowHeadersWidth = 51;
            this.dgvMembers.RowTemplate.Height = 24;
            this.dgvMembers.Size = new System.Drawing.Size(495, 173);
            this.dgvMembers.TabIndex = 8;
            // 
            // LoanBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 658);
            this.Controls.Add(this.dgvMembers);
            this.Controls.Add(this.dtpLoanDate);
            this.Controls.Add(this.lblLoanBook);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnLoanBook);
            this.Controls.Add(this.lblLoanDate);
            this.Controls.Add(this.dgvLoans);
            this.Controls.Add(this.dgvBooks);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoanBookForm";
            this.Text = "Loan Book";
            ((System.ComponentModel.ISupportInitialize)(this.memberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hallLIbraryDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.DataGridView dgvLoans;
        private HallLIbraryDataSet1 hallLIbraryDataSet1;
        private System.Windows.Forms.BindingSource memberBindingSource;
        private HallLIbraryDataSet1TableAdapters.MemberTableAdapter memberTableAdapter;
        private System.Windows.Forms.Label lblLoanDate;
        private System.Windows.Forms.Button btnLoanBook;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblLoanBook;
        private System.Windows.Forms.DateTimePicker dtpLoanDate;
        private System.Windows.Forms.DataGridView dgvMembers;
    }
}
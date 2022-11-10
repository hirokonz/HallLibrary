using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HallLibrary
{
    public partial class LoanBookForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager cmMember;
        private CurrencyManager cmBook;
        private CurrencyManager cmLoan;
        private CurrencyManager cmFK_MEMBER_LOAN;
       


        public LoanBookForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
            BindControls();
        }

        public void BindControls()
        {
            cmMember = (CurrencyManager)this.BindingContext[DC.dsHall, "Member"];
            cmBook = (CurrencyManager)this.BindingContext[DC.dsHall, "Book"];
            cmLoan = (CurrencyManager)this.BindingContext[DC.dsHall, "Member.FK_MEMBER_LOAN"];
            

            dgvMembers.DataSource = DC.dsHall;
            dgvMembers.DataMember = "Member";


            dgvBooks.DataSource = DC.dsHall;
            dgvBooks.DataMember = "Book";

            dgvLoans.DataSource = DC.dsHall;
            dgvLoans.DataMember = "Member.FK_MEMBER_LOAN";


        }

        private void btnLoanBook_Click(object sender, EventArgs e)
        {
            DataRow newLoan = DC.dtLoan.NewRow();

            newLoan["BookID"] = dgvBooks["BookID", cmBook.Position].Value;
            newLoan["MemberID"] = dgvMembers["MemberID", cmMember.Position].Value;
            newLoan["LoanDate"] = dtpLoanDate.Text;

            DataRow updateBookRow = DC.dtBook.Rows[cmBook.Position];
            updateBookRow["Status"] = "Loaned".ToString();

            DC.dsHall.Tables["Loan"].Rows.Add(newLoan);
            DC.UpdateLoan();
            DC.UpdateBook();
          

            DialogResult dResult = MessageBox.Show("Book loaned successfully", "Acknowledgement", MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
            if (dResult == DialogResult.OK)
            {
                MessageBox.Show("loan another book?", "Acknowledgement", MessageBoxButtons.OK,
                              MessageBoxIcon.Exclamation);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }


        //private void LoanBookForm_Load(object sender, EventArgs e)
        //{
        //    // TODO: This line of code loads data into the 'hallLIbraryDataSet1.Member' table. You can move, or remove it, as needed.
        //    this.memberTableAdapter.Fill(this.hallLIbraryDataSet1.Member);

        //}
    }
}

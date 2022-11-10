using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace HallLibrary
{
    public partial class ReturnBookForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager cmMember;
        private CurrencyManager cmBook;
        private CurrencyManager cmLoan;
        private CurrencyManager cmFK_Member_Loan;
        private CurrencyManager cmBook_Loan;


        public ReturnBookForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            BindControls();
            frmMenu.Hide();
        }
        public void BindControls()
        {
            cmMember = (CurrencyManager)this.BindingContext[DC.dsHall, "Member"];
            cmBook = (CurrencyManager)this.BindingContext[DC.dsHall, "Book"];
            cmLoan = (CurrencyManager)this.BindingContext[DC.dsHall, "Loan"];
            cmFK_Member_Loan = (CurrencyManager)this.BindingContext[DC.dsHall, "Member.FK_Member_Loan"];
            

            dgvMembers.DataSource = DC.dsHall;
            dgvMembers.DataMember = "Member";

            //dgvLoans.DataSource = DC.dsHall;
            //dgvLoans.DataMember = "Loan";

            dgvLoans.DataSource = DC.dsHall;
            dgvLoans.DataMember = "Member.FK_Member_Loan";

        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            int aBookID = Convert.ToInt32(dgvLoans["BookID", cmFK_Member_Loan.Position].Value);
            int aMemberID = Convert.ToInt32(dgvLoans["MemberID", cmFK_Member_Loan.Position].Value);
            object[] primaryKey = new object[1];
            primaryKey[0] = aBookID;
          //  primaryKey[1] = aMemberID;

            cmLoan.Position = DC.loanView.Find(primaryKey);
            DataRow deleteLoanRow = DC.dtLoan.Rows[cmLoan.Position];
            

            //DataRow updateBookRow = DC.dtBook.Rows[cmBook.Position];   
            //updateBookRow["Status"] = "Available".ToString();              

            
            deleteLoanRow.Delete();
            DC.UpdateLoan();
            //DC.UpdateBook();





            //The system computes an amount of find by loan date over 21 days is earlier than today's date.
            //
            //1. If the "daysOnLoan" is greater than 21 days,
            //  1.1 calculate the FineDue by currentFine = CurrentFine = daysOnLoan((todayDate - loanDate) - 21) * $0.50

            //2. Else
            //2.1 change bookstatus to available
            //2.2 delete the loan record


            //cmMember.Position = DC.memberView.Find(aMemberID);
            //DataRow drMember = DC.dtMember.Rows[cmMember.Position];
            //double FineDue = Convert.ToDouble(drMember["FineDue"].ToString());

            //DateTime todayDate = DateTime.Now;
            //DateTime loandate = dtpLoanDate.Value;
            //double daysOnLoan = (todayDate - loandate).TotalDays;
            //daysOnLoan = Math.Ceiling(daysOnLoan);

            //// Math.Ceiling
            //if (daysOnLoan > 21)
            //{
            //    daysOnLoan -= 21;
            //    daysOnLoan *= 0.5;

            //    double currentFine = Convert.ToInt32(drMember["FineDue"]);
            //    currentFine += daysOnLoan;
            //    drMember["FineDue"] = currentFine;
            //    DC.UpdateMember();

            //}
            //DataRow deleteLoanRow = DC.dtLoan.Rows[cmLoan.Position];

            //foreach (DataRow drLoan in DC.dtLoan.Rows)
            //    if ((aMemberID == Convert.ToInt32(drLoan["MemberID"])) & (aBookID == Convert.ToInt32(drLoan["BookID"])))
            //    {
            //        drLoan.Delete();
            //        DC.UpdateLoan();
            //    }



            DialogResult dResult = MessageBox.Show("Book returned successfully", "Acknowledgement", MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
            if (dResult == DialogResult.OK)
            {
                MessageBox.Show("Return another book?", "Acknowledgement", MessageBoxButtons.OK,
                              MessageBoxIcon.Exclamation);
            }

        }

        private void dgvMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cmMember.Position != -1)
            {
                int aMemberID = Convert.ToInt32(dgvMembers["MemberID", cmMember.Position].Value);
                cmMember.Position = DC.memberView.Find(aMemberID);
                DataRow drMember = DC.dtMember.Rows[cmMember.Position];
                txtMemberID.Text = drMember["MemberID"].ToString();
                txtLastName.Text = drMember["LastName"].ToString();
                txtFirstName.Text = drMember["FirstName"].ToString();
                txtStreetAddress.Text = drMember["Street Address"].ToString();
            }
        }


        private void dgvLoans_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cmFK_Member_Loan.Position != -1) 
            {
                int aBookID = Convert.ToInt32(dgvLoans["BookID", cmFK_Member_Loan.Position].Value);
                cmBook.Position = DC.bookView.Find(aBookID);
                DataRow drBook = DC.dtBook.Rows[cmBook.Position];
                txtBookID.Text = drBook["BookID"].ToString();
                txtTitle.Text = drBook["Title"].ToString();

                //(cmBook_Loan.Position != -1)
                //    dtpLoanDate.Text = drLoan["LoanDate"].ToString();
                
            }

        }


        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }

    }
}


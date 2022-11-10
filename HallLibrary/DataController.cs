using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace HallLibrary
{
    public partial class DataController : Form
    {
        public DataTable dtAuthor;
        public DataTable dtBook;
        public DataTable dtLoan;
        public DataTable dtMember;
        public DataTable dtSuburb;
        public DataView authorView;
        public DataView bookView;
        public DataView loanView;
        public DataView memberView;
        public DataView suburbView;

        public DataController()
        {
            InitializeComponent();
            dsHall.EnforceConstraints = false;
            daAuthor.Fill(dsHall);
            daBook.Fill(dsHall);
            daLoan.Fill(dsHall);
            daMember.Fill(dsHall);
            daSuburb.Fill(dsHall);
            dtAuthor = dsHall.Tables["Author"];
            dtBook = dsHall.Tables["Book"];
            dtLoan = dsHall.Tables["Loan"];
            dtMember = dsHall.Tables["Member"];
            dtSuburb = dsHall.Tables["Suburb"];
            authorView = new DataView(dtAuthor);
            authorView.Sort = "AuthorID";
            bookView = new DataView(dtBook);
            bookView.Sort = "BookID";
            loanView = new DataView(dtLoan);
            loanView.Sort = "MemberID";
            memberView = new DataView(dtMember);
            memberView.Sort = "MemberID";
            suburbView = new DataView(dtSuburb);
            suburbView.Sort = "SuburbID";
            dsHall.EnforceConstraints = false;
        }
        public void UpdateMember()
        {
            daMember.Update(dsHall, "Member");
        }
        private void daMember_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            // Include a variable and a command to retrieve
            // the identity value from the Access database.
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnHall);
            if (e.StatementType == StatementType.Insert)
            {
                // Retrieve the identity value and 
                // store it in the Department ID column.
                newID = (int)idCMD.ExecuteScalar();
                e.Row["MemberID"] = newID;

            }
        }

        public void UpdateLoan()
        {
            daLoan.Update(dsHall,"Loan");
        }

        private void daLoan_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            // Include a variable and a command to retrieve
            // the identity value from the Access database.
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnHall);
            if (e.StatementType == StatementType.Insert)
            {
                // Retrieve the identity value and 
                // store it in the Loan ID column.
                newID = (int)idCMD.ExecuteScalar();
                e.Row["LoanID"] = newID;
            }
        }




        public void UpdateBook()
        {
            daBook.Update(dsHall, "Book");
        }

        private void daBook_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {
            // Include a variable and a command to retrieve
            // the identity value from the Access database.
            int newID = 0;
            OleDbCommand idCMD = new OleDbCommand("SELECT @@IDENTITY", ctnHall);
            if (e.StatementType == StatementType.Insert)
            {
                // Retrieve the identity value and 
                // store it in the Department ID column.
                newID = (int)idCMD.ExecuteScalar();
                e.Row["BookID"] = newID;

            }
        }

        private void daAuthor_RowUpdated(object sender, OleDbRowUpdatedEventArgs e)
        {

        }
    }


}

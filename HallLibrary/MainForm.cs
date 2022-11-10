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
    public partial class MainForm : Form
    {
        public DataController DC { get; set; }               	// the reference to the form that holds the data components
        private AddMemberForm frmAddMember;         // the reference to the add member form
        private UpdateMemberForm frmUpdateMember;   // the reference to the update member form
        private DeleteMemberForm frmDeleteMember;   // the reference to the delete member form
        private MemberReportForm frmMemberReport;   // the reference to the members report form
        private AddBookForm frmAddBook;             // the reference to the add book form
        private LoanBookForm frmLoanBook;           // the reference to the loan book form
        private ReturnBookForm frmReturnBook;       // the reference to the return book form
        private BookReportForm frmBookReport;       // the reference to the books reort form

       

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DC = new DataController(); //create the data controller and load the dataset
        }

        private void btnMembersReport_Click(object sender, EventArgs e)
        {
            if (frmMemberReport == null)
            {
                frmMemberReport = new MemberReportForm(DC, this);
            }
            frmMemberReport.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            if (frmAddMember == null)
            {
                frmAddMember = new AddMemberForm(DC, this);
            }
            frmAddMember.ShowDialog();
        }

        private void btnUpdateMember_Click(object sender, EventArgs e)
        {
            if (frmUpdateMember == null)
            {
                frmUpdateMember = new UpdateMemberForm(DC,this);
            }
            frmUpdateMember.ShowDialog();
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            if (frmDeleteMember == null)
            {
                frmDeleteMember = new DeleteMemberForm(DC, this);
            }
            frmDeleteMember.ShowDialog();
        }

        private void btnLoanBook_Click(object sender, EventArgs e)
        {
            if(frmLoanBook ==null)
            {
                frmLoanBook = new LoanBookForm(DC, this);
            }
            frmLoanBook.ShowDialog();   
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            if (frmReturnBook == null)
            {
                frmReturnBook = new ReturnBookForm(DC, this);
            }
            frmReturnBook.ShowDialog();
        }

        private void btnBooksReport_Click(object sender, EventArgs e)
        {
            if (frmBookReport == null)
            {
                frmBookReport = new BookReportForm(DC, this);
            }
            frmBookReport.ShowDialog();
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (frmAddBook == null)
            {
                frmAddBook = new AddBookForm(DC, this);
            }
            frmAddBook.ShowDialog();
        }
    }
}

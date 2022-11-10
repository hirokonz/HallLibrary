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
    public partial class MemberReportForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager cmLoan;


        public MemberReportForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            this.frmMenu = mnu;
            frmMenu.Hide();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }

        private void btnMembersReport_Click(object sender, EventArgs e)
        {
            //print member details
            string memberText = "";
            txtMembers.Text = "";

            string bookText = "";

            //Members report sorted by book order:
            foreach (DataRow drMember in DC.dtMember.Rows.Cast<DataRow>().OrderBy(row => row[1]))
            {
                DataRow[] drLoans= drMember.GetChildRows(DC.dtMember.ChildRelations["FK_Member_Loan"]);


                txtMembers.Text += "\r\n\r\n\r\nName: " + drMember["LastName"] + ", " + drMember["FirstName"] + "\r\n";
                txtMembers.Text += "Member ID:  " + drMember["MemberID"] + "\t\t\tMembership Type:" + " ";   //SuburbID needs to be converted to name of Suburb "Sururb"
                txtMembers.Text += drMember["MembershipType"] + "\t\tFine Due: $" + drMember["FineDue"] + "\r\n";
                txtMembers.Text += "Address: " + drMember["Street Address"] + ", " + drMember["SuburbID"] + "\t\tPhone Number: ";
                txtMembers.Text += drMember["PhoneNumber"] + "\t\tEmail:  " + drMember["EmailAddress"].ToString() + "\r\n\r\n";
                
                if (drLoans.Length == 0)
                {
                    txtMembers.Text += "No book loaned";
                    txtMembers.Text += " \r\n\r\n";
                }
                else
                {
                    txtMembers.Text += "Book loaned:\r\n";
                    
                    foreach (DataRow drLoan in drLoans)
                    {
                        DataRow drBook = drLoan.GetParentRow("Book_Loan");
                        txtMembers.Text += "\r\n";
                        txtMembers.Text += "Book Title: "+ drBook["Title"] + "\t\t";
                        DataRow drAuthor = drBook.GetParentRow("AuthorBook");
                        txtMembers.Text += "Author: " + drAuthor["LastName"] + ", " + drAuthor["FirstName"] + " ";
                        txtMembers.Text += "";

                    }
                }

                memberText += "\r\n\r\n";
                memberText = "";
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}






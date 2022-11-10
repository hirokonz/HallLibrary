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

    public partial class DeleteMemberForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager cmMember;
        private CurrencyManager cmLoan;
        private CurrencyManager cmFK_Member_Loan;
        private CurrencyManager cmSuburb;   



        public DeleteMemberForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            BindControls();
            frmMenu.Hide();
        }

        //public void BindControls()
        //{
        //    txtMemberID.DataBindings.Add("Text", DC.dsHall, "member.MemberID");
        //    txtLastName.DataBindings.Add("Text", DC.dsHall, "Member.LastName");
        //    txtFirstName.DataBindings.Add("Text", DC.dsHall, "Member.FirstName");
        //    dtpDateOfBirth.DataBindings.Add("Text", DC.dsHall, "Member.DateOfBirth");
        //    txtStreetAddress.DataBindings.Add("Text", DC.dsHall, "Member.Street Address");
        //    txtSuburb.DataBindings.Add("Text", DC.dsHall, "Member.SuburbID");
        //    txtPhoneNumber.DataBindings.Add("Text", DC.dsHall, "Member.PhoneNumber");
        //    cmMember = (CurrencyManager)this.BindingContext[DC.dsHall, "Member"];
        //    dgvMember.DataSource = DC.dsHall;
        //    dgvMember.DataMember = "Member";

        //    dgvLoan.DataSource = DC.dsHall;
        //    dgvLoan.DataMember = "Loan";

        //}

        public void BindControls()
        {
            cmMember = (CurrencyManager)this.BindingContext[DC.dsHall, "Member"];
            cmLoan = (CurrencyManager)this.BindingContext[DC.dsHall, "Loan"];
            cmFK_Member_Loan = (CurrencyManager)this.BindingContext[DC.dsHall, "Member.FK_Member_Loan"];

            dgvMember.DataSource = DC.dsHall;
            dgvMember.DataMember = "Member";

            dgvLoan.DataSource = DC.dsHall;
            dgvLoan.DataMember = "Member.FK_Member_Loan";
        }




        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }

        private void clearFields()
        {
            txtLastName.Text = "";
            txtFirstName.Text = "";
            txtStreetAddress.Text = "";
            //cboSuburbID.Text = "";
            txtPhoneNumber.Text = "";

        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {

            DataRow deleteMemberRow = DC.dtMember.Rows[cmMember.Position];
            DataRow[] drloan = deleteMemberRow.GetChildRows(DC.dtMember.ChildRelations["MemberLoan"]);
            if (drloan.Length == 0)

                deleteMemberRow.Delete();

            DC.UpdateMember();

            DialogResult dResult = MessageBox.Show("Member deleted successfully", "Acknowledgement", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
            if (dResult == DialogResult.OK)
            {
                MessageBox.Show("Delete another member?", "Acknowledgement", MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }

            clearFields();
        }
        private void dgvMembers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cmMember.Position != -1)
            {
                int aMemberID = Convert.ToInt32(dgvMember["MemberID", cmMember.Position].Value);
                cmMember.Position = DC.memberView.Find(aMemberID);
                DataRow drMember = DC.dtMember.Rows[cmMember.Position];
                txtMemberID.Text = drMember["MemberID"].ToString();
                txtLastName.Text = drMember["LastName"].ToString();
                txtFirstName.Text = drMember["FirstName"].ToString();
                dtpDateOfBirth.Text = drMember["DateOfBirth"].ToString();
                txtStreetAddress.Text = drMember["Street Address"].ToString();
                txtSuburb.Text = drMember["SuburbID"].ToString();
                txtPhoneNumber.Text = drMember["PhoneNumber"].ToString();


                
            }
        }


    }


}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace HallLibrary
{
    public partial class UpdateMemberForm : Form
    {
        private DataController DC;
        private DataController DC2;
        private MainForm frmMenu;
        private CurrencyManager cmMember;
        private CurrencyManager cmSuburb;   

        public UpdateMemberForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            BindControls();
            frmMenu.Hide();
        }

        private void UpdateMemberForm_Load(object sender, EventArgs e)
        {
            DisplaySuburbs();
            //LoadSuburbs();
        }

        public void DisplaySuburbs()
        {
            string suburbText = "";


            foreach (DataRow drSuburb in DC.dtSuburb.Rows)
            {
                suburbText += drSuburb["Suburb"];
            }
        }

        public void LoadSuburbs()
        {

            cboSuburbID.DataSource = DC.dsHall;
            cboSuburbID.DisplayMember = "Suburb.SuburbID";
            cboSuburb.DataSource = DC.dsHall;
            cboSuburb.DisplayMember = "suburb.Suburb";
            

        }

        public void BindControls()
        {
            txtMemberID.DataBindings.Add("Text", DC.dsHall, "Member.MemberID");
            txtLastName.DataBindings.Add("Text", DC.dsHall, "Member.LastName");
            txtFirstName.DataBindings.Add("Text", DC.dsHall, "Member.FirstName");
            dtpDateOfBirth.DataBindings.Add("Text", DC.dsHall, "Member.DateOfBirth");
            txtStreetAddress.DataBindings.Add("Text", DC. dsHall, "Member.Street Address");
            //txtSuburb.DataBindings.Add("Text", DC.dsHall, "Member.SuburbID"); //using dgv Members
            //LoadSuburbs();
            //cboSuburbID.SelectedIndex = cboSuburbID.Items.IndexOf(4);
            cboSuburbID.DataSource = DC.dsHall;
            cboSuburbID.DisplayMember = "Suburb.SuburbID";
            cboSuburb.DataSource = DC.dsHall;
            cboSuburb.DisplayMember = "suburb.Suburb";
            cboSuburbID.DataBindings.Add("Text", DC.dsHall, "Member.SuburbID");
            //cboSuburbID.Visible = false;

            // DataRow drSuburb = drMember.GetParentRow(DC.dtMember.ParentRelations["SuburbMember"]);
            txtEmailAddress.DataBindings.Add("Text", DC.dsHall, "Member.EmailAddress");
            txtPhoneNumber.DataBindings.Add("Text", DC.dsHall, "Member.PhoneNumber");
            nudFineDue.DataBindings.Add("Text", DC.dsHall, "Member.FineDue");
            cboMembershipType.DataBindings.Add("Text", DC.dsHall, "Member.MembershipType");
            cmMember = (CurrencyManager)this.BindingContext[DC.dsHall, "Member"];
            cmSuburb = (CurrencyManager)this.BindingContext[DC.dsHall, "Suburb"];
            dgvMembers.DataSource = DC.dsHall;
            dgvMembers.DataMember = "Member";
            //MessageBox.Show("value:" + txtSuburb.Text);
            //cboSuburbID.Text = txtSuburb.Text;
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
            //cboSuburb.Text = "";
            txtPhoneNumber.Text = "";
            cboMembershipType.Text = "";
            nudFineDue.Text = "";
            txtEmailAddress.Text = "";
        }

        private void btnUpdateMember_Click(object sender, EventArgs e)
        {
            if (txtLastName.Text == "" || txtFirstName.Text == "" || dtpDateOfBirth.Value == null || txtStreetAddress.Text == "" || txtEmailAddress.Text == "" || txtPhoneNumber.Text == "" || cboMembershipType.Text == "" || nudFineDue.Text == "")
            {
                MessageBox.Show("One or more fields is blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                DataRow updateMemberRow = DC.dtMember.NewRow();
                updateMemberRow["LastName"] = txtLastName.Text;                  //create a new department row
                updateMemberRow["FirstName"] = txtFirstName.Text;                // set FirstName for the new row
                updateMemberRow["Street Address"] = txtStreetAddress.Text;        // set Street Address for the new row
                updateMemberRow["SuburbID"] = cboSuburbID.Text;                   // set Suburb for the new row
                updateMemberRow["DateOfBirth"] = dtpDateOfBirth.Value;           // set DateOfBirthe for the new row
                updateMemberRow["PhoneNumber"] = txtPhoneNumber.Text;            // set Phone Numbers for the new row
                updateMemberRow["MembershipType"] = cboMembershipType.Text;      // set Membership Type for the new row
                updateMemberRow["FineDue"] = nudFineDue.Value;                   // set Fine Due for the new row
                updateMemberRow["EmailAddress"] = txtEmailAddress;               // set Email Address for the new row
                cmMember.EndCurrentEdit();
                DC.UpdateMember();
              
                DialogResult dResult = MessageBox.Show("Member updatead successfully", "Acknowledgement", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                if (dResult == DialogResult.OK)
                {
                    MessageBox.Show("update another member?", "Acknowledgement", MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                }

                clearFields();
            }
            
        }

        // private void txtEmailAddress_TextChanged(object sender, EventArgs e)

    }
}

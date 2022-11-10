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
    public partial class AddMemberForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;

        public AddMemberForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
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
            cboPostCode.DataSource = DC.dsHall;
            cboPostCode.DisplayMember = "suburb.PostCode";
        }

        private void AddMemberForm_Load(object sender, EventArgs e)
        {
            DisplaySuburbs();
            LoadSuburbs();
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
            cboSuburb.Text = "";
            txtPhoneNumber.Text = "";
            cboMembershipType.Text = "";
            nudFineDue.Text = "";
            txtEmailAddress.Text = "";
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            if (txtLastName.Text == "" || txtFirstName.Text == "" || dtpDateOfBirth.Value == null || txtStreetAddress.Text == "" || cboSuburb.Text == "" || txtEmailAddress.Text == "" || txtPhoneNumber.Text == "" || cboMembershipType.Text == "" || nudFineDue.Text == "")
            {
                MessageBox.Show("One or more fields is blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                DataRow newMemberRow = DC.dtMember.NewRow();
                newMemberRow["LastName"] = txtLastName.Text;                  //create a new department row
                newMemberRow["FirstName"] = txtFirstName.Text;                // set FirstName for the new row
                newMemberRow["Street Address"] = txtStreetAddress.Text;        // set Street Address for the new row
                newMemberRow["SuburbID"] = Int32.Parse(cboSuburbID.Text);      // set Suburb for the new row
                newMemberRow["DateOfBirth"] = dtpDateOfBirth.Value;           // set DateOfBirthe for the new row
                newMemberRow["PhoneNumber"] = txtPhoneNumber.Text;            // set Phone Numbers for the new row
                newMemberRow["MembershipType"] = cboMembershipType.Text;           // set Membership Type for the new row
                newMemberRow["FineDue"] = nudFineDue.Value;                   // set Fine Due for the new row
                newMemberRow["EmailAddress"] = txtEmailAddress.Text;               // set Email Address for the new row
                DC.dsHall.Tables["Member"].Rows.Add(newMemberRow);           // Add dataset table
                DC.UpdateMember();
                DisplaySuburbs();

                DialogResult dResult = MessageBox.Show("Member added successfully", "Acknowledgement", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                if (dResult == DialogResult.OK) {
                    MessageBox.Show("update another member?", "Acknowledgement", MessageBoxButtons.OK,
                                  MessageBoxIcon.Exclamation);
                }

                
            }

            clearFields();
        }


    }
}

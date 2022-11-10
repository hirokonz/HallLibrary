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
    public partial class AddBookForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;
        private CurrencyManager currencyManager;

        public AddBookForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
        }


        public void DisplayAuthors()
        {
            string authorText = "";


            foreach (DataRow drAuthor in DC.dtAuthor.Rows)
            {
                authorText += drAuthor["LastName"];
            }
        }

        public void LoadAuthor()
        {
            cboAuthorID.DataSource = DC.dsHall;
            cboAuthorID.DisplayMember = "Author.AuthorID";
            cboLastName.DataSource = DC.dsHall;
            cboLastName.DisplayMember = "Author.LastName";
            cboFirstName.DataSource = DC.dsHall;
            cboFirstName.DisplayMember = "Author.FirstName";
        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {
            DisplayAuthors();
            LoadAuthor();
        }

        private void clearFields()
        {
            txtTitle.Text = "";
            txtPage.Text = "";
            txtYearPublished.Text = "";
            cboStatus.Text = "";
            txtNotes.Text = "";
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == "" || txtPage.Text == "" || txtYearPublished.Text == "")
            {
                MessageBox.Show("One or more fields is blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                DataRow newBookRow = DC.dtBook.NewRow();                    //create a new title row
                newBookRow["Title"] = txtTitle.Text;                        //set a new title row
                newBookRow["Page"] = txtPage.Text;                          // set Page for the new row
                newBookRow["YearPublished"] = txtYearPublished.Text;        // set Year Published for the new row
                newBookRow["AuthorID"] = Int32.Parse(cboAuthorID.Text);     // set AUthorIDb for the new row
                newBookRow["Status"] = cboStatus.Text;
                newBookRow["Note"] = txtNotes.Text;                          // set DateOfBirthe for the new row
                DC.dsHall.Tables["Book"].Rows.Add(newBookRow);               // Add dataset table
                DC.UpdateBook();
                DisplayAuthors();

                DialogResult dResult = MessageBox.Show("Book added successfully", "Acknowledgement", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                if (dResult == DialogResult.OK)
                {
                    MessageBox.Show("update another book?", "Acknowledgement", MessageBoxButtons.OK,
                                  MessageBoxIcon.Exclamation);
                }

                clearFields();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }
    }
}
    


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HallLibrary
{
    public partial class BookReportForm : Form
    {
        private DataController DC;
        private MainForm frmMenu;

        public BookReportForm(DataController dc, MainForm mnu)
        {
            InitializeComponent();
            DC = dc;
            frmMenu = mnu;
            frmMenu.Hide();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu.Show();
        }

        private void btnBooksReport_Click(object sender, EventArgs e)
        {
            string bookText = "";
            txtBooks.Text = "";

            //Book report sorted by book order:
            foreach (DataRow drBook in DC.dtBook.Rows.Cast<DataRow>().OrderBy(row => row[1]))
            {
                DataRow drAuthor = drBook.GetParentRow(DC.dtBook.ParentRelations["AuthorBook"]);
                //MessageBox.Show(drAuthor["LastName"].ToString());
                //DataRow[] drAuthor = drBook.GetChildRows(DC.dtBook.ChildRelations["AuthorBook"]);
                //String msg = drAuthor[0].ToString();
                //MessageBox.Show(msg);
                bookText += "Title: " + drBook["Title"] + "\t\t\t\tBook ID: ";
                bookText+= drBook["BookID"] + "\t\t\tStatus:\t" + drBook["Status"];
                bookText += "\r\n\r\nAuthor: " + drAuthor["LastName"].ToString() + ", " + drAuthor["FirstName"].ToString();
                bookText += "\t\t\tYear Published: " + drBook["YearPublished"] + "\t\tNumber of Pages: \t";
                bookText += drBook["Page"] + "\r\n\r\r\n\rNote: ";
                bookText += drBook["Note"].ToString() + "\r\n";

                bookText += "----------------------------------------------------------------------------------------------------------------------- \r\n\r\n";
                txtBooks.Text += bookText;
                bookText = "";
            }
        }   
    }
}

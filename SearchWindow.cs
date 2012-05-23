using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Odbc;

namespace MajorEvaluator
{
    public partial class SearchWindow : Form
    {

        private String ID;
        private String lastName;
        private String firstName;
        private String dsnSource;

        public SearchWindow(MainWindow parent)
        {
            InitializeComponent();
            ID = null;
            firstName = null;
            lastName = null;
            dsnSource= parent.getDSNSource();
        }

        public String getId()
        {
            return ID;
        }

        public String getName()
        {
            return (this.lastName + ", " + this.firstName);
        }

        /* queries for all students (IDs, First names, last names)
         * whose ID numbers contain the values provided by the student W# field
         * in the current form. */
        private void button1_Click(object sender, System.EventArgs e)
        {
            //Refresh the listview.
            searchView.Items.Clear();
            string SearchTerm = searchField.Text;
            System.Data.Odbc.OdbcConnection connection = new System.Data.Odbc.OdbcConnection(dsnSource);
            
            try
            {
                connection.Open();
                System.Data.Odbc.OdbcCommand command = connection.CreateCommand();
                command.CommandText = "SELECT ID, FIRST_NAME, LAST_NAME FROM G_PERSON WHERE ID like '%" + SearchTerm + "%'";
                System.Data.Odbc.OdbcDataReader Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    String id = Reader["ID"].ToString();
                    String fname = Reader["FIRST_NAME"].ToString();
                    String lname = Reader["LAST_NAME"].ToString();
                    ListViewItem item = new ListViewItem(new[] { id, fname, lname });
                    searchView.Items.Add(item);

                }
                connection.Close();
            } catch (Exception s) {
                MessageBox.Show("Could not connect at this time. Please try again later.");
                MessageBox.Show(s.ToString());
            }
        }


        /* Clears the SearchWindow's listview everytime a user opens 
         * this form */
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            searchView.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (searchView.SelectedItems.Count > 0)
            {

                ListViewItem tempItem = searchView.SelectedItems[0];
                this.ID = tempItem.SubItems[0].Text;
                this.firstName = tempItem.SubItems[1].Text;
                this.lastName = tempItem.SubItems[2].Text;
                this.Close();
            }
            else
            {
                MessageBox.Show("Please select a student.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchWindow_Load(object sender, EventArgs e)
        {
            searchView.Items.Clear();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}

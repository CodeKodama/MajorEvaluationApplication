using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MajorEvaluator
{
    public partial class SearchWindow : Form
    {

        private String ID;
        private String lastName;
        private String firstName;

        public SearchWindow()
        {
            InitializeComponent();
            ID = null;
            firstName = null;
            lastName = null;
        }

        public String getId()
        {
            return ID;
        }

        public String getName()
        {
            return (this.lastName + ", " + this.firstName);
        }

        private void button1_Click(object sender, System.EventArgs e)
        {
            string SearchTerm = textBox1.Text;
            string MyConString = "SERVER=tcekle.com;" +
                "DATABASE=dummydb;" +
                "UID=remote;" +
                "PASSWORD=f3erePub;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = "select ID, FIRST_NAME, LAST_NAME from G_PERSON where ID like '%" + SearchTerm + "%'";
            connection.Open();
            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                String id = Reader["ID"].ToString();
                String fname = Reader["FIRST_NAME"].ToString();
                String lname = Reader["LAST_NAME"].ToString();
                ListViewItem item = new ListViewItem(new[] { id, fname, lname });
                listView1.Items.Add(item);
                //string[] row1 = { "s1", "s2", "s3" };
                //listView1.Items.Add("Column1Text").SubItems.AddRange(row1);
                //ListViewItem lv = new ListViewItem(fname);
                //lv.SubItems.Add(fname);
                //lv.SubItems.Add(lname);
                //listView1.Items.Add(lv);
            }
            connection.Close();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //First row of all selected entries.
            ListViewItem tempItem = listView1.SelectedItems[0];

            this.ID = tempItem.SubItems[0].Text;
            this.firstName = tempItem.SubItems[1].Text;
            this.lastName = tempItem.SubItems[2].Text;

            MessageBox.Show(tempItem.SubItems[1].Text);
            //tempItem = listView1.SelectedItems[0];
            //this.lastName = tempItem.Text;
           // ListViewItem item = listView1.SelectedItems[2];
           // this.firstName = tempItem.Text;

            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           // this.get
          //  setStudent("hello");
            
            this.Close();
        }

        private void SearchWindow_Load(object sender, EventArgs e)
        {

        }
    }
}

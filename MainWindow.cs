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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        /**Connect to the  dummy DB on click. Pull all entries from the
        /*'G_PERSON' and put them in the listbox*/
        private void button1_Click(object sender, System.EventArgs e)
        {
            string MyConString = "SERVER=tcekle.com;" +
                "DATABASE=dummydb;" +
                "UID=remote;" +
                "PASSWORD=f3erePub;";
            MySqlConnection connection = new MySqlConnection(MyConString);
            MySqlCommand command = connection.CreateCommand();
            MySqlDataReader Reader;
            command.CommandText = "select * from G_PERSON";
            connection.Open();
            Reader = command.ExecuteReader();
            while (Reader.Read())
            {
                string thisrow = "";
                for (int i = 0; i < Reader.FieldCount; i++)
                {
                    thisrow += Reader.GetValue(i).ToString() + ",";
                }
                listBox1.Items.Add(thisrow);
            }
            connection.Close();
        }
    }
}

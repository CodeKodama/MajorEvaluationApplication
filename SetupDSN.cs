using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace MajorEvaluation
{
    public partial class SetupDSN : Form
    {

        private MajorEvaluator.MainWindow main;
        private string dsnSource;


        public SetupDSN()
        {
            InitializeComponent();
            dsnSource = "";
        }

        public string getDSNSource()
        {
            return dsnSource;
        }

        /* Construct a connection string. If a user specifies their own connection 
         * string, the contents of the 'server', 'database', 'username', and 'password'
         * fields are disregarded. */
        private void DSNAccept_Click(object sender, EventArgs e)
        {
            dsnSource = "DSN=" + DSNOp.Text.ToString()  + ";";

            /*Try connection String, catch if string is improperly
             * formatted*/
            try
            {
                System.Data.Odbc.OdbcConnection connection = new System.Data.Odbc.OdbcConnection(dsnSource); 

                /*Try to connect with the provided MySqlConnection. If successful, launch
                 * The main application. If the connection fails to reach a source, catch 
                 * and produce an error message. */
                try
                {
                    connection.Open();
                    connection.Close();
                    main = new MajorEvaluator.MainWindow(this);
                    main.ShowDialog(this);
                    this.Close();

                }
                catch (Exception s)
                {
                    MessageBox.Show("Could not connect to server. Please try again.");
                    //MessageBox.Show(s.ToString());
                    DSNOp.Clear();
                }
            } catch (Exception s) {
                MessageBox.Show("Improper connection string.");
                //MessageBox.Show(s.ToString());
            }
        }

        private void CheckKeys(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                // Then Enter key was pressed
                DSNAccept_Click(sender, e);
            }
        }

    }
}

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
    public partial class ClassSubstitute : Form
    {

        private bool cancelled;

        public ClassSubstitute()
        {
            InitializeComponent();
            cancelled = true;

        }


        public bool isCancelled()
        {
            return cancelled;
        }

        public void setCancelled(bool setter)
        {
            cancelled = setter;
        }

        private void repCancelButton_Click(object sender, EventArgs e)
        {
            repSubject.Text = null;
            repNumber.Text = null;
            repCredits.Text = null;
            repUniversity.Text = null;
            cancelled = true;
            this.Close();
        }

        private void repSaveButton_Click(object sender, EventArgs e)
        {

            cancelled = false;
            this.Close();
        }

        public bool repReady()
        {
            int credits;
            bool creditsIsInt;
            creditsIsInt = int.TryParse(repCredits.Text.ToString(), out credits);
            if ((repSubject.Text.ToString() != "")
                && (repNumber.Text.ToString() != "")
                && (repUniversity.Text.ToString() != "")
                && (creditsIsInt))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public string getSubject()
        {
            return repSubject.Text.ToString();
        }

        public string getNumber()
        {
            return repNumber.Text.ToString();
        }

        public string getUniversity()
        {
            return repUniversity.Text.ToString();
        }

        public int getCredits()
        {
            string repCreditString = repCredits.Text.ToString();
            if (repCreditString == "")
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(repCreditString);
            }
        }

        public void clearFields()
        {
            repSubject.Text = null;
            repNumber.Text = null;
            repCredits.Text = null;
            repUniversity.Text = null;
            cancelled = true;

        }

    }
}

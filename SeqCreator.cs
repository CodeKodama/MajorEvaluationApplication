using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Newtonsoft.Json;

namespace MajorEvaluation
{
    public partial class SeqCreator : Form
    {
        public TreeNode mainNode;

        public SeqCreator()
        {
            InitializeComponent();
        }

        public void refresh()
        {
            seqView.Nodes.Clear();
            seqView.Refresh();
        }

        public void convertWithCompletes(SeqNode start)
        {
            refresh();
            foreach (SeqNode sRoot in start.getChildren())
            {
                TreeNode tRoot = new TreeNode();
                tRoot.Text = "" + sRoot.dept + " " + sRoot.courseNum;
                if (sRoot.complete == true)
                {
                    tRoot.ForeColor = Color.DarkGreen;
                    tRoot.Text += " (Complete)";
                }
                else
                {
                    tRoot.ForeColor = Color.DarkRed;
                    tRoot.Text += " (Incomplete)";
                }
                seqView.Nodes.Add(tRoot);
                convertWithCompletes(sRoot, tRoot);
            }
        }

        private void convertWithCompletes(SeqNode sParent, TreeNode tParent)
        {
            foreach (SeqNode sChild in sParent.getChildren())
            {
                TreeNode tChild = new TreeNode();
                tChild.Text = "" + sChild.dept + " " + sChild.courseNum;
                if (sChild.complete == true)
                {
                    tChild.ForeColor = Color.DarkGreen;
                    tChild.Text += " (Complete)";
                }
                else
                {
                    tChild.ForeColor = Color.DarkRed;
                    tChild.Text += " (Incomplete)";
                }
                tParent.Nodes.Add(tChild);
                convertWithCompletes(sChild, tChild);
            }
        }

        public void Convert(SeqNode start)
        {
            refresh();
            foreach (SeqNode sRoot in start.getChildren())
            {
                TreeNode tRoot = new TreeNode();
                tRoot.Text = "" + sRoot.dept + " " + sRoot.courseNum;
                seqView.Nodes.Add(tRoot);
                Convert(sRoot, tRoot);
            }
        }

        private void Convert(SeqNode sParent, TreeNode tParent)
        {
            foreach (SeqNode sChild in sParent.getChildren())
            {
                TreeNode tChild = new TreeNode();
                tChild.Text = "" + sChild.dept + " " + sChild.courseNum;
                tParent.Nodes.Add(tChild);
                Convert(sChild, tChild);
            }
        }


        private void doneButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

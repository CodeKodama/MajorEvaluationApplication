using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace MajorEvaluation
{
    public partial class Creator : Form
    {
        List<MajorEvaluation.ReqCourses> requirements = new List<ReqCourses>();
        TextWriter out_file;
        TextReader in_file;
        SeqNode seqRoot = new SeqNode();
        SeqCreator seqPreview = new SeqCreator();
        public Creator()
        {
            InitializeComponent();
            //sequence_creator = new SeqCreator();
            data.Columns[1].ValueType = typeof(Int32);
            data.Columns[2].ValueType = typeof(Int32);
            data.Columns[4].ValueType = typeof(Int32);
            data.Columns[5].ValueType = typeof(Int32);
            data.RowHeadersWidth = 100;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            make_list();
             
        }

        private bool make_list()
        {
            requirements.Clear();
            ReqCourses input;
            seqRoot = new SeqNode();
            int numrows;

            //MessageBox.Show(data.RowCount.ToString());
            if (data.RowCount == 1)
                numrows = 1;
            else
                numrows = data.RowCount-1;

            for (int ix = 0; ix < data.RowCount-1; ix++)
            {

                if (check_row(ix))
                {
                    List<int> tmp = new List<int>();

                    /*for (int ij = 6; ij < data.Columns.Count; ij++)
                    {
                        tmp.Add(Convert.ToInt32(data[ij, ix].Value));
                        MessageBox.Show("Testing: " + Convert.ToInt32(data[ij, ix].Value));
                        //MessageBox.Show(tmp[ij-6].ToString());
                    }*/

                    input = new ReqCourses(data[0, ix].Value.ToString(),
                        Convert.ToInt32(data[1, ix].Value),
                        Convert.ToInt32(data[2, ix].Value),
                        data[3, ix].Value.ToString(),
                        Convert.ToInt32(data[4, ix].Value),
                        Convert.ToInt32(data[5, ix].Value));


                    // Check to see if the class has already been added
                    bool already = false;
                    
                    for (int ij = 0; ij < requirements.Count; ij++)
                    {
                        if (requirements[ij].COURSE_NUM.Equals(input.COURSE_NUM)
                            && requirements[ij].DEPT.Equals(input.DEPT))
                        {
                            already = true;
                        }
                    }

                    if (!already)
                    {
                        if ((input.VALUE != 0) || (input.PAR_VALUE != 0))
                        {
                            SeqNode temp = new SeqNode(input.DEPT, input.COURSE_NUM, input.CREDITS, input.REQ_OR_ELEC, input.VALUE);
                            //MessageBox.Show("Succesfully Added node with value: " + input.VALUE);
                            seqRoot.addChild(input.PAR_VALUE, temp);
                        }
                        requirements.Add(input);
                    }
                    else
                    {
                        MessageBox.Show("There are duplicate classes!");
                    }
                }
                else
                {
                    return false;
                }
            }
 
            return true;
        }


        private bool check_row(int row)
        {

            //MessageBox.Show("" + data[0, row].ToString() + "" + Convert.ToInt32(data[1, row].Value));
            if (data[0, row].Value == null
                || data[1, row].Value == null
                || data[2, row].Value == null
                || data[3, row].Value == null)
            {
                return false;
            }
                

            //If the row potentially represents a node in the sequence.
            else if ((Convert.ToInt32(data[4, row].Value) != 0) || (Convert.ToInt32(data[5, row].Value) != 0))
            {
                //Root of sequence has value of 0. All new nodes of sequence must have value greater than 0.
                if (Convert.ToInt32(data[4, row].Value) == 0)
                {
                    MessageBox.Show("Row " + (row+1) + " does not contain a valid value (greater than 0) to construct a sequence. Please try again.");
                    return false;
                }
                //Check if value in row is already part of the sequence.
                if (seqRoot.nodeExists(Convert.ToInt32(data[4, row].Value)))
                {
                    MessageBox.Show("Row " + (row + 1) + " contains a value which already exists. Please try again.");
                    return false;
                }
                //If parent provided by the row doesn't exist in the sequence, the new node cannot be added.
                if (!seqRoot.nodeExists(Convert.ToInt32(data[5, row].Value)))
                {
                    MessageBox.Show("Row " + (row+1) + " contains a parent value which do not exist. Please try again.");
                    return false;
                }
                return true;
            }
            else
            {
                // Here's where to check the values eventually
                return true;
            }

        }

        // Be able to set the list of required classes in Creator outside Creator
        public List<MajorEvaluation.ReqCourses> Set_List(ReqCourses incoming)
        {
            requirements.Add(incoming);
            return requirements;
        }

        // Get the list from Creator of all the required classes outside Creator
        public List<MajorEvaluation.ReqCourses> Set_List()
        {
            return requirements;
        }

        //Creates new major evaluation. Previously opened filnames are disregarded.
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            requirements = new List<ReqCourses>();
            seqRoot = new SeqNode();
            data.Rows.Clear();
            seqPreview.refresh();
            open.FileName = "";
            save.FileName = "";
            seqCred.Clear();
            elecCred.Clear();
            uDivCred.Clear();
        }

        private void read_list()
        {
            seqRoot = new SeqNode();
            data.Rows.Clear();
            for (int ix = 0; ix < requirements.Count; ix++)
            {
                data.Rows.Add(requirements[ix].DEPT,
                    requirements[ix].COURSE_NUM,
                    requirements[ix].CREDITS,
                    requirements[ix].REQ_OR_ELEC,
                    requirements[ix].VALUE,
                    requirements[ix].PAR_VALUE);

                if ((requirements[ix].VALUE != 0) || (requirements[ix].PAR_VALUE != 0))
                {
                    SeqNode temp = new SeqNode(requirements[ix].DEPT, requirements[ix].COURSE_NUM,
                        requirements[ix].CREDITS, requirements[ix].REQ_OR_ELEC, requirements[ix].VALUE);
                    //MessageBox.Show("Succesfully Added node with value: " + requirements[ix].VALUE);
                    seqRoot.addChild(requirements[ix].PAR_VALUE, temp);
                }

            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.ShowDialog();
            if ((open.CheckFileExists) && (open.FileName != ""))
            {
                try {
                    in_file = new StreamReader(open.FileName);
                    uDivCred.Text = in_file.ReadLine();
                    elecCred.Text = in_file.ReadLine();
                    seqCred.Text = in_file.ReadLine();
                    requirements = (List<ReqCourses>)JsonConvert.DeserializeObject(in_file.ReadLine(), typeof(List<ReqCourses>));
                    read_list();
                    in_file.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Could not open the specified file. Please try again.");
                }
            }
            else
            {
                MessageBox.Show("No valid file was selected.");
            }
        }

        //Selected "Save As"
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (make_list())
            {
                save.ShowDialog();
                if (!save.FileName.Equals(""))
                {
                    out_file = new StreamWriter(save.FileName);
                    out_file.WriteLine(uDivCred.Text.ToString());
                    out_file.WriteLine(elecCred.Text.ToString());
                    out_file.WriteLine(seqCred.Text.ToString());
                    out_file.WriteLine(JsonConvert.SerializeObject(requirements).ToString());
                    out_file.Close();
                }
            }
        }

        // Add rows to datagrid
        private void data_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (data != null)
            {
                for (int count = 0; (count <= (data.Rows.Count - 2)); count++)
                {
                    data.Rows[count].HeaderCell.Value = (count+1).ToString();
                }
            }
        }

        private void add_class_group_Enter(object sender, EventArgs e)
        {
        }

        public void prevSeq_Click(object sender, EventArgs e)
        {
            //Only accessible if a sequence exists (constructed upon saving, opening).
            if (seqRoot.getChildren().Count == 0)
            {
                MessageBox.Show("Please save or open a major. The sequence preview will be generated for the most recently saved or opened major.");
            }
            else
            {
                seqPreview.Convert(seqRoot);
                seqPreview.ShowDialog(this);
            }
        }

        //Selected "Save".
        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (make_list())
            {
                //If a file has been opened, save over it.
                if (open.FileName != "")
                {
                    out_file = new StreamWriter(open.FileName);
                    //out_file.WriteLine(current_or.ToString());
                    out_file.WriteLine(uDivCred.Text.ToString());
                    out_file.WriteLine(elecCred.Text.ToString());
                    out_file.WriteLine(seqCred.Text.ToString());
                    out_file.WriteLine(JsonConvert.SerializeObject(requirements).ToString());
                    out_file.Close();
                }
                //If no file has been opened, save new file.
                else
                {
                    saveToolStripMenuItem_Click(sender, e);
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}

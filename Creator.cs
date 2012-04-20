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
        bool run_ands_ors = true;
        int and_lvl = 1;
        int or_lvl = 1;
        public Creator()
        {
            InitializeComponent();
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

        private void make_list()
        {
            requirements.Clear();
            ReqCourses input;
            int numrows;

            MessageBox.Show(data.RowCount.ToString());
            if (data.RowCount == 1)
                numrows = 1;
            else
                numrows = data.RowCount-1;

            for (int ix = 0; ix < data.RowCount-1; ix++)
            {
                
                if (check_row(ix))
                {
                    input = new ReqCourses(data[0, ix].Value.ToString(),
                        Convert.ToInt32(data[1, ix].Value),
                        Convert.ToInt32(data[2, ix].Value), 
                        data[3, ix].Value.ToString(),
                        Convert.ToInt32(data[4, ix].Value),
                        Convert.ToInt32(data[5, ix].Value));

                    // Check to see if the class has already been added
                    bool already = false;
                    for (int ij = 0; ij < requirements.Count; ij++)
                        if (requirements[ij].COURSE_NUM.Equals(input.COURSE_NUM)
                            && requirements[ij].DEPT.Equals(input.DEPT)) already = true;

                    if (!already) requirements.Add(input);
                    else MessageBox.Show("There are duplicate classes!");


                }
            }
            MessageBox.Show(JsonConvert.SerializeObject(requirements).ToString());
        }


        private bool check_row(int row)
        {
            // Should eventually check the data inside the columns as well
            //MessageBox.Show((data[0, row].Value == null).ToString());

            if (data[0, row].Value == null
                || data[1, row].Value == null
                || data[2, row].Value == null
                || data[3, row].Value == null) return false;
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

        private void add_class_Click(object sender, EventArgs e)
        {
            ReqCourses input = new ReqCourses(subject_box.Text, Convert.ToInt32(course_num_box.Text),
                    Convert.ToInt32(credits_box.Text), req_or_elec.Text,1,1);

            // Check to see if the class has already been added
            bool already = false;
            for (int ix = 0; ix < requirements.Count; ix++)
                if (requirements[ix].COURSE_NUM.Equals(input.COURSE_NUM) 
                    && requirements[ix].DEPT.Equals(input.DEPT)) already = true;

            if (!already) requirements.Add(input);
            else MessageBox.Show("Class has already been added!");
            
            // Update the GUI list
            update_req_list();
        }

        private void update_req_list()
        {
            req_list.Items.Clear();
            for (int i = 0; i < requirements.Count; i++)
            {
                ListViewItem item = new ListViewItem(new[] { requirements[i].DEPT.ToString(), 
                        requirements[i].COURSE_NUM.ToString(), requirements[i].CREDITS.ToString(), requirements[i].REQ_OR_ELEC.ToString()  });
                req_list.Items.Add(item);
            }

        }

        private void remove_Click(object sender, EventArgs e)
        {
            requirements.RemoveAt(req_list.SelectedIndices[0]);

            update_req_list();
        }

        private void set_and_or(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (run_ands_ors)
            {
                data[4, data.CurrentRow.Index].Value = 0;
                data[5, data.CurrentRow.Index].Value = 0;
            }
        
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("New isn't done yet!");
        }

        private void read_list()
        {
            run_ands_ors = false;
            data.Rows.Clear();
            for (int ix = 0; ix < requirements.Count; ix++)
            {
                data.Rows.Add(requirements[ix].DEPT,
                    requirements[ix].COURSE_NUM,
                    requirements[ix].CREDITS,
                    requirements[ix].REQ_OR_ELEC,
                    requirements[ix].AND,
                    requirements[ix].OR);

            }
            run_ands_ors = true;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open.ShowDialog();
            in_file = new StreamReader(open.FileName);
            requirements = (List<ReqCourses>)JsonConvert.DeserializeObject(in_file.ReadLine(), typeof(List<ReqCourses>));
            MessageBox.Show(JsonConvert.SerializeObject(requirements).ToString());
            read_list();
            in_file.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            make_list();
            save.ShowDialog();
            if (!save.FileName.Equals(""))
            {
                out_file = new StreamWriter(save.FileName);
                out_file.WriteLine(JsonConvert.SerializeObject(requirements).ToString());
                out_file.Close();
            }
        }

        private void and_button_Click(object sender, EventArgs e)
        {
            if (data.SelectedRows.Count > 1)
            {
                for (int row = 0; row < data.SelectedRows.Count; row++)
                    data[4, data.SelectedRows[row].Index].Value = and_lvl;
                and_lvl++;
            }
            else MessageBox.Show("Please select at least two rows!");
        }

        private void or_button_Click(object sender, EventArgs e)
        {
            if (data.SelectedRows.Count > 1)
            {
                for (int row = 0; row < data.SelectedRows.Count; row++)
                    data[5, data.SelectedRows[row].Index].Value = or_lvl;
                or_lvl++;
            }
            else MessageBox.Show("Please select at least two rows!");
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


    }
}

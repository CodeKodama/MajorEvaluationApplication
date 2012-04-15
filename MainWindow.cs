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
        private string ID;
        private SearchWindow newWindow;
        private CourseList studentCourseList;
        private EvalList majorCourseList;

        public MainWindow()
        {
            InitializeComponent();
            newWindow = new SearchWindow();
        }

        public void setStudent(string ID)
        {
            this.button1.Text = ID;
        }


        /**Connect to the  dummy DB on click. Pull all entries from the
        /*'G_PERSON' and put them in the listbox*/
        private void button1_Click(object sender, System.EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(ThreadProc));
            //t.Start(this);
            newWindow.ShowDialog(this);
            String studentName = newWindow.getName();
            String studentID = newWindow.getId();
            if (studentID != null)
            {
                groupBox1.Text = studentName;

                //Overwrite the previous student course list
                this.studentCourseList = new CourseList();
                
                string MyConString = "SERVER=tcekle.com;" +
                    "DATABASE=dummydb;" +
                    "UID=remote;" +
                    "PASSWORD=f3erePub;";
                MySqlConnection connection = new MySqlConnection(MyConString);
                MySqlCommand command = connection.CreateCommand();
                MySqlDataReader Reader;
                command.CommandText = "select * from S_HIST_DETAIL where ID = '" + studentID + "'";
                connection.Open();
                Reader = command.ExecuteReader();
                while (Reader.Read())
                {
                    

                    //Not sure if 'SUBJECT' or 'DEPT' fields give the correct course
                    //category (i.e. MATH, CSCI, PHIL, PSYCH, etc)
                    String courseSubject = Reader["SUBJECT"].ToString();

                    String courseNumber = Reader["COURSE_NUMBER"].ToString();
                    String CRN = Reader["CRN"].ToString();
                    Double gpa = Reader.GetDouble("DECIMAL_GRADE");
                    String term = Reader["TERM"].ToString();
                  

                    Course currCourse = new Course(CRN, courseNumber, gpa, courseSubject, term);
                    studentCourseList.add(currCourse);

                    //We can test the contents of our cours list by adding them to the listview
                    ListViewItem item2 = new ListViewItem(new[] { (courseSubject + courseNumber), 
                        CRN, gpa.ToString(), term, "none", "complete"  });

                    listView1.Items.Add(item2);
                }
                connection.Close();




                MessageBox.Show(studentID);
            }
        }
    }
}

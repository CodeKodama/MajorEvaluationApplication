using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System.IO;

namespace MajorEvaluator
{

    public partial class MainWindow : Form
    {
        private SearchWindow searchWindow;
        private MajorEvaluation.Creator reqWindow;
        private List<Course> studentCourseList;
        private EvalList majEval;
        private TextReader inFileMajor;
        List<MajorEvaluation.ReqCourses> requirements;
 
        public MainWindow()
        {
            InitializeComponent();
            searchWindow = new SearchWindow();
            reqWindow = new MajorEvaluation.Creator();
            setMajorName("");
            studentCourseList = new List<Course>();
            majEval = new EvalList();
        }

        public void setStudent(string studentID, string name)
        {
            currStudent.Text = name + ": " + studentID;
        }


        //Populate evalView with with the current evaluation.
        private void updateListView()
        {
            evalView.Items.Clear();
            
            //Proposed way to get all sequences.
            //List<EvalSeq> evalSequences = majEval.getEvalSeqs();

            List<Eval> evals = majEval.getEvals();
            ListViewItem evalItem;


            //Core classes, not in sequences.
            foreach (Eval e in evals)
            {
                String course = e.getSubject() + " " + e.getNumber();
                String credits = e.getCredits().ToString();
                String gpa = e.getGpa().ToString();
                String type = e.getCreditType();

                String repSchool = e.getReplaceSchool();
                if (repSchool == null)
                {
                    repSchool = "N/A";
                }

                String repName = e.getReplaceSubject();
                if (repName == null)
                {
                    repName = "";
                }

                String repNumber = e.getReplaceNumber();
                if (repNumber == null)
                {
                    repNumber = "";
                }

                String repCredits = e.getReplaceCredits().ToString();

                if (e.isComplete())
                {
                    evalItem = new ListViewItem(new[] { course, credits,
                    gpa, type, repSchool + " " + repName + " " + repNumber, repCredits, "Complete"});
                    evalItem.ForeColor = Color.DarkGreen;
                }
                else
                {
                    evalItem = new ListViewItem(new[] { course, credits,
                    gpa, type, repSchool + " " + repName + " " + repNumber, repCredits, "Incomplete"});
                    evalItem.ForeColor = Color.DarkRed;
                }

                evalView.Items.Add(evalItem);


            }

            //Proposed way to parse through sequences.
            //foreach (EvalSeq es in evalSequences)
           // {
           // }


        }

        
        //Build an evaluation structure.
        private void buildMajorEvaluation()
        {
            evalView.Items.Clear();
            bool found;
            

            //Parse through each requirement from the JSON file
            for (int i = 0; i < requirements.Count; i++)
            {
                found = false;
                ListViewItem evalItem = null;

                //Parse through each course taken by student
                foreach (Course c in studentCourseList)
                {

                    //If the student has taken the current requirement, record as complete.
                    if ((requirements[i].DEPT == c.getSubject()) &&
                        (requirements[i].COURSE_NUM.ToString() == c.getNumber()))
                    {
                        Eval newEval = new Eval();
                        newEval.setComplete(true);
                        newEval.setCredits(requirements[i].CREDITS);
                        newEval.setCreditType(requirements[i].REQ_OR_ELEC);
                        newEval.setGpa(c.getGpa());
                        newEval.setSubject(requirements[i].DEPT);
                        newEval.setNumber(requirements[i].COURSE_NUM.ToString());

                        //NOTE: I removed all conditionals related to sequences.

                        //If OR sequence, record.
                       /* if ((requirements[i].AND != 0) || (requirements[i].OR != 0))
                        {
                            //majEval.addEvalSeq(newEval, requirements[i].AND, requirements[i].OR);
                        }
                        //If not part of a sequence, record.
                        else
                        {*/
                            majEval.addEval(newEval);
                        //}   

                        found = true;
                    }
                }
                //}

                //If the student has not taken the required class, record as incomplete.
                if (!found)
                {
                    Eval newEval = new Eval();
                    newEval.setComplete(false);
                    newEval.setCredits(requirements[i].CREDITS);
                    newEval.setCreditType(requirements[i].REQ_OR_ELEC);
                    //newEval.setGpa(0);
                    newEval.setSubject(requirements[i].DEPT);
                    newEval.setNumber(requirements[i].COURSE_NUM.ToString());
                    

                    //NOTE: I removed all conditionals related to sequences.

                    //If AND Sequence, record.
                   /* if (requirements[i].AND != 0)
                    {
                       //majEval.addToEvalSeq(newEval, requirements[i].AND, "AND");
                    }
                    //If OR sequence, record
                    else if (requirements[i].OR != 0)
                    {
                       // majEval.addToEvalSeq(newEval, requirements[i].OR, "OR");
                    }
                    //If not part of a sequence, record.
                    else
                    {*/
                        majEval.addEval(newEval);
                   // }
                }
                found = false;
            }
            updateListView();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void classSubstituteButton_Click(object sender, EventArgs e)
        {

        }

        private void reqChangeButton_Click(object sender, EventArgs e)
        {
            reqWindow.ShowDialog(this);
            //reqList = reqWindow.Set_List();
            //buildMajorRequirements();

        }

        private void evalPreviewButton_Click(object sender, EventArgs e)
        {

        }

        private void evalPrintButton_Click(object sender, EventArgs e)
        {

        }

        private void setMajorName(String name)
        {
            majorName.Text = "Major: " + name;
        }

        private void studentSelectionButton_Click(object sender, EventArgs e)
        {

            searchWindow.ShowDialog(this);
            String studentName = searchWindow.getName();
            String studentID = searchWindow.getId();
            if (studentID != null)
            {

                setStudent(studentID, studentName);

                //Overwrite the previous student course list
                this.studentCourseList = new List<Course>();

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
                    studentCourseList.Add(currCourse);
 
                }
                connection.Close();

                if (majEval.size() > 0)
                {
                    buildMajorEvaluation();
                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openEvaluation_Click(object sender, EventArgs e)
        {
          
        }

        private void openMajorJSONFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openMajor.ShowDialog();
            if (openMajor.FileName != "")
            {
                inFileMajor = new StreamReader(openMajor.FileName);
                requirements = (List<MajorEvaluation.ReqCourses>)JsonConvert.DeserializeObject(inFileMajor.ReadLine(), typeof(List<MajorEvaluation.ReqCourses>));
                MessageBox.Show(JsonConvert.SerializeObject(requirements).ToString());
                setMajorName(Path.GetFileNameWithoutExtension(openMajor.FileName));
                buildMajorEvaluation();
                inFileMajor.Close();
            }

        }

        private void evalView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

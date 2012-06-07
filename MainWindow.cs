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
        private MajorEvaluation.SetupDSN connectWindow;
        private String dsnSource;
        private MajorEvaluation.SeqNode seqRoot;
        private MajorEvaluation.SeqCreator seqWindow;
        private MajorEvaluation.ClassSubstitute subWindow;
        private int reqUDivCreds;
        private int reqElecCreds;
        private int reqSeqCreds;
        private int reqTotCreds;
        private int actualUDivCreds;
        private int actualElecCreds;
        private int actualSeqCreds;
        private int actualTotCreds;
       
 
        public MainWindow(MajorEvaluation.SetupDSN parent)
        {
            InitializeComponent();
            reqWindow = new MajorEvaluation.Creator();
            studentCourseList = new List<Course>();
            majEval = new EvalList();
            connectWindow = parent;
            dsnSource = connectWindow.getDSNSource();
            searchWindow = new SearchWindow(this);
            seqWindow = new MajorEvaluation.SeqCreator();
            subWindow = new MajorEvaluation.ClassSubstitute();
            reqUDivCreds = 0;
            reqElecCreds = 0;
            reqSeqCreds = 0;
            reqTotCreds = 0;
            actualUDivCreds = 0;
            actualElecCreds = 0;
            actualSeqCreds = 0;
            actualTotCreds = 0;
        }

        public String getDSNSource()
        {
            return dsnSource;
        }

        public void updateCreditInfo()
        {
            uDivCreds.Text = "Upper Division Credits:  " + actualUDivCreds + " / " + reqUDivCreds;
            elecCreds.Text = "Elective Credits:  " + actualElecCreds + " / " + reqElecCreds;
            seqCreds.Text = "Math/Sci Credits:  " + actualSeqCreds + " / " + reqSeqCreds;
            if (actualUDivCreds >= reqUDivCreds)
            {
                uDivCreds.ForeColor = Color.DarkGreen;
            }
            else
            {
                uDivCreds.ForeColor = Color.DarkRed;
            }

            elecCreds.Text = "Elective Credits:  " + actualElecCreds + " / " + reqElecCreds;
            if (actualElecCreds >= reqElecCreds)
            {
                elecCreds.ForeColor = Color.DarkGreen;
            }
            else
            {
                elecCreds.ForeColor = Color.DarkRed;
            }

            seqCreds.Text = "Sequence Credits:  " + actualSeqCreds + " / " + reqSeqCreds;
            if (actualSeqCreds >= reqSeqCreds)
            {
                seqCreds.ForeColor = Color.DarkGreen;
            }
            else
            {
                seqCreds.ForeColor = Color.DarkRed;
            }
        }

        public void updateActualCredits(int uDiv, int elec, int seq)
        {
            actualUDivCreds = uDiv;
            actualElecCreds = elec;
            actualSeqCreds = seq;
            updateCreditInfo();

        }

        public void updateRequiredCredits(int uDiv, int elec, int seq)
        {
            reqUDivCreds = uDiv;
            reqElecCreds = elec;
            reqSeqCreds = seq;
            updateCreditInfo();
        }


        public void setStudent(string studentID, string name)
        {
            studentInfo.Text = name + ": " + studentID;
            studentInfo.ForeColor = Color.DarkBlue;
        }


        //Populate evalView with with the current evaluation.
        private void updateListView()
        {
            evalView.Items.Clear();
            
            /* Later,  get all sequences as well. Might look like:
            List<EvalSeq> evalSequences = majEval.getEvalSeqs();*/

            List<Eval> evals = majEval.getEvals();
            ListViewItem evalItem;


            //Core classes, not in sequences.
            foreach (Eval e in evals)
            {
                String course = e.getSubject() + " " + e.getNumber();
                String credits = e.getCredits().ToString();
                String gpa = e.getGpa().ToString();
                String type = e.getCreditType();
                String seq = e.getSequence();

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
                    gpa, type, repSchool + ", " + repName + " " + repNumber, repCredits, "Complete", seq});
                    evalItem.ForeColor = Color.DarkGreen;
                }
                else
                {
                    evalItem = new ListViewItem(new[] { course, credits,
                    gpa, type, repSchool + " " + repName + " " + repNumber, repCredits, "Incomplete", seq});
                    evalItem.ForeColor = Color.DarkRed;
                }

                evalView.Items.Add(evalItem);
            }

           /*Later, parse through sequences here*/
        }


        private void parseSequence(MajorEvaluation.SeqNode sNode)
        {
            /*foreach (MajorEvaluation.SeqNode child in sNode.getChildren())
            {

                String course = child.dept + " " + child.courseNum;
                String credits = child.credits.ToString();
                String gpa = child.gpa.ToString();
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
                    gpa, type, repSchool + " " + repName + " " + repNumber, repCredits, "Complete", "No"});
                    evalItem.ForeColor = Color.DarkGreen;
                }
                else
                {
                    evalItem = new ListViewItem(new[] { course, credits,
                    gpa, type, repSchool + " " + repName + " " + repNumber, repCredits, "Incomplete", "No"});
                    evalItem.ForeColor = Color.DarkRed;
                }

                evalView.Items.Add(evalItem);



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
            }*/
        }
        
        //Build an evaluation structure.
        private void buildMajorEvaluation()
        {
            updateActualCredits(0, 0, 0);
            evalView.Items.Clear();
            majEval = new EvalList();
            seqRoot = new MajorEvaluation.SeqNode();
            bool found;
            

            //Parse through each requirement from the JSON file
            for (int i = 0; i < requirements.Count; i++)
            {
                found = false;

                //Parse through each course taken by student
                foreach (Course c in studentCourseList)
                {

                    //If the student has taken the current requirement, record as complete.
                    if ((requirements[i].DEPT == c.getSubject()) &&
                        (requirements[i].COURSE_NUM.ToString() == c.getNumber()))
                    {
                        //If the class taken is an elective, add to elective count.
                        if (requirements[i].REQ_OR_ELEC == "E")
                        {
                            actualElecCreds += requirements[i].CREDITS;
                        }

                        if ((requirements[i].DEPT == "M/CS") || (requirements[i].DEPT == "MATH"))
                        {
                            actualSeqCreds += requirements[i].CREDITS;
                        }

                        if ((requirements[i].DEPT == "GEOL") || (requirements[i].DEPT == "BIOL") || (requirements[i].DEPT == "CHEM") || (requirements[i].DEPT == "PHYS"))
                        {
                            actualSeqCreds += requirements[i].CREDITS;
                        }


                        //IF the class is upper division, add to uDivision count.
                        if (requirements[i].COURSE_NUM >= 300)
                        {
                            actualUDivCreds += requirements[i].CREDITS;
                        }


                        //For sequences:
                        if ((requirements[i].VALUE != 0) || (requirements[i].PAR_VALUE != 0))
                        {
                            MajorEvaluation.SeqNode temp = new MajorEvaluation.SeqNode(requirements[i].DEPT, requirements[i].COURSE_NUM,
                                requirements[i].CREDITS, requirements[i].REQ_OR_ELEC, requirements[i].VALUE);
                            temp.complete = true;
                            //MessageBox.Show("Succesfully Added node with value: " + requirements[i].VALUE);
                            seqRoot.addChild(requirements[i].PAR_VALUE, temp);

                            Eval newEval = new Eval();
                            newEval.setComplete(true);
                            newEval.setSequence("Yes");
                            newEval.setCredits(requirements[i].CREDITS);
                            newEval.setCreditType(requirements[i].REQ_OR_ELEC);
                            newEval.setGpa(c.getGpa());
                            newEval.setSubject(requirements[i].DEPT);
                            newEval.setNumber(requirements[i].COURSE_NUM.ToString());
                            majEval.addEval(newEval);

                        }
                        //For Individual Classes:
                        else
                        {
                            Eval newEval = new Eval();
                            newEval.setComplete(true);
                            newEval.setCredits(requirements[i].CREDITS);
                            newEval.setCreditType(requirements[i].REQ_OR_ELEC);
                            newEval.setGpa(c.getGpa());
                            newEval.setSubject(requirements[i].DEPT);
                            newEval.setNumber(requirements[i].COURSE_NUM.ToString());
                            majEval.addEval(newEval);
                        }


                        found = true;

                        /*Later, setup conditional to test for sequences. If the class is in a sequence,
                        * record for the sequence here.*/
                    }
                }
                

                //If the student has not taken the required class, record as incomplete.
                if (!found)
                {

                    //For sequences:
                    if ((requirements[i].VALUE != 0) || (requirements[i].PAR_VALUE != 0))
                    {
                        MajorEvaluation.SeqNode temp = new MajorEvaluation.SeqNode(requirements[i].DEPT, requirements[i].COURSE_NUM,
                            requirements[i].CREDITS, requirements[i].REQ_OR_ELEC, requirements[i].VALUE);
                        //MessageBox.Show("Succesfully Added node with value: " + requirements[i].VALUE);
                        seqRoot.addChild(requirements[i].PAR_VALUE, temp);

                        Eval newEval = new Eval();
                        newEval.setSequence("Yes");
                        newEval.setComplete(false);
                        newEval.setCredits(requirements[i].CREDITS);
                        newEval.setCreditType(requirements[i].REQ_OR_ELEC);
                        newEval.setSubject(requirements[i].DEPT);
                        newEval.setNumber(requirements[i].COURSE_NUM.ToString());
                        majEval.addEval(newEval);

                    }
                        //For individual classes:
                    else
                    {
                        Eval newEval = new Eval();
                        newEval.setComplete(false);
                        newEval.setCredits(requirements[i].CREDITS);
                        newEval.setCreditType(requirements[i].REQ_OR_ELEC);
                        newEval.setSubject(requirements[i].DEPT);
                        newEval.setNumber(requirements[i].COURSE_NUM.ToString());
                        majEval.addEval(newEval);
                    }
                }
                found = false;
            }
            updateListView();
            updateCreditInfo();
        }

        private void button1_Click(object sender, System.EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void classSubstituteButton_Click(object sender, EventArgs e)
        {

           // ListViewItem tempItem = searchView.SelectedItems[0];
            //this.ID = tempItem.SubItems[0].Text;
            //this.firstName = tempItem.SubItems[1].Text;
            //this.lastName = tempItem.SubItems[2].Text;


            if (studentCourseList.Count == 0)
            {
                MessageBox.Show("Please select a student.");
            }
            else if (majEval.evals.Count == 0)
            {
                MessageBox.Show("Please open a major. Sequences are generated from a valid JSON file.");
            }
            else if (evalView.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a class to replace.");
            }
            else
            {
                ListViewItem tempItem = evalView.SelectedItems[0];
                string selectedCourse = tempItem.SubItems[0].Text;
                subWindow.ShowDialog(this);
                if (subWindow.isCancelled() == false)
                {
                    if (subWindow.repReady())
                    {
                        MessageBox.Show("" + selectedCourse);
                        foreach (Eval thisEval in majEval.evals)
                        {
                            if (String.Equals((thisEval.getSubject() + " " + thisEval.getNumber()), selectedCourse))
                            {
                                MessageBox.Show("found it");
                                String repSubject = subWindow.getSubject();
                                String repNumber = subWindow.getNumber();
                                String repUniversity = subWindow.getUniversity();
                                int repCredits = subWindow.getCredits();
                                thisEval.setReplaceSchool(repUniversity);
                                thisEval.setReplaceCredits(repCredits);
                                thisEval.setReplaceNumber(repNumber);
                                thisEval.setReplaceSubject(repSubject);
                                thisEval.setComplete(true);
                                seqRoot.setComplete(thisEval.getSubject(), thisEval.getNumber());
                                if (thisEval.getCreditType() == "E")
                                {
                                    actualElecCreds += repCredits;
                                }
                                else if (Convert.ToInt32(repNumber) >= 300)
                                {
                                    actualUDivCreds += repCredits;
                                }

                                if ((thisEval.getSubject() == "MATH") || (thisEval.getSubject() == "M/CS"))
                                {
                                    actualSeqCreds += repCredits;
                                }

                                if ((thisEval.getSubject() == "GEOL") || (thisEval.getSubject() == "PHYS") || (thisEval.getSubject() == "BIOL") || (thisEval.getSubject() == "CHEM"))
                                {
                                    actualSeqCreds += repCredits;
                                }
                            }
                        }
                        updateCreditInfo();
                        updateListView();
                    }
                    else
                    {
                        MessageBox.Show("Invalid substituion input. Please try again.");
                    }
                }
            }
            subWindow.clearFields();
        }

        private void reqChangeButton_Click(object sender, EventArgs e)
        {
            reqWindow.ShowDialog(this);
        }

        private void evalPreviewButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry, not yet available!");
        }

        private void evalPrintButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry, not yet available!");
        }

        private void setMajorName(String name)
        {
            majorName.Text = name;
            majorName.ForeColor = Color.DarkBlue;
        }

        
        /*Queries the database for all the classes the currently selected student has taken. 
         * Then, it constructs a List containing 'Course' objects which represent each course 
         * the student has completed*/
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

                System.Data.Odbc.OdbcConnection connection = new System.Data.Odbc.OdbcConnection(dsnSource); 
                System.Data.Odbc.OdbcCommand command = connection.CreateCommand();
                System.Data.Odbc.OdbcDataReader Reader;
                command.CommandText = "select * from S_HIST_DETAIL where ID = '" + studentID + "'";
                try
                {
                    connection.Open();
                    Reader = command.ExecuteReader();
                    while (Reader.Read())
                    {

                        String courseSubject = Reader["SUBJECT"].ToString();
                        String courseNumber = Reader["COURSE_NUMBER"].ToString();
                        String CRN = Reader["CRN"].ToString();
                        Double gpa = Convert.ToDouble(Reader["DECIMAL_GRADE"]);
                        String term = Reader["TERM"].ToString();
                        Course currCourse = new Course(CRN, courseNumber, gpa, courseSubject, term);
                        studentCourseList.Add(currCourse);

                    }
                    connection.Close();
                }
                catch (Exception s)
                {
                    MessageBox.Show("There was a connection problem. Please try again later");
                    MessageBox.Show(s.ToString());
                }

                if (majEval.size() > 0)
                {
                    buildMajorEvaluation();
                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry, not yet available!");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry, not yet available!");
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry, not yet available!");
        }

        private void openEvaluation_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry, not yet available!");
        }

        //Open saved major requirements from a valid JSON file.
        private void openMajorJSONFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openMajor.FileName = "";
            openMajor.ShowDialog(this);
  
            if ((openMajor.CheckFileExists) && (openMajor.FileName != ""))
            {
                try
                {
                    inFileMajor = new StreamReader(openMajor.FileName);
                    int udiv = Convert.ToInt32(inFileMajor.ReadLine());
                    int elec = Convert.ToInt32(inFileMajor.ReadLine());
                    int seq = Convert.ToInt32(inFileMajor.ReadLine());
                    updateRequiredCredits(udiv, elec, seq);
                    requirements = (List<MajorEvaluation.ReqCourses>)JsonConvert.DeserializeObject(inFileMajor.ReadLine(), typeof(List<MajorEvaluation.ReqCourses>));
                    setMajorName(Path.GetFileNameWithoutExtension(openMajor.FileName));
                    buildMajorEvaluation();
                    inFileMajor.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("Could not open the specified file. Please try again.");
                }
            }
            else
            {
                MessageBox.Show("No file was selected.");
            }
        }

        private void evalView_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void newEvaluation_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry, not yet available!");
        }

        private void saveEvaluation_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry, not yet available!");
        }

        private void sequenceButton_Click(object sender, EventArgs e)
        {
            if (majEval.evals.Count == 0)
            {
                MessageBox.Show("Please open a major. Sequences are generated from a valid JSON file.");
            }
            else
            {
                seqWindow.convertWithCompletes(seqRoot);
                seqWindow.ShowDialog(this);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void seqCreds_Click(object sender, EventArgs e)
        {

        }
    }
}

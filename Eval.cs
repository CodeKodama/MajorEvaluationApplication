using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MajorEvaluator
{
    class Eval
    {
        
        private int CRN, courseNumber;
        private double gpa;
        private string courseName;
        private Boolean complete;
        
        /*Constructor sets each course's
        /*members to default values, subject 
        /*to change.*/
        public Eval(){
            CRN = 0;
            courseNumber = 0;
            gpa = 0.0;
            courseName = null;
            complete = false;
        }

        public Boolean isComplete()
        {
            return complete;
        }

        public void setBoolean(Boolean complete)
        {
            this.complete = complete;
        }

        public int getCRN()
        {
            return CRN;
        }
        
        public void setCRN(int CRN)
        {
            this.CRN = CRN;
        }

        public double getGpa()
        {
            return gpa;
        }

        public void setGpa(double gpa)
        {
            this.gpa = gpa;
        }

        public string getCourseName()
        {
            return courseName;
        }

        public void setCourseName(string courseName)
        {
            this.courseName = courseName;
        }

        public int getCourseNumber()
        {
            return courseNumber;
        }

        public void setCourseNumber(int courseNumber)
        {
            this.courseNumber = courseNumber;
        }
    }
}

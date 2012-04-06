using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MajorEvaluationApplication
{
    class Course
    {
        private int CRN, courseNumber;
        private double gpa;
        private string courseName;
        
        /*Construtor sets each course's
        /*members to default values, subject 
        /*to change.*/
        public Course(){
            CRN = 0;
            courseNumber = 0;
            gpa = 0.0;
            courseName = null;
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

        public void setGpa(double Gpa)
        {
            this.gpa = CRN;
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

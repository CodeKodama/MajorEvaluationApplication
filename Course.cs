using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MajorEvaluator
{
    class Course
    {

        private string CRN, subject, number, term;
        private double gpa;
        private int credits;
        private Boolean complete;
        
        /*Constructor sets each course's
        /*members to default values, subject 
        /*to change.*/
        public Course(){
            CRN = null;
            subject = null;
            gpa = 0.0;
            number = null;
            term = null;
        }

        public Course(string CRN, string courseNumber, double gpa, string courseSubject, string term)
        {
            this.term = term;
            this.CRN = CRN;
            this.number = courseNumber;
            this.gpa = gpa;
            this.subject = courseSubject;
        }

        public string getTerm()
        {
            return term;
        }

        public void setTerm(string term)
        {
            this.term = term;
        }

        public string getCRN()
        {
            return CRN;
        }
        
        public void setCRN(string CRN)
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

        public string getSubject()
        {
            return subject;
        }

        public void setSubject(string courseSubject)
        {
            this.subject = courseSubject;
        }

        public string getNumber()
        {
            return number;
        }

        public void setNumber(string courseNumber)
        {
            this.number = courseNumber;
        }
    }
}

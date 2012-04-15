using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MajorEvaluator
{
    class Eval
    {

        private string CRN, subject, number;
        private double gpa;
        private int credits;
        private Boolean complete;
        
        /*Constructor sets each course's
        /*members to default values, subject 
        /*to change.*/
        public Eval(){
            CRN = null;
            number = null;
            gpa = 0.0;
            subject = null;
            complete = false;
            credits = 0;
        }

        public Boolean isComplete()
        {
            return complete;
        }

        public void setComplete(Boolean complete)
        {
            this.complete = complete;
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

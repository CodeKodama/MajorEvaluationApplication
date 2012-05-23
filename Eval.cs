using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MajorEvaluator
{
    class Eval
    {

        private string subject, number, creditType, sequence, 
            replaceSchool, replaceSubject, replaceNumber;
        private double gpa;
        private int credits, replaceCredits;
        private Boolean complete;
       
        
        
        /*Constructor sets each course's
        /*members to default values, subject 
        /*to change.*/
        public Eval(){
            number = null;
            gpa = 0.0;
            subject = null;
            creditType = null;
            complete = false;
            credits = 0;
            sequence = "No";
            replaceSchool = null;
            replaceNumber = null;
            replaceSubject = null;
            replaceCredits = 0;
        }

        public void setSequence(String sequence)
        {
            this.sequence = sequence;
        }

        public string getSequence()
        {
            return sequence;
        }

        public string getReplaceSchool()
        {
            return replaceSchool;
        }

        public int getReplaceCredits()
        {
            return replaceCredits;
        }

        public string getReplaceSubject()
        {
            return replaceSubject;
        }

        public string getReplaceNumber()
        {
            return replaceNumber;
        }

        public void setCreditType(string creditType)
        {
            this.creditType = creditType;
        }

        public string getCreditType()
        {
            return creditType;
        }

        public void setCredits(int credits)
        {
            this.credits = credits;
        }

        public int getCredits()
        {
            return credits;
        }

        public Boolean isComplete()
        {
            return complete;
        }

        public void setComplete(Boolean complete)
        {
            this.complete = complete;
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

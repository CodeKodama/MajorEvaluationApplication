using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MajorEvaluation
{
    public class SeqNode
    {
        public string dept { get; set; }
        public int courseNum { get; set; }
        public int credits { get; set; }
        public string reqOrElec { get; set; }
        public int value { get; set; }
        public bool complete { get; set; }
        public List<SeqNode> children;

        //In case of root.
        public SeqNode()
        {
            dept = "ROOT";
            courseNum = 0;
            credits = 0;
            reqOrElec = null;
            value = 0;
            complete = false;
            children = new List<SeqNode>();
        }

        public SeqNode(string dept, 
            int courseNum, 
            int credits, 
            string reqOrElec, 
            int value)
        {
            this.dept = dept;
            this.courseNum = courseNum;
            this.credits = credits;
            this.reqOrElec = reqOrElec;
            this.value = value;
            this.complete = false;
            children = new List<SeqNode>(); 
        }

        public void addChild(SeqNode child)
        {
            children.Add(child);
        }

        //Add the provided SeqNode to the SeqNode with the provided ParentValue.
        public void addChild(int parentValue, SeqNode newChild)
        {
            //We have found our parent value, add the new child.
            if (value == parentValue)
            {
                children.Add(newChild);
            }
            else
            {
                //Check each child to see if they are the parent value.
                foreach (SeqNode child in children)
                {
                    child.addChild(parentValue, newChild);
                }
            }
        }
        

        public void removeChild(int parentValue, int childValue)
        {
            //We have found our parent value.
            if (value == parentValue)
            {
                //Locate the child to remove.
                foreach (SeqNode child in children)
                {
                    if (child.value == childValue)
                    {
                        //Remove the child.
                        children.Remove(child);
                    }
                }
            }
            else
            {
                //Check each child to see if they are the parent value,
                //attempting removal on each one.
                foreach (SeqNode child in children)
                {
                    child.removeChild(parentValue, childValue);
                }
            }
        }

        //Determine if the sequence tree contains a SeqNode with
        //The provided value.
        public bool nodeExists(int nodeValue)
        {
            //Value is located, return true.
            if (value == nodeValue)
            {
                return true;
            }
            //Value is no located, no children
            //left, return false.
            else if (children.Count() == 0)
            {
                return false;
            }
            //No value found, but children exist.
            //Check each child for node.
            else
            {
                bool exists = false;
                foreach (SeqNode child in children)
                {
                    if (child.nodeExists(nodeValue))
                    {
                        exists = true;
                    }
                }
                return exists;
            }
        }


        public void setComplete(string department, string number)
        {
            
            if (string.Equals((dept + " " + courseNum), (department + " " + number)))
            {
                complete = true;
                MessageBox.Show("found it");
            }

            else
            {

                foreach (SeqNode child in children)
                {
                    child.setComplete(department, number);
                }
            }
        }

        //Searches all SeqNodes descending from the current 
        //SeqNode. If the provided ParentValue is found, it returns
        //that SeqNode's children.
        public List<SeqNode> getChildren(int parenValue)
        {
            if (value == parenValue)
            {
                return children;
            }
            else
            {
                foreach (SeqNode child in children)
                {
                    child.getChildren(parenValue);
                }
                return null;
            }
        }

        //Returns a list of the current SeqNodes children.
        public List<SeqNode> getChildren()
        {
            return children;
        }
    }
}

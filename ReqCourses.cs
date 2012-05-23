using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MajorEvaluation
{
    public class ReqCourses
    {
        public string DEPT { get; set; }
        public int COURSE_NUM { get; set; }
        public int CREDITS { get; set; }
        public string REQ_OR_ELEC { get; set; }
        public int VALUE { get; set; }
        public int PAR_VALUE { get; set; }

        public List<MajorEvaluation.ReqCourses> requirements = new List<ReqCourses>();

        public ReqCourses(string dept, 
            int course_num, 
            int credits, 
            string req, 
            int value, 
            int par)
        {
            DEPT = dept;
            COURSE_NUM = course_num;
            CREDITS = credits;
            REQ_OR_ELEC = req;
            VALUE = value;
            PAR_VALUE = par;
        }

        public override string ToString()
        {
            string ret = "Subject: " + DEPT.ToString() + "," +
                         "Course number: " + COURSE_NUM.ToString() + "," +
                         "Credits: " + CREDITS.ToString() + "," + 
                         "Required: " + REQ_OR_ELEC.ToString();
            return ret;
        }

        public List<MajorEvaluation.ReqCourses> get_reqs()
        {
            return requirements;
        }
    }



}

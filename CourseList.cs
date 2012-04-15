using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MajorEvaluator
{
    class CourseList
    {
        private List<Course> allCourses;
        private string name;


        public CourseList()
        {
            allCourses = new List<Course>();
        }

        public void add(Course newCourse)
        {
            this.allCourses.Add(newCourse);
        }

        public double averageGpa()
        {
            double totalGpa = 0.0;
            double avgGpa = 0.0;
            foreach (Course c in allCourses)
            {
                totalGpa = totalGpa + c.getGpa();
            }
            avgGpa = totalGpa / allCourses.Count();
            avgGpa = Math.Round(avgGpa, 2);
            return avgGpa;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MajorEvaluator
{
    class EvalList
    {
        private List<Eval> allEvals;
        private string name;


        public EvalList()
        {
            allEvals = null;
        }

        public double averageGpa()
        {
            double totalGpa = 0.0;
            double avgGpa = 0.0;
            foreach (Eval e in allEvals)
            {
                totalGpa = totalGpa + e.getGpa();
            }
            avgGpa = totalGpa / allEvals.Count();
            avgGpa = Math.Round(avgGpa, 2);
            return avgGpa;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MajorEvaluator
{
    class EvalList
    {
        private List<Eval> evals;
        
        private string name;

        public EvalList()
        {
            evals = new List<Eval>();
        }



        public List<Eval> getEvals()
        {
            return evals;
        }

        public void addEval(Eval eval)
        {
            evals.Add(eval);
        }

        public int size()
        {
            return evals.Count();
        }
            

        public double averageGpa()
        {
            double totalGpa = 0.0;
            double avgGpa = 0.0;
            foreach (Eval e in evals)
            {
                totalGpa = totalGpa + e.getGpa();
            }
            avgGpa = totalGpa / evals.Count();
            avgGpa = Math.Round(avgGpa, 2);
            return avgGpa;
        }
    }
}

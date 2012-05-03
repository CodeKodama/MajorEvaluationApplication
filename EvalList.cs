using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MajorEvaluator
{
    class EvalList
    {
        private List<Eval> evals;
        
        //Proposed classes to handle sequences.
        //private List<ORSeq> ORSeqs;
        //private List<ANDSeq> ANDSeqs;
        //private List<EvalSeq> evalSeqs;
   
        private string name;

        public EvalList()
        {
            //Evals, not in sequences.
            evals = new List<Eval>();
          
            
          // Need some way to handle Evals in sequences:
          //
          //  ORSeqs = new List<ORSeq>();
          //  ANDSeqs = new List<ANDSeq>();
          //
          // Or maybe:
          //
          //  evalSeqs = new List<EvalSeq>();
        }



        public List<Eval> getEvals()
        {
            return evals;
        }


        //Proposed method to return sequences.
        //public List<EvalSeq> getEvalSeqs()
        //{
            //return evalSeqs;
       // }

        //Propsed method to add to an existing sequence, or to add
        //an additional sequence if the provided one does not exist.
       // public void addEvalSeq(Eval eval, int ORLevel, int ANDLevel)
       // {
       // }

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

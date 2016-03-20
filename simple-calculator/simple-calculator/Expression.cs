using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_calculator
{
    public class Expression
    {
        //public int part1 { get; set; }
        //public int part2 { get; set; }
        public char mathOp { get; private set; }
        public string[] parts { get; set; }
        public string lasteqn { get; set; }
        public char firstVar { get; set; }

        public object[] Parse(string eqn, Evaluate Eval)
        {
            //stack_.LastQ = eqn;
            eqn = eqn.Replace(" ", "");

            string eqnEdit = " " + eqn.Substring(1);
            // This is to ensure that if the first number is negative, 
            // it does not interpret that as the operator

            int ExpIndex = eqnEdit.IndexOfAny(new char[] { '+', '-', '*', '/', '%', '=' });
            mathOp = eqn[ExpIndex];
            parts = eqn.Split(eqn[ExpIndex]);

            if (ExpIndex == -1)
            {
                throw new Exception();
            }
            
            if (parts.Length != 2 || ExpIndex== -1)
            {
                throw new IndexOutOfRangeException();
            }

            if (mathOp == '=')
            {
                object[] allparts = Eval.stack_record.AssignConstant(eqn, parts);
                return allparts;
            }
 
            else
            {
                //part1
                int part1;
                bool success1 = int.TryParse(eqn.Substring(0, ExpIndex), out part1);
                if (!success1)
                {
                    char cLookup = char.ToLower(eqn.Substring(0, ExpIndex)[0]);
                    part1 = Eval.stack_record.RetrieveValue(cLookup);
                    if (part1 == -1)
                    {
                        throw new ArgumentException("That doesn't look to be a valid first term");
                    }
                }

                //part2
                //secondTerm = int.Parse(eqn.Substring(ExpIndex + 1));
                int part2;
                bool success2 = int.TryParse(eqn.Substring(ExpIndex + 1), out part2);
                if (!success2)
                {
                    char cLookup = char.ToLower(eqn.Substring(ExpIndex + 1)[0]);
                    part2 = Eval.stack_record.RetrieveValue(cLookup);
                    if (part2 == -1)
                    {
                        throw new ArgumentException("That doesn't look to be a valid second term");
                    }
                }


                object[] allparts = { part1, mathOp, part2 };
                return allparts;
            }
            
        }
    }
}

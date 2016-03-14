using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_calculator
{
    public class Expression
    {
        public int firstTerm { get; private set; }
        public int secondTerm { get; private set; }
        public char mathOp { get; private set; }
        public string[] parts { get; set; }
        public string lasteqn { get; set; }
        public char firstVar { get; set; }

        public object[] FirstExpression(string eqn)
        {
            eqn = eqn.Replace(" ", "");
            lasteqn = eqn;

            string eqnEdit = " " + eqn.Substring(1);
            // This is to ensure that if the first number is negative, 
            // it does not interpret that as the operator

            int ExpIndex = eqnEdit.IndexOfAny(new char[] { '+', '-', '*', '/', '%', '=' });
            if (ExpIndex == -1)
            {
                throw new Exception();
            }
            
            parts = eqn.Split(eqn[ExpIndex]);
            if (parts.Length != 2 || ExpIndex== -1)
            {
                throw new IndexOutOfRangeException();
            }

            if (eqn.Substring(0,1).IndexOfAny(new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '-', '+' }) == -1)
            {
                firstVar = (char)eqn[0];
                secondTerm = int.Parse(eqn.Substring(ExpIndex + 1));
                mathOp = eqn[ExpIndex];
                object[] allparts = { firstVar, mathOp, secondTerm };
                return allparts;
            } else {
                firstTerm = int.Parse(eqn.Substring(0, ExpIndex));
                secondTerm = int.Parse(eqn.Substring(ExpIndex + 1));
                mathOp = eqn[ExpIndex];
                object[] allparts = { firstTerm, mathOp, secondTerm };
                return allparts;
            }
            
        }
    }
}

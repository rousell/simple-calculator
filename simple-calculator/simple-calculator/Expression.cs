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

        public string[] FirstExpression(string eqn)
        {
            eqn = eqn.Replace(" ", "");
            //Console.WriteLine(eqn);

            string eqnEdit = " " + eqn.Substring(1);
            int ExpIndex = eqnEdit.IndexOfAny(new char[] { '+', '-', '*', '/' });
            if (ExpIndex == -1)
            {
                throw new Exception();
            }
            
            parts = eqn.Split(eqn[ExpIndex]);
            Console.WriteLine(parts.Length);
            if (parts.Length != 2 || ExpIndex== -1)
            {
                throw new IndexOutOfRangeException();
            }
            firstTerm = int.Parse(eqn.Substring(0, ExpIndex));
            secondTerm = int.Parse(eqn.Substring(ExpIndex + 1));
            if (firstTerm <  0 || secondTerm < 0)
            {
                throw new ArgumentException("a term is negative");
            }
            mathOp = eqn[ExpIndex];

            return parts;
            
        }
    }
}

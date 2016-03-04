using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_calculator
{
    public class Expression
    {
        public string FirstExpression()
        {
            string eqn;
            Console.WriteLine("Write Math Here");
            eqn = Console.ReadLine();
            eqn = eqn.Replace(" ", "");

            int ExpIndex = eqn.IndexOfAny(new char[] { '+', '-', '*', '/' });
           
            if (ExpIndex == -1)
            {
                Console.WriteLine("There is no operator in your equation");
            }

            string[] parts = eqn.Split(eqn[ExpIndex]);

            Parse pExp = new Parse();
            pExp.firstTerm = int.Parse(eqn.Substring(0,ExpIndex));
            pExp.secondTerm = int.Parse(eqn.Substring(ExpIndex + 1));
            pExp.mathOp = eqn[ExpIndex];

            Console.WriteLine(pExp.firstTerm + " "+ pExp.mathOp + " " + pExp.secondTerm);
            return eqn;
        }
    }
}

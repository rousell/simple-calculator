using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool status = true;
            int n = 0;
            while (status)
            {
                string eqn;
                Console.Write("[{0}]> ",n);
                n++;
                eqn = Console.ReadLine();
                if (eqn == "exit" || eqn == "quit")
                {
                    status = false;
                }
                else
                {
                    Expression math = new Expression();
                    var result = math.FirstExpression(eqn);
                    Evaluate Eval = new Evaluate();
                    string actual = Eval.EvaluateFirst(result);
                    Console.WriteLine("   = {0}",actual);
                    //calc++;
                }
            }
        }
    }
}

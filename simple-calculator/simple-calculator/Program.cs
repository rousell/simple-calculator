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
            string eqn;
            Console.WriteLine("Write Math Here");
            eqn = Console.ReadLine();
            Expression math = new Expression();
            var result = math.FirstExpression(eqn);
            Evaluate Eval = new Evaluate();
            string actual = Eval.EvaluateFirst(result);
            Console.WriteLine(actual);
            Console.ReadKey();
        }
    }
}

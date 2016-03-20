using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_calculator
{
    class Program
    {
        //public static Stack stack_record { get; private set; }

        static void Main(string[] args)
        {
            //Stack stack_record = new Stack();
            Expression math = new Expression();
            Evaluate Eval = new Evaluate();
            //Stack stack_obj = Eval.ReturnStack();

            bool status = true;
            int n = 0;
            while (status)
            {
                string eqn;
                Console.Write("[{0}]> ", n);
                n++;
                eqn = Console.ReadLine();
                if (eqn == "exit" || eqn == "quit")
                {
                    status = false;
                } else if (eqn == "lastq" || eqn == "last"){
                    if (eqn == "lastq")
                    {
                        var actual = Eval.last();
                        Console.WriteLine("   = {0}", actual);
                    }
                    else
                    {
                        var actual = Eval.lastA();
                        Console.WriteLine("   = {0}", actual);
                    }
                }
                else
                {
                    var result = math.Parse(eqn, Eval);
                    string actual = Eval.EvaluateFirst(result);
                    Console.WriteLine("   = {0}",actual);
                }
            }
        }
    }
}

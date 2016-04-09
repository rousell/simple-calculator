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
            Expression math = new Expression();
            Evaluate Eval = new Evaluate();

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
                    //object[] result;
                    try
                    {
                        var result = math.Parse(eqn, Eval);
                        string actual = Eval.EvaluateFirst(result);
                        Console.WriteLine("   = {0}", actual);
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine("     {0}",e.Message);
                    } catch (IndexOutOfRangeException e)
                    {
                        Console.WriteLine("    {0}",e.Message);
                    }
                    //var result = math.Parse(eqn, Eval);
                    //string actual = Eval.EvaluateFirst(result);
                    //Console.WriteLine("   = {0}",actual);
                }
            }
        }
    }
}

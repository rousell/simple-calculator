﻿using System;
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
            Console.WriteLine("this is Program.cs");
            Expression math = new Expression();
            math.FirstExpression();
            Console.ReadKey();
        }
    }
}

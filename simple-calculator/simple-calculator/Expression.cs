﻿using System;
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
        public int ExpIndex { get; set; } 

        public string FirstExpression(string eqn)
        {
            eqn = eqn.Replace(" ", "");
            //Console.WriteLine(eqn);

            try
            {
                ExpIndex = eqn.IndexOfAny(new char[] { '+', '-', '*', '/' });
            }
            catch (Exception) when (ExpIndex == -1)
            {
                Console.WriteLine(ExpIndex);
                //throw new Exception("Operator is Invalid");
            }
            
            try
            {
                parts = eqn.Split(eqn[ExpIndex]);
                Console.WriteLine(parts.Length);
                firstTerm = int.Parse(eqn.Substring(0, ExpIndex));
                secondTerm = int.Parse(eqn.Substring(ExpIndex + 1));
                mathOp = eqn[ExpIndex];

                return parts[0];
            }
            catch (IndexOutOfRangeException)
            {
                throw new IndexOutOfRangeException("index is out of range");
            }
            catch (Exception)
            {
                throw new Exception("exception!");
            }
        }
    }
}

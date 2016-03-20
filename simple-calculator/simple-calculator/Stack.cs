using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_calculator
{
    public class Stack
    {
        public string LastQ { get; set; }
        public int LastA { get; set; }

        public Dictionary<char, int> constant = new Dictionary<char, int>();

        public int RetrieveValue(char cvar)
        {
            int cvalue = -1;
            if (constant.ContainsKey(cvar))
            {
                if (!constant.TryGetValue(cvar, out cvalue))
                {
                    throw new ArgumentException("constant value does not exist currently");
                } else
                {
                    constant.TryGetValue(cvar, out cvalue);
                }
            }
            return cvalue;
        }

       public object[] AssignConstant (string Exp, string[] parts)
        {
            char op = '=';
            string part1 = parts[0].ToLower();
            int assignmentcheck = part1.IndexOfAny(new char[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' });
            if (assignmentcheck == -1)
            {
                throw new ArgumentException("You did not use the right type of character as your variable");
            }
            char rconstant = Exp[assignmentcheck];

            int rvalue;
            bool success = int.TryParse(parts[1], out rvalue);
            if (!success)
            {
                throw new ArgumentException("You can't assign that value, try another");
            }
            if (constant.ContainsKey(rconstant))
            {
                throw new ArgumentException("You have already used that constant");
            }

            constant.Add(rconstant, rvalue);
            return new object[] { rconstant, op, rvalue };

        }
    }
}

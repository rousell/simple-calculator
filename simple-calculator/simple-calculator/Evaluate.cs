using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_calculator
{
    public class Evaluate
    {
        private int answer { get; set; }
        public int EvaluateFirst(object[] exp)
        {
            Operations OpAction = new Operations();
            char op = (char)exp[1];
            if (op == '+')
            {
                int result = OpAction.add((int)(exp[0]), (int)(exp[2]));
                return result;
            } else if (op == '-')
            {
                int result = OpAction.sub((int)(exp[0]), (int)(exp[2]));
                return result;
            } else if (op == '*')
            {
                int result = OpAction.mul((int)(exp[0]), (int)(exp[2]));
                return result;
            } else if (op == '/')
            {
                int result = OpAction.div((int)(exp[0]), (int)(exp[2]));
                return result;
            } else if (op == '%')
            {
                int result = OpAction.div((int)(exp[0]), (int)(exp[2]));
                return result;
            } else
            {
                return -1;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_calculator
{
    public class Evaluate
    {
        public Stack stack_record { get; set; }
        public Evaluate()
        {
            stack_record = new Stack();
        }
        public int answer { get; set; }
        public object[] question { get; set; }
        public int EvaluateFirst(object[] exp)
        {
            Operations OpAction = new Operations();

            StringBuilder qString = new StringBuilder();
            qString.Append(exp[0]);
            qString.Append(exp[1]);
            qString.Append(exp[2]);
            string quest = qString.ToString();

            stack_record.LastQ = quest;

            char op = (char)exp[1];
            if (op == '+')
            {
                int answer = OpAction.add((int)(exp[0]), (int)(exp[2]));
                stack_record.LastA = answer;
                return answer;
            }
            else if (op == '-')
            {
                int answer = OpAction.sub((int)(exp[0]), (int)(exp[2]));
                stack_record.LastA = answer;
                return answer;
            }
            else if (op == '*')
            {
                int answer = OpAction.mul((int)(exp[0]), (int)(exp[2]));
                stack_record.LastA = answer;
                return answer;
            }
            else if (op == '/')
            {
                int answer = OpAction.div((int)(exp[0]), (int)(exp[2]));
                stack_record.LastA = answer;
                return answer;
            }
            else if (op == '%')
            {
                int answer = OpAction.div((int)(exp[0]), (int)(exp[2]));
                stack_record.LastA = answer;
                return answer;
            }
            else
            {
                return -1;
            }
        }
            
        public int lastA()
        {
            return stack_record.LastA;
        }
        public string last()
        {
            return stack_record.LastQ;
        }
        
    }
}

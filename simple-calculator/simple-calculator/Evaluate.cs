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
        public string EvaluateFirst(object[] exp)
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
                return answer.ToString();
            }
            else if (op == '-')
            {
                int answer = OpAction.sub((int)(exp[0]), (int)(exp[2]));
                stack_record.LastA = answer;
                return answer.ToString();
            }
            else if (op == '*')
            {
                int answer = OpAction.mul((int)(exp[0]), (int)(exp[2]));
                stack_record.LastA = answer;
                return answer.ToString();
            }
            else if (op == '/')
            {
                int answer = OpAction.div((int)(exp[0]), (int)(exp[2]));
                stack_record.LastA = answer;
                return answer.ToString();
            }
            else if (op == '%')
            {
                int answer = OpAction.mod((int)(exp[0]), (int)(exp[2]));
                stack_record.LastA = answer;
                return answer.ToString();
            }
            else if (op == '=')
            {
                string answer = OpAction.var((char)exp[0], (int)(exp[2]));
                return answer;
            }
            else
            {
                return "Invalid inputs!";
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

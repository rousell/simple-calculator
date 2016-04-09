using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_calculator
{
    public class Operations
    {
        public int add(int rt, int lf)
        {
            return rt + lf;
        }
        public int sub(int rt, int lf)
        {
            return rt - lf;
        }
        public int mul(int rt, int lf)
        {
            return rt * lf;
        }
        public int div(int rt, int lf)
        {
            return rt / lf;
        }
        public int mod(int rt, int lf)
        {
            return rt % lf;
        }
        public string var(char rt, int lf)
        {
            string text = "saved '" + rt + "' as '" + lf + "'";
            return text;

        }
    }
}

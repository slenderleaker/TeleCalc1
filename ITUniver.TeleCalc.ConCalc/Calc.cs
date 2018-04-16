using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITUniver.TeleCalc.ConCalc
{
    public class Calc
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }
        public int Sub(int x, int y)
        {
            return x - y;
        }
        public int Div(int x, int y)
        {
            return x / y;
        }
        public int Mul(int x, int y)
        {
            return x * y;
        }
        public int Mod(int x, int y)
        {
            return x % y;
        }
        public int Exp(int x, int y)
        {
            return x ^ y;
        }
    }
}

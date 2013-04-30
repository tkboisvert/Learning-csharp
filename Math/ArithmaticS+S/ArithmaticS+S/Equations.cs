using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ArithmaticS_S
{
    class Equations
    {
        public static int AddEntireSequence(int length_N, int startingDigit_B, string arrayEquation)
        {
            string[] equation = new string[10];
            int i = 0;
            foreach (char c in arrayEquation)
            {
                
                if (char.IsDigit(c))
                {
                    string s = Convert.ToString(c);
                    equation[i] = s;
                }
                if (c == 'b')
                {
                    string startingDigit = Convert.ToString(startingDigit_B);
                    equation[i] = startingDigit;
                }
                if (c == '*')
                {
                    equation[i] = "*";
                }
                if (c == '/')
                {
                    equation[i] = "/";
                }
                if (c == '+')
                {
                    equation[i] = "+";
                }
                if (c == '-')
                {
                    equation[i] = "-";
                }


                i++;
            }

            int a1 = 0;
            return i;
        }
    }
}

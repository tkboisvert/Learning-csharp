using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TKBoisvert.Calculus.ConsoleApp
{
    class BinomialTheoremRunner
    {
        public static void Run()
        {
            
            string A = UI.GetStringFactor("first term (A)", "A");
            string B = UI.GetStringFactor("second term (B)", "B");
            string N = UI.GetStringFactor("power to be raised to (N)", "N");

            bool allFactorsAreNumbers = true;

            foreach (string s in new string[] { A, B, N })
            {
                if (UI.CheckIsNumber(s) == false)
                {
                    allFactorsAreNumbers = false;
                }
            }

            if (allFactorsAreNumbers == true)
            {
                BinomialTheoremForNumbersOnly.Run(Convert.ToDouble(A), Convert.ToDouble(B), Convert.ToDouble(N));
            }
            else
            {

            }

        }
    }
}

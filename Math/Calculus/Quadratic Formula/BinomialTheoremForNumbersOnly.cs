using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TKBoisvert.Calculus.ConsoleApp
{
    class BinomialTheoremForNumbersOnly
    {
        public static void Run(double A, double B, double N)
        {
            double[] myResults = new double[Convert.ToInt32(N) + 1];

            double answer = 0;

            for (int i = 0; i < (N + 1); i++)
            {
                myResults[i] = Equations.binomialTheorem(A, B, N, i);
            }

            foreach (double d in myResults)
            {
                answer += d;
            }

            Text.sumIs(answer * 2, "The total is");

            Console.ReadKey();
        }
    }
}

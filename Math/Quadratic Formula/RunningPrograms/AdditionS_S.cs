using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TKBoisvert.Calculus
{
    class AdditionS_S
    {
        public static void Run()
        {
            Console.Clear();

            double a1 = UI.GetFactor("first term (a1)", "a1");
            double d = UI.GetFactor("common differance (d)", "d");
            double n = UI.GetFactor("length (n)", "n");

            double an = Equations.findASpecificNumber(a1, n, d);

            double sum = Equations.calculateSeries(n, a1, an);

            Text.sumIs(sum);

        }
    }
}

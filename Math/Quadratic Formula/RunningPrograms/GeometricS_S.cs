using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TKBoisvert.Calculus
{
    class GeometricS_S
    {
        public static void Run()
        {
            Console.Clear();

            double a1 = UI.GetFactor("first term (a1)", "a1 = ");
            double r = UI.GetFactor("ratio (r)", "r = ");
            double n = UI.GetFactor("length (n)", "n = ");


            double answer = Equations.calculateGeometricSS(a1, r, n);

            Text.sumIs(answer, "Σ");

            Console.ReadKey();
        }
    }
}

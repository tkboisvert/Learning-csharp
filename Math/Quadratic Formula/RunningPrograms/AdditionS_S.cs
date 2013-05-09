using System;

namespace TKBoisvert.Calculus
{
    internal class AdditionS_S
    {
        public static void Run()
        {
            Console.Clear();

            double a1 = UI.GetFactor("first term (a1)", "a1 = ");
            double d = UI.GetFactor("common difference (d)", "d = ");
            double n = UI.GetFactor("length (n)", "n = ");

            Console.Clear();

            double an = Equations.findASpecificNumberInAdditionSS(a1, n, d);

            double sum = Equations.calculateAdditionSSSeries(n, a1, an);

            Text.sumIs(sum, "Σ");

            Console.ReadKey();
        }
    }
}
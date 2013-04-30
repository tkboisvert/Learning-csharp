using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quadratic_Formula
{
    class UI
    {
        public static Stack<int> GetABC()
        {
            Stack<int> UI = new Stack<int>();

            Console.WriteLine("Enter A");
            UI.Push(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Enter B");
            UI.Push(Convert.ToInt32(Console.ReadLine()));
            Console.WriteLine("Enter C");
            UI.Push(Convert.ToInt32(Console.ReadLine()));

            return UI;
        }
        public static int GetFactor(bool first)
        {
            if (first == true)
            {
                Console.WriteLine("Enter your first factor");
            }
            if (first == false)
            {
                Console.WriteLine("Enter your second factor");
            }
            return Convert.ToInt32(Console.ReadLine());
        }
        public static string GetSelection()
        {
            Console.Clear();
            Console.WriteLine("Enter 1 for factoring, enter 2 for checking factors");
            return Console.ReadLine();
        }
    }
}

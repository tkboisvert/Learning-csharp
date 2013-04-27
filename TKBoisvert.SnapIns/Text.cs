using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TKBoisvert.SnapIns
{
    class Text
    {
        public static void DisplaySecondsAndMinutes(int Seconds, int Minutes)
        {
            if (Minutes > 1)
            {
                if (Seconds == 60) { Console.WriteLine("There are {0} minutes and 0 seconds left", ++Minutes); }
                else if (Seconds > 1) { Console.WriteLine("There are {0} minutes and {1} seconds left", Minutes, Seconds); }
                else { Console.WriteLine("There are {0} minutes and {1} second left", Minutes, Seconds); }
            }
            else if (Minutes == 1)
            {
                if (Seconds == 60) { Console.WriteLine("There are {0} minutes and 0 seconds left", ++Minutes); }
                else if (Seconds > 1) { Console.WriteLine("There is 1 minute and {0} seconds left", Seconds); }
                else { Console.WriteLine("There is 1 minute and {0} second left", Seconds); }
            }
            else
            {
                if (Seconds == 60) { Console.WriteLine("There is {0} minute and 0 seconds left", ++Minutes); }
                else if (Seconds > 1) { Console.WriteLine("There is {0} seconds left", Seconds); }
                else { Console.WriteLine("There is {0} second left", Seconds); }
            }
        }
        public static void ZeroSecondDisplay(int Seconds, int Minutes)
        {
            if (Minutes > 1) { Console.WriteLine("There are {0} minutes and 0 seconds left", Minutes); }
            if (Minutes == 1) { Console.WriteLine("There is {0} minute and 0 seconds left", Minutes); }
            else { Console.WriteLine("There is 0 seconds left"); }
        }

        public static void EndText(bool TrueWhenBeingRunByAUser)
        {
            if (TrueWhenBeingRunByAUser == true)
            {
                Console.Clear();
                Console.WriteLine("Time's up!");
                Console.ReadLine();
            }
        }
    }
}
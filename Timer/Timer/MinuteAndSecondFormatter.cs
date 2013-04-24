using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Timer
{
    public class MinuteAndSecondFormatter
    {
        
        public static int MinuteCondenser(int Seconds, int Minutes)
        {
            if (Seconds == 0) { return Minutes; }

            int extraMinutes = 0;

            if (Seconds > 60)
            {
                extraMinutes = Seconds / 60;
                Seconds -= extraMinutes * 60;
            }

            Minutes += extraMinutes;

            return Minutes;
        }
        public static int SecondReducer(int Seconds, int Minutes)
        {
            if (Seconds == 0) { return Seconds; }

            int extraMinutes = 0;

            if (Seconds > 60)
            {
                extraMinutes = Seconds / 60;
                Seconds -= extraMinutes * 60;
            }

            return Seconds;
        }
        public static Stack<int> GetInfoFromUser(int seconds, int minutes)
        {
            

            Console.WriteLine("Enter the amount of seconds");
            string secondstring = Console.ReadLine();
            Console.WriteLine("Enter the amount of minutes");
            string minutestring = Console.ReadLine();

            if (secondstring == "") { seconds = 0; }
            else { seconds = Convert.ToInt32(secondstring); }

            if (minutestring == "") { minutes = 0; }
            else { minutes = Convert.ToInt32(minutestring); }

            Stack<int> UI = new Stack<int>(); UI.Push(minutes); UI.Push(seconds);

            return UI;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Timer;

namespace Timer
{
    class Program
    {

        static void Main(string[] args)
        {
            
            int seconds = 0;
            int minutes = 0;

            Console.WriteLine("Enter the amount of seconds");
            string secondstring = Console.ReadLine();
            Console.WriteLine("Enter the amount of minutes");
            string minutestring = Console.ReadLine();

            if (secondstring == "") { seconds = 0; }
            else { seconds = Convert.ToInt32(secondstring); }

            if (minutestring == "") { minutes = 0; }
            else { minutes = Convert.ToInt32(minutestring); }

            minutes = MinuteAndSecondFormatter.MinuteCondenser(seconds, minutes);
            seconds = MinuteAndSecondFormatter.SecondReducer(seconds, minutes);

            do
            {

                seconds = Timers.SecondTimer(seconds, minutes);
                if (minutes >= 1) { seconds = 60; }
                minutes = Timers.MinuteTimer(minutes);


            } while (seconds != 0 || minutes != 0);

            Console.Read();
        }
    }
}

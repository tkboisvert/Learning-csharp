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
            while (true)
            {
                Stack<int> UI = MinuteAndSecondFormatter.GetInfoFromUser();

                int seconds = UI.Pop();
                int minutes = UI.Pop();

                minutes = MinuteAndSecondFormatter.MinuteCondenser(seconds, minutes);
                seconds = MinuteAndSecondFormatter.SecondReducer(seconds, minutes);

                do
                {

                    if (MinuteAndSecondFormatter.CheckForEmptyInput(seconds, minutes) == false) { break; }

                    seconds = Timers.SecondTimer(seconds, minutes);
                    if (minutes >= 1) { seconds = 60; }
                    minutes = Timers.MinuteTimer(minutes);

                } while (seconds != 0 || minutes != 0);

                Console.Clear();
                Console.WriteLine("Time's up!");
                Console.ReadLine();
            }
        }
    }
}

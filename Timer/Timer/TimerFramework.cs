using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Timer
{
    class TimerFramework
    {
        public static void Run(bool trueForUIFalseForPassing, int programInputOne, int programInputTwo)
        {
            while (true)
            {
                Stack<int> UI = MinuteAndSecondFormatter.GetInfoFromUser(trueForUIFalseForPassing, programInputOne, programInputTwo);

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
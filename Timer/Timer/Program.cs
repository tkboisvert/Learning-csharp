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

            
            Stack<int> UI = MinuteAndSecondFormatter.GetInfoFromUser(seconds, minutes);

            seconds = UI.Pop();
            minutes = UI.Pop();

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

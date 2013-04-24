using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Timer
{
    public class Timers
    {
        public static int SecondTimer(int Seconds, int Minutes)
        {
            if (Seconds == 0) { return 0; }

            do
            {
                Console.Clear();
                Text.DisplaySecondsAndMinutes(Seconds, Minutes);
                Thread.Sleep(1000);
                Seconds--;

            } while (Seconds != 0);

            Console.Clear();

            Text.ZeroSecondDisplay(Seconds, Minutes);

            return Seconds;
        }

        public static int MinuteTimer(int Minutes)
        {
            if (Minutes == 0) { return 0; }
            else { Minutes--; return Minutes; }
        }

    }
}

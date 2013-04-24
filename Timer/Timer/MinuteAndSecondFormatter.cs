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
    }
}

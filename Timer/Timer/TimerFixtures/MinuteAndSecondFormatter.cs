﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

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
        public static Stack<int> GetInfoFromUser(bool TrueForUIFalseForPassing, int programInputOne, int programInputTwo)
        {
            Stack<int> UI = new Stack<int>();

            if (TrueForUIFalseForPassing == true)
            {
                Console.Clear();

                string secondString = GetInfo(true, TrueForUIFalseForPassing);
                string minuteString = GetInfo(false, TrueForUIFalseForPassing);

                int seconds = ConvertInputToNumber(secondString);
                int minutes = ConvertInputToNumber(minuteString);

                UI.Push(minutes); UI.Push(seconds);

                return UI;
            }
            else
            {
                UI.Push(programInputOne); UI.Push(programInputTwo);

                return UI;
            }
        }

        public static string GetInfo(bool TrueForSecondFalseForMinute, bool TrueForUIFalseForPassing)
        {
            if (TrueForUIFalseForPassing == true)
            {
                if (TrueForSecondFalseForMinute == true)
                {
                    Console.WriteLine("Enter the amount of seconds");
                }
                if (TrueForSecondFalseForMinute == false)
                {
                    Console.WriteLine("Enter the amount of minutes");
                }
                return Console.ReadLine();
            }
            else { return "0"; }
        }

        public static int ConvertInputToNumber(string UI)
        {
            if (UI == "") { return 0; }
            else { return (Convert.ToInt32(UI)); }
        }

        public static bool CheckForEmptyInput(int seconds, int minutes)
        {
            if (seconds == 0 && minutes == 0)
            {
                Console.Clear();
                Console.WriteLine("There are 0 minutes and 0 seconds left");
                Thread.Sleep(1000);
                return false;
            }
            else return true;
        }
    }
}
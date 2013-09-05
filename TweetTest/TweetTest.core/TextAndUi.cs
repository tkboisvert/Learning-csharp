using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;


namespace TweetTest.core
{
    public class TextAndUi
    {

        public static string GetText()
        {
            ShowSomethingToTheUser("Enter your Tweet", true);
            string ui = Console.ReadLine();
            CheckLength(ui);
            return ui;
        }
        private static void CheckLength(string ui)
        {
            if (ui.Count() > 121)
            {
                Console.Clear();
                Console.WriteLine("You used more than 140 characters in your tweet, press any key to continue");
                Console.ReadKey();
                GetText();
            }
        }
        public static bool MessageIsSuitableLength(string ui)
        {
            return ui.Count() <= 129;
        }

        private static void DisplayProgress(object obj)
        {
            var whatsGoingOn = (string)obj;
            while(true)
            {
                Console.WriteLine(whatsGoingOn + " . . .");
                Thread.Sleep(500);
                Console.Clear();
                Console.WriteLine(whatsGoingOn + ". . . ");
                Thread.Sleep(500);
                Console.Clear();
            }
        }

        public static void ShowSomethingToTheUser(string s, bool clearScreen)
        {
            if(clearScreen == true)
            {
                Console.Clear();
            }
            Console.WriteLine(s);
            
        }
        public static Thread GetStatisThread()
        {
            return new Thread(start: TextAndUi.DisplayProgress);
        }

        public static void IsSuccuess(string response)
        {
            if (response.Count() > 200)
            {
                ShowSomethingToTheUser("Posted!", clearScreen: false);
            }
            else { Console.WriteLine(response); }
        }

    }
}

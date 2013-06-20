using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace TKBoisvert.Cryptography.Core
{
    public class UserInteractions
    {
        private string GetCodeWord(string firstOrVerify)
        {
            StringBuilder asterisksLength = new StringBuilder();

            StringBuilder codePhrase = new StringBuilder();

            //string codePhrase = null;

            TellSomethingToTheUser(true, new string[]{firstOrVerify, "null", "null"});

            do
            {
                string characterInTheCodePhrase = GetCharacterInCodePhrase();

                if (characterInTheCodePhrase == "break")
                {
                    TellSomethingToTheUser(true, new string[]{"null", asterisksLength.ToString(), "null"});
                    break;
                }
                else
                {
                    codePhrase.Append(characterInTheCodePhrase);
                    TellSomethingToTheUser(true,new string[]{firstOrVerify, asterisksLength + characterInTheCodePhrase, "null"});
                    asterisksLength.Append("*");
                }
            } while (true);

            if (codePhrase.Length == 0)
            {
                codePhrase.Append(GetCodeWord(firstOrVerify));
            }

            return codePhrase.ToString();
            
        }

        public string GetAndVerifyPassPhrase()
        {
            while (true)
            {
                string passPhrase = GetCodeWord("Enter your passphrase");

                if (passPhrase == GetCodeWord("Please verify your passphrase"))
                {
                    return passPhrase;
                }
                else
                {
                    TellSomethingToTheUser(true, new string[]{"They did not match,", "press any key to try again", "null"});
                    Console.ReadKey();
                }
            }


        }

        public string GetCharacterInCodePhrase()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            if (keyInfo.Key == ConsoleKey.Enter)
            {
                return "break";
            }
            else
            {
                return keyInfo.KeyChar.ToString();
            }
        }

       

        public void TellSomethingToTheUser(bool clearScreen,string[] arrayOrStringsYouWantToWrite)
        {
            if (clearScreen == true)
            {
                Console.Clear();
            }

            foreach (string s in arrayOrStringsYouWantToWrite)
            {
                if (s == "null") { }
                else if (s != null)
                {
                    Console.WriteLine(s);
                }
                else { Console.WriteLine(""); }
            }
        }

        public string GetSomethingFromTheUser(bool clearScreen, string[] arrayOfStringsYouWantToWrite)
        {
            TellSomethingToTheUser(clearScreen, arrayOfStringsYouWantToWrite);

            return Console.ReadLine();
        }

        public ConsoleKeyInfo Menu()
        {
            while (true)
            {
                Console.Clear();

                string menu = BuildMenu(new[] { "encoding", "decoding" });

                Console.Write(menu);

                ConsoleKeyInfo keyInfo = Console.ReadKey();

                //Remember That You need To Update the acceptable keys strokes for the applicible options
                //Here
                
                if (keyInfo.Key == ConsoleKey.D1 || keyInfo.Key == ConsoleKey.D2)
                {
                    return keyInfo;
                }
                else
                {
                    TellSomethingToTheUser(true, new string[] { "Um, that isn't an option..." });
                    Console.ReadKey();
                }
            }
        }

        private static string BuildMenu(string[] menuItems)
        {
            int longestMenuItemName = menuItems.OrderByDescending(s => s.Length).First().Length;
            int padSize = 7 + longestMenuItemName;
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine("╓".PadRight(padSize, '─') + "╖");
            stringBuilder.AppendLine("║Press. . .".PadRight(padSize) + "║");
            stringBuilder.AppendLine("╟".PadRight(padSize, '─') + "╢");

            for (int i = 0; i < menuItems.Length; i++)
            {
                var menuItem = string.Format("║{0} for {1}", i + 1, menuItems[i]);
                stringBuilder.AppendLine(menuItem.PadRight(padSize) + "║");
            }
            stringBuilder.AppendLine("╙".PadRight(padSize, '─') + "╜");

            return stringBuilder.ToString();
        }
    }
}
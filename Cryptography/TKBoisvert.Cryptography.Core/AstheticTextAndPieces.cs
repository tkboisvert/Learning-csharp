using System;
using System.Linq;
using System.Text;

namespace TKBoisvert.Cryptography.Core
{
    public class AstheticTextAndPieces
    {
        private string GetCodeWord(string firstOrVerify)
        {
            StringBuilder asterisksLength = new StringBuilder();
            string codePhrase = null;

            TellSomethingToTheUser(true, firstOrVerify, "null", "null");

            do
            {
                string characterInTheCodePhrase = GetCharacterInCodePhrase();

                if (characterInTheCodePhrase == "break")
                {
                    TellSomethingToTheUser(true, "null", asterisksLength.ToString(), "null");
                    break;
                }
                else
                {
                    codePhrase += characterInTheCodePhrase;
                    TellSomethingToTheUser(true, firstOrVerify, asterisksLength + characterInTheCodePhrase, "null");
                    asterisksLength.Append("*");
                }
            } while (true);

            if (codePhrase == null)
            {
                GetAndVerifyPassPhrase();
            }
            return codePhrase;
            
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
                    TellSomethingToTheUser(true, "They did not match,", "press any key to try again", "null");
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

        //public int[] GetCodedText()
        //{
        //    List<int> listOfInts = new List<int>();

        //    string theNumbers = "";

        //    while (true)
        //    {
        //        string numberString = GetSomethingFromTheUser("Enter 000 to move on", theNumbers, "null");
        //        int numberInt = Convert.ToInt32(numberString);
        //        if (numberInt == 000)
        //        {
        //            WhatAmIDoing(theNumbers, "null", "null");
        //            break;
        //        }
        //        else { listOfInts.Add(numberInt); }

        //        theNumbers += (numberString + " ");
        //    }

        //    int[] arrayOfInts = new int[listOfInts.Count];

        //    arrayOfInts = listOfInts.ToArray();

        //    return arrayOfInts;
        //}

        public void TellSomethingToTheUser(bool clearScreen,string high, string middle, string low)
        {
            if (clearScreen == true)
            {
                Console.Clear();
            }

            if (high == "null") { }
            else if (high != null)
            {
                Console.WriteLine(high);
            }
            else { Console.WriteLine(""); }

            if (middle == "null") { }
            else if (middle != null)
            {
                Console.WriteLine(middle);
            }
            else { Console.WriteLine(""); }

            if (low == "null") { }
            else if (low != null)
            {
                Console.WriteLine(low);
            }
            else { Console.WriteLine(""); }
        }

        public string GetSomethingFromTheUser(bool clearScreen, string whatItIsYouWant, string middle, string low)
        {
            TellSomethingToTheUser(clearScreen, whatItIsYouWant, middle, low);

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

                if (keyInfo.Key == ConsoleKey.D1 || keyInfo.Key == ConsoleKey.D2)
                {
                    return keyInfo;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Um, that isn't an option...");
                    Console.ReadKey();
                }
            }
        }

        private static string BuildMenu(string[] menuItems)
        {
            const int minSize = 7;
            int longestMenuItemName = menuItems.OrderByDescending(s => s.Length).First().Length;
            int padSize = minSize + longestMenuItemName;
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
using System;
using System.Text;
using System.Linq;

namespace TKBosivert.SnapIns
{
    public class AstheticTextAndPieces
    {
        public void TellSomethingToTheUser(bool clearScreen, string high, string middle, string low)
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

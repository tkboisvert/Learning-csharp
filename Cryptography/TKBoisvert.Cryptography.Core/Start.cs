using System;
namespace TKBoisvert.Cryptography.Core
{
    internal class Start
    {
        public static void TKC(char[] charArray)
        {

            ConsoleKeyInfo keyInfo = new UserInteractions().Menu();

            string stringToBeConverted = Change.ChangeToFormattedStringForConversion(charArray);

            if (keyInfo.Key == ConsoleKey.D1)
            {
                ProgramForEncoding.Encode(stringToBeConverted);
            }
            else if (keyInfo.Key == ConsoleKey.D2)
            {
                ProgramForDecoding.Decode(stringToBeConverted);
            }
        }
    }
}
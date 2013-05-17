using System;
using System.Linq;

namespace TKBoisvert.Cryptography.Core
{
    public class Determine
    {
        public void HashToUse(char[] charArray)
        {
            char c = charArray.Last();

            switch (c)
            {
                case 't':
                    ActionToCarryOut(Hashes.TKC, charArray);
                    break;

                case '?':
                    ActionToCarryOut(Hashes.Help, charArray);
                    break;

                default:
                    throw new NotImplementedException();
            }
        }

        public void ActionToCarryOut(Hashes hash, char[] charArrayForEncodingPurposes)
        {
            switch (hash)
            {
                case Hashes.TKC:
                    Start.TKC(charArrayForEncodingPurposes);
                    break;

                case Hashes.Help:
                    throw new NotImplementedException("help page");

                default:
                    throw new NotImplementedException("We dont support that yet");
            }
        }

        public static string IsDivisibleByFour(string theStringInQuestion)
        {
            if (theStringInQuestion.Length % 4 != 0)
            {
                theStringInQuestion += " ";
            }
            return theStringInQuestion;
        }

        public enum Hashes
        {
            TKC,
            Help,
        }
    }
}
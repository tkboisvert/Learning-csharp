using System;
using System.Linq;
using TKBoisvert.Cryptography.Core.HelpFixtures;
using System.Text;

namespace TKBoisvert.Cryptography.Core
{
    public class Determine
    {
        public void HasFlag(StringBuilder stringBuilder)
        {

            UserInteractions ATaP = new UserInteractions();

            Determine determine = new Determine();

            if (Check.ForFlag(stringBuilder.ToString()) == false)
            {
                while (true)
                {
                    HelpPage.ListFlags();

                    string flag = (ATaP.GetSomethingFromTheUser(false, new string[]{null, "Enter your desired flag"}));

                    if (Check.ForFlag(flag) == true)
                    {
                        stringBuilder.Append(flag);
                        break;
                    }
                }
            }

            determine.HashToUse(stringBuilder.ToString().ToArray());
            
        }

        private void HashToUse(char[] charArray)
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

                case '/':
                    ActionToCarryOut(Hashes.Help, charArray);
                    break;

                default:
                    throw new NotImplementedException();
            }
        }

        private void ActionToCarryOut(Hashes hash, char[] charArrayForEncodingOrDecodingPurposes)
        {
            switch (hash)
            {
                case Hashes.TKC:
                    Start.TKC(charArrayForEncodingOrDecodingPurposes);
                    break;

                case Hashes.Help:
                    HelpPage.Explaination();
                    break;

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
            //Update Definitions Alongside Hashes
        }

        public static bool IfTwoStringArraysAreTheSameLength(string[] one, string[] two)
        {
            if (one.Length == two.Length)
            {
                return true;
            }
            else { throw new ArrayTypeMismatchException("Somethun's broke muster"); }
        }
    }
}
using System.Linq;
using TKBoisvert.Cryptography.Core;

namespace TKBoisvert.Cryptography
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            AstheticTextAndPieces ATaP = new AstheticTextAndPieces();

            Determine determine = new Determine();

            string text = ATaP.GetSomethingFromTheUser("Characters to be changed", "Remember to add your preferred encoding flag", "Type /? for help");

            determine.HashToUse(text.ToArray());
        }
    }
}
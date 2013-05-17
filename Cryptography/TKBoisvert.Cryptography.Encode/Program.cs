using System.Linq;
using TKBoisvert.Cryptography.Core;

namespace TKBoisvert.Cryptography
{
    class Program
    {
        static void Main(string[] args)
        {
            AstheticTextAndPieces ATaP = new AstheticTextAndPieces();

            Determine determine = new Determine();

            string text = ATaP.GetSomethingFromTheUser("Characters to be changed", "null", "null");

            determine.HashToUse(text.ToArray());

        }
    }
}

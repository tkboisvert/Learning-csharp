using System.Linq;
using TKBoisvert.Cryptography.Core;
using TKBoisvert.Cryptography.Core.HelpFixtures;
using System.Text;

namespace TKBoisvert.Cryptography
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            while (true)
            {
                UserInteractions ATaP = new UserInteractions();

                Determine determine = new Determine();

                StringBuilder stringBuilder = new StringBuilder();

                stringBuilder.Append(ATaP.GetSomethingFromTheUser(true, new string[] {"Enter what you want to encode/decode", "Remember to add a flag", "Type /? for help"}));

                determine.HasFlag(stringBuilder);
                
            }
        }
    }
}
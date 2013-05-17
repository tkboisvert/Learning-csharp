using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TKBoisvert.Cryptography.Core
{
    class ProgramForDecoding
    {
        public static void Decode()
        {
            Descrambler descrambler = new Descrambler();

            AstheticTextAndPieces ATaP = new AstheticTextAndPieces();

            Console.WriteLine(descrambler.ArrayOfASCIIToString(descrambler.Descramble(ATaP.GetCodedText(), Console.ReadLine())));

            Console.ReadLine();
        }
    }
}

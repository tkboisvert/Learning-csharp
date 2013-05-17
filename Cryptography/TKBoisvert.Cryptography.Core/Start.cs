using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TKBoisvert.Cryptography.Core;

namespace TKBoisvert.Cryptography.Core
{
    class Start
    {
        public static void TKC(char[] charArray)
        {
            AstheticTextAndPieces ATaP = new AstheticTextAndPieces();
            string oneForEncodingTwoForDecoding = ATaP.Menu();

            if (oneForEncodingTwoForDecoding == "1")
            {
                ProgramForEncoding.Encode(charArray);
            }
            else if (oneForEncodingTwoForDecoding == "2")
            {
                ProgramForDecoding.Decode();
            }

        }
        
        
    }
}

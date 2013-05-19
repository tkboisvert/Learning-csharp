using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TKBoisvert.Cryptography.Core
{
    public class Check
    {
        public static bool ForFlag(string stringBuilder)
        {
            if (stringBuilder.Contains('/'))
            {
                return true;
            }
            else { return false; }
        }
    }
}

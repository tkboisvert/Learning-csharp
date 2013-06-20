using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;

namespace Crypto
{
    class Class1
    {
        public static string testString()
        {
            string test = "hello";
            try 
            {
                using (MemoryStream msstream = new MemoryStream())
                {
                    StreamWriter newStreamWriter = new StreamWriter(msstream);

                    newStreamWriter.Write(test);
    
                }
            }


        byte[] newbytes = new byte[] { };

        HMACRIPEMD160 asdf = new HMACRIPEMD160()
        }
    }
}

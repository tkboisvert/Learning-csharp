using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Crypto
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string encryptedText = Crypto.EncryptStringAES("BADGER", "fart");

                Console.WriteLine(encryptedText);

                Console.ReadKey();

                Console.WriteLine(Crypto.DecryptStringAES(encryptedText, "fart"));

                Console.ReadKey();
            }
        }
    }
}

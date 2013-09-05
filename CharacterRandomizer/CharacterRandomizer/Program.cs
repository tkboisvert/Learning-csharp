using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterRandomizer
{
    class Program
    {
        static void Main(string[] args)
        {
            string allWheels = string.Empty;

            for (int i = 0; i <= 52; i++)
            {

                int looper = 0;

                string wheel = string.Empty;

                Console.WriteLine(i);

                do
                {
                    const string lumpText =
                        "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM[];',.`1234567890-={}|:<>?~!@#$%^&*()_+";

                    var random = new Random();

                    var nextChar = random.Next(0, 90);

                    if (!wheel.Contains(lumpText[nextChar]))
                    {
                        wheel += lumpText[nextChar];

                        looper++;
                    }
                } while (looper < 52);

                string currentWheel = wheel.Aggregate(string.Empty,
                                                      (current, c) => current + ("\"" + c.ToString() + "\"" + ", "));

                allWheels += "new string[]{" + currentWheel + "}," + Environment.NewLine;
            }

            System.IO.File.WriteAllText(@"C:\Users\Michael\Desktop\wheel.txt", allWheels);
        }
    }
}

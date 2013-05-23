using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz.Tests
{
    class FizzBuzzEngine
    {
        public IEnumerable<string> Run(int startingNumber, int endNumber)
        {
            for (int i = startingNumber; i <= endNumber; i++)
            {
                if (i == 3) { yield return "fizz"; }
                else { yield return i.ToString(); }
            }
        }
    }
}

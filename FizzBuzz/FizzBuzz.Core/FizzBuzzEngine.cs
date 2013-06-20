using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
    public class FizzBuzzEngine
    {
        public IEnumerable<string> Run(int startingNumber, int endNumber)
        {
            var numberConverter = new NumberToFizzBuzzConverter();

            return Enumerable.Range(startingNumber, endNumber).Select(numberConverter.Convert);
        }
    }
}

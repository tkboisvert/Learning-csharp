using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzzDataFormatter
    {
        public string Format(IEnumerable<string> fizzBuzzRawResults)
        {
            var stringBuilder = new StringBuilder();
            
            if (fizzBuzzRawResults.Count() == 0)
            {
                return string.Empty;
            }

            stringBuilder.Append(fizzBuzzRawResults.First());

            foreach (var fizzBuzzRawResult in fizzBuzzRawResults.Skip(1))
            {
                stringBuilder.Append(' ');

                stringBuilder.Append(fizzBuzzRawResult);
            }

            return stringBuilder.ToString();
        }
    }
}
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzz
{
    public class FizzBuzzDataFormatter
    {
        public string Format(IEnumerable<string> fizzBuzzRawResults)
        {
            int fizz = 0;


            var stringBuilder = new StringBuilder();
            
            if (!fizzBuzzRawResults.Any())
            {
                return string.Empty;
            }

            stringBuilder.Append(fizzBuzzRawResults.First());

            foreach (var fizzBuzzRawResult in fizzBuzzRawResults.Skip(1))
            {
                stringBuilder.Append(' ');

                stringBuilder.Append(fizzBuzzRawResult);

                if (fizzBuzzRawResult == "fizz")
                {
                    fizz++;
                }
            }

            stringBuilder.AppendLine();
            stringBuilder.Append("fizz: ");
            stringBuilder.Append(fizzBuzzRawResults.Count(x => x == "fizz"));
            stringBuilder.AppendLine();
            stringBuilder.Append("buzz: ");
            stringBuilder.Append(fizzBuzzRawResults.Count(x => x == "buzz"));
            stringBuilder.AppendLine();
            stringBuilder.Append("fizzbuzz: ");
            stringBuilder.Append(fizzBuzzRawResults.Count(x => x == "fizzbuzz"));
            stringBuilder.AppendLine();
            stringBuilder.Append("lucky: ");
            stringBuilder.Append(fizzBuzzRawResults.Count(x => x == "lucky"));
            stringBuilder.AppendLine();
            stringBuilder.Append("integer: ");
            var count = fizzBuzzRawResults.Count(x => x != "fizz" && x != "buzz" && x != "fizzbuzz" && x != "lucky");
            stringBuilder.Append(count);
            stringBuilder.AppendFormat(" - because there {1} {0} number{2} that {1} not altered", count, count > 1 ? "were" : "was", count > 1 ? "s" : string.Empty );
              

            return stringBuilder.ToString();
        }
    }
}
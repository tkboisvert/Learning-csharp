namespace FizzBuzz
{
    public class NumberToFizzBuzzConverter
    {
        public string Convert(int numerToConvert)
        {
            if (numerToConvert % 15 == 0)
            {
                return "fizzbuzz";
            }
            if (numerToConvert % 3 == 0)
            {
                return "fizz";
            }
            if (numerToConvert % 5 == 0)
            {
                return "buzz";
            }
            return numerToConvert.ToString(); 
        }
    }
}
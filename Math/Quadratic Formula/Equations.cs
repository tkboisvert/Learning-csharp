namespace TKBoisvert.Calculus
{
    internal class Equations
    {
        public static double contentsOfSquareRootForQF(double a, double b, double c)
        {
            double answer = ((b * b) - (4 * a * c));
            return answer;
        }

        public static double positiveResultForQF(double squareRoot, double b, double a)
        {
            double answer = (-b + squareRoot) / (2 * a);
            return answer;
        }

        public static double negativeResultForQF(double squareRoot, double b, double a)
        {
            double answer = (-b - squareRoot) / (2 * a);
            return answer;
        }

        public static double findASpecificNumber(double a1, double n, double d)
        {
            double answer = (a1 + ((n - 1) * d));
            return answer;
            //returns 'an'
        }

        public static double calculateSeries(double n, double a1, double an)
        {
            double answer = ((n * (a1 + an)) / 2);
            return answer;
        }
    }
}
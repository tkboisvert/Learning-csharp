using System;

namespace TKBoisvert.Pizza.ConsoleApp
{
    public class PizzaBuilderFactory
    {
        public IPizzaBuilder Create(string userInput)
        {
            switch (userInput)
            {
                case "hawiian":
                    return new HawaiianPizzaBuilder();

                case "spicy":
                    return new SpicyPizzaBuilder();

                default:
                    throw new NotImplementedException();
            }
        }
    }
}
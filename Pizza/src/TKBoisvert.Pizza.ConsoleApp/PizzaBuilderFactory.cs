using System;

namespace TKBoisvert.Pizza.ConsoleApp
{
    public class PizzaBuilderFactory
    {
        public IPizzaBuilder Create(string userInput)
        {
            if (userInput == "hawiian")
            {
                
                return new HawiianPizzaBuilder();
            }
            throw new NotImplementedException();
        }
    }
}
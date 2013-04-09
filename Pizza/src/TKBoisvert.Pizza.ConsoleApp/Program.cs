using System;

namespace TKBoisvert.Pizza.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Press 1 for Hawaiian press 2 for Spicy");

            string userInput = Console.ReadLine();
            
            PizzaBuilderFactory pizzaBuilderFactory = new PizzaBuilderFactory();
            
            IPizzaBuilder pizzaBuilder = pizzaBuilderFactory.Create(userInput);
            
            Pizza pizza = pizzaBuilder.GetPizza();

            Console.WriteLine(pizza);
        }
    }
}

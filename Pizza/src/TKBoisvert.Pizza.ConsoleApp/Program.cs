using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TKBoisvert.Pizza.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Press 1 for Hawaiian press 2 for Spicy");

            string userInput = Console.ReadLine();
            
            PizzaBuilderFactory pizzaBuilderFactory = new PizzaBuilderFactory();
            
            PizzaBuilder pizzaBuilder = pizzaBuilderFactory.Create(userInput);
            
            Pizza pizza = pizzaBuilder.GetPizza();
            
            Console.WriteLine();

        }
        class Pizza
        {
            
        }
        class PizzaBuilder
        {
            public Pizza GetPizza()
            {
                return new Pizza();
            }
            
        }
        class PizzaBuilderFactory
        {
            public PizzaBuilder Create(string userInput)
            {
                throw new NotImplementedException();
            }
        }
    }
}

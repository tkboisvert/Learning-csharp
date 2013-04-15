namespace TKBoisvert.Pizza.ConsoleApp
{
    public class HawaiianPizzaBuilder : IPizzaBuilder
    {
        public Pizza GetPizza()
        {
            return new Pizza(Topping.Hawaiian);
        }
    }
}
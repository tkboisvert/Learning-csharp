namespace TKBoisvert.Pizza.ConsoleApp
{
    public class Pizza
    {
        public Pizza(Topping topping)
        {
            Topping = topping;
        }

        public Topping Topping { get; private set; }

        public override string ToString()
        {
            return string.Format("Piazza with {0}", Topping);
        }
    }
}
using System;

namespace TKBoisvert.Pizza.ConsoleApp
{
    [Flags]
    public enum Topping
    {
        Ham = 0,
        Pinapple = 1,
        Pepperoni = 2,
        Sausage = 3,
        Peppers = 4,
        Hawaiian = Ham | Pinapple,
        MeatLovers = Pepperoni | Sausage,
        Spicy = MeatLovers | Peppers
    }
}
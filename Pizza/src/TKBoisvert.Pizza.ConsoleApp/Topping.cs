using System;

namespace TKBoisvert.Pizza.ConsoleApp
{
    [Flags]
    public enum Topping
    {
        Ham = 0,
        Pinapple = 1,
        Hawaiian = Ham | Pinapple
    }
}
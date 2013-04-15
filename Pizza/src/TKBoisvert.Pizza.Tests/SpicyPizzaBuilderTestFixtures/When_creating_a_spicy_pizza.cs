using FluentAssertions;
using NUnit.Framework;
using TKBoisvert.Pizza.ConsoleApp;

namespace TKBoisvert.Pizza.Tests.SpicyPizzaBuilderTestFixtures
{
    [TestFixture]
    class When_creating_a_spicy_pizza
    {
        [Test]
        public void should_creat_a_pizza_with_spicy_topping()
        {
            var spicyPizzaBuilder = new SpicyPizzaBuilder();

            var pizza = spicyPizzaBuilder.GetPizza();

            pizza.Topping.Should().Be(Topping.Spicy);
        }

    }
}

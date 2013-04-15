using FluentAssertions;
using NUnit.Framework;
using TKBoisvert.Pizza.ConsoleApp;

namespace TKBoisvert.Pizza.Tests.HawaiianPizzaBuilderTestFixtures
{
    [TestFixture]
    class When_creating_a_hawaiian_pizza
    {
        [Test]
        public void Should_create_pizza_with_hawaiian_topping()
        {
            var hawaiianPizzaBuilder = new HawaiianPizzaBuilder();

            var pizza= hawaiianPizzaBuilder.GetPizza();

            pizza.Topping.Should().Be(Topping.Hawaiian);
        }
    }
}
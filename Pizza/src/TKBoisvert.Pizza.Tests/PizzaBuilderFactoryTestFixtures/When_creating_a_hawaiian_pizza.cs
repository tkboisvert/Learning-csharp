using FluentAssertions;
using NUnit.Framework;
using TKBoisvert.Pizza.ConsoleApp;

namespace TKBoisvert.Pizza.Tests.PizzaBuilderFactoryTestFixtures
{
    [TestFixture]
    class When_creating_a_pizza_builder
    {
        [Test]
        public void Should_return_a_hawiian_pizza_builder()
        {
            var pizzaBuilderFactory = new PizzaBuilderFactory();

            var pizzaBuilder = pizzaBuilderFactory.Create("hawiian");

            pizzaBuilder.Should().BeOfType<HawiianPizzaBuilder>();
        }
    }
}
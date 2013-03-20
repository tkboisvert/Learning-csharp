using CalculatorApp;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Calculator.Tests.ScientificFixtures
{
    [TestFixture]
    class When_asking_for_Standard_to_scientific_notation
    {
        [Test]
        public void Should_return_a_properly_notated_mathamatical_expression()
        {
            Notation toNotation = new Notation();

            string result = toNotation.Calculate("543000");

            Assert.AreEqual("5.43x10^5", result);

        }
        public class Notation
        {
            public string Calculate(string input)
            {
                string firstSignificantDigit = null;

                string followingSequence = null;

                string finalFollowingSequence = null;

                int toThePowerOf = 0;

                bool boolFirstNumber = true;

                bool boolForFollowingSequence = false;

                bool singleLoopBool = true;

                foreach (char c in input)
                {
                    if (char.IsDigit(c) && boolFirstNumber == true)
                    {
                        firstSignificantDigit += c;
                        boolFirstNumber = false;

                    }
                    if (char.IsDigit(c) && boolForFollowingSequence == true)
                    {
                        followingSequence += c;
                        toThePowerOf += 1;
                    }

                    if (boolForFollowingSequence == true && singleLoopBool == true && followingSequence.Length == 2)
                    {
                        finalFollowingSequence = followingSequence;
                        singleLoopBool = false;
                    }

                    else
                    {
                        boolForFollowingSequence = true;
                    }

                }

                string result = (firstSignificantDigit + "." + finalFollowingSequence + "x10^" + toThePowerOf);
                return (result);
            }
        }
    }
}
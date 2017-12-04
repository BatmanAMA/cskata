using System;
using NUnit.Framework;
using kata;
using System.Linq;
using System.Text.RegularExpressions;

namespace kata.tests
{
    public class roman_tests
    {

        [Test]
        public void no_overrepeat()
        {
            foreach (int number in Enumerable.Range(0,3999))
            {
                Assert.That(
                    condition: !Regex.IsMatch(
                            input: Roman.toRoman(number),
                            pattern: "([A-Z])\\1{3}"
                        ),
                    message: "Characters repeat more then once"
                );
            }
        }
        [Test]
        public void no_weird_patterns()
        {
            // "(V[^V]V|XXX[^XI]X|L[^LI]L|CCC[^CI]C|D[^DI]D)"
            foreach (int number in Enumerable.Range(0,3999))
            {
                Assert.That(
                    condition: !Regex.IsMatch(
                            input: Roman.toRoman(number),
                            pattern: "(V[^V]V|XXX[^XI]X|L[^LI]L|CCC[^CI]C|D[^DI]D)"
                        ),
                    message: "Weird patterns are output (ex: VIV instead of IX)"
                );
            }
        }
        [Test]
        public void is_correct()
        {
            foreach (int number in Enumerable.Range(0,3999))
            {
                bool isReversable = Roman.fromRoman(Roman.toRoman(number)) == number;
                Assert.That(
                    condition: isReversable,
                    message: $"Couldn't successfully convert {number} back and forth"
                );
            }
        }
    }
}
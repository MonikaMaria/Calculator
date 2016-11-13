using System;
using NUnit.Framework;

namespace Calculator.Tests
{
    public partial class CalcTests
    {
        #region Root

        [Test]
        public void Root_positive_fraction()
        {
            Fraction f = new Fraction(4, 1);

            double wynik = Fraction.Root(f);

            Assert.That(wynik, Is.EqualTo(2));
        }

        [Test]
        public void Root_negative_fraction()
        {
            Fraction f = new Fraction(-4, 6);

            Assert.That(() => Fraction.Root(f), Throws.TypeOf<InvalidOperationException>());
        }

        [Test]
        public void Root_zero_fraction()
        {
            Fraction f = new Fraction(0, 6);

            double wynik = Fraction.Root(f);

            Assert.That(wynik, Is.EqualTo(0));
        }

        #endregion
    }
}
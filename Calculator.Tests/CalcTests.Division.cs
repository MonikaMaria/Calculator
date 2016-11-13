using System;
using NUnit.Framework;

namespace Calculator.Tests
{
    public partial class CalcTests
    {
        #region Division

        [Test]
        public void Divide_positive_fraction_by_zero()
        {
            Fraction f = new Fraction(1, 4);
            Fraction g = new Fraction(0, 1);

            Assert.That(() => f/g, Throws.TypeOf<DivideByZeroException>());
        }

        [Test]
        public void Divide_negative_fraction_by_zero()
        {
            Fraction f = new Fraction(-1, 4);
            Fraction g = new Fraction(0, 1);

            Assert.That(() => f/g, Throws.TypeOf<DivideByZeroException>());
        }

        [Test]
        public void Divide_zero_by_zero()
        {
            Fraction f = new Fraction(0, 4);
            Fraction g = new Fraction(0, 1);

            Assert.That(() => f/g, Throws.TypeOf<DivideByZeroException>());
        }

        [Test]
        public void Divide_zero_fraction_by_positive_fraction()
        {
            Fraction f = new Fraction(0, 4);
            Fraction g = new Fraction(5, 1);

            Fraction wynik = f/g;

            Assert.That(wynik.Nominator, Is.EqualTo(0));
            Assert.That(wynik.Denominator, Is.EqualTo(1));
        }

        [Test]
        public void Divide_zero_fraction_by_negative_fraction()
        {
            Fraction f = new Fraction(0, 4);
            Fraction g = new Fraction(-2, 9);

            Fraction wynik = f/g;

            Assert.That(wynik.Nominator, Is.EqualTo(0));
            Assert.That(wynik.Denominator, Is.EqualTo(1));
        }

        [Test]
        public void Divide_positive_by_negative_fraction()
        {
            Fraction f = new Fraction(1, 4);
            Fraction g = new Fraction(-5, 7);

            Fraction wynik = f/g;

            Assert.That(wynik.Nominator, Is.EqualTo(-7));
            Assert.That(wynik.Denominator, Is.EqualTo(20));
        }

        [Test]
        public void Divide_negative_by_positive_fraction()
        {
            Fraction f = new Fraction(-1, 4);
            Fraction g = new Fraction(5, 7);

            Fraction wynik = f/g;

            Assert.That(wynik.Nominator, Is.EqualTo(-7));
            Assert.That(wynik.Denominator, Is.EqualTo(20));
        }

        [Test]
        public void Divide_negative_by_negative_fraction()
        {
            Fraction f = new Fraction(-1, 4);
            Fraction g = new Fraction(-5, 7);

            Fraction wynik = f/g;

            Assert.That(wynik.Nominator, Is.EqualTo(7));
            Assert.That(wynik.Denominator, Is.EqualTo(20));
        }

        [Test]
        public void Divide_positive_by_positive_fraction()
        {
            Fraction f = new Fraction(1, 4);
            Fraction g = new Fraction(5, 7);

            Fraction wynik = f/g;

            Assert.That(wynik.Nominator, Is.EqualTo(7));
            Assert.That(wynik.Denominator, Is.EqualTo(20));
        }

        #endregion
    }
}
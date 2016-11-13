using NUnit.Framework;

namespace Calculator.Tests
{
    public partial class CalcTests
    {
        #region Multiplication

        [Test]
        public void Multiply_two_zeros()
        {
            Fraction f = new Fraction(0, 1);
            Fraction g = new Fraction(0, 1);

            Fraction wynik = f*g;

            Assert.That(wynik.Nominator, Is.EqualTo(0));
            Assert.That(wynik.Denominator, Is.EqualTo(1));
        }

        [Test]
        public void Multiply_zero_and_positive_fraction()
        {
            Fraction f = new Fraction(0, 1);
            Fraction g = new Fraction(2, 1);

            Fraction wynik = f*g;

            Assert.That(wynik.Nominator, Is.EqualTo(0));
            Assert.That(wynik.Denominator, Is.EqualTo(1));
        }

        [Test]
        public void Multiply_positive_fraction_and_zero()
        {
            Fraction f = new Fraction(2, 1);
            Fraction g = new Fraction(0, 1);

            Fraction wynik = f*g;

            Assert.That(wynik.Nominator, Is.EqualTo(0));
            Assert.That(wynik.Denominator, Is.EqualTo(1));
        }

        [Test]
        public void Multiply_zero_and_negative_fraction()
        {
            Fraction f = new Fraction(0, 1);
            Fraction g = new Fraction(-2, 1);

            Fraction wynik = f*g;

            Assert.That(wynik.Nominator, Is.EqualTo(0));
            Assert.That(wynik.Denominator, Is.EqualTo(1));
        }

        [Test]
        public void Multiply_negative_fraction_and_zero()
        {
            Fraction f = new Fraction(-2, 1);
            Fraction g = new Fraction(0, 1);

            Fraction wynik = f*g;

            Assert.That(wynik.Nominator, Is.EqualTo(0));
            Assert.That(wynik.Denominator, Is.EqualTo(1));
        }

        [Test]
        public void Multiply_two_negative_fractions()
        {
            Fraction f = new Fraction(-4, 5);
            Fraction g = new Fraction(-2, 7);

            Fraction wynik = f*g;

            Assert.That(wynik.Nominator, Is.EqualTo(8));
            Assert.That(wynik.Denominator, Is.EqualTo(35));
        }

        [Test]
        public void Multiply_two_positive_fractions()
        {
            Fraction f = new Fraction(4, 5);
            Fraction g = new Fraction(2, 7);

            Fraction wynik = f*g;

            Assert.That(wynik.Nominator, Is.EqualTo(8));
            Assert.That(wynik.Denominator, Is.EqualTo(35));
        }

        #endregion
    }
}
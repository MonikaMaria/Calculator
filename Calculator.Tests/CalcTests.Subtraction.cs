using NUnit.Framework;

namespace Calculator.Tests
{
    public partial class CalcTests
    {
        #region Subtraction

        [Test]
        public void Subtract_two_positive_fractions_equals_positive()
        {
            Fraction f = new Fraction(5, 6);
            Fraction g = new Fraction(1, 6);

            Fraction wynik = f - g;

            Assert.That(wynik.Nominator, Is.EqualTo(2));
            Assert.That(wynik.Denominator, Is.EqualTo(3));
        }

        [Test]
        public void Subtract_two_positive_fractions_equals_negative()
        {
            Fraction g = new Fraction(1, 6);
            Fraction f = new Fraction(5, 6);

            Fraction wynik = g - f;

            Assert.That(wynik.Nominator, Is.EqualTo(-2));
            Assert.That(wynik.Denominator, Is.EqualTo(3));
        }

        [Test]
        public void Subtract_two_negative_fractions_equals_zero()
        {
            Fraction f = new Fraction(-5, 6);
            Fraction g = new Fraction(-5, 6);

            Fraction wynik = f - g;

            Assert.That(wynik.Nominator, Is.EqualTo(0));
            Assert.That(wynik.Denominator, Is.EqualTo(1));
        }

        [Test]
        public void Subtract_two_negative_fractions_equals_negative_fraction()
        {
            Fraction f = new Fraction(-5, 6);
            Fraction g = new Fraction(-1, 6);

            Fraction wynik = f - g;

            Assert.That(wynik.Nominator, Is.EqualTo(-2));
            Assert.That(wynik.Denominator, Is.EqualTo(3));
        }

        [Test]
        public void Subtract_positive_fraction_and_zero()
        {
            Fraction f = new Fraction(5, 6);
            Fraction g = new Fraction(0, 6);

            Fraction wynik = f - g;

            Assert.That(wynik.Nominator, Is.EqualTo(5));
            Assert.That(wynik.Denominator, Is.EqualTo(6));
        }

        [Test]
        public void Subtract_zero_and_positive()
        {
            Fraction f = new Fraction(0, 6);
            Fraction g = new Fraction(5, 6);

            Fraction wynik = f - g;

            Assert.That(wynik.Nominator, Is.EqualTo(-5));
            Assert.That(wynik.Denominator, Is.EqualTo(6));
        }

        [Test]
        public void Subtract_negative_and_zero()
        {
            Fraction f = new Fraction(-5, 6);
            Fraction g = new Fraction(0, 6);

            Fraction wynik = f - g;

            Assert.That(wynik.Nominator, Is.EqualTo(-5));
            Assert.That(wynik.Denominator, Is.EqualTo(6));
        }

        [Test]
        public void Subtract_zero_and_negative()
        {
            Fraction f = new Fraction(0, 6);
            Fraction g = new Fraction(-5, 6);

            Fraction wynik = f - g;

            Assert.That(wynik.Nominator, Is.EqualTo(5));
            Assert.That(wynik.Denominator, Is.EqualTo(6));
        }

        [Test]
        public void Subtract_zero_and_zero()
        {
            Fraction f = new Fraction(0, 6);
            Fraction g = new Fraction(0, 6);

            Fraction wynik = f - g;

            Assert.That(wynik.Nominator, Is.EqualTo(0));
            Assert.That(wynik.Denominator, Is.EqualTo(1));
        }

        #endregion
    }
}
using NUnit.Framework;

namespace Calculator.Tests
{
    public partial class CalcTests
    {
        #region Adding

        [Test]
        public void Add_two_positive_fractions()
        {
            Fraction f = new Fraction(1, 2);
            Fraction g = new Fraction(2, 6);

            Fraction wynik = f + g;

            Assert.That(wynik.Nominator, Is.EqualTo(5));
            Assert.That(wynik.Denominator, Is.EqualTo(6));
        }

        [Test]
        public void Add_two_fractions_is_equal_zero()
        {
            Fraction f = new Fraction(1, 2);
            Fraction g = new Fraction(-2, 4);

            Fraction wynik = f + g;

            Assert.That(wynik.Nominator, Is.EqualTo(0));
            Assert.That(wynik.Denominator, Is.EqualTo(1));
        }

        [Test]
        public void Add_two_negative_fractions()
        {
            Fraction f = new Fraction(-1, 2);
            Fraction g = new Fraction(-2, 4);

            Fraction wynik = f + g;

            Assert.That(wynik.Nominator, Is.EqualTo(-1));
            Assert.That(wynik.Denominator, Is.EqualTo(1));
        }

        [Test]
        public void Add_two_zero_fractions()
        {
            Fraction f = new Fraction(0, 2);
            Fraction g = new Fraction(0, 4);

            Fraction wynik = f + g;

            Assert.That(wynik.Nominator, Is.EqualTo(0));
            Assert.That(wynik.Denominator, Is.EqualTo(1));
        }

        #endregion
    }
}
using System;
using NUnit.Framework;

namespace Calculator.Tests
{
    public partial class CalcTests
    {
        #region Power

        [Test]
        public void Power_negative_fraction_positive_power_value()
        {
            Fraction f = new Fraction(-5, 6);
            int g = 2;

            Fraction wynik = f ^ g;

            Assert.That(wynik.Nominator, Is.EqualTo(25));
            Assert.That(wynik.Denominator, Is.EqualTo(36));
        }

        [Test]
        public void Power_positive_fraction_positive_power_value()
        {
            Fraction f = new Fraction(5, 6);
            int g = 2;

            Fraction wynik = f ^ g;

            Assert.That(wynik.Nominator, Is.EqualTo(25));
            Assert.That(wynik.Denominator, Is.EqualTo(36));
        }

        [Test]
        public void Power_zero_fraction_positive_power_value()
        {
            Fraction f = new Fraction(0, 1);
            int g = 2;

            Fraction wynik = f ^ g;

            Assert.That(wynik.Nominator, Is.EqualTo(0));
            Assert.That(wynik.Denominator, Is.EqualTo(1));
        }

        [Test]
        public void Power_negative_fraction_negative_power_value()
        {
            Fraction f = new Fraction(-5, 6);
            int g = -2;

            Fraction wynik = f ^ g;

            Assert.That(wynik.Nominator, Is.EqualTo(36));
            Assert.That(wynik.Denominator, Is.EqualTo(25));
        }

        [Test]
        public void Power_positive_fraction_negative_power_value()
        {
            Fraction f = new Fraction(5, 6);
            int g = -2;

            Fraction wynik = f ^ g;

            Assert.That(wynik.Nominator, Is.EqualTo(36));
            Assert.That(wynik.Denominator, Is.EqualTo(25));
        }

        [Test]
        public void Power_zero_fraction_negative_power_value()
        {
            Fraction f = new Fraction(0, 1);
            int g = -2;

            Assert.That(() => f ^ g, Throws.TypeOf<ArithmeticException>());
        }

        [Test]
        public void Power_fraction_zero_power_value()
        {
            Fraction f = new Fraction(4, 10);
            int g = 0;

            Fraction wynik = f ^ g;

            Assert.That(wynik.Nominator, Is.EqualTo(1));
            Assert.That(wynik.Denominator, Is.EqualTo(1));
        }

        [Test]
        public void Power_zero_fraction_zero_power_value()
        {
            Fraction f = new Fraction(0, 1);
            int g = 0;

            Fraction wynik = f ^ g;

            Assert.That(wynik.Nominator, Is.EqualTo(1));
            Assert.That(wynik.Denominator, Is.EqualTo(1));
        }

        #endregion
    }
}
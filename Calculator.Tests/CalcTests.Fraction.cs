using NUnit.Framework;

namespace Calculator.Tests
{
    public partial class CalcTests
    {
        #region Fraction and parsing

        [Test]
        public void Fraction_is_valid()
        {
            Fraction f = new Fraction(1, 2);

            Assert.That(f.Nominator, Is.EqualTo(1));
            Assert.That(f.Denominator, Is.EqualTo(2));
        }

        [Test]
        public void Shorten_positive_fraction()
        {
            Fraction f = new Fraction(2, 4);

            Assert.That(f.Nominator, Is.EqualTo(1));
            Assert.That(f.Denominator, Is.EqualTo(2));
        }

        [Test]
        public void Shorten_negative_fraction()
        {
            Fraction f = new Fraction(-2, 4);

            Assert.That(f.Nominator, Is.EqualTo(-1));
            Assert.That(f.Denominator, Is.EqualTo(2));
        }

        [Test]
        public void Shorten_zero_fraction()
        {
            Fraction f = new Fraction(0, 4);

            Assert.That(f.Nominator, Is.EqualTo(0));
            Assert.That(f.Denominator, Is.EqualTo(1));
        }

        [Test]
        public void Negative_nominator_and_denominator()
        {
            Fraction f = new Fraction(-1, -2);

            Assert.That(f.Nominator, Is.EqualTo(1));
            Assert.That(f.Denominator, Is.EqualTo(2));
        }

        [Test]
        public void Negative_denominator()
        {
            Fraction f = new Fraction(1, -2);

            Assert.That(f.Nominator, Is.EqualTo(-1));
            Assert.That(f.Denominator, Is.EqualTo(2));
        }

        [Test]
        public void Negative_nominator()
        {
            Fraction f = new Fraction(-1, 2);

            Assert.That(f.Nominator, Is.EqualTo(-1));
            Assert.That(f.Denominator, Is.EqualTo(2));
        }

        [Test]
        public void Parse_positive_fraction_from_string_to_fraction()
        {
            Fraction wynik;
            string f = "2/5";

            bool parsed = Fraction.TryParse(f, out wynik);

            Assert.That(parsed, Is.True);
            Assert.That(wynik.Nominator, Is.EqualTo(2));
            Assert.That(wynik.Denominator, Is.EqualTo(5));
        }

        [Test]
        public void Parse_zero_fraction_from_string_to_fraction()
        {
            Fraction wynik;
            string f = "0/5";

            bool parsed = Fraction.TryParse(f, out wynik);

            Assert.That(parsed, Is.True);
            Assert.That(wynik.Nominator, Is.EqualTo(0));
            Assert.That(wynik.Denominator, Is.EqualTo(1));
        }

        [Test]
        public void Parse_negative_fraction_from_string_to_fraction()
        {
            Fraction wynik;
            string f = "-2/5";

            bool parsed = Fraction.TryParse(f, out wynik);

            Assert.That(parsed, Is.True);
            Assert.That(wynik.Nominator, Is.EqualTo(-2));
            Assert.That(wynik.Denominator, Is.EqualTo(5));
        }

        [Test]
        public void Parse_positive_fraction_with_integer_from_string()
        {
            Fraction wynik;
            string f = "1 2/5";

            bool parsed = Fraction.TryParse(f, out wynik);

            Assert.That(parsed, Is.True);
            Assert.That(wynik.Nominator, Is.EqualTo(7));
            Assert.That(wynik.Denominator, Is.EqualTo(5));
        }

        [Test]
        public void Parse_negative_fraction_with_integer_from_string()
        {
            Fraction wynik;
            string f = "-1 2/5";

            bool parsed = Fraction.TryParse(f, out wynik);

            Assert.That(parsed, Is.True);
            Assert.That(wynik.Nominator, Is.EqualTo(-7));
            Assert.That(wynik.Denominator, Is.EqualTo(5));
        }

        [Test]
        public void Parse_float_number_bigger_than_one_from_string_to_fraction()
        {
            Fraction wynik;
            string f = "1,25";

            bool parsed = Fraction.TryParse(f, out wynik);

            Assert.That(parsed, Is.True);
            Assert.That(wynik.Nominator, Is.EqualTo(5));
            Assert.That(wynik.Denominator, Is.EqualTo(4));
        }

        [Test]
        public void Parse_float_number_smaller_than_one_from_string_to_fraction()
        {
            Fraction wynik;
            string f = "0,25";

            bool parsed = Fraction.TryParse(f, out wynik);

            Assert.That(parsed, Is.True);
            Assert.That(wynik.Nominator, Is.EqualTo(1));
            Assert.That(wynik.Denominator, Is.EqualTo(4));
        }

        #endregion
    }
}
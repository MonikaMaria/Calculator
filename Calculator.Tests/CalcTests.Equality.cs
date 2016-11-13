using NUnit.Framework;

namespace Calculator.Tests
{
    public partial class CalcTests
    {
        #region Equality

        [Test]
        public void Null_fractions_are_not_equal_with_equality_operator()
        {
            Fraction a = null;
            Fraction b = null;

            var comparison = a == b;

            Assert.IsTrue(comparison);
        }

        [Test]
        public void Null_fraction_and_fraction_are_not_equal_with_nonequality_operator()
        {
            Fraction a = null;
            Fraction b = new Fraction(1, 2);

            var comparison = a != b;

            Assert.IsTrue(comparison);
        }

        [Test]
        public void Null_fractions_are_not_equal()
        {
            Fraction a = null;
            Fraction b = null;

            var comparison = a.Equals(b);

            Assert.IsFalse(comparison);
        }

        [Test]
        public void Fraction_and_null_fraction_are_not_equal()
        {
            Fraction a = null;
            Fraction b = new Fraction(1, 2);

            var comparison = b.Equals(a);

            Assert.IsFalse(comparison);
        }

        [Test]
        public void Null_fraction_and_fraction_are_not_equal()
        {
            Fraction a = null;
            Fraction b = new Fraction(1, 2);

            var comparison = a.Equals(b);

            Assert.IsFalse(comparison);
        }

        #endregion
    }
}
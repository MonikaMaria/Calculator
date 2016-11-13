using System;

namespace Calculator
{
    public sealed class Fraction : IEquatable<Fraction>
    {
        private int nominator;
        private int denominator;

        public int Nominator
        {
            get { return nominator; }
        }

        public int Denominator
        {
            get { return denominator; }
        }

        public Fraction(int nominator, int denominator)
        {
            if (denominator == 0)
                throw new DivideByZeroException();

            if (denominator < 0)
            {
                denominator = Math.Abs(denominator);
                nominator = -nominator;
            }

            int gcd = GetGreatestCommonDivision(Math.Abs(nominator), Math.Abs(denominator));
            this.nominator = nominator/gcd;
            this.denominator = denominator/gcd;
        }

        #region Parsing

        public static bool TryParse(string input, out Fraction output)
        {
            if (input == null)
                throw new ArgumentNullException();

            if (input.Contains(","))
            {
                output = ParseFloatToFraction(input);
                return true;
            }

            if (input.Contains("/"))
            {
                if (input.Contains(" "))
                {
                    output = ParseFractionWithInteger(input);
                    return true;
                }
                output = ParseFraction(input);
                return true;
            }

            if (!input.Contains(",") && !input.Contains("/"))
            {
                output = ParseIntegerToFraction(input);
                return true;
            }

            output = null;
            throw new FormatException();
        }

        private static Fraction ParseFraction(string input)
        {
            int nominator, denominator;

            int indexOfSlash = input.IndexOf("/", StringComparison.Ordinal);

            string leftSubstring = input.Substring(0, indexOfSlash);
            string rightSubstring = input.Substring(indexOfSlash + 1);

            if (!int.TryParse(leftSubstring, out nominator) ||
                !int.TryParse(rightSubstring, out denominator))
            {
                throw new FormatException();
            }

            return new Fraction(nominator, denominator);
        }

        private static Fraction ParseFractionWithInteger(string input)
        {
            int indexOfSpace = input.IndexOf(" ", StringComparison.Ordinal);
            string integerSubstring = input.Substring(0, indexOfSpace);
            string fractionSubstring = input.Substring(indexOfSpace + 1);

            Fraction fraction = ParseFraction(fractionSubstring);

            int integer;

            if (!int.TryParse(integerSubstring, out integer))
            {
                throw new FormatException();
            }

            // a b/c = (a*c + b) / c
            int nominator = integer * fraction.denominator + (integer > 0 ? fraction.nominator : -fraction.nominator);
            return new Fraction(nominator, fraction.denominator);
        }

        private static Fraction ParseFloatToFraction(string input)
        {
            int indexOfDecimalPart = input.IndexOf(",");
            string stringDecimalPart = input.Substring(indexOfDecimalPart + 1);
            int lengthOfDecimalPart = stringDecimalPart.Length;

            string stringIntPart = input.Substring(0, indexOfDecimalPart);
            
            int intPart, decimalPart;

            if (!int.TryParse(stringIntPart, out intPart) ||
                !int.TryParse(stringDecimalPart, out decimalPart))
            {
                throw new FormatException();
            }

            int denominator = 1;
            int i = 1;
            
            do
            {
                denominator *= 10;
                i++;
            }
            while (i <= lengthOfDecimalPart);

            return new Fraction(intPart * denominator + decimalPart, denominator);
        }

        private static Fraction ParseIntegerToFraction(string input)
        {
            int parsedInput;

            if (!int.TryParse(input, out parsedInput))
                throw new FormatException();

            return new Fraction(parsedInput, 1);
        }

        public static float ParseFractionToFloat(Fraction wynik)
        {
            float parsedNominator = (float)wynik.Nominator;
            float parsedDenominator = (float)wynik.Denominator;
            float wynikFloat = parsedNominator / parsedDenominator;
            return wynikFloat;
        }

        #endregion

        #region Operators/operations

        public static Fraction operator -(Fraction left, Fraction right)
        {
            if (left.Nominator - right.Nominator == 0 && left.Denominator == right.Denominator)
            {
                return new Fraction(0, 1);
            }

            int newNominator = left.nominator * right.denominator - right.nominator * left.denominator;
            int newDenominator = left.denominator * right.denominator;
            int gcd = GetGreatestCommonDivision(newNominator, newDenominator);

            newNominator = newNominator / gcd;
            newDenominator = newDenominator / gcd;

            return new Fraction(newNominator, newDenominator);
        }

        public static Fraction operator *(Fraction left, Fraction right)
        {
            return new Fraction(left.nominator * right.nominator, 
                left.denominator * right.denominator);
        }

        public static Fraction operator +(Fraction left, Fraction right)
        {
            // a/b + c/d = (a*d + c*b)/(b*d)
            if (left.Nominator + right.Nominator == 0)
            {
                return new Fraction(0, 1);
            }

            int newNominator = left.nominator * right.denominator + right.nominator * left.denominator;
            int newDenominator = left.denominator * right.denominator;
            int gcd = GetGreatestCommonDivision(newNominator, newDenominator);

            newNominator = newNominator / gcd;
            newDenominator = newDenominator / gcd;

            return new Fraction(newNominator, newDenominator);
        }

        public static Fraction operator /(Fraction left, Fraction right)
        {
            // a/b / c/d = a*d / b*c

            if (right.nominator == 0)
                throw new DivideByZeroException();

            int newNominator = left.nominator * right.denominator;
            int newDenominator = right.nominator * left.denominator;

            int gcd = GetGreatestCommonDivision(newNominator, newDenominator);

            newNominator = newNominator / gcd;
            newDenominator = newDenominator / gcd;

            return new Fraction(newNominator, newDenominator);
        }

        public static Fraction operator ^(Fraction left, int power)
        {
            int absPower = Math.Abs(power);

            if (power == 0)
            {
                return new Fraction(1, 1);
            }

            if (left.nominator == 0)
            {
                if (power < 0)
                    throw new ArithmeticException("0^0");

                return new Fraction(0, 1);
            }

            int newNominator = left.nominator;
            int newDenominator = left.denominator;

            int multiplierOfNominator = left.nominator;
            int multiplierOfDenominator = left.denominator;

            for (int i = 1; absPower > i; i++)
            {
                newNominator *= multiplierOfNominator;
                newDenominator *= multiplierOfDenominator;
            }

            if (power < 0)
            {
                int temp = newNominator;
                newNominator = newDenominator;
                newDenominator = temp;
            }

            return new Fraction(newNominator, newDenominator);
        }

        public static double Root(Fraction baseOfRoot)
        {
            float floatValue = ParseFractionToFloat(baseOfRoot);
            if (floatValue < 0)
            {
                throw new InvalidOperationException();
            }
            return Math.Round(Math.Sqrt(floatValue), 3);
        }

        #endregion

        #region Other

        private static int GetGreatestCommonDivision(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            if (a == 0 || b == 0)
            {
                return a > b ? a : b;
            }

            while (a != b)
            {
                if (a < b)
                {
                    b = b - a;
                }
                else
                {
                    if (b < a)
                    {
                        a = a - b;
                    }
                }
            }
            return a;
        }

        #endregion

        #region IEquatable<> implementation

        public bool Equals(Fraction frac)
        {
            if (ReferenceEquals(null, frac)) return false;
            if (ReferenceEquals(this, frac)) return true;
            return nominator == frac.nominator && denominator == frac.denominator;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            var a = obj as Fraction;
            return a != null && Equals(a);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (nominator*397) ^ denominator;
            }
        }

        public static bool operator ==(Fraction a, Fraction b)
        {
            // If both are null, or both are same instance, return true.
            if (System.Object.ReferenceEquals(a, b))
            {
                return true;
            }

            // If one is null, but not both, return false.
            if (((object)a == null) || ((object)b == null))
            {
                return false;
            }

            // Return true if the fields match:
            return a.nominator == b.nominator && a.denominator == b.denominator;
        }

        public static bool operator !=(Fraction a, Fraction b)
        {
            return !(a == b);
        }

        #endregion

        public override string ToString()
        {
            if (denominator == 1)
                return nominator.ToString();

            if (Math.Abs(nominator) > denominator)
                return string.Format("{0} {1}/{2}", nominator / denominator, Math.Abs(nominator % denominator), denominator);

            return string.Format("{0}/{1}", nominator, denominator);
        }
    }
}

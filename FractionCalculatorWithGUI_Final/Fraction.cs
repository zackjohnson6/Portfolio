namespace FractionCalculatorWithGUI_Final
{
    internal class Fraction : IComparable
    {
        public int numerator = 0;
         public int denominator = 1;
        public int CompareTo(object rightObject)
        {
            // typecast the object parameter to a Fraction
            Fraction rightFrac = (Fraction)rightObject;

            // get both Fractions as (comparable) doubles
            double f1 = (double)(this.numerator) / (double)(this.denominator);
            double f2 = (double)(rightFrac.numerator) / (double)(rightFrac.denominator);

            // compare the 2 doubles
            int retVal = 0;
            if (f1 < f2)
                retVal = -1;
            else if (f1 == f2)
                retVal = 0;
            else
                retVal = 1;

            return retVal;
        }
        public override bool Equals(object obj)
        {
            bool equals = false;
            if (obj is Fraction)
                equals = (this == (Fraction)obj);
            return equals;
        }
        public static Fraction Parse(String str)
        {

            Fraction newFraction = new Fraction();

            int indexSlash = str.IndexOf("/");
            if (indexSlash == -1)
            {
                throw new ArgumentException("'/' Character not detected. Please input '/' when writing the fraction.");
            }
            newFraction.numerator = int.Parse(str.Substring(0, indexSlash));
            newFraction.denominator = int.Parse(str.Substring(indexSlash + 1));

            return newFraction;
        }

        public static Fraction operator + (Fraction firstFrac, Fraction secondFrac)
        {
            Fraction sum = new Fraction();
            sum.numerator = ((firstFrac.numerator * secondFrac.denominator) + (secondFrac.numerator * firstFrac.denominator));
            sum.denominator = firstFrac.denominator * secondFrac.denominator;
            return sum;
        }
        public static Fraction operator - (Fraction firstFrac, Fraction secondFrac)
        {
            Fraction difference = new Fraction();
            difference.numerator = ((firstFrac.numerator * secondFrac.denominator) - (secondFrac.numerator * firstFrac.denominator));
            difference.denominator = firstFrac.denominator * secondFrac.denominator;
            return difference;
        }
        public static Fraction operator * (Fraction firstFrac, Fraction secondFrac)
        {
            Fraction product = new Fraction();
            product.numerator = firstFrac.numerator * secondFrac.numerator;
            product.denominator = firstFrac.denominator * secondFrac.denominator;
            return product;
        }
        public static Fraction operator / (Fraction firstFrac, Fraction secondFrac)
        {
            Fraction dividend = new Fraction();
            dividend.numerator = firstFrac.numerator * secondFrac.denominator;
            dividend.denominator = firstFrac.denominator * secondFrac.numerator;
            return dividend;
        }

        

        override public String ToString()
        {
            return numerator.ToString() + "/" + denominator.ToString();
        }
    }
}
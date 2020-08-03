using System;

public static class RealNumberExtension
{
    public static double Expreal(this int realNumber, RationalNumber r)
    {
        return Math.Pow(realNumber, (double)r.NumNumerator / r.Denominator);
    }
}

public struct RationalNumber
{
    private readonly (int vintNumerator, int vintDenominator) number;

    public int NumNumerator { get => number.vintNumerator; }

    public int Denominator { get => number.vintDenominator; }

    public RationalNumber(int numerator, int denominator)
    {
        if(denominator == 0 )
        {
            throw new ArgumentException("Denominator must be <> 0.");
        }
        int intGcd = Gcd(numerator, denominator);

        this.number = (numerator / intGcd, denominator / intGcd);
    }

    private static int Gcd(int a, int b)
    {
        return b == 0 ? a : Gcd(b, a % b);
    }

    public static RationalNumber operator +(RationalNumber r1, RationalNumber r2)
    {
        return new RationalNumber(r1.NumNumerator * r2.Denominator + r2.NumNumerator * r1.Denominator, r1.Denominator * r2.Denominator);
    }

    public static RationalNumber operator -(RationalNumber r1, RationalNumber r2)
    {
        return new RationalNumber(r1.NumNumerator * r2.Denominator - r2.NumNumerator * r1.Denominator, r1.Denominator * r2.Denominator);
    }

    public static RationalNumber operator *(RationalNumber r1, RationalNumber r2)
    {
        return new RationalNumber(r1.NumNumerator * r2.NumNumerator, r1.Denominator * r2.Denominator);
    }

    public static RationalNumber operator /(RationalNumber r1, RationalNumber r2)
    {
        return new RationalNumber(r1.NumNumerator * r2.Denominator, r1.Denominator * r2.NumNumerator);
    }

    public RationalNumber Abs()
    {
        return new RationalNumber(Math.Abs(NumNumerator), Math.Abs(Denominator));
    }

    public RationalNumber Reduce()
    {
        return this;
    }

    public RationalNumber Exprational(int power)
    {
        return new RationalNumber((int)Math.Pow(NumNumerator, power), (int)Math.Pow(Denominator, power));
    }
}
//submit C:\Users\eric\Exercism\csharp\rational-numbers\RationalNumbers.cs

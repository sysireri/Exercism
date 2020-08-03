using System;

public struct ComplexNumber
{
    private double mdblReal;
    private double mdblImaginary;

    public ComplexNumber(double real, double imaginary)
    {
        mdblReal = real;
        mdblImaginary = imaginary;
    }

    public double Real() => mdblReal;

    public double Imaginary() => mdblImaginary;

    public ComplexNumber Mul(ComplexNumber other)
        => new ComplexNumber(Real() * other.Real() - Imaginary() * other.Imaginary(), Imaginary() * other.Real() + Real() * other.Imaginary());

    public ComplexNumber Add(ComplexNumber other)
        => new ComplexNumber(Real() + other.Real(), Imaginary() + other.Imaginary());

    public ComplexNumber Sub(ComplexNumber other)
        => new ComplexNumber(Real() - other.Real(), Imaginary() - other.Imaginary());

    public ComplexNumber Div(ComplexNumber other)
    {
        double dblDividedReal = (Real() * other.Real() + Imaginary() * other.Imaginary()) / (Math.Pow(other.Real(), 2D) + Math.Pow(other.Imaginary(), 2D));
        double DblDividedmdblImaginary = (Imaginary() * other.Real() - Real() * other.Imaginary()) / (Math.Pow(other.Real(), 2D) + Math.Pow(other.Imaginary(), 2D));
        return new ComplexNumber(dblDividedReal, DblDividedmdblImaginary);
    }

    public double Abs() => Math.Sqrt(Math.Pow(Real(), 2D) + Math.Pow(Imaginary(), 2D));

    public ComplexNumber Conjugate() => new ComplexNumber(Real(), -Imaginary());

    public ComplexNumber Exp() =>
        new ComplexNumber(Math.Exp(Real()) * Math.Cos(Imaginary()), Math.Exp(Real()) * Math.Sin(Imaginary()));
}
//submit C:\Users\eric\Exercism\csharp\complex-numbers\ComplexNumbers.cs
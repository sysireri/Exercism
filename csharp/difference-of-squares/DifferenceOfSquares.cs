using System;
using System.Linq;

public static class DifferenceOfSquares
{
    public static int CalculateSquareOfSum(int max)
    {
        return (int)Math.Pow( Enumerable.Range(1, max).Sum(),2);
    }

    public static int CalculateSumOfSquares(int max)
    {
        return Enumerable.Range(1, max).Select(x => x * x).Sum();
    }
    public static int CalculateDifferenceOfSquares(int max)
    {
        return CalculateSquareOfSum(max) - CalculateSumOfSquares(max);
    }
}
//exercism submit C:\Users\eric\Exercism\csharp\difference-of-squares\DifferenceOfSquares.cs

//public static int CalculateSquareOfSum(int max)
//{
//    int intSum = 0;

//    for (int IntI = 1; IntI <= max; IntI++)
//    {
//        intSum += IntI;
//    }

//    return (int)Math.Pow(intSum, 2);
//}

//public static int CalculateSumOfSquares(int max)
//{
//    int intSum = 0;

//    for (int IntI = 1; IntI <= max; IntI++)
//    {
//        intSum += (int)Math.Pow(IntI, 2);
//    }

//    return intSum;
//}

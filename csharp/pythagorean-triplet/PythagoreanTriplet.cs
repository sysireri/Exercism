using System;
using System.Collections.Generic;

public static class PythagoreanTriplet
{
    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
    {
        List<(int, int, int)> lstTriplets = new List<(int, int, int)>();

        int intC = 0;

        for (int intA = 1; intA < sum; intA++)
        {
            for (int intB = intA + 1; intB < sum -1; intB++)
            {
                intC = sum - intA - intB;
                if (intC > intB && Math.Pow(intA, 2) + Math.Pow(intB, 2) == Math.Pow(intC, 2))
                {
                    lstTriplets.Add((intA, intB, intC));
                }
            }
        }
        return lstTriplets;
    }
}
// exercism submit C:\Users\eric\Exercism\csharp\pythagorean-triplet\PythagoreanTriplet.cs
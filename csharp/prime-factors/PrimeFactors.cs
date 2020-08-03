using System;
using System.Collections.Generic;

public static class PrimeFactors
{
    public static long[] Factors(long number)
    {
        List<long> lstFactors = new List<long>();
        long lngCurrentNumber = number;
        int intFactor = 0;

        while (lngCurrentNumber != 1)
        {
            intFactor = FirstFactor(lngCurrentNumber);
            lngCurrentNumber = lngCurrentNumber / intFactor;
            lstFactors.Add(intFactor);
        }
        return lstFactors.ToArray();
    }

    private static int FirstFactor(long lngNumber)
    {
        for (int i = 2; i <= lngNumber; i++)
        {
            if (lngNumber % i == 0)
                return i;
        }
        return 1;
    }
}
// submit C:\Users\eric\Exercism\csharp\prime-factors\PrimeFactors.cs
using System;
using System.Collections.Generic;
using System.Linq;
public static class SumOfMultiples
{
    public static int Sum(IEnumerable<int> multiples, int max)
    {
        List<int> lstResults = new List<int>() { };
        int intResult = 0;

        foreach (int intCurrent in multiples)
        {
            for (int intI = 1; intI < max; intI++)
            {
                intResult = intI * intCurrent;
                if (intResult < max && !lstResults.Contains(intResult))
                {
                    lstResults.Add(intResult);
                }
            }
        }

        return lstResults.Sum();

    }
}
// exercism submit C:\Users\eric\Exercism\csharp\sum-of-multiples\SumOfMultiples.cs
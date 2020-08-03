using System;
using System.Collections.Generic;
using System.Linq;

public static class Sieve
{
    public static int[] Primes(int limit)
    {
        HashSet<int> hasPrimes;

        if (limit < 2)
        {
            throw new ArgumentOutOfRangeException("ArgumentOutOfRangeException");
        }

        hasPrimes = Enumerable.Range(2, limit -1).ToHashSet();

        for (int intCurrentNumber = 2; intCurrentNumber <= limit; intCurrentNumber++)
        {
            if(hasPrimes.Contains(intCurrentNumber))
            {
                for(int intResult = intCurrentNumber * 2 ; intResult <= limit; intResult += intCurrentNumber)
                {
                    if (hasPrimes.Contains(intResult))
                    {
                        hasPrimes.Remove(intResult);
                    }
                }
            }
        }

        return hasPrimes.ToArray();
    }
}

//submit C:\Users\eric\Exercism\csharp\sieve\Sieve.cs
using System;
using System.Linq;
using System.Collections.Generic;
public static class AllYourBase
{
    public static int[] Rebase(int inputBase, int[] inputDigits, int outputBase)
    {
        List<int> lstRebases = new List<int>();
        int intRemainder = 0;
        int intInBase10 = 0;

        if (inputBase < 2)
        {
            throw new ArgumentException("invalid inputBase: use base 2 or more.");
        }
        if (inputDigits.Any(x => x > inputBase - 1 || x < 0))
        {
            throw new ArgumentException("invalid inputDigits.");
        }
        if (outputBase < 2)
        {
            throw new ArgumentException("invalid outputBase: use base 2 or more.");
        }
        if (inputDigits.All(x => x == 0))
        {
            lstRebases.Add(0);
        }
        else
        {
            // convert num to base 10:
            for (int intI = 0; intI < inputDigits.Length; intI++)
            {
                intInBase10 += (int)(inputDigits[intI] * Math.Pow(inputBase, inputDigits.Length - (intI + 1)));
            }
            //convert to requested base
            while (intInBase10 > 0)
            {
                intRemainder = intInBase10 % outputBase;
                lstRebases.Add(intRemainder);
                intInBase10 /= outputBase;
            }
        }

        lstRebases.Reverse();
        return lstRebases.ToArray();
    }
}
// submit C:\Users\eric\Exercism\csharp\all-your-base\AllYourBase.cs
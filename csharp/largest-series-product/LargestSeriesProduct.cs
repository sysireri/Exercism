using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic;

public static class LargestSeriesProduct
{
    public static long GetLargestProduct(string digits, int span) 
    {
        List<long> lstProducts = new List<long>();

        string strCurrentDigits = "";
        long lngCurrentProduct = 0;

        if(span < 0)
        {
            throw new ArgumentException("Invalid Parameter span. Must be => 0.");
        }

        if (span > digits.Length)
        {
            throw new ArgumentException("Invalid Parameter span. Must be <= digits.");
        }

        if(digits.ToUpper().Where(x => Char.IsLetter(x)).Any())
        {
            throw new ArgumentException("Invalid Parameter digits. Must be numeric.");
        }

        if(span == 0 )
        {
            lstProducts.Add(1);
        }
        else
        {
            for (int intCurrent = 0; intCurrent <= digits.Length - span; intCurrent += 1)
            {
                strCurrentDigits = digits.Substring(intCurrent, span);

                lngCurrentProduct = (long)strCurrentDigits.ToCharArray().Select(n => Convert.ToInt32(Char.GetNumericValue(n))).Aggregate((a, b) => a * b);
                lstProducts.Add(lngCurrentProduct);
            }

        }
        return lstProducts.Max();

    }
}
// exercism submit C:\Users\eric\Exercism\csharp\largest-series-product\LargestSeriesProduct.cs

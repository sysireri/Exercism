using System;
using System.Collections.Generic;
using System.Linq;

public static class Raindrops
{
    public static string Convert(int number)
    {
        string strRet = "";

        IEnumerable<int> lstPossibleFactors = null;
        lstPossibleFactors = from Factor in Enumerable.Range(1, number)
                             where number % Factor == 0 && (Factor == 3 || Factor == 5 || Factor == 7)
                             select Factor;

        if(lstPossibleFactors.Count() > 0)
        {

            if (lstPossibleFactors.Contains(3))
            {
                strRet += "Pling";
            }

            if (lstPossibleFactors.Contains(5))
            {
                strRet += "Plang";
            }

            if (lstPossibleFactors.Contains(7))
            {
                strRet += "Plong";
            }
        }
        else
        {
            strRet = number.ToString();
        }

        return strRet;
    }
}
//submit C:\Users\eric\Exercism\csharp\raindrops\Raindrops.cs
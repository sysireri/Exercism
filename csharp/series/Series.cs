using System;
using System.Collections.Generic;
using System.Linq;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        List<string> lstSlices = new List<string> {};

        if(sliceLength > numbers.Length || sliceLength <= 0 || numbers.Length == 0)
        {
            throw new ArgumentException("Invalid parameters.");
        }

        for (int intCurrent = 0; intCurrent <= numbers.Length - sliceLength ; intCurrent++)
        {
            lstSlices.Add(numbers.Substring(intCurrent, sliceLength));
        }

        return lstSlices.ToArray();
    }
}
//submit C:\Users\eric\Exercism\csharp\series\Series.cs
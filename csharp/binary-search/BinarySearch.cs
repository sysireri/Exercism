using System;
using System.Linq;
public static class BinarySearch
{
    public static int Find(int[] input, int value)
    {
        int intValue = -1;

        intValue = Array.BinarySearch(input.OrderBy(x => x).ToArray(), value);

        if(intValue < 0)
        {
            intValue = -1;
        }

        return intValue;
    }
}

//submit C:\Users\eric\Exercism\csharp\binary-search\BinarySearch.cs
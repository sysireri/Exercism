using System;
using System.Linq;

public static class Hamming
{
    public static int Distance(string firstStrand, string secondStrand)
    {
        if(firstStrand.Length != secondStrand.Length )
        {
            throw new ArgumentException("Both Strand must have same lenght.");
        }
        return firstStrand.Where((sourceChar, i) => sourceChar != secondStrand[i]).Count();
    }
}
//exercism submit C:\Users\eric\Exercism\csharp\hamming\Hamming.cs
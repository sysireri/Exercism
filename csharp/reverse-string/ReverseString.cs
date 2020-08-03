using System;
using System.Linq;

public static class ReverseString
{
    public static string Reverse(string input) => string.Concat(input.ToCharArray().Reverse());
}
//submit C:\Users\eric\Exercism\csharp\reverse-string\ReverseString.cs
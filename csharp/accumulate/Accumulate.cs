using System;
using System.Collections.Generic;
using System.Linq;

public static class AccumulateExtensions
{
    public static IEnumerable<U> Accumulate<T, U>(this IEnumerable<T> collection, Func<T, U> func)
    {
        foreach (T  CurrentItem in collection)
        {
          yield return func(CurrentItem);
        }
    }
}
// Commentaire pou tester GIT.
//exercism submit C:\Users\eric\Exercism\csharp\accumulate\Accumulate.cs

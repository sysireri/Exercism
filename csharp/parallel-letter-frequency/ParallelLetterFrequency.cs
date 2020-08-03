using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;

public static class ParallelLetterFrequency
{
    public static Dictionary<char, int> Calculate(IEnumerable<string> texts)
    {
        ConcurrentDictionary<char, int> dicCountLetter = new ConcurrentDictionary<char, int>();

        System.Threading.Tasks.Parallel.ForEach(texts, strCurrenttext =>
         {
             foreach(char chrCurrent in strCurrenttext.ToLower())
             {
                 if (char.IsLetter(chrCurrent))
                 {
                     dicCountLetter.AddOrUpdate(chrCurrent, 1, (Key, oldValue) => oldValue + 1);
                 }
             }
         });

        return dicCountLetter.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
    }
}

//submit C:\Users\eric\Exercism\csharp\parallel-letter-frequency\ParallelLetterFrequency.cs

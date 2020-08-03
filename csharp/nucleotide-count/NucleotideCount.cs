using System;
using System.Collections.Generic;
using System.Linq;

public static class NucleotideCount
{
    public static IDictionary<char, int> Count(string sequence)
    {
        Dictionary<char, int> dicDefaultDna = new Dictionary<char, int>
    {
        ['A'] = 0,
        ['C'] = 0,
        ['G'] = 0,
        ['T'] = 0
    };

        foreach(char chrCurrentSeq in sequence)
        {
            if( dicDefaultDna.ContainsKey(chrCurrentSeq))
            {
                dicDefaultDna[chrCurrentSeq]++;
            }
            else
            {
                throw new ArgumentException("Invalid nucleotides sequence.");
            }
        }

        return dicDefaultDna;
    }
}
//exercism submit C:\Users\eric\Exercism\csharp\nucleotide-count\NucleotideCount.cs
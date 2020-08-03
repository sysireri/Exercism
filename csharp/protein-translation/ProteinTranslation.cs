using System;
using System.Collections.Generic;

public static class ProteinTranslation
{
    private static Dictionary<string, string> mdictcodons = new Dictionary<string, string>()
    {
        { "AUG","Methionine"},

        { "UUU","Phenylalanine"},
        { "UUC","Phenylalanine"},

        { "UUA","Leucine"},
        { "UUG","Leucine"},

        { "UCU","Serine"},
        { "UCC","Serine"},
        { "UCA","Serine"},
        { "UCG","Serine"},

        { "UAU","Tyrosine"},
        { "UAC","Tyrosine"},

        { "UGU","Cysteine"},
        { "UGC","Cysteine"},

        { "UGG","Tryptophan"},

        { "UAA","STOP-REMOVE-AUG"},
        { "UAG","STOP"},
        { "UGA","STOP"},

    };

    private const int CondoLenght = 3;
    private const string STOP = "STOP";
    private const string STOP_REMOVE = "STOP-REMOVE";

    public static string[] Proteins(string strand)
    {
        List<string> lstProteins = new List<string>();
        string strCurrentProtein = "";


        for(int intCurrentPosition = 0; intCurrentPosition <= strand.Length -1;intCurrentPosition += CondoLenght)
        {
            strCurrentProtein = "";
            if(mdictcodons.TryGetValue(strand.Substring(intCurrentPosition, CondoLenght), out strCurrentProtein))
            {
                if(strCurrentProtein.StartsWith(STOP))
                {
                    break;
                }
                else if(strCurrentProtein.StartsWith(STOP_REMOVE))
                {
                    lstProteins.RemoveAt(lstProteins.Count - 1);
                    break;
                }
                else
                {
                    lstProteins.Add(strCurrentProtein);
                }
            }

        }

        return lstProteins.ToArray();

    }
}
//submit C:\Users\eric\Exercism\csharp\protein-translation\ProteinTranslation.cs
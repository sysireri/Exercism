using System;
using System.Collections.Generic;
using System.Linq;
public class Anagram
{
    private string mstrBaseWord = "";

    private string SortString(string strToSort) => String.Concat(strToSort.ToUpper().OrderBy(CurrentChar => CurrentChar));

    public Anagram(string baseWord)
    {
        mstrBaseWord = baseWord;
    }

    public string[] FindAnagrams(string[] potentialMatches)
    {
        string strBaseWordSorted = SortString(mstrBaseWord);
        string strCurrentPossibleMatchSorted ="";

        List<string> lstMatch = new List<string>();

        foreach (string strCurrentPossibleMatch in potentialMatches)
        {
            strCurrentPossibleMatchSorted = SortString(strCurrentPossibleMatch);
            if (strCurrentPossibleMatch.ToUpper() != mstrBaseWord.ToUpper())
            {
                if (strBaseWordSorted == strCurrentPossibleMatchSorted)
                {
                    lstMatch.Add(strCurrentPossibleMatch);
                }
            }
        }
        return lstMatch.ToArray();
    }
}

//submit C:\Users\eric\Exercism\csharp\anagram\Anagram.cs
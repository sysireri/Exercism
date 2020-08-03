using System;

public static class Acronym
{
    const string strSpace = " ";
    const string strMinus = "-";
    const string strUnderscore = "_";

    public static string Abbreviate(string phrase)
    {
        System.Text.StringBuilder objStringBuilder = new System.Text.StringBuilder("");
        bool bolExtractNextChar = false;

        foreach (char chrCurrent in strSpace + phrase.ToUpper())
        {
            if(bolExtractNextChar && (chrCurrent >= 'A' && chrCurrent <= 'Z'))
            {
                objStringBuilder.Append(chrCurrent);
            }
            bolExtractNextChar = chrCurrent.ToString() == strSpace || chrCurrent.ToString() == strMinus || chrCurrent.ToString() == strUnderscore;

        }
        return objStringBuilder.ToString();
    }
}

// exercism submit C:\Users\eric\Exercism\csharp\acronym\Acronym.cs
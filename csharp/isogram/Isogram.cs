using System;

public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        bool bolRet = true;

        string strBuffer ="";

        foreach (char chrCurrent in word.ToUpper())
        {
            if(chrCurrent >= 'A' && chrCurrent <= 'Z')
            {
                if (!strBuffer.Contains(chrCurrent))
                {
                    strBuffer += chrCurrent;
                }
                else
                {
                    bolRet = false;
                    break;
                }
            }
        }

        return bolRet;
    }
}
// exercism submit C:\Users\eric\Exercism\csharp\isogram\Isogram.cs
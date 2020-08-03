using System;
using System.Text.RegularExpressions;

public class SimpleCipher
{
    private int[] ArrNumericKeys;
    private string mstrKey = "";

    public string Key
    {
        get
        {
            return mstrKey;
        }
        private set
        {
            mstrKey = value;
        }
    }

    public SimpleCipher()
    {
        Random objRandom = new Random();
        for (int intI = 1; intI <= 100; intI++)
        {
            Key += (char)(objRandom.Next('a', 'z'));
        };

        // This array stores the difference of Ascii codes of my key characters from "aaaaaaaaa....."
        GenerateNumericKeys();
    }

    public SimpleCipher(string key)
    {
        if ((Regex.IsMatch(key, @"[^a-z]")) || key == "")
        {
            throw new ArgumentException("Key must be alphabetic and lowercase");
        };

        Key = key;
        GenerateNumericKeys();
    }
    public string Encode(string plaintext)
    {
        string strRet = "";
        int intCode = 0;
        int intJ = 0;

        foreach (char chrCurrent in plaintext)
        {
            intCode = (int)chrCurrent + ArrNumericKeys[intJ];
            if (intCode > 122)
            {
                intCode = intCode - 26;
            }

            strRet += (char)intCode;
            intJ++;
            if (intJ == ArrNumericKeys.Length)
            {
                intJ = 0;
            }
        };
        return strRet;
    }

    public string Decode(string ciphertext)
    {
        string strRet = "";
        int intCode = 0;
        int intJ = 0;

        foreach (char chrCurrent in ciphertext)
        {
            intCode = (int)chrCurrent - ArrNumericKeys[intJ];
            if (intCode < 97)
            {
                intCode = intCode + 26;
            }

            strRet += (char)intCode;
            intJ++;
            if (intJ == ArrNumericKeys.Length)
            {
                intJ = 0;
            }
        };
        return strRet;
    }

    private void GenerateNumericKeys()
    {
        ArrNumericKeys = new int[Key.Length];

        for (int intI = 0; intI < Key.Length; intI++)
        {
            ArrNumericKeys[intI] = (int)Key[intI] - ('a');
        };
    }
}

//submit C:\Users\eric\Exercism\csharp\simple-cipher\SimpleCipher.cs

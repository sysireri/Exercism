using System;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        System.Text.StringBuilder objStringBuilder = new System.Text.StringBuilder();
        int intValue = 0;

        foreach(char chrCurrentChar in text)
        {
            if(char.IsLetter(chrCurrentChar))
            {
                intValue = (char.ToLower(chrCurrentChar) - 97 + shiftKey) % 26;
                objStringBuilder.Append((char)(char.IsUpper(chrCurrentChar) ? (intValue + 65) : (intValue + 97)));
            }
            else
            {
                objStringBuilder.Append(chrCurrentChar);
            }
        }

        return objStringBuilder.ToString();
    }
}

//submit C:\Users\eric\Exercism\csharp\rotational-cipher\RotationalCipher.cs
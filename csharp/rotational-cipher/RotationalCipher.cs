using System;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        System.Text.StringBuilder objStringBuilder = new System.Text.StringBuilder();

        foreach(char chrCurrentChar in text)
        {
            if(char.IsLetter(chrCurrentChar))
            {
                int intCurrentAsciiCode = (char.ToLower(chrCurrentChar) - 'a' + shiftKey) % 26;
                objStringBuilder.Append((char)(char.IsUpper(chrCurrentChar) ? (intCurrentAsciiCode + 'A') : (intCurrentAsciiCode + 'a')));
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
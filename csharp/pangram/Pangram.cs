using System;
using System.Windows;
public static class Pangram
{
    private const byte bytMaxAscii = 255;

    public static bool IsPangram(string input)
    {

        bool bolRetVal = false;
        byte[] ArrChar;
        Int32 intAsciiValue = 0;
        int intI;
        try
        {
            ArrChar = new byte[bytMaxAscii];

            foreach (char chaCurrent in input.ToUpper())
            {
                intAsciiValue = (int)chaCurrent;
                ArrChar[intAsciiValue] = bytMaxAscii;
            }

            for (intI = 'A'; intI <= 'Z'; intI++)

            {
                if (ArrChar[intI] != bytMaxAscii)
                {
                    break;
                }
            }

            if(intI == 'Z' + 1)
            {
                bolRetVal = true;
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            Console.WriteLine("Stack Trace: " + System.Environment.NewLine + ex.StackTrace);
        }
        finally
        {
            ArrChar = null;
        }

        return bolRetVal;
    }
}

//exercism submit C:\Users\eric\Exercism\csharp\pangram\Pangram.cs

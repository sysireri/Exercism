using System;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        double dblTotal = 0;

        foreach(char chrCurrentNumber in number.ToString())
        {
            dblTotal += Math.Pow((int)char.GetNumericValue(chrCurrentNumber), number.ToString().Length);
        }

        return dblTotal == number;
    }
}
// submit C:\Users\eric\Exercism\csharp\armstrong-numbers\ArmstrongNumbers.cs
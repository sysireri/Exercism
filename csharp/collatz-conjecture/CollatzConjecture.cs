using System;

public static class CollatzConjecture
{
    public static int Steps(int number)
    {
        int intCount = 0;
        int intCurrentValue = number;

        if(number <= 0)
        {
            throw new ArgumentOutOfRangeException("Number must be positive.");
        }

        while (intCurrentValue != 1)
            {
                if (intCurrentValue % 2 == 0)
                    {
                        intCurrentValue /= 2;
                    }

                else
                    {
                        intCurrentValue = intCurrentValue * 3 + 1;
                    }

                intCount++;
            }

    return intCount;

    }
}

// exercism submit C:\Users\eric\Exercism\csharp\collatz-conjecture\CollatzConjecture.cs
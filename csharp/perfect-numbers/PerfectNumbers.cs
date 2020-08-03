using System;

public enum Classification
{
    Perfect,
    Abundant,
    Deficient
}

public static class PerfectNumbers
{
    public static Classification Classify(int number)
    {
        int intSumOfFactor = 0;
        Classification RetClassification;

        if(number <= 0 )
        {
            throw new ArgumentOutOfRangeException("Number must be > 0.");
        }

        for(int Inti = 1 ; Inti <= number / 2; Inti++)
            {
                if(number % Inti == 0)
                    {
                        intSumOfFactor += Inti;
                    }
            }

        if(intSumOfFactor == number)
        {
            RetClassification = Classification.Perfect;
        }
        else if(intSumOfFactor > number)
        {
            RetClassification = Classification.Abundant;
        }
        else
        {
            RetClassification = Classification.Deficient;
        }

        return RetClassification;

    }
}

// exercism submit C:\Users\eric\Exercism\csharp\perfect-numbers\PerfectNumbers.cs

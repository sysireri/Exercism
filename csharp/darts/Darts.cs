using System;

public static class Darts
{
    public static int Score(double x, double y)
    {
        int intScore = 0;

        // calculate distance from the centre
        double dblDistance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));

        switch (dblDistance)
        {
            case double dblToevaluate when dblToevaluate > 5 && dblToevaluate <= 10:
                intScore = 1;
                break;

            case double dblToevaluate when dblToevaluate > 1 && dblToevaluate <= 5:
                intScore = 5;
                break;

            case double dblToevaluate when dblToevaluate <= 1:
                intScore = 10;
                break;

            default:
                intScore = 0;
                break;
        }

        return intScore;

    }
}
//submit C:\Users\eric\Exercism\csharp\darts\Darts.cs
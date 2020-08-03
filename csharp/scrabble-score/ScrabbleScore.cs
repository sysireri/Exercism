using System;
using System.Collections.Generic;

public static class ScrabbleScore
{
    private static List<char> lstOnePoint = new List<char> { 'A', 'E', 'I', 'O', 'U', 'L', 'N', 'R', 'S', 'T' };
    private static List<char> lstTwoPointS = new List<char> { 'D', 'G' };
    private static List<char> lstThreePointS = new List<char> { 'B', 'C', 'M', 'P' };
    private static List<char> lstFourPointS = new List<char> { 'F', 'H', 'V', 'W', 'Y' };
    private static List<char> lstFivePointS = new List<char> { 'K' };
    private static List<char> lstHeightPointS = new List<char> { 'J', 'X' };
    private static List<char> lstTentPointS = new List<char> { 'Q', 'Z' };

    public static int Score(string input)
    {
        int intScore = 0;

        foreach(char chrCurrentChar in input.Trim().ToUpper())
            {
                if(lstOnePoint.Contains(chrCurrentChar))
                    {
                        intScore += 1;
                    }
                else if(lstTwoPointS .Contains(chrCurrentChar))
                    {
                        intScore += 2;
                    }
                else if (lstThreePointS .Contains(chrCurrentChar))
                    {
                        intScore += 3;
                    }
                else if (lstFourPointS.Contains(chrCurrentChar))
                    {
                        intScore += 4;
                    }
                else if (lstFivePointS.Contains(chrCurrentChar))
                    {
                        intScore += 5;
                    }
                else if (lstHeightPointS.Contains(chrCurrentChar))
                    {
                        intScore += 8;
                    }
                else if (lstTentPointS.Contains(chrCurrentChar))
                    {
                        intScore += 10;
                    }
        }

        return intScore;
    }
}

//exercism submit C:\Users\eric\Exercism\csharp\scrabble-score\ScrabbleScore.cs
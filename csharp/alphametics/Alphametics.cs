using System;
using System.Collections.Generic;
using System.Linq;

// My code is strongly inspired by : ErikSchierboom's solution
public static class Alphametics
{
    public static IDictionary<char, int> Solve(string equation)
    {
        return AlphameticsSolver.Solve(Parse(equation));
    }

    private static AlphameticsEquation Parse(string vstrEquation)
    {
        (string[] strLeft, string[] strRight) = ParseOperands(vstrEquation);
        return new AlphameticsEquation(strLeft, strRight);
    }

    private static (string[] Left, string[] Right) ParseOperands(string vstrEquation)
    {
        string[] leftAndRightOperands = vstrEquation.Split(" == ");
        string[] strLeft = leftAndRightOperands[0].Split(" + ");
        string[] strRight = leftAndRightOperands[1].Split(" + ");

        return (strLeft, strRight);
    }
}

public class AlphameticsEquation
{
    public Dictionary<char, long> dicLettersWithCount { get; } = new Dictionary<char, long>();
    public HashSet<char> hasNonZeroLetters { get; } = new HashSet<char>();

    public AlphameticsEquation(string[] vstrLeft, string[] vstrRight)
    {
        foreach (string leftSideOperand in vstrLeft)
            ProcessOperand(leftSideOperand, 1);

        foreach (string rightSideOperand in vstrRight)
            ProcessOperand(rightSideOperand, -1);
    }

    private void ProcessOperand(string vstrOperand, long lngMultiplyCountBy)
    {
        long lngLetterCount = lngMultiplyCountBy;
        char chrCurrentLetter = '\0';
        long lngexistingCount = 0;
        for (int i = vstrOperand.Length - 1; i >= 0; i--)
        {
            chrCurrentLetter = vstrOperand[i];
            if (dicLettersWithCount.TryGetValue(chrCurrentLetter, out lngexistingCount))
            {
                dicLettersWithCount[chrCurrentLetter] = lngexistingCount + lngLetterCount;
            }
            else
            {
                dicLettersWithCount[chrCurrentLetter] = lngLetterCount;
            }

            lngLetterCount *= 10;
        }

        hasNonZeroLetters.Add(vstrOperand[0]);
    }
}

public static class AlphameticsSolver
{
    private static AlphameticsEquation mobjEquation;

    public static IDictionary<char, int> Solve(AlphameticsEquation vobjEquation)
    {
        mobjEquation = vobjEquation;

        int[] intLetterCount = LetterCountCombinations(vobjEquation).FirstOrDefault(IsSolution);

        if(intLetterCount == null)
        {
            throw new ArgumentException();
        }
        return SolutionForLetterCount(intLetterCount);
    }

    private static IEnumerable<int[]> LetterCountCombinations(AlphameticsEquation vobjEquation)
        => Enumerable.Range(0, 10)
            .ToArray()
            .Permutations(vobjEquation.dicLettersWithCount.Count);

    private static bool IsSolution(int[] vintLetterCountCombination)
    {
        bool bolRet = false;

        if (LetterCountHasInvalidNonZeroLetter(vintLetterCountCombination))
        {
            bolRet = false;
        }
        else
        {
            bolRet= mobjEquation.dicLettersWithCount.Values
                    .Zip(vintLetterCountCombination, (count, solutionCount) => count * solutionCount).Sum() == 0;
        }

        return bolRet;
    }

    private static bool LetterCountHasInvalidNonZeroLetter(int[] vintLetterCountCombination)
    {
        int intZeroLetterIndex = Array.IndexOf(vintLetterCountCombination, 0);
        return intZeroLetterIndex != -1 && mobjEquation.hasNonZeroLetters.Contains(mobjEquation.dicLettersWithCount.Keys.ElementAt(intZeroLetterIndex));
    }

    private static Dictionary<char, int> SolutionForLetterCount(IEnumerable<int> vintLetterCount)
        => vintLetterCount
            .Zip(mobjEquation.dicLettersWithCount.Keys, (x, y) => new KeyValuePair<char, int>(y, x))
            .ToDictionary(x => x.Key, x => x.Value);
}

public static class EnumerableExtensions
{
    public static IEnumerable<T[]> Permutations<T>(this T[] source, int length)
    {
        IEnumerable<T[]> arrPermutations = null;

        if (length == 1)
        {
            arrPermutations = source.Select(t => new[] { t });
        }
        else
        {
            arrPermutations =  source.Permutations(length - 1)
                .SelectMany(t => source.Where(o => !t.Contains(o)),
                    (t1, t2) => t1.Concat(new T[] { t2 }).ToArray());
        }

        return arrPermutations;

    }

}
//submit C:\Users\eric\Exercism\csharp\alphametics\Alphametics.cs

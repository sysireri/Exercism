using System;
using System.Collections.Generic;
using System.Linq;

public class HighScores
{
    List<int> mlstIntHighScores;
    public HighScores(List<int> list) => mlstIntHighScores = list;

    public List<int> Scores() => mlstIntHighScores;

    public int Latest() => mlstIntHighScores.Last();

    public int PersonalBest() => mlstIntHighScores.Max();

    public List<int> PersonalTopThree() => mlstIntHighScores.OrderByDescending(i => i).Take(3).ToList();
}
//exercism submit C:\Users\eric\Exercism\csharp\high-scores\HighScores.cs

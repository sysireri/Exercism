using System;
using System.Collections.Generic;
using System.Linq;

public enum Plant
{
    Violets,
    Radishes,
    Clover,
    Grass
}

// Stringly inspired from : davidfrogley's solution
public class KindergartenGarden
{
    private string[] mstrRows;
    private IReadOnlyDictionary<string, int> mdicStudents = new Dictionary<string, int>
    {
        { "Alice", 0 },
        { "Bob", 2 },
        { "Charlie", 4 },
        { "David", 6 },
        { "Eve", 8 },
        { "Fred", 10 },
        { "Ginny", 12 },
        { "Harriet", 14 },
        { "Ileana", 16 },
        { "Joseph", 18 },
        { "Kincaid", 20 },
        { "Larry", 22 }
    };

    public KindergartenGarden(string diagram) => mstrRows = diagram.Split('\n');

    public IEnumerable<Plant> Plants(string student)
    {
        return mstrRows.SelectMany(CurrentRow => CurrentRow.Substring(mdicStudents[student], 2)).Select(CurrentChar => (CurrentChar) switch
        {
            'V' => Plant.Violets,
            'R' => Plant.Radishes,
            'C' => Plant.Clover,
            'G' => Plant.Grass,
             _ => throw new ArgumentException()
        });
    }
}
//submit C:\Users\eric\Exercism\csharp\kindergarten-garden\KindergartenGarden.cs
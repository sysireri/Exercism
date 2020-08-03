using System;
using System.Collections.Generic;
using System.Linq;

public static class Etl
{
    public static Dictionary<string, int> Transform(Dictionary<int, string[]> old)
    {
        Dictionary<string, int> dicTransformed = new Dictionary<string, int>();

        foreach (KeyValuePair<int,string[]> CurrentScore in old)
        {
            foreach (string strCurrentOldKey in CurrentScore.Value)
            {
                dicTransformed.Add(strCurrentOldKey.ToLower(), CurrentScore.Key);
            }
        }

        return dicTransformed;
    }
}
//submit C:\Users\eric\Exercism\csharp\etl\Etl.cs
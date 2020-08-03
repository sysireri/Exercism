using System;

public static class Proverb
{
    public static string[] Recite(string[] subjects)
    {
        string[] ArrSong = new string[subjects.Length];

        if (subjects.Length > 0)
        {
            for (int intI = 0; intI < subjects.Length - 1; intI++)
            {
                ArrSong[intI] = "For want of a " + subjects[intI] + " the " + subjects[intI + 1] + " was lost.";
            }

            ArrSong[subjects.Length - 1] = "And all for the want of a " + subjects[0] + ".";
        }

        return ArrSong;
    }
}
//submit C:\Users\eric\Exercism\csharp\proverb\Proverb.cs
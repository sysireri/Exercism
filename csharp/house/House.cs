using System;
using System.Collections.Generic;
using System.Linq;

public static class House
{
    private static List<(string subject,  string verb)> parts = new List<(string, string)>(){
        ("", ""),
        ("the malt", "lay in"),
        ("the rat", "ate"),
        ("the cat","killed"),
        ("the dog","worried"),
        ("the cow with the crumpled horn","tossed"),
        ("the maiden all forlorn","milked"),
        ("the man all tattered and torn", "kissed"),
        ("the priest all shaven and shorn", "married"),
        ("the rooster that crowed in the morn","woke"),
        ("the farmer sowing his corn","kept"),
        ("the horse and the hound and the horn","belonged to")
    };

    public static string Recite(int verseNumber)
    {
        System.Text.StringBuilder objStringBuilder = new System.Text.StringBuilder();

        objStringBuilder.Append("This is ");

            for (int IntI = verseNumber - 1; IntI >= 1; IntI--)
            {
                objStringBuilder.AppendFormat("{0} that {1} ", parts[IntI].subject, parts[IntI].verb);
            }

        objStringBuilder.Append("the house that Jack built.");

        return objStringBuilder.ToString();
    }

    public static string Recite(int startVerse, int endVerse)
    {
        System.Text.StringBuilder objStringBuilder = new System.Text.StringBuilder();
        int count = endVerse - startVerse + 1;

        objStringBuilder.AppendJoin("\n", Enumerable.Range(startVerse, count)
                                          .Select(CurrentVerse => Recite(CurrentVerse))
                                    );
        return objStringBuilder.ToString();
    }
}
//submit C:\Users\eric\Exercism\csharp\house\House.cs
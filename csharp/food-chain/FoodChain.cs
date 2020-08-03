using System;
using System.Collections.Generic;
using System.Text;

public static class FoodChain
{
    private static readonly IReadOnlyDictionary<int, string>
        dicStart = new Dictionary<int, string>()
    {
        {1, "a fly." },
        {2, "a spider.\nIt wriggled and jiggled and tickled inside her." },
        {3, "a bird.\nHow absurd to swallow a bird!" },
        {4, "a cat.\nImagine that, to swallow a cat!" },
        {5, "a dog.\nWhat a hog, to swallow a dog!" },
        {6, "a goat.\nJust opened her throat and swallowed a goat!" },
        {7, "a cow.\nI don't know how she swallowed a cow!" },
        {8, "a horse." }
    };

    private static readonly IReadOnlyDictionary<int, string>
        dicReason = new Dictionary<int, string>()
    {
        {2, "She swallowed the spider to catch the fly.\n" },
        {3, "She swallowed the bird to catch the spider " +
                "that wriggled and jiggled and tickled inside her.\n" },
        {4, "She swallowed the cat to catch the bird.\n"},
        {5, "She swallowed the dog to catch the cat.\n"},
        {6, "She swallowed the goat to catch the dog.\n"},
        {7, "She swallowed the cow to catch the goat.\n"}
    };

    public static string Recite(int startVerse, int endVerse)
    {
        StringBuilder objStringBuilder = new StringBuilder();
        for (; startVerse <= endVerse; startVerse++)
        {
            objStringBuilder.Append(Recite(startVerse));

            if (startVerse != endVerse)
            {
                objStringBuilder.Append("\n\n");
            }
        }
        return objStringBuilder.ToString();
    }

    public static string Recite(int verseNumber)
    {
        StringBuilder objStringBuilder = new StringBuilder();

        objStringBuilder.Append(AddStart(verseNumber));
        objStringBuilder.Append(AddMethodology(verseNumber));
        objStringBuilder.Append(AddOutcomeOfIt(verseNumber));

        return objStringBuilder.ToString();
    }

    private static string AddStart(int vintVerseNumber)
        => $"I know an old lady who swallowed {dicStart[vintVerseNumber]}\n";

    private static string AddMethodology(int vintVerseNumber)
    {
        StringBuilder objStringBuilder = new StringBuilder();

        while (dicReason.ContainsKey(vintVerseNumber))
        {
            objStringBuilder.Append(dicReason[vintVerseNumber--]);
        }

        return objStringBuilder.ToString();
    }

    private static string AddOutcomeOfIt(int intVerseNumber)
        => intVerseNumber < 8
        ? "I don't know why she swallowed the fly. Perhaps she'll die."
        : "She's dead, of course!";
}

//submit C:\Users\eric\Exercism\csharp\food-chain\FoodChain.cs
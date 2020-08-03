using System;
using System.Text;
public static class BeerSong
{
    public static string Recite(int startBottles, int takeDown)
    {
        System.Text.StringBuilder stringBuilder = new StringBuilder();

        for (int i = takeDown; i > 0; i--, startBottles--)
        {
            if (i != takeDown)
                stringBuilder.Append("\n\n");

            switch (startBottles)
            {
                case 0:
                    stringBuilder.Append(
                                        $"No more bottles of beer on the wall, no more bottles of beer.\n"
                                        + $"Go to the store and buy some more, 99 bottles of beer on the wall."
                                        );
                    break;

                case 1:
                    stringBuilder.Append(
                                        $"1 bottle of beer on the wall, 1 bottle of beer.\n"
                                        + $"Take it down and pass it around, no more bottles of beer on the wall."
                                        );
                    break;

                default:
                    stringBuilder.Append(
                                         $"{startBottles} bottles of beer on the wall, {startBottles} bottles of beer.\n"
                                         + $"Take one down and pass it around, {startBottles - 1} {(startBottles - 1 == 1 ? "bottle" : "bottles")} of beer on the wall.")
                                        ;
                    break;
            }
        }
        return stringBuilder.ToString();

    }
}
//submit C:\Users\eric\Exercism\csharp\beer-song\BeerSong.cs
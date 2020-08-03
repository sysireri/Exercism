using System;

public static class ResistorColor

{ 
    private static string[] strResistorColors = new[] { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };

    public static int ColorCode(string color) => Array.IndexOf(strResistorColors, color);

    public static string[] Colors() => strResistorColors;
}

// exercism submit C:\Users\eric\Exercism\csharp\resistor-color\ResistorColor.cs
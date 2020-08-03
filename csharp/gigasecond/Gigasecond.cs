using System;

public static class Gigasecond
{
    public static DateTime Add(DateTime moment) => moment.AddSeconds(1e9);

    // exercism submit C:\Users\eric\Exercism\csharp\gigasecond\Gigasecond.cs
}
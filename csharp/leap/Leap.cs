using System;

public static class Leap
{
    public static bool IsLeapYear(int year) => (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);

    // exercism submit C:\Users\eric\Exercism\csharp\leap\Leap.cs
}
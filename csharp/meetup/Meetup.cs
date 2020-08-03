using System;

public enum Schedule
{
    Teenth,
    First,
    Second,
    Third,
    Fourth,
    Last
}

public class Meetup
{
    private int mintMonth;
    private int mintYear;

    public Meetup(int month, int year)
    {
        mintMonth = month;
        mintYear = year;
    }

    public DateTime Day(DayOfWeek dayOfWeek, Schedule schedule)
    {
        DateTime Retdate = new DateTime();

        switch (schedule)
        {
            case Schedule.Teenth:
                {
                    Retdate = new DateTime(mintYear, mintMonth, 13);
                    while (Retdate.DayOfWeek != dayOfWeek)
                    {
                        Retdate = Retdate.AddDays(1);
                    }
                    break;
                }

            case Schedule.First:
                {
                    Retdate = new DateTime(mintYear, mintMonth, 1);
                    while (Retdate.DayOfWeek != dayOfWeek)
                    {
                        Retdate = Retdate.AddDays(1);
                    }
                    break;
                }

            case Schedule.Second:
                {
                    Retdate = new DateTime(mintYear, mintMonth, 8);
                    while (Retdate.DayOfWeek != dayOfWeek)
                    {
                        Retdate = Retdate.AddDays(1);
                    }
                    break;
                }

            case Schedule.Third:
                {
                    Retdate = new DateTime(mintYear, mintMonth, 15);
                    while (Retdate.DayOfWeek != dayOfWeek)
                    {
                        Retdate = Retdate.AddDays(1);
                    }
                    break;
                }

            case Schedule.Fourth:
                {
                    Retdate = new DateTime(mintYear, mintMonth, 22);
                    while (Retdate.DayOfWeek != dayOfWeek)
                    {
                        Retdate = Retdate.AddDays(1);
                    }
                    break;
                }

            case Schedule.Last:
                {
                    Retdate = new DateTime(mintYear, mintMonth, DateTime.DaysInMonth(mintYear, mintMonth));
                    while (Retdate.DayOfWeek != dayOfWeek)
                    {
                        Retdate = Retdate.AddDays(-1);
                    }
                    break;
                }
        }

        return Retdate;

    }
}

//exercism submit C:\Users\eric\Exercism\csharp\meetup\Meetup.cs
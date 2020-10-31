using System;

public class Clock : IEquatable<Clock>
{

    private const int intHoursPerDay = 24;
    private const int intMMinutesPerHour = 60;

    private int mintHours;
    private int mintMinutes;

    public Clock(int hours, int minutes)
    {
        mintHours = hours;
        mintMinutes = minutes;
    }

    public Clock Add(int minutesToAdd)
    {
        Clock newClock = new Clock(mintHours, mintMinutes + minutesToAdd);
        return newClock;
    }

    public Clock Subtract(int minutesToSubtract)
    {
        Clock newClock = new Clock(mintHours, mintMinutes - minutesToSubtract);
        return newClock;
    }

    public override string ToString()
    {
        CalculateClock();
        return mintHours.ToString("D2") + ":" + mintMinutes.ToString("D2");
    }

    public bool Equals(Clock other)
    {
        return (ToString().Equals(other.ToString()));
    }

    private void CalculateClock()
    {
        mintHours = mintHours + mintMinutes / intMMinutesPerHour;
        mintMinutes = mintMinutes % intMMinutesPerHour;
        if (mintMinutes < 0)
        {
            mintMinutes += intMMinutesPerHour;
            mintHours -= 1;
        }

        mintHours = mintHours % intHoursPerDay;
        if (mintHours < 0)
        {
            mintHours += intHoursPerDay;
        }
    }

}
//submit C:\Users\eric\Exercism\csharp\clock\Clock.cs
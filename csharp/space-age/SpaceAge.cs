using System;

public class SpaceAge
{
    private const int consIntEarthYear = 31557600;

    private int mintspaceAge;
    public SpaceAge(int seconds)
    {
        mintspaceAge = seconds;
    }

    private double mCalculateAge(double vdblOrbitalPeriod) => Math.Round(mintspaceAge / (consIntEarthYear * vdblOrbitalPeriod), 2);

    public double OnEarth() => mCalculateAge(1);

    public double OnMercury() => mCalculateAge(0.2408467);

    public double OnVenus() => mCalculateAge(0.61519726);

    public double OnMars() => mCalculateAge(1.8808158);

    public double OnJupiter() => mCalculateAge(11.862615);

    public double OnSaturn() => mCalculateAge(29.447498);

    public double OnUranus() => mCalculateAge(84.016846);

    public double OnNeptune() => mCalculateAge(164.79132);

}

//exercism submit C:\Users\eric\Exercism\csharp\space-age\SpaceAge.cs
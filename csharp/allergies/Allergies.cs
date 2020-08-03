
using System;
using System.Linq;
[Flags]
public enum Allergen
{
    Eggs = 1,
    Peanuts = 2,
    Shellfish = 4,
    Strawberries = 8,
    Tomatoes = 16,
    Chocolate = 32,
    Pollen = 64,
    Cats = 128
}

public class Allergies
{
    private Allergen EnuMask;

    public Allergies(int mask)
    {
        EnuMask = (Allergen)mask;
    }

    public bool IsAllergicTo(Allergen allergen)
    {
        //return (mintMask & (int)allergen) > 0;
        return EnuMask.HasFlag(allergen);
    }
    public Allergen[] List()
    {
        return Enum.GetValues(typeof(Allergen))
            .Cast<Allergen>()
            .Where(x => (IsAllergicTo(x)))
            .ToArray();
    }
}
//submit C:\Users\eric\Exercism\csharp\allergies\Allergies.cs
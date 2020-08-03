using System;

public static class Grains
{
    public static ulong Square(int n)
    {
            if(n <= 0 || n > 64 )
            {
                throw new ArgumentOutOfRangeException("Argument 'n' is out of range.  Bust be betwwen 1-64.");
            }

            return Convert.ToUInt64( Math.Pow(2, n - 1));
    }

    public static ulong Total()
    {
        ulong utlRet = 0;

        for(Int32 IntI = 1; IntI <= 64; IntI += 1)
        {

            utlRet += Square(IntI);
        }

        return utlRet;
    }

    // exercism submit C:\Users\eric\Exercism\csharp\grains\Grains.cs
}
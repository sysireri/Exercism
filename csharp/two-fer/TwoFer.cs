using System;

public static class TwoFer
{
    private const string strStartString = "One for ";
    private const string strEndString = ", one for me.";
    private const string strDefaultName = "you";

    // In order to get the tests running, first you need to make sure the Speak method 
    // can be called both without any arguments and also by passing one string argument.
    public static string Speak(string vstrName = strDefaultName)
    {
            return strStartString + vstrName + strEndString;
    }
}
// exercism submit C:\Users\eric\Exercism\csharp\two-fer\TwoFer.cs

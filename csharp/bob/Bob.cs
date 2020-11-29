using System;
using System.Linq;

public static class Bob
{
    static private bool IsAsking(string strStatement)
    {
        return strStatement.EndsWith('?');
    }
    static private bool IsShouting(string strStatement)
    {
        return strStatement.Any(char.IsLetter) && strStatement.Where(char.IsLetter).All(char.IsUpper);
    }
    public static string Response(string statement)
    {
        statement = statement.Trim();

        if (statement.Length == 0)
        {
            return "Fine. Be that way!";
        }

        if (IsAsking(statement) && IsShouting(statement))
        {
            return "Calm down, I know what I'm doing!";
        }

        if (IsShouting(statement))
        {
            return "Whoa, chill out!";
        }

        if (IsAsking(statement))
        {
            return "Sure.";
        }

        return "Whatever.";
    }
}

//submit C:\Users\eric\Exercism\csharp\bob\Bob.cs

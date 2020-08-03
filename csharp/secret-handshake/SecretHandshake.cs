using System;
using System.Collections.Generic;

public static class SecretHandshake

{
    private static Dictionary<int, string> dicSecrethandshake = new Dictionary<int, string>()
        {
        {1,"wink"},
        {2,"double blink"},
        {4,"close your eyes"},
        {8,"jump"}
        };

    public static string[] Commands(int commandValue)
    {
        List<string> lstReturnMessage = new List<string>();

        foreach (KeyValuePair<int, string> CurrentHandShake in dicSecrethandshake)
        {
            if ((commandValue & CurrentHandShake.Key) == CurrentHandShake.Key)
            {
                lstReturnMessage.Add(CurrentHandShake.Value);
            }
        }

        if ((commandValue & 16) != 0)
        {
            lstReturnMessage.Reverse();
        }

        return lstReturnMessage.ToArray();
    }
}
//submit C:\Users\eric\Exercism\csharp\secret-handshake\SecretHandshake.cs
using System;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        string strRet = "";

        foreach(char carCurrent in phoneNumber )
            {
                if (carCurrent >= '0' && carCurrent <= '9')
                    {
                       strRet += carCurrent;
                    }
            }

        if(strRet.StartsWith("1"))
        {
            strRet = strRet.Remove(0, 1);
        }

        if (strRet.Length == 10)
        {
            if (strRet.StartsWith("1") || strRet.StartsWith("0")  || strRet.Substring(3,1 ) == "1" || strRet.Substring(3, 1) == "0")
            {
                throw new ArgumentException("Invalid Phone Number.");
            }
        }
        else
        {
            throw new ArgumentException("Invalid Phone Number.");
      }
        return strRet;
    }
}
// exercism submit C:\Users\eric\Exercism\csharp\phone-number\PhoneNumber.cs
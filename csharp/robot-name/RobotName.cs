using System;
using System.Collections.Generic;
using System.Text;

public class Robot
{
    private static HashSet<string> mhasNames = new HashSet<string>();

    private Random mobjRandom = null;
    private string mstrCurrentName = "";

    public Robot()
        {
            mobjRandom = new Random();
            Name = mGetNextName();
        }
    public string Name
    {
        get
        {
            return mstrCurrentName;
        }
        private set
        {
            mstrCurrentName = value;
        }
    }

    private string mGetNextName()
    {

    string strName = mGenerateName();
        while (mhasNames.Add(strName) == false)
        {
            strName = mGenerateName();
        }
        return strName;
    }
    private string mGenerateName()
    {
        StringBuilder objStringBuilder = new StringBuilder();

        objStringBuilder.Append((char)mobjRandom.Next((int)'A', (int)'Z' + 1));
        objStringBuilder.Append((char)mobjRandom.Next((int)'A', (int)'Z' + 1));
        objStringBuilder.Append(mobjRandom.Next(0, 10).ToString());
        objStringBuilder.Append(mobjRandom.Next(0, 10).ToString());
        objStringBuilder.Append(mobjRandom.Next(0, 10).ToString());
        return objStringBuilder.ToString();
    }

    public void Reset()
    {
        if(mhasNames.Contains(Name))
        {
            mhasNames.Remove(Name);
            Name = mGetNextName();
        }
    }
}
//exercism submit C:\Users\eric\Exercism\csharp\robot-name\RobotName.cs

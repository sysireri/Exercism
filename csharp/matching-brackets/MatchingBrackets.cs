using System;
using System.Collections.Generic;

public static class MatchingBrackets
{
    public static bool IsPaired(string input)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char chrCurrentChar in input)
        {
            switch (chrCurrentChar)
            {
                case '[':
                    {
                        stack.Push(']');
                        break;
                    }

                case '{':
                    {
                        stack.Push('}');
                        break;
                    }
                case '(':
                    {
                        stack.Push(')');
                        break;
                    }
                case ')':
                case '}':
                case ']':
                    {
                        if (stack.Count > 0 && stack.Peek() == chrCurrentChar)
                        {
                            stack.Pop();
                        }
                        else
                        {
                            return false;
                        }

                        break;
                    }
            }
        }
        return stack.Count == 0;
    }
}

//submit C:\Users\eric\Exercism\csharp\matching-brackets\MatchingBrackets.cs
using System.Net.NetworkInformation;
using System.Collections.Generic;
using System;
using System.Collections;

namespace IsValid
{
    class Program
    {
        static bool IsValid(string s)
        {
            Stack st = new Stack();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(' || s[i] == '[' || s[i] == '{')
                {
                    st.Push(s[i]);
                }
                else if (s[i] == ')' || s[i] == ']' || s[i] == '}')
                {
                    if (st.Count == 0)
                    {
                        return false;
                    }
                    char cur = Convert.ToChar(st.Pop());
                    if (cur == '(' && s[i] != ')')
                    {
                        return false;
                    }
                    if (cur == '[' && s[i] != ']')
                    {
                        return false;
                    }
                    if (cur == '{' && s[i] != '}')
                    {
                        return false;
                    }
                }
            }
            if (st.Count == 0)
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            string s = "(]";
            System.Console.WriteLine(IsValid(s));
        }
    }
}

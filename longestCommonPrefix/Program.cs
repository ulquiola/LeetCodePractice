using System.Collections.Generic;
using System;

namespace longestCommonPrefix
{
    class Program
    {
        static string longestCommonPrefix(string[] strs)
        {
            string lcp = "";
            if (strs.Length == 0 || strs == null)
            {
                return lcp;
            }
            string min = strs[0];
            for(int i=0;i<strs.Length;i++)
            {
                if(strs[i].Length<min.Length)
                {
                    min=strs[i];
                }
            }
            for (int i = 0; i < min.Length; i++)
            {
                for (int k = 0; k < strs.Length; k++)
                {
                    if (min[i] != strs[k][i])
                    {
                        return lcp;
                    }
                }
                lcp += min[i];
            }
            return lcp;

        }
        static void Main(string[] args)
        {
            string[] s = { "ca","a" };
            System.Console.WriteLine(longestCommonPrefix(s));
        }
        
    }
}

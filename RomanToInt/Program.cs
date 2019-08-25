using System.Collections.Generic;
using System.Text;
using System;

namespace RomanToInt
{
    class Program
    {
        static int RomanToInt(string s)
        {
            int result = 0;
            char[] tar=s.ToCharArray();
            Dictionary<string, int> dic = new Dictionary<string, int>()
            {
              {"I",1},{"IV",4},{"V",5},{"IX",9},{"X",10},{"XL",40},{"L",50},
              {"XC",90},{"C",100},{"CD",400},{"D",500},{"CM",900},{"M",1000}
            };
            int i=0;
            while(i<tar.Length)
            {
                if(i+1<s.Length && dic.ContainsKey(tar[i].ToString()+tar[i+1]))
                {
                    result +=dic[tar[i].ToString()+tar[i+1]];
                    i+=2;
                }
                else{
                    result +=dic[(s[i]).ToString()];
                    i+=1;
                }
            }
            return result;

        }
        static void Main(string[] args)
        {
            string s = "IV";
            System.Console.WriteLine(RomanToInt(s));

        }
    }
}

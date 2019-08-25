using System;

namespace IsPalindrome
{
    class Program
    {
        static public bool IsPalindrome(int x)
        {
            bool result=false;
            int num=x;
            int reverse = 0;
            if (x < 0)
            {
                return false;
            }
            while (x != 0)
            {
                int pop = x % 10;
                reverse = reverse * 10 + pop;
                x = x / 10;
            }
            if (num == reverse)
            {
                result=true;
            }
            return result;

        }
        static void Main(string[] args)
        {
            System.Console.WriteLine(IsPalindrome(121));
        }
    }
}

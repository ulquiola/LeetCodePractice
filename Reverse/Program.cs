using System.Reflection;
using System.Collections.Generic;
using System.Text;
using System;

namespace Reverse
{
    class Program
    {
        static int Reverse(int x)
        {
            bool flag = false;
            long temp = 0;
            int result = 0;
            if (x > 0){                
            }
            else
            {
                x = -x; 
                flag = true;
            }
            while (x != 0)
            {
                int pop = x % 10;
                temp = temp * 10 + pop;
                x = x / 10;
            }
            if (temp > int.MaxValue || temp < int.MinValue)
            {
                return 0;
            }
            else
            {
                result = Convert.ToInt32(temp);
            }
            return result=flag?-result:result;
        }
        static void Main(string[] args)
        {
            int num = 1534236469;
            System.Console.WriteLine(Reverse(num));
        }
    }
}

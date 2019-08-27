using System.Collections.Generic;
using System;
using System.Collections;

namespace TwoSum
{
    class Program
    {
        static int[] TwoSum(int[] nums,int target)
        {
            var result = new int[2];
            Dictionary<int, int> dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                int currentNum = nums[i];//当前数
                int wanaGet = target - currentNum;//对比数
                if (dic.ContainsKey(wanaGet))
                {
                    result[1] = i;
                    result[0] = dic[wanaGet];
                }
                else//没有就添加入字典
                {
                    dic[currentNum] = i;//直接赋值就好，不能使用Add方法，会出现重复key异常
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            int[] nums={3,3};
            var res = TwoSum(nums,6);
            foreach(var i in res)
            {
                System.Console.WriteLine(i);
            }
        }
    }
}

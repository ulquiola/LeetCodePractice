using System.Collections.Generic;
using System;
using System.Collections;

namespace TwoSum
{
    class Program
    {
        static int[] TwoSum(int[] nums,int target)
        {
            Hashtable h =new Hashtable();
            for(int i=0;i<nums.Length;i++)
            {
                int wannaNum =target-nums[i];//3,3
                if(h.ContainsKey(wannaNum))
                {
                    return new int[] {i};
                }
                h[nums[i]]=i;
            }
            return null;
        }
        static void Main(string[] args)
        {
            int[] nums={3,3};
            TwoSum(nums,6);
            Console.WriteLine("Hello World!");
        
        }
    }
}

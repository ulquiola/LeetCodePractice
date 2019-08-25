using System.ComponentModel;
using System;

namespace QuickSort
{
    class Program
    {
        static int[] QuickSort(int[] nums,int left,int right)
        {
            if(left<right)
                {
                    int x =nums[left]; 
                int i=left;
                int j=right;
                while(i<j)
                {
                    while(i<j)
                    {
                        if(nums[j]<= x)
                        {
                            nums[i]=nums[j];
                            break;
                        }
                        else
                        {
                            j--;
                        }
                    }
                    while(i<j)
                    {
                        if(nums[i]>x)
                        {
                            nums[j]=nums[i];
                            break;
                        }
                        else
                        {
                            i++;
                        }
                    }
                    nums[i]=x;
                    QuickSort(nums,left,i-1);
                    QuickSort(nums,i+1,right);
                }
                return nums;   
            }
            return null;            
        }
        static void Main(string[] args)
        {
            int[] nums={1,5,3,2,4};
            QuickSort(nums,0,nums.Length-1);
            foreach(var i in nums)
            {
                System.Console.WriteLine(i);
            }
        }
    }
}

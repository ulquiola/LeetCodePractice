using System.Linq.Expressions;
using System;

namespace MergeTwoLists
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
        }
    }
    class Program
    {
        public class Solution
        {
            public ListNode MergeTwoLists(ListNode l1, ListNode l2)
            {
                if (l1 == null)
                {
                    return l2;
                }
                if (l2 == null)
                {
                    return l1;
                }
                if (l1.val < l2.val)
                {
                    l1.next = MergeTwoLists(l1.next, l2);
                    return l1;
                }
                else
                {
                    l2.next = MergeTwoLists(l1, l2.next);
                    return l2;
                }
            }
        }
        static void Main(string[] args)
        {
            ListNode l1 = new ListNode(1);
            ListNode l2 = new ListNode(2);
            ListNode l3 = new ListNode(4);
            ListNode m1 = new ListNode(1);
            ListNode m2 = new ListNode(3);
            ListNode m3 = new ListNode(4);

            l1.next = l2;
            l2.next = l3;
            l3.next = null;

            m1.next = m2;
            m2.next = m3;
            m3.next = null;

            Solution s = new Solution();
            var result = s.MergeTwoLists(l1, m1);
            while (result != null)
            {
                System.Console.WriteLine(result.val + " ");
                result = result.next;
            }

        }
    }
}

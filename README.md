# LeetCode 刷题思路与解法

###快速排序

```
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
```

1.给定一个整数数组 nums 和一个目标值 target，请你在该数组中找出和为目标值的那 两个 思路整数，并返回他们的数组下标。

你可以假设每种输入只会对应一个答案。但是，你不能重复利用这个数组中同样的元素。

示例:

给定 nums = [2, 7, 11, 15], target = 9

因为 nums[0] + nums[1] = 2 + 7 = 9
所以返回 [0, 1]

```
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
```

7.给出一个 32 位的有符号整数，你需要将这个整数中每位上的数字进行反转。

示例  1:

输入: 123
输出: 321
  示例 2:

输入: -123
输出: -321
示例 3:

输入: 120
输出: 21
注意:

假设我们的环境只能存储得下 32 位的有符号整数，则其数值范围为  [−231,  231 − 1]。请根据这个假设，如果反转后整数溢出那么就返回 0。

```
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
```

9.判断一个整数是否是回文数。回文数是指正序（从左向右）和倒序（从右向左）读都是一样的整数。

示例 1:

输入: 121
输出: true
示例  2:

输入: -121
输出: false
解释: 从左向右读, 为 -121 。 从右向左读, 为 121- 。因此它不是一个回文数。
示例 3:

输入: 10
输出: false
解释: 从右向左读, 为 01 。因此它不是一个回文数。

```
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
```

13.罗马数字包含以下七种字符: I， V， X， L，C，D  和  M。

字符 数值

```
I 1
V 5
X 10
L 50
C 100
D 500
M 1000
```

例如， 罗马数字 2 写做  II ，即为两个并列的 1。12 写做  XII ，即为  X + II 。 27 写做   XXVII, 即为  XX + V + II 。

通常情况下，罗马数字中小的数字在大的数字的右边。但也存在特例，例如 4 不写做  IIII，而是  IV。数字 1 在数字 5 的左边，所表示的数等于大数 5 减小数 1 得到的数值 4 。同样地，数字 9 表示为  IX。这个特殊的规则只适用于以下六种情况：

I  可以放在  V (5) 和  X (10) 的左边，来表示 4 和 9。
X  可以放在  L (50) 和  C (100) 的左边，来表示 40 和  90。 
C  可以放在  D (500) 和  M (1000) 的左边，来表示  400 和  900。
给定一个罗马数字，将其转换成整数。输入确保在 1  到 3999 的范围内。

示例  1:

输入: "III"
输出: 3
示例  2:

输入: "IV"
输出: 4
示例  3:

输入: "IX"
输出: 9
示例  4:

输入: "LVIII"
输出: 58
解释: L = 50, V= 5, III = 3.
示例  5:

输入: "MCMXCIV"
输出: 1994
解释: M = 1000, CM = 900, XC = 90, IV = 4.

```
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
```

14.编写一个函数来查找字符串数组中的最长公共前缀。

如果不存在公共前缀，返回空字符串  ""。

示例  1:

输入: ["flower","flow","flight"]
输出: "fl"
示例  2:

输入: ["dog","racecar","car"]
输出: ""
解释: 输入不存在公共前缀。
说明:

所有输入只包含小写字母  a-z 。

```
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
```

20.给定一个只包括 '('，')'，'{'，'}'，'['，']'  的字符串，判断字符串是否有效。

有效字符串需满足：

左括号必须用相同类型的右括号闭合。
左括号必须以正确的顺序闭合。
注意空字符串可被认为是有效字符串。

示例 1:

输入: "()"
输出: true
示例  2:

输入: "()[]{}"
输出: true
示例  3:

输入: "(]"
输出: false
示例  4:

输入: "([)]"
输出: false
示例  5:

输入: "{[]}"
输出: true

```
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
```

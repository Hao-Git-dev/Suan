using System;
using System.Buffers;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
//链表
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int x)
    {
        val = x;
    }
}
//JZ35的特殊链表
public class RandomListNode
{
    public int label;
    public RandomListNode next, random;
    public RandomListNode(int x)
    {
        this.label = x;
    }
}
namespace m
{
    public class Class1
    {
        //力扣394，字符串解码
        public string DecodeString(string s)
        {
            int k = 0, left = 0, right = 0;//为重复次数，左指针，右指针
            string strk = "", encoded = "", end = "";//k的字符格式，每次要重复的字符串，最终解码
            string t = "";//递归时的字符串
            while (right < s.Length)//右指针移动
            {
                //判断右指针指向的字符
                if (s[right] == '[')
                {
                    //为[时先判断左指针是否已经指向了一个[，即是否为[[]]这种格式
                    if (s[left] == '[')
                    {
                        //若是嵌套，找到所有嵌套内容，再走一遍该方法
                        List<int> leftList = new List<int>();//[数量
                        List<int> righList = new List<int>();//]数量
                        int r = right, l = right;
                        //通过[和]的数量判断，如果]比[多出一个，即嵌套的格式结束
                        while (leftList.Count != righList.Count - 1)
                        {
                            r = s.IndexOf(']', r + 1);//查找下一个]的位置
                            l = s.IndexOf('[', l + 1);//查找下一个[的位置
                            if (r > l && l > 0)//右括号在左括号的右边是存储即为[]
                            {
                                righList.Add(r);
                                leftList.Add(l);
                            }
                            else//否则只存储右括号即搜索到的为][ 
                            {
                                righList.Add(r);
                            }
                            
                        }
                        t = encoded;//将已经查找到的encoded给t
                        for (int j = right; j <= r; j++)//从右指针开始向后遍历到外层右括号，即在encoded的基础上加上endcoded没有的外层[]内部的内容
                        {
                            t += s[j];
                        }
                        encoded = DecodeString(t);//再次调用该方法解内部的码
                        right = r + 1;//解完右指针直接跳到外层括号后面
                        continue;

                    }
                    //如果左指针没有指向[即将左指针指向该[开始记录内部的字符
                    left = right;
                    right++;
                }
                else if (s[right] == ']')//右指针指向]即为结束，开始解码
                {
                    k = Convert.ToInt32(strk);
                    for (int j = 0; j < k; j++)
                    {
                        end += encoded;
                    }
                    encoded = "";
                    strk = "";
                    right++;
                    left = right;//解码后移开左指针
                }
                else if (s[left] == '[')//右指针没有指向括号，判断左指针是否指向了
                {
                    //若指向了记录字符到encoded，以便解码时重复
                    encoded += s[right].ToString();
                    right++;
                }
                else//两个指针都没有指向括号，即为最外层内容，为数字strk记录，为字符，直接添加到最终结果中
                {
                    if ('0' <= s[right] && '9' >= s[right])
                    {
                        strk += s[right];
                    }
                    else
                    {
                        end += s[right];
                    }
                    right++;
                }
            }
            return end;
        }
        //剑指
        public string JZ5(string s)
        {
            //return s.Replace(" ", "%20");
            string s1 = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                    s1 += "%20";
                }
                else
                {
                    s1 += s[i];
                }
            }
            return s1;
        }
        public int JZ10(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }
            return JZ10(n - 1) + JZ10(n - 2);
        }
        public int[] JZ17(int n)
        {
            int l = 9;
            for (int i = 1; i < n; i++)
            {
                l = l * 10 + 9;
            }
            int[] nums = new int[l];
            for (int i = 0; i < l; i++)
            {
                nums[i] = i + 1;
            }
            return nums;
        }
        public int JZ50(string str)
        {
            // write code here
            //Dictionary<char,int> keyValuePairs = new Dictionary<char,int>();
            List<char> chars = new List<char>();//存储出现过一次的字符
            for (int i = 0; i < str.Length; i++)//遍历字符串
            {
                if (chars.Contains(str[i]))//出现过了
                {
                    chars.Remove(str[i]);//移除
                }
                else
                {
                    chars.Add(str[i]);//没出现过，添加
                }
            }
            if (chars.Count == 0)//全部重复返回-1
            {
                return -1;
            }
            for (int i = 0; i < str.Length; i++)//查找都一个的下标
            {
                if (chars[0] == str[i])
                {
                    return i;
                }
            }
            return -1;//运行不到这里
        }
        #region 剑指分类:数据结构_链表题
        public List<int> JZ6(ListNode listNode) 
        {
            List<int> list = new List<int>();//数组存储链表值
            ListNode  p = listNode;
            while(p != null)
            {
                list.Add(p.val);//数组存储
                p = p.next;
            }
            List<int> l = new List<int>();
            for (int i = list.Count - 1; i >= 0; i--)//反向存储
            {
                l.Add(list[i]);
            }
            return l;
        }
        public ListNode JZ24(ListNode head)
        {
            //将链表值存入数组
            List<int> list = new List<int>();
            ListNode p = head;
            while (p != null)
            {
                list.Add(p.val);
                p = p.next;
            }
            //重新指向头节点
            p = head;
            //数组值反向给链表
            for (int i = list.Count - 1; i >= 0 && p != null; i--)
            {
                if (i == list.Count - 1)
                {
                    //当为第一个时定义为头节点
                    head = p;
                }
               p.val = list[i];
               p = p.next;
            }
            return head;
        }
        public ListNode JZ25(ListNode pHead1, ListNode pHead2)
        {
            // write code here
            ListNode p = pHead1,head = pHead2;
            if (pHead1 == null || pHead2 == null)//有空链表返回另一个链表，都为空返回空
            {
                p = pHead1 == null ? pHead2 : pHead1;
                return p;
            }
            ListNode pt1 = pHead1, pt2 = pHead2;
            if (pHead1.val > pHead2.val)//找到最小的头节点，并将指针向后移
            {
                p = pHead2;
                pt1 = pHead1;
                pt2 = pHead2.next;
            }
            else
            {
                p = pHead1;
                pt1 = pHead2;
                pt2 = pHead1.next;
            }
            head = p;//记录头节点
            //不断对比两个指针指向的数字，指向小的，被指向的指针向后移动
            while (p != null)
            {    
                //有一方为null了则不断记录另一方
                if (pt1 == null && pt2 == null)
                {
                    break;
                }
                if (pt1 == null)
                {
                    p.next = pt2;
                    pt2 = pt2.next;
                    p = p.next;
                    continue;
                }
                if (pt2 == null)
                {
                    p.next = pt1;
                    pt1 = pt1.next;
                    p = p.next;
                    continue;
                }
                if (pt1.val < pt2.val)
                {
                    p.next = pt1;
                    pt1 = pt1.next;
                }
                else
                {
                    p.next = pt2;
                    pt2 = pt2.next;
                }
                p = p.next;
            }
            return head;
        }
        public ListNode JZ51(ListNode pHead1, ListNode pHead2)
        {
            ListNode p1 = pHead1, p2 = pHead2;
            //查找两个链表相差多少，再将长的链表减去差值，因为末尾相同，前面一定不会相同
            while (p1 != null && p2 != null)
            {
                p1 = p1.next;
                p2 = p2.next;
            }
            int n = 0;
            if (p1 == null)
            {
                while (p2 != null)
                {
                    n++;
                    p2 = p2.next;
                }
                p1 = pHead1;
                p2 = pHead2;
                for (int i = 0; i < n; i++)
                {
                    p2 = p2.next;
                }
            }
            else
            {
                while (p1 != null)
                {
                    n++;
                    p1 = p1.next;
                }
                p1 = pHead1;
                p2 = pHead2;
                for (int i = 0; i < n; i++)
                {
                    p1 = p1.next;
                }
            }
            //只剩两个相同长度的链表，向后遍历，节点相同即返回
            while (p1 != null && p2 != null)
            {
                if (p1 == p2)
                {
                    return p1;
                }
                p1 = p1.next;
                p2 = p2.next;
            }
            //没有相同返回null
            return null;
        }
        public ListNode JZ23(ListNode pHead)//数组或哈希存储判断超出题目要求空间复杂度,未完成
        {
            List<ListNode> listNodes = new List<ListNode>();
            ListNode p = pHead;
            while (p != null)
            {
                if (listNodes.Contains(p))
                {
                    return p;
                }
                else
                {
                    listNodes.Add(p);
                }
                p = p.next;

            }
            return null;
        }
        public ListNode JZ22(ListNode pHead, int k)
        {
            ListNode p = pHead;
            int n = 0;
            //查找链表的总位数
            while (p != null)
            {
                n++;
                p = p.next;
            }
            p = pHead;
            //如果n-k小于0，则证明链表总长度小于k，返回null
            if (n - k < 0)
            {
                return null;
            }
            //倒数第k位是正数第n - k位的下一个节点,通过循环找到节点
            for (int i = 0; i < n - k; i++)
            {
                p = p.next;
            }
            return p;
        }
        public ListNode JZ18(ListNode head, int val)
        {
            // write code here
            ListNode p = head;//p为当前节点
            ListNode p2 = head;//p2为上一个节点
            //先判断一次头节点
            if (p.val == val)
            {
                //如果头节点是目标值，则直接返回头节点的next即可
                return head.next;
            }
            else
            {
                p = p.next;
            }
            while (p != null)
            {
                if (p.val == val)//查找要删除的点
                {
                    p2.next = p.next;//找到后直接让前一个节点的值指向后一个即可
                    break;
                }
                else
                {
                    //若不是继续前移
                    p = p.next;
                    p2 = p2.next;
                }
            }
            return head;
        }
        public ListNode JZ76(ListNode pHead)
        {
            //为空退出
            if (pHead == null)
            {
                return null;
            }
            ListNode left = pHead;//左指针为第一位
            ListNode last = new ListNode(0);//头前面添加一个作为左指针之前的一个
            last.next = pHead;
            pHead = last;//重新定义头指针
            ListNode right = left.next;//右指针在左指针的后一个
            if (right == null)//右指针为空表示只有一个结点，直接返回
            {
                return pHead.next;
            }
            while (right.next != null)//右指针指向最后一个时退出
            {
                if (right.val == left.val)//左右指针所指节点的值是否相等
                {
                    right = right.next;//相等右指针移动
                }
                else if(left.next != right)//不相等判断左指针下一个是不是右指针，不是说明刚遇到重复节点
                {
                    left = right;//重复结束，改变左右指针的位置脱离重复区域,然后循环进行下次判断
                    right = right.next;
                }
                else//不相等且没有遇到重复，更改三个指针的位置
                {
                    last.next = left;
                    left = left.next;
                    right = right.next;
                    last = last.next;
                }
            }
            //退出循环时右指针指向最后一个，需要判断
            if (right.val == left.val)//左右相等，说明最后节点重复
            {
                last.next = null;//直接指向空
            }
            else if (left.next != right)//左右不相等但刚经历重复，越过重复指向右指针
            {
                last.next = right;
            }
            else//左右不相等且没有刚经历重复，指向左指针
            {
                last.next = left;
            }
            return pHead.next;//返回头节点的下一个，即去除添加的节点
        }
        public RandomListNode JZ35(RandomListNode pHead)
        {
            if (pHead == null)//为空返回空
            {
                return null;
            }
            // write code here
            RandomListNode p = pHead;//定义指针
            RandomListNode randomListNode = new RandomListNode(0);//新的链表
            RandomListNode p2 = randomListNode;//新链表的指针
            //使新链表中的值等于pHead的值
            while (p != null)
            {
                p2.label = p.label;
                if (p.next != null)//如果链表下一个节点为空，则不为新链表创建新节点
                {
                    p2 = p2.next = new RandomListNode(0);
                }
                p = p.next;
            }
            //指针归位
            p2 = randomListNode;
            p = pHead;
            while (p != null)
            {
                if (p.random == null)//如果链表的random指向空，新链表也直接指向空
                {
                    p2.random = null;
                }
                else//否则查找指向第几个节点，并让新链表也指过去
                {
                    int i = 0;//指向第几个节点
                    RandomListNode p3 = pHead;//指针用于查找被指向的节点
                    while (p.random != p3)//查找被指向的节点
                    {
                        p3 = p3.next;
                        i++;
                    }
                    RandomListNode p4 = randomListNode;//指针用于定位应该被指向的节点
                    for (int k = 0; k < i; k++)//查找
                    {
                        p4 = p4.next;
                    }
                    p2.random = p4;//找到后指过去
                }
                p = p.next;
                p2 = p2.next;
            }
            return randomListNode;
        }
        #endregion
    }
}

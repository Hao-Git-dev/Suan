// See https://aka.ms/new-console-template for more information
using m; 

Console.WriteLine("Hello, World!");
Class1 class1 = new Class1();
//Console.WriteLine(class1.DecodeString("3[z]2[2[y]pq4[2[jk]e1[f]]]ef"));
//Console.WriteLine(class1.JZ5("We Are Happy"));
//Console.WriteLine(class1.JZ10(4));
/*
ListNode node = new ListNode(0);
ListNode p = node;
for (int i = 1; i < 10; i++)
{
    p.next = new ListNode(i);
    p = p.next;
}
p = node;
while (p != null)
{
    Console.WriteLine(p.val);
    p = p.next;
}
foreach (var item in class1.JZ6(node))
{
    Console.WriteLine(item);
}
*/

/*
ListNode node = new ListNode(0);
ListNode node1 = new ListNode(1);
ListNode p = node, p1 = node1;
for (int i = 2; i < 10; i++)
{
    if (i%2 == 0)
    {
        p.next = new ListNode(i);
        p = p.next;
    }
    else
    {
        p1.next = new ListNode(i);
        p1 = p1.next;
    }
}
p = node;
p1 = node1;
while (p != null)
{
    Console.Write(p.val + ",");
    p = p.next;
}
Console.WriteLine();
while (p1 != null)
{
    Console.Write(p1.val + ",");
    p1 = p1.next;
}
p = class1.JZ25(node, node1);
Console.WriteLine();
while (p != null)
{
    Console.Write(p.val + ",");
    p = p.next;
}
*/
/*
ListNode node = new ListNode(1);
ListNode p = node;
for (int i = 0; i < 7; i++)
{
    int n = Convert.ToInt32(Console.ReadLine());
    p.next = new ListNode(n);
    p = p.next;
}
p = node;
while (p != null)
{
    Console.Write(p.val + ",");
    p = p.next;
}
Console.WriteLine();
p = class1.JZ76(node);
while (p != null)
{
    Console.Write(p.val + ",");
    p = p.next;
}
*/
RandomListNode pHead = new RandomListNode(0);
RandomListNode p = pHead;
while (true)
{
    Console.Write("输入值");
    string s = Console.ReadLine();
    if (s == "E")
    {
        break;
    }
    //p = new RandomListNode(Convert.ToInt32(s));
    p.label = Convert.ToInt32(s);
    p = p.next = new RandomListNode(0);
}
p = pHead;
while (p != null)
{
    Console.Write(p.label + ",");
    p = p.next;
}
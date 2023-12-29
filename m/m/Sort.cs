/// <summary>
/// 10000随机数排序时间（自测）
/// 插入：00:00:00.1158842
/// 冒泡：00:00:00.3357724
/// 选择：00:00:00.1098786
/// 希尔：00:00:00.0025604
/// </summary>
public class SortTest
{
    static void Main(string[] args)
    {
        //Random rd = new Random();
        //Stopwatch sw = new Stopwatch();
        //int[] nums = new int[10000];
        ////int[] nums = { 99, 46, 4, 5, 24, 56, 5 };
        //for (int i = 0; i < nums.Length; i++)
        //{
        //    nums[i] = rd.Next(32767);
        //}
        //foreach (int item in nums)
        //{
        //    Console.Write(item + " ");
        //}
        //Console.WriteLine();
        //sw.Start();
        ////nums= InsertionSort(nums);
        ////nums = BubbleSort(nums);
        ////nums = SelectSort(nums);
        //nums = ShellSort(nums);
        //sw.Stop();
        //for (int i = 0; i < nums.Length-1; i++)
        //{
        //    if (nums[i] > nums[i + 1])
        //    {
        //        Console.WriteLine("错错错");
        //    }
        //}
        //foreach (int item in nums)
        //{
        //    Console.Write(item + " ");
        //}

        //Console.WriteLine("\n"+sw.Elapsed);
        int[] a = { 9, 7, 1, 10, 5 };
        int n = a.Length;
        for (int i = n - 1; i >= 0; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                if (a[j - 1] > a[j])
                {
                    int t = a[j - 1];
                    a[j - 1] = a[j];
                    a[j] = t;
                }
            }
        }
        foreach (int item in a)
        {
            Console.Write(item + " ");
        }
        Console.ReadKey();
    }
    /// <summary>
    /// 插入排序
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    static int[] InsertionSort(int[] nums)
    {
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] < nums[i - 1])
            {
                for (int j = i; j > 0; j--)
                {
                    if (nums[j] > nums[j - 1])
                    {
                        break;
                    }
                    else
                    {
                        int temp = nums[j];
                        nums[j] = nums[j - 1];
                        nums[j - 1] = temp;
                    }
                }
            }
        }
        return nums;
    }
    /// <summary>
    /// 冒泡
    /// </summary>
    /// <param name="nums">传入的数组</param>
    /// <returns></returns>
    static int[] BubbleSort(int[] nums)
    {
        for (int i = 1; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length - i; j++)
            {
                if (nums[j] > nums[j + 1])
                {
                    int temp = nums[j];
                    nums[j] = nums[j + 1];
                    nums[j + 1] = temp;
                }
            }
        }
        return nums;
    }
    /// <summary>
    /// 选择排序
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    static int[] SelectSort(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            int min = i;
            for (int j = i; j < nums.Length; j++)
            {
                if (nums[j] < nums[min])
                {
                    min = j;
                }
            }
            int temp = nums[i];
            nums[i] = nums[min];
            nums[min] = temp;
        }
        return nums;
    }
    /// <summary>
    /// 希尔排序
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    static int[] ShellSort(int[] nums)
    {
        int i = nums.Length / 2;
        while (i >= 1)
        {
            for (int j = 0; j + i < nums.Length; j++)
            {
                if (nums[j] > nums[j + i])
                {
                    for (int k = j; k >= 0; k -= i)
                    {
                        if (nums[k] > nums[k + i])
                        {
                            int temp = nums[k];
                            nums[k] = nums[k + i];
                            nums[k + i] = temp;
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            i /= 2;
        }
        return nums;
    }
}

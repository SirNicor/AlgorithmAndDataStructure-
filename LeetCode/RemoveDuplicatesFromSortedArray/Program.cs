public static class Program
{
    public static void Main(string[] args)
    {
        var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();   
        int k = RemoveDuplicates(nums);
        foreach (int num in nums)
        {
            Console.Write(num + " ");
        }
        Console.Write(Environment.NewLine + $"k - {k}");
    }

    private static int RemoveDuplicates(int[] nums)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int[] subNums = new int[nums.Length];
        int i = 0;
        foreach (var num in nums)
        {
            if (dict.ContainsKey(num))
            {
                continue;
            }
            subNums[i] = num;
            i++;
            dict.Add(num, 1);
        }
        subNums.CopyTo(nums, 0);
        return i;
    }
}
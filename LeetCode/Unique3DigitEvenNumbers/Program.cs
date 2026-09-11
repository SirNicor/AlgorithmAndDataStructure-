public class Programm
{
    public static void Main()
    {
        int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();
        Console.WriteLine(TotalNumbers(arr));
    }
    
    public static int TotalNumbers(int[] digits)
    {
        int count = 0;
        Dictionary<int, int> dict = new Dictionary<int, int>();
        foreach (int num in digits)
        {
            if (!dict.TryAdd(num, 1))
            {
                dict[num]++;
            }
        }
        for (int i = 100; i < 1000; i+=2)
        {
            var miniDict = new Dictionary<int, int>();
            int[] nums = new int[3];
            nums[0] = i % 10;
            nums[1] = i / 10 % 10;
            nums[2] = i/100;
            foreach (int num in nums)
            {
                if (!miniDict.TryAdd(num, 1))
                {
                    miniDict[num]++;
                }
            }

            bool y = true;
            foreach (var item in miniDict)
            {
                if(dict.TryGetValue(item.Key, out var val))
                {
                    if (val < item.Value)
                    {
                        y = false;
                    }
                }
                else
                {
                    y = false;
                }
            }

            if (y)
            {
                count++;
            }
        }

        return count;
    }
}
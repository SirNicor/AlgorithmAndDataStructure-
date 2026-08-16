namespace ContainsDuplicate;

public static class Program
{
    public static void Main()
    {
        //Given an integer array nums, return true if any value appears more than once in the array, otherwise return false.
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Console.WriteLine(HashVariant(nums));
    }

    private static bool BroodForce(int[] nums)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int i1 = i+1; i1 < nums.Length; i1++)
            {
                if (nums[i] == nums[i1])
                {
                    return true;
                }
            }
        }

        return false;
    }

    private static bool HashVariant(int[] nums)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        foreach (var t in nums)
        {
            if (dict.ContainsKey(t))
            {
                return true;
            }
            else
            {
                dict.Add(t, 1);
            }
        }

        return false;
    }
}
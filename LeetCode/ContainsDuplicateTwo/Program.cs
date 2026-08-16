namespace ContainsDuplicate;

public static class Program
{
    public static void Main()
    {
        //Given an integer array nums and an integer k, return true if there are two distinct indices i and j in the array such that nums[i] == nums[j] and abs(i - j) <= k.
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine(Hash(nums, k));
    }

    private static bool Hash(int[] nums, int k)
    {
        Dictionary<int, int[]> dict = new Dictionary<int, int[]>();
        int i = 0;
        foreach (var t in nums)
        {
            if (dict.ContainsKey(t))
            {
                if (Math.Abs(i - dict[t][1]) <= k)
                {
                    return true;
                }

                dict[t][1] = i;
            }
            else
            {
                dict.Add(t, [1, i]);
            }

            i++;
        }

        return false;
    }
}
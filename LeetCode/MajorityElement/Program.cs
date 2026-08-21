public class Programm
{
    public static void Main()
    {
        /**Given an array nums of size n, return the majority element.

The majority element is the element that appears more than ⌊n / 2⌋ times. You may assume that the majority element always exists in the array. **/
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Console.WriteLine(MajorityElementWithoutDict(nums));
        Console.WriteLine(MajorityElementWithDict(nums));
    }

    private static int MajorityElementWithoutDict(int[] nums)
    {
        int major = nums[0];
        int count = 1;

        for (int i = 1; i < nums.Length; ++i) {
            if (count == 0)
            {
                count = 1;
                major = nums[i];
            }

            else if (major == nums[i])
            {
                ++count;
            }

            else
            {
                --count;
            }

        }
        return major;
    }
    
    private static int MajorityElementWithDict(int[] nums)
    {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        int aver = nums.Length/2;
        foreach (var t in nums)
        {
            if (!dict.TryAdd(t, 1))
            {
                dict[t]++;
            }

            if (dict[t] > aver)
            {
                return t;
            }
        }

        return 0;
    }
}
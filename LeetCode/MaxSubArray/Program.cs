public static class Programm
{
    public static void Main()
    {
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        Console.WriteLine(MaxSubArray(nums));
    }
    
    public static int MaxSubArray(int[] nums)
    {
        int max, maxSubArray;
        max = nums[0];
        maxSubArray = nums[0];
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] < 0)
            {
                if (maxSubArray + nums[i] > 0)
                {
                    maxSubArray += nums[i];
                }
                else
                {
                    maxSubArray = nums[i];
                }
            }
            else
            {
                if (maxSubArray + nums[i] >= nums[i])
                {
                    maxSubArray += nums[i];
                }
                else
                {
                    maxSubArray = nums[i];
                }
            }
            if (maxSubArray > max)
            {
                max = maxSubArray;
            }
        }

        return max;
    }
}
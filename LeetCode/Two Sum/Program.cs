public class Program
{
    public static void Main()
    {
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int target = Convert.ToInt32(Console.ReadLine());
        int[] result = TwoSum(nums, target);
        foreach (int num in result)
        {
            Console.WriteLine(num);
        }
    }

    private static int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(target - nums[i]))
            {
               return [dict[target - nums[i]], i];
            }
            if (dict.ContainsKey(nums[i]))
            {
                dict[nums[i]] = i;
            }
            else
            {
                dict.Add(nums[i], i);
            }
        }

        return null;
    }
}
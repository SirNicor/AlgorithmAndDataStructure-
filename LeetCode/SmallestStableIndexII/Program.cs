public class Program
{
    public static void Main()
    {
        int[] nums = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
        int k = int.Parse(Console.ReadLine());
        Console.WriteLine(FirstStableIndex(nums, k));
    }
    
    public static int FirstStableIndex(int[] nums, int k)
    {
        int length = nums.Length, max = nums[0];
        int[] minNumbers = new int[length];
        minNumbers[length - 1] = nums[length - 1];
        for (int i = length - 2; i > -1; i--)
        {
            if (nums[i] < minNumbers[i + 1])
            {
                minNumbers[i] = nums[i];
            }
            else
            {
                minNumbers[i] = minNumbers[i + 1];
            }
        }

        for (int i = 0; i < length; i++)
        {
            if (nums[i] > max)
            {
                max = nums[i];
            }

            if (max - minNumbers[i] <= k)
            {
                return i;
            }
        }

        return -1;
    }
}
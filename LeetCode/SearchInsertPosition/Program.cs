public class Programm
{
    public static void Main()
    {
        int[] nums = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
        int target = int.Parse(Console.ReadLine());
        Console.WriteLine(SearchInsert(nums, target));
    }
    
    public static int SearchInsert(int[] nums, int target)
    {
        int left = 0, right = nums.Length - 1;
        if (nums[left] > target)
        {
            return 0;
        }
        while (left <= right)
        {
            int mid = (left + right) / 2;
            if (nums[mid] == target)
            {
                return mid;
            }
            if (nums[mid] > target)
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }
        return right + 1;
    }
}
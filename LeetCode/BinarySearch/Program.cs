public class Programm
{
    public static void Main()
    {
        int[] nums = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
        int target = int.Parse(Console.ReadLine());
        Console.WriteLine(Search(nums, target));
    }
    
    public static int Search(int[] nums, int target) {
        int left = 0, right = nums.Length-1;
        if (nums[0] == target)
        {
            return 0;
        }
        while(left<=right)
        {
            int mid = (left + right) / 2;
            if(nums[mid] > target)
            {
                right = mid-1;
            }
            else if(nums[mid] < target)
            {
                left = mid+1;
            }
            else
            {
                return mid;
            }
        }

        return -1;
    }
}
public class Programm
{
    public static void Main()
    {
        /**Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.
            Note that you must do this in-place without making a copy of the array.**/
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        MoveZeroes(nums);
        foreach (var num in nums)
        {
            Console.Write(num + " ");
        }
    }

    private static void MoveZeroes(int[] nums) {
        int index = 0;
        foreach (var t in nums)
        {
            if (t != 0)
            {
                nums[index] = t;
                index++;
            }
        }

        for (int i = index; i < nums.Length; i++)
        {
            nums[i] = 0;
        }
    }
}
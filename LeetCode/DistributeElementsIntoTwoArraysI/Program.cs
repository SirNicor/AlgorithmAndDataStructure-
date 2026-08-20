public class Programm
{
    public static void Main()
    {
        /**You are given a 1-indexed array of distinct integers nums of length n.
            You need to distribute all the elements of nums between two arrays arr1 and arr2 using n operations.
             In the first operation, append nums[1] to arr1. In the second operation, append nums[2] to arr2. Afterwards, in the ith operation:
        If the last element of arr1 is greater than the last element of arr2, append nums[i] to arr1. Otherwise, append nums[i] to arr2.
            The array result is formed by concatenating the arrays arr1 and arr2. For example, if arr1 == [1,2,3] and arr2 == [4,5,6], then result = [1,2,3,4,5,6].
            Return the array result.**/
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] result = ResultArray(nums);
        foreach (var t in result)
        {
            Console.Write(t + " ");
        }
    }
    
    public static int[] ResultArray(int[] nums) {
        List<int> left = new List<int>();
        List<int> right = new List<int>();
        left.Add(nums[0]);
        right.Add(nums[1]);
        int leftIndex = 0,  rightIndex = 0;
        for (int i = 2; i < nums.Length; i++)
        {
            if (left[leftIndex] > right[rightIndex])
            {
                left.Add(nums[i]);
                leftIndex++;
            }
            else
            {
                right.Add(nums[i]);
                rightIndex++;
            }
        }
        left.CopyTo(nums, 0);
        right.CopyTo(nums, leftIndex+1);
        return nums;
    }
}
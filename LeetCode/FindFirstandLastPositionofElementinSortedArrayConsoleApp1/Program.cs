using System.Globalization;

public class Programm
{
    public static void Main()
    {
        int[] nums = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
        int target = int.Parse(Console.ReadLine());
        int[] res = SearchRange(nums, target);
        Console.WriteLine(res[0] + " " + res[1]);
    }
    public static int[] SearchRange(int[] nums, int target)
    {
        int left = 0, right = nums.Length - 1, index = -1, rightEnd, leftEnd;
        while (left <= right)
        {
            int mid = (left+right)/2;
            if(nums[mid] == target)
            {
                index = mid;
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

        if (index == -1)
        {
            return [-1, -1];
        }

        if (index + 1 < nums.Length)
        {
            if(nums[index+1] == target)
            {
                left = index + 1;
                right = nums.Length-1;
                int subTarget = target + 1;
                while (left <= right)
                {
                    int mid = (left+right)/2;
                    if (nums[mid] >= subTarget)
                    {
                        right = mid - 1;
                    }
                    else
                    {
                        left = mid + 1;
                    }
                }
                rightEnd = right - 1;
            }
            else
            {
                rightEnd = index;
            }
        }
        else
        {
            rightEnd = index;
        }

        if (index - 1 > -1)
        {
            if(nums[index-1] == target)
            {
                right = index - 1;
                left = 0;
                int subTarget = target - 1;
                while (left <= right)
                {
                    int mid = (left+right)/2;
                    if (nums[mid] > subTarget)
                    {
                        right = mid - 1;
                    }ч
                    else
                    {
                        left = mid + 1;
                    }
                }
                leftEnd = left + 1;
            }
            else
            {
                leftEnd = index;
            }
        }
        else
        {
            leftEnd = index;
        }

        return [leftEnd, rightEnd];
    }
}
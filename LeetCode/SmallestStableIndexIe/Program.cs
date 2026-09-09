public class Programm
{
    public static void Main()
    {
        
    }
    
    public static int FirstStableIndex(int[] nums, int k) {
        int[] arrayWithMaxNumbers = new int[nums.Length], arrayWithMinNumbers = new int[nums.Length];
        int length = nums.Length;
        for (int i = 0; i < length; i++)
        {
            if (i == 0)
            {
                arrayWithMaxNumbers[i] = nums[i];
                arrayWithMinNumbers[length-1-i] = nums[length-1-i];
                continue;
            }

            if (nums[i] > arrayWithMaxNumbers[i - 1])
            {
                arrayWithMaxNumbers[i] = nums[i];
            }
            else
            {
                arrayWithMaxNumbers[i] = arrayWithMaxNumbers[i - 1];
            }
            
            if (nums[length-1-i] < arrayWithMinNumbers[length-i])
            {
                arrayWithMinNumbers[length-1-i] = nums[length-1-i];
            }
            else
            {
                arrayWithMinNumbers[length-1-i] = arrayWithMinNumbers[length-i];
            }
        }

        for (int i = 0; i < length; i++)
        {
            if (arrayWithMaxNumbers[i] - arrayWithMinNumbers[i] <= k)
            {
                return i;
            }
        }

        return -1;
    }
}
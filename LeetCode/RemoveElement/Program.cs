public class Programm
{
    public static void Main()
    {
        int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int val = int.Parse(Console.ReadLine());
        val = RemoveElement(nums, val);
        Console.WriteLine("val - " + val);
        foreach (int num in nums)
        {
            Console.Write(num + " ");
        }
    }
    
    public static int RemoveElement(int[] nums, int val) {
        int[] result = new int[nums.Length];
        int index = 0;
        foreach (int num in nums)
        {
            if (num != val)
            {
                result[index] = num;
                index++;
            }
        }
        result.CopyTo(nums, 0);
        return index;
    }
}
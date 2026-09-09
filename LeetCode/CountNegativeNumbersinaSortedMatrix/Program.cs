public class Programm
{
    public static void Main()
    {
        int count = int.Parse(Console.ReadLine());
        int[][] grid = new int[count][];
        for (int i = 0; i < count; i++)
        {
            grid[i] = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
        }
        Console.WriteLine(CountNegatives(grid));
    }
    
    public static int CountNegatives(int[][] grid)
    {
        int count = 0, length = grid[0].Length;
        foreach (var array in grid)
        {
            if (array[length-1] >= 0)
            {
                continue;
            }

            int left = 0, right = length - 1;
            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (array[mid] >= 0)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            count += length - left;
        }
        return count;
    }
}
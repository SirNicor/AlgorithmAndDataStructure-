using System.Reflection.Metadata;

public static class Programm
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(IsPerfectSquare(n));
    }
    
    public static bool IsPerfectSquare(int num)
    {
        int left = 0, right = num;
        while (left <= right)
        {
            int mid = left+(right-left)/2;
            if ((long)mid * mid < num)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }

        if (left * left == num || right * right == num)
        {
            return true;
        }
        return false;
    }
}
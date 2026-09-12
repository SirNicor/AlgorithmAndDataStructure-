public static class Programm
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(MySqrt(n));
    }
    
    public static int MySqrt(int x)
    {
        int left = 0, right = x;
        while (left <= right)
        {
            int mid = left+(right-left)/2;
            if (mid * mid == x)
            {
                return mid;
            }
            if ((long)mid * mid < x)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
        }
        
        return right;
    }
}
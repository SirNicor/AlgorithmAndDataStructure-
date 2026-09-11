public class GuessProg
{
    private static int _quess;
    public static void Main()
    {
        _quess = int.Parse(Console.ReadLine());
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(GuessNumber(n));
    }
    
    public static int GuessNumber(int n)
    {
        int left = 1, right = n;
        while (left <= right)
        {
            int mid = left + (right-left) / 2;
            int res = Guess(mid);
            if (res == 0)
            {
                return mid;
            }
            if (res == 1)
            {
                left = mid + 1;
            }
            else if (res == -1)
            {
                right = mid - 1;
            }
        }

        return -1;
    }

    public static int Guess(int n)
    {
        if (n == _quess)
        {
            return 0;
        }
        if (n > _quess)
        {
            return -1;
        }

        return 1;
    }
}
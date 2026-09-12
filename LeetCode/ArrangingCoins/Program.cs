public static class Programm
{
    public static void Main()
    {
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(ArrangeCoins(num));
    }
    
    public static int ArrangeCoins(int n)
    {
        long k = 0;
        int count = 1;
        while (k <= n)
        {
            if (k == n)
            {
                return count - 1;
            }
            k += count;
            count++;
        }
        return count - 2;
    }
}
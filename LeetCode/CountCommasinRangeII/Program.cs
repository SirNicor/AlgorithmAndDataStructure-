public class Programm
{
    public static void Main()
    {
        
    }
    
    public long CountCommas(long n) {
        long count0 = 1_000_000L - 1_000L;
        long count1 = 1_000_000_000L - 1_000_000L;
        long count2 = 1_000_000_000_000L - 1_000_000_000L;
        long count3 = 1_000_000_000_000_000L - 1_000_000_000_000L;
        if (n - 999 < 1)
        {
            return 0;
        }
        if (n < Math.Pow(10, 6))
        {
            return n - 999;
        }
        if(n < Math.Pow(10, 9))
        {
            return count0 + (n - 999 - count0) * 2;
        }
        if (n < Math.Pow(10, 12))
        {
            return count0 + count1 * 2 + (n - 999 - count0 - count1) * 3;
        }
        if (n < Math.Pow(10, 15))
        {
            return count0 + count1 * 2 + count2 * 3 + (n - 999 - count0 - count1 - count2) * 4;
        }

        return count0 + count1 * 2 + count2 * 3 + count3 * 4 + 5;
    }
}
public class Programm
{
    public static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(CountCommas(n));
    }
    public static int CountCommas(int n)
    {
        int x = n - 999;
        if (x < 0)
        {
            return 0;
        }

        return x;
    }
}
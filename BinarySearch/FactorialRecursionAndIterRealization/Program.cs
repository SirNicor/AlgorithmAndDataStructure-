namespace FactorialRecursionAndIterRealization;

public static class Programm
{
    public static void Main()
    {
        Console.WriteLine("Input your number");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("FactorialRec - " + FactorialRec(number));
        Console.WriteLine("FactorialIter - "+ FactorialIter(number));

    }

    public static int FactorialRec(int x)
    {
        if (x == 1)
        {
            return x;
        }
        else
        {
            return x * FactorialRec(x - 1);
        }
    }
    public static int FactorialIter(int x)
    {
        int res = 1;
        while (x != 0)
        {
            res = res * x;
            x--;
        }

        return res;
    }
}
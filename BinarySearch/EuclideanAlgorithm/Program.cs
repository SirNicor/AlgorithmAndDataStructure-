public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Input your numbers separated by a space: ");
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int number1 = numbers[0], number2 = numbers[1];
        Console.WriteLine("Rec variant - " + EuclidianAlgorithmRec(number1, number2));
        Console.WriteLine("Iter variant - " + EuclidianAlgorithmIter(number1, number2));
    }

    private static int EuclidianAlgorithmRec(int number1, int number2)
    {
        if (number1 == 0)
        {
            return number2;
        }
        else if(number2 == 0)
        {
            return number1;
        }
        if (number1 < number2)
        {
            number2 %= number1;
        }
        else
        {
            number1 %= number2;
        }
        return EuclidianAlgorithmRec(number1, number2);
    }

    private static int EuclidianAlgorithmIter(int number1, int number2)
    {
        while (number1 != 0 && number2 !=0)
        {
            if (number1 < number2)
            {
                number2 %= number1;
            }
            else
            {
                number1 %= number2;
            }
        }
        return number1 == 0 ? number2 : number1;
    }
}
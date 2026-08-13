public class Programm
{
    const int Length = 100;
    private const int MaxNumber = 100;
    private static void Main()
    {
        int[] arr0 = new int[Length], arr1 = new int[Length];
        Random rnd = new Random();
        Console.WriteLine("NonSorted Array: ");
        for(int i = 0; i < Length; i++)
        {
            int x = rnd.Next(1, MaxNumber);
            arr0[i] = x;
            arr1[i] = x;
            Console.Write(arr0[i] + " ");
        }
        //DESC sort, O(n^2)
        Console.WriteLine(Environment.NewLine + "DESC sorted Array: ");
        int currentIndex = 0;
        while (currentIndex < Length - 1)
        {
            int maxNumber = arr0[currentIndex+1], indexMaxNumber = currentIndex;
            for (int i = currentIndex + 1; i < Length; i++)
            {
                if (arr0[i] > maxNumber)
                {
                    maxNumber = arr0[i];
                    indexMaxNumber = i;
                }
            }

            if (currentIndex != indexMaxNumber)
            {
                (arr0[currentIndex], arr0[indexMaxNumber]) = (arr0[indexMaxNumber], arr0[currentIndex]);
            }
            currentIndex++;
        }
        foreach (int number in arr0)
        {
            Console.Write(number + " ");
        }
        //ASC sort
        Console.WriteLine(Environment.NewLine + "ASC sorted Array: "); 
        currentIndex = 0;
        while (currentIndex < Length - 1)
        {
            int minNumber = arr1[currentIndex+1], indexMinNumber = currentIndex;
            for (int i = currentIndex + 1; i < Length; i++)
            {
                if (arr1[i] < minNumber)
                {
                    minNumber = arr1[i];
                    indexMinNumber = i;
                }
            }

            if (currentIndex != indexMinNumber)
            {
                (arr1[currentIndex], arr1[indexMinNumber]) = (arr1[indexMinNumber], arr1[currentIndex]);
            }
            currentIndex++;
        }
        foreach (int number in arr1)
        {
            Console.Write(number + " ");
        }
    }
}
namespace MergeSort;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Input your numbers separated by a space: ");
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        numbers = QuickSort(numbers);
        Console.WriteLine("Sorted numbers: ");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
    }

    public static T[] QuickSort<T>(T[] inputArray)
    {
        if (inputArray.Length < 2)
        {
            return (T[])inputArray.Clone();
        }
        int middleIndex = inputArray.Length/2;
        var equal = new List<T> {inputArray[middleIndex]};
        List<T> left = new List<T>();
        var right = new List<T>();
        for(int i = 0; i < inputArray.Length; i++)
        {
            if (i == middleIndex)
            {
                continue;
            }

            int compare = Comparer<T>.Default.Compare(inputArray[i], equal[0]);
            if (compare < 0)
            {
                left.Add(inputArray[i]);
            }
            else if(compare > 0)
            {
                right.Add(inputArray[i]);
            }
            else
            {
                equal.Add(inputArray[i]);
            }
        }
        var result = new T[inputArray.Length];
        QuickSort(left.ToArray()).CopyTo(result, 0);
        equal.CopyTo(result, left.Count);
        QuickSort<T>(right.ToArray()).CopyTo(result, left.Count + equal.Count);
        return result;
    }
}
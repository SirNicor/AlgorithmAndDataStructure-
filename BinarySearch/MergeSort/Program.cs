namespace MergeSort;

public static class Program
{
    public static void Main()
    {
        Console.WriteLine("Input your numbers separated by a space: ");
        int[] numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        numbers = MergeSort(numbers);
        Console.WriteLine("Sorted by merge numbers: ");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
    }

    public static T[] MergeSort<T>(T[] inputArray)
    {
        if (inputArray.Length < 2)
        {
            return (T[])inputArray.Clone();
        }
        int length = inputArray.Length, middle = inputArray.Length / 2;
        var left = MergeSort(inputArray.Take(middle).ToArray());
        var right = MergeSort(inputArray.Skip(middle).ToArray());
        var merged = new T[length];
        int leftIndex = 0, rightIndex = 0, index = 0;
        while (right.Length > rightIndex && left.Length > leftIndex)
        {
            if (Comparer<T>.Default.Compare(left[leftIndex], right[rightIndex]) > 0)
            {
                merged[index] = right[rightIndex];
                rightIndex++;
            }
            else
            {
                merged[index] = left[leftIndex];
                leftIndex++;
            }
            index++;
        }
        while (leftIndex < left.Length)
        {
            merged[index] = left[leftIndex];
            leftIndex++;
            index++;
        }
        while (rightIndex < right.Length)
        {
            merged[index] = right[rightIndex];
            rightIndex++;
            index++;
        }
        return merged.ToArray();
    }
}
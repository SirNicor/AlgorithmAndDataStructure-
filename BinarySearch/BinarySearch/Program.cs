public class Program
{
    const int MaxNumber = 100000;
    const int Length = 10000;
    public static void Main(string[] args)
    {
        int[] arr = new int[Length];
        Random rnd = new Random();
        for(int i = 0; i < Length; i++)
        {
            arr[i] = rnd.Next(1, MaxNumber);
        }
        Array.Sort(arr); //Necessarily
        int findNumber = arr[rnd.Next(0, Length)], left = 0, right = Length-1, mid = right/2, resultIndex = -1;
        while (left <= right)
        {
            if (arr[mid] == findNumber)
            {
                resultIndex = mid;
                break;
            }
            else if (arr[mid] < findNumber)
            {
                left = mid + 1;
            }
            else
            {
                right = mid - 1;
            }
            mid = (left + right) / 2;
        }
        Console.WriteLine(resultIndex >= 0 ? resultIndex.ToString() : "Not found");
    }
}
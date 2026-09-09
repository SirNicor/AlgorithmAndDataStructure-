public class Programm
{
    public static void Main()
    {
        char[] nums = Console.ReadLine().Split(' ').Select(x => Convert.ToChar(x)).ToArray();
        char target = Convert.ToChar(Console.ReadLine());
        Console.WriteLine(NextGreatestLetter(nums, target));
    }
    public static char NextGreatestLetter(char[] letters, char target) {
        int left = 0, right = letters.Length - 1;
        while(left<=right)
        {
            int mid = (left + right) / 2;
            if(letters[mid] > target)
            {
                right = mid - 1;
            }
            else
            {
                left = mid + 1;
            }
        }

        return left == letters.Length ? letters[0] : letters[left];
    }
}
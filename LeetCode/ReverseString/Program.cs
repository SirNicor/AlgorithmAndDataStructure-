public class Programm
{
    public static void Main()
    {
        char[] str = Console.ReadLine().ToCharArray();
        ReverseString(str);
        Console.WriteLine(string.Join("", str));
    }
    
    public static void ReverseString(char[] s) {
        int length = s.Length;
        if (length == 1)
        {
            return;
        }
        for (int i = 0; i < length / 2; i++)
        {
            (s[length-1-i], s[i]) = (s[i], s[length-1-i]);
        }
    }
}
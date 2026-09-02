using System.Text;

public class Programm
{
    public static void Main()
    {
        string s =  Console.ReadLine();
        Console.WriteLine(IsPalindrome(s));
    }

    public static bool IsPalindrome(string s)
    {
        int len = s.Length, startIndex = 0, endIndex = len-1;
        bool isPalindrome = true, flag = true;
        while(true)
        {
            char symbolInEnd;
            while (true)
            {
                symbolInEnd = s[endIndex];
                if (symbolInEnd > 64 && symbolInEnd < 91){
                    symbolInEnd = (char)(symbolInEnd + 32);
                    break;
                }
                else if (symbolInEnd > 96 && symbolInEnd < 123 || symbolInEnd >= 48 && symbolInEnd <= 57)
                {
                    break;
                }
                endIndex--;
                if (endIndex <= startIndex)
                {
                    flag = false;
                    break;
                }
            }

            char symbolInStart;
            while (true)
            {
                symbolInStart = s[startIndex];
                if (symbolInStart > 64 && symbolInStart < 91){
                    symbolInStart = (char)(symbolInStart + 32);
                    break;
                }
                else if (symbolInStart > 96 && symbolInStart < 123 || symbolInStart >= 48 && symbolInStart <= 57)
                {
                    break;
                }
                startIndex++;
                if (endIndex <= startIndex)
                {
                    flag = false;
                    break;
                }
            }

            if (flag == false)
            {
                break;
            }
            if (symbolInStart != symbolInEnd)
            {
                isPalindrome = false;
                break;
            }
            if (endIndex <= startIndex)
            {
                break;
            }
            endIndex--;
            startIndex++;
        }
        return isPalindrome;
    }
}
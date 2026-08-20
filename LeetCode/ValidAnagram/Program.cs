public class Program
{
    public static void Main()
    {
        var s = Console.ReadLine();
        var t = Console.ReadLine();
        Console.WriteLine(IsAnagram(s, t));
    }

    private static bool IsAnagram(string s, string t) {
        if (s.Length != t.Length)
        {
            return false;
        }
        Dictionary<char, int> dict =  new Dictionary<char, int>();
        for (int i = 0; i < s.Length; i++)
        {
            if (dict.ContainsKey(s[i]))
            {
                dict[s[i]]++;   
            }
            else
            {
                dict.Add(s[i], 1);
            }
            if (dict.ContainsKey(t[i]))
            {
                dict[t[i]]--;   
            }
            else
            {
                dict.Add(t[i], -1);
            }
        }

        foreach (var item in dict)
        {
            if (item.Value != 0)
            {
                return false;
            }
        }

        return true;
    }
}
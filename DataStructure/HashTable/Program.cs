namespace HashTable;

public class Program
{
    public static void Main()
    {
        var test1 = new MyHashTable<string, int>();
        var test2 = new MyHashTable<string, int>(("key1", 1));
        var test3 = new MyHashTable<string, int>([("key0", 0), ("key1", 1), ("key2", 2)]);
        Console.WriteLine("Contains - " + test2.Contains("key1"));
        for (int i = 0; i < test3.Length(); i++)
        {
            string key = "key" + i;
            Console.WriteLine($"test3: {key} value: {test3.Get(key)}");
            test1.Add(key, i);
        }
        test1.Delete("key2");
        test1.Insert("key1", 11);
        for (int i = 0; i < test1.Length(); i++)
        {
            string key = "key" + i;
            Console.WriteLine($"test1: {key} value: {test1.Get(key)}");
        }

        for (int i = 0; i < 100; i++)
        {
            string key = "key" + i;
            test2.Add(key, i);
        }
        for (int i = 0; i < 100; i++)
        {
            string key = "key" + i;
            Console.WriteLine($"test2: {key} value: {test2.Get(key)}");
        }
    }
}
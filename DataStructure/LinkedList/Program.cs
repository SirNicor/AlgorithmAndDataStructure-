namespace LinkedList;

public class Programm
{
    public static void Main()
    {
        MyLinkedList<int> list = new MyLinkedList<int>();
        for (int i = 0; i < 10; i++)
        {
            list.AddFirst(i);
            list.AddLast(i);
        }
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine("Check Remove and Contains");
        for (int i = 0; i < 10; i++)
        {
            if (i % 2 == 0)
            {
                list.Remove(i);
            }
            else
            {
                Console.WriteLine($"Find element {i} - {list.Contains(i)}");
            }
        }
        foreach (var item in list)
        {
            Console.Write(item + " ");
            list.Remove(item);
        }

        Console.WriteLine("Length - " + list.Count);
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
    }
}
namespace DynamicArray;

public class Programm
{
    public static void Main()
    {
        Random random = new Random();
        MyList<string> myList0 = new MyList<string>(5);
        MyList<int> myList1 = new MyList<int>(5, [0, 1, 2, 3, 4]);
        MyList<int> myList2 = new MyList<int>([0, 1, 2, 3, 4, 5]);
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Element myList0 - " + myList0.GetElement(i) + ", ");
            Console.Write("Element myList1 - " + myList1.GetElement(i) + ", ");
            Console.Write("Element myList2 - " + myList2.GetElement(i) + ", ");
            Console.WriteLine();
        }

        for (int i = 0; i < 5; i++)
        {
            myList0.InsertElement(i, Convert.ToString(i));
        }

        for (int i = 0; i < 5; i++)
        {
            myList1.InsertElement(i, random.Next(1, 10));
        }

        for (int i = 0; i < 20; i++)
        {
            myList2.InsertElement(i, random.Next(1, 10));
            myList2.AddElement(0);
        }
        
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Element myList0 - " + myList0.GetElement(i) + ", ");
            Console.Write("Element myList1 - " + myList1.GetElement(i) + " ");
            Console.WriteLine();
        }

        for (int i = 0; i < 25; i++)
        {
            Console.Write($"Element myList2, index {i} - " + myList2.GetElement(i) + ", ");
        }

        foreach (int x in myList2)
        {
            Console.Write($"Element myList2 in foreach - " + x + ", ");
        }
    }
}
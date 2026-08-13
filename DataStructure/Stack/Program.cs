namespace stack;

public class Programm
{
    public static void Main()
    {
        MyStack<int> myStack = new MyStack<int>();
        myStack = new MyStack<int>([1, 2, 3, 4, 5]);
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(myStack.Pop());
        }
        myStack.Push(1);
        myStack.Push(2);
        for(int i = 0; i < 2; i++)
        {
            Console.WriteLine(myStack.Pop());
        }

        for (int i = 0; i < 10; i++)
        {
            myStack.Push(i);
        }

        try
        {
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(myStack.Pop());
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
        
    }
}
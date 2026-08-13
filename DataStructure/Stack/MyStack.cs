namespace stack;

public class MyStack<T>
{
    private LinkedList<T> Value;

    public MyStack()
    {
        Value = new LinkedList<T>();
    }
    
    public MyStack(T[] value)
    {
        Value = new LinkedList<T>(value);
    }


    public void Push(T x)
    {
        Value.AddLast(x);
    }

    public T Pop()
    {
        if (Value.Last == null)
        {
            throw new InvalidOperationException("Stack is empty");
        }
        T x = Value.Last.Value;
        Value.RemoveLast();
        return x;
    }
}
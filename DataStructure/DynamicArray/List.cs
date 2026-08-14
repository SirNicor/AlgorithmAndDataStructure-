using System.Collections;

namespace DynamicArray;

public class MyList<T> : IEnumerable<T>
{
    private T[] Value { get; set; }
    private int CurrentIndex { get; set; } = 0;

    public MyList(T[] value)
    {
        if (value == null)
        {
            throw new NullReferenceException();
        }
        int length = Convert.ToInt32(Math.Pow(2, Math.Ceiling(Math.Log(value.Length, 2))));
        Value = new T[length];
        for (int i = 0; i < value.Length; i++)
        {
            Value[i] = value[i];
        }
        CurrentIndex = value.Length - 1;
    }
    
    public MyList(int length, T[] value)
    {
        if (value == null)
        {
            throw new NullReferenceException();
        }

        if (value.Length > length)
        {
            throw new ArgumentException();
        }
        length = Convert.ToInt32(Math.Pow(2, Math.Ceiling(Math.Log(length, 2))));
        if (length == 0)
        {
            length = 2;
        }
        Value = new T[length];
        try
        {
            for (int i = 0; i < value.Length; i++)
            {
                Value[i] = value[i];
            }
        }
        catch(Exception ex)
        {
            throw ex;
        }
        CurrentIndex = value.Length - 1;
    }
    
    public MyList(int length)
    {
        length = Convert.ToInt32(Math.Pow(2, Math.Ceiling(Math.Log(length, 2))));
        if (length == 0)
        {
            length = 2;
        }
        Value = new T[length];
        for (int i = 0; i < length; i++)
        {
            Value[i] = default(T);
        }
        CurrentIndex = length - 1;
    }

    public T GetElement(int index)
    {
        if (index > CurrentIndex || index < 0)
        {
            throw new IndexOutOfRangeException();;
        }
        return Value[index];
    }

    public void InsertElement(int index, T value)
    {
        if (index > CurrentIndex || index < 0)
        {
            throw new IndexOutOfRangeException();;
        }
        Value[index] = value;
    }

    public void AddElement(T value)
    {
        int length = Value.Length;
        if (length == CurrentIndex+1)
        {
            T[] subArray = new T[length];
            Array.Copy(Value, subArray, length);
            int length1 = Convert.ToInt32(Math.Pow(2, Math.Ceiling(Math.Log(Value.Length, 2))+1));
            Value = new T[length1];
            Array.Copy(subArray, Value, length);
        }
        CurrentIndex++;
        Value[CurrentIndex] = value;
    }

    public IEnumerator<T> GetEnumerator()
    {
        foreach (var t in Value)
        {
            yield return t;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable<T>)this).GetEnumerator();
    }
}
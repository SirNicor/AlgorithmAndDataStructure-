using System.Collections;

namespace LinkedList;

public class MyLinkedList<T> : IEnumerable<T>
{
    private ObjectForLinkedList<T>? _head = null;
    private ObjectForLinkedList<T>? _tail = null;
    private int _count = 0;
    public MyLinkedList() { }
    
    public MyLinkedList(T value)
    {
        AddLast(value);
    }
    public int Count => _count;
    public MyLinkedList(T[] values)
    {
        if (values == null)
        {
            throw new ArgumentNullException(nameof(values));
        }
        foreach (T value in values)
        {
            AddLast(value);
        }
    }

    public void AddLast(T value)
    {
        var node = new ObjectForLinkedList<T>(value);
        if (_head == null)
        {
            _head = node;
        }
        else
        {
            _tail.Next = node;
        }
        _tail = node;
        _count++;
    }

    public void AddFirst(T value)
    {
        var x = new ObjectForLinkedList<T>(value)
        {
            Next = _head
        };
        _head = x;
        if (_tail == null)
            _tail = _head;
        _count++;
    }
    
    public bool Contains(T value)
    {
        var av = _head;
        while (av != null)
        {
            if (EqualityComparer<T>.Default.Equals(av.Value, value))
            {
                return true;
            }
            av = av.Next;
        }

        return false;
    }

    public bool Remove(T value)
    {
        if (_head == null)
        {
            return false;
        }
        if (EqualityComparer<T>.Default.Equals(_head.Value, value))
        {
            if (_head == _tail)
            {
                _head = null;
                _tail = null;
                _count--;
                return true;
            }
            _head = _head.Next;
            _count--;
            return true;
        }
        var av = _head;
        while (av.Next != null)
        {
            if (EqualityComparer<T>.Default.Equals(av.Next.Value, value))
            {
                if (av.Next.Next == null)
                {
                    _tail = av;
                    av.Next = null;
                }
                else
                {
                    av.Next = av.Next.Next;
                }
                _count--;
                return true;
            }
            av = av.Next;
        }
        return false;
    }

    public void Clear()
    {
        _head = null;
        _tail = null;
        _count = 0;
    }

    public IEnumerator<T> GetEnumerator()
    {
        var current = _head;

        while (current != null)
        {
            yield return current.Value;
            current = current.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

internal class ObjectForLinkedList<T>(T value)
{
    public T Value { get; set; } = value;
    public ObjectForLinkedList<T>? Next { get; set; }
}
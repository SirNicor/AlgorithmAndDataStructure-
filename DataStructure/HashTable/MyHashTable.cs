using System.ComponentModel;

namespace HashTable;

public class MyHashTable<TKey, TValue>
{
    private int _memorySize;
    private TValue[] _buckets;
    private int[] _contains;
    private TKey[] _keys;
    private int _maxAssayingSize;
    private int _count = 0;
        
    private int IndexFunction(TKey key)
    {
        return Math.Abs(HashCode.Combine(key)%_memorySize);
    }
    private int IndexFunction(TKey key, int length)
    {
        return Math.Abs(HashCode.Combine(key)%length);
    }
    private int MaxAssayingSizeCompute()
    {
        return Convert.ToInt32(Math.Round(Math.Log2(_memorySize)));
    }

    private int FindLargerOrEqualsPrimeNumber(int number)
    {
        while (true)
        {
            bool simple = true;
            for (int i = 2; i < Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    simple = false;
                    break;
                }
            }

            if (simple)
            {
                return number;
            }
            number++;
        }
    }
    private bool Contains(ref int index, TKey key, TKey[] keys, int[] contains, int memorySize)
    {
        int count = 0;
        while (!Equals(keys[index], key) || count == _count)
        {
            if (contains[index] == 0)
            {
                return false;
            }
            index++;
            if (index == memorySize)
            {
                index = 0;
            }

            count++;
        }
        return contains[index] == 1;
    }
    private void UpMemory()
    {
        int length = _memorySize * 2, copySize = _memorySize;
        length = FindLargerOrEqualsPrimeNumber(length);
        var subArrayValue = new TValue[_memorySize];
        var subArrayIndex = new TKey[_memorySize];
        var subArrayContains = new int[_memorySize];
        _contains.CopyTo(subArrayContains, 0);
        _buckets.CopyTo(subArrayValue, 0);
        _keys.CopyTo(subArrayIndex, 0);
        _buckets = new TValue[length];
        _keys = new TKey[length];
        _contains = new int[length];
        _memorySize = length;
        foreach (var key in subArrayIndex)
        {
            int oldIndex = IndexFunction(key, copySize);
            bool contain = Contains(ref oldIndex, key, subArrayIndex, subArrayContains, copySize);
            if (!contain)
            {
                continue;
            }
            TValue value = subArrayValue[oldIndex];
            Add(key, value);
        }
    }

    public MyHashTable()
    {
        _memorySize = 11;
        _buckets = new TValue[_memorySize];
        _contains = new int[_memorySize];
        _keys = new TKey[_memorySize];
        _maxAssayingSize = MaxAssayingSizeCompute();
    }

    public MyHashTable((TKey, TValue)[] pairs)
    {
        _memorySize = FindLargerOrEqualsPrimeNumber(pairs.Length*2);
        _buckets = new TValue[_memorySize];
        _contains = new int[_memorySize];
        _keys = new TKey[_memorySize];
        _maxAssayingSize = MaxAssayingSizeCompute();
        foreach (var pair in pairs)
        {
            Add(pair.Item1, pair.Item2);
        }
    }

    public MyHashTable((TKey, TValue) pair)
    {
        _memorySize = 11;
        _buckets = new TValue[_memorySize];
        _contains = new int[_memorySize];
        _keys = new TKey[_memorySize];
        _maxAssayingSize = MaxAssayingSizeCompute();
        Add(pair.Item1, pair.Item2);
    }
    
    public void Add(TKey key, TValue value)
    {
        int index = IndexFunction(key), count = 0;
        if (Contains(key))
        {
            return;
        }
        while (count != _maxAssayingSize)
        {
            if (_contains[index] == 0)
            {
                _keys[index] = key;
                _buckets[index] = value;
                _contains[index] = 1;
                _count++;
                return;
            }
            index++;
            if (index == _memorySize)
            {
                index = 0;
            }
            count++;
        }
        UpMemory();
        Add(key, value);
    }

    public bool Contains(TKey key)
    {
        int index = IndexFunction(key);
        return Contains(ref index, key, _keys, _contains, _memorySize);
    }

    public void Get(TKey key, out TValue value)
    {
        var index = IndexFunction(key);
        var contains = Contains(ref index, key, _keys, _contains, _memorySize);
        if (!contains)
        {
            throw new KeyNotFoundException();
        }
        value = _buckets[index];
    }
    public TValue? Get(TKey key)
    {
        var index = IndexFunction(key);
        var contains = Contains(ref index, key, _keys, _contains, _memorySize);
        if (!contains)
        {
            throw new KeyNotFoundException();
        }
        return _buckets[index];
    }

    public void Delete(TKey key)
    {
        int index = IndexFunction(key);
        var contains = Contains(ref index, key, _keys, _contains, _memorySize);
        if (!contains)
        {
            return;
        }
        _buckets[index] = default(TValue);
        _keys[index] = default(TKey);
        _count--;
        _contains[index] = -1;
    }

    public void Insert(TKey key, TValue value)
    {
        int index = IndexFunction(key);
        var contains = Contains(ref index, key, _keys, _contains, _memorySize);
        if (!contains)
        {
            return;
        }
        _buckets[index] = value;
    }

    public int Length()
    {
        return _count;
    }
}
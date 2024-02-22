namespace Assignment_4;

public class MyList <T>
{
    private const int DefaultCapacity = 10;
    private T[] list;
    private int count;

    public MyList(int capacity = DefaultCapacity)
    {
        this.list = new T[capacity];
        this.count = 0;
    }

    public void Add(T element)
    {
        EnsureCapacity();
        list[count++] = element;
    }

    public T Remove(int index)
    {
        if (index < 0 || index >= count)
        {
            throw new IndexOutOfRangeException("Index out of range.");
        }

        T removedElement = list[index];
        for (int i = index; i < count - 1; i++)
        {
            list[i] = list[i + 1];
        }

        count--;
        return removedElement;
    }

    public bool Contains(T element)
    {
        for (int i = 0; i < count; i++)
        {
            if (element.Equals(list[i]))
            {
                return true;
            }
        }

        return false;
    }

    public void Clear()
    {
        list = new T[DefaultCapacity];
        count = 0;
    }

    public void InsertAt(T element, int index)
    {
        if (index < 0 || index > count)
        {
            throw new IndexOutOfRangeException("Index out of range.");
        }
        
        EnsureCapacity();
        
        for (int i = count; i > index; i--)
        {
            list[i] = list[i - 1];
        }

        list[index] = element;
        count++;
    }

    public void DeleteAt(int index)
    {
        Remove(index);
    }

    public T Find(int index)
    {
        if (index < 0 || index >= count)
        {
            throw new IndexOutOfRangeException("Index out of range.");
        }

        return list[index];
    }

    public int Count()
    {
        return count;
    }

    private void EnsureCapacity()
    {
        if (count == list.Length)
        {
            int newCapacity = list.Length * 2;
            Array.Resize(ref list, newCapacity);
        }
    }
}
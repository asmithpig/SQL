namespace Assignment_4;

public class MyStack<T>
{
    class Node
    {
        public T Val { get; set; }
        public Node Prev { get; set; }

        public Node(T val, Node prev)
        {
            Val = val;
            Prev = prev;
        }
    }

    private Node top;
    private int count;

    public MyStack()
    {
        this.top = null;
        this.count = 0;
    }

    public int Count()
    {
        return count;
    }

    public T Pop()
    {
        if (count == 0)
        {
            throw new Exception("Invalid Pop() operations. The stack is empty.");
        }

        T ret = top.Val;
        top = top.Prev;
        count--;
        return ret;
    }

    public void Push(T val)
    {
        top = new Node(val, top);
        count++;
    }
}
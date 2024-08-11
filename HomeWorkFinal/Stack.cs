public class Stack<T> where T : class
{
    public int Count { get; private set; }

    public bool Empty => Count == 0;

    private Node<T> _top;

    public Stack()
    {
        _top = null;

        Count = 0;
    }

    public void Push(T value)
    {
        _top = new Node<T>(value, _top);

        Count++;
    }

    public T Pop()
    {
        if (Empty) return null;

        var result = _top.Value;

        _top = _top.Previous;

        Count--;

        return result;
    }

    public T Peek(int index)
    {
        if (index < 0 && index >= Count) return null;

        var i = 0;

        var node = _top;

        while (i != index)
        {
            node = node.Previous;

            i++;
        }

        return node.Value;
    }

    public T Peek()
        => _top?.Value;

    private class Node<T>(T value, Node<T> previous = null)
    {
        public T Value = value;

        public Node<T>? Previous = previous;
    }
}

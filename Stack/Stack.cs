public class Stack
{
    private readonly List<object> _stack = new List<object>();

    public void Push(object obj)
    {
        try
        {
            if (obj != null)
                _stack.Insert(0, obj);
            else
                throw new InvalidOperationException();
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine("Null can't be add to stack");
        }
    }

    public void Clear()
    {
        _stack.Clear();
    }

    public object Pop()
    {
        try
        {
            if (_stack.Count == 0)
                throw new InvalidOperationException();
            var temp = _stack[0];
            _stack.RemoveAt(0);

            return temp;
        }
        catch (InvalidOperationException ex)
        {
            return "Stack is empty";
        }
    }
}

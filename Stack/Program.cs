public class Program
{
    static void Main(string[] args)
    {
        var stack = new Stack();
        

        var from = 0;
        var to = 5;

        for(int i = from; i < to; i++)
            stack.Push(i);

        for(int i = from; i < to; i++)
            Console.WriteLine(stack.Pop());

        for (int i = from; i < to; i++)
            stack.Push(i);

        stack.Clear();
        
        Console.WriteLine(stack.Pop());

        stack.Push(null);
    }
}

public class Program
{
    static void Main(string[] args)
    {
        var stopwatch = new Stopwatch();
        var inputRead = "";
        var menu = 4;
        var isContinue = true;
        do
        {
            Console.WriteLine("This application simulate stopwatch run. Press:" +
                "\n1) Start" +
                "\n2) Stop" +
                "\n3) Exit");
            inputRead = Console.ReadLine();
            Int32.TryParse(inputRead, out menu);

            if (!(Int32.TryParse(inputRead, out menu)) || !(menu == 1 || menu == 2 || menu == 3))
            {
                Console.WriteLine("Invalid data. Try once agian");
                continue;
            }

            if (menu == 1)
                stopwatch.Start();
            else if (menu == 2)
            {
                stopwatch.Stop();
                Console.WriteLine();
                stopwatch.Result();
            }
            else if (menu == 3)
                isContinue = false;

            Console.WriteLine();
            Console.WriteLine();
        } while (isContinue);
        
    }
}
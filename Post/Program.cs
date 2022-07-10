public class Program
{
    public static void Main(string[] args)
    {
        var post = new Post("Tytuł", "Krótki opis dla tego posta");

        Console.WriteLine(post.CreatedDate);
        Console.WriteLine(post.Description);
        Console.WriteLine(post.Title);

        post.Description = "Zmiana opisu";

        Console.WriteLine(post.Description);
    }
}

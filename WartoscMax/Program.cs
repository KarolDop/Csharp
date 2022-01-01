
class Program
{
    static void Main(string[] args)
    {
        int liczba1, liczba2, dlugosc;
        string ciag;
        wartoscMaxZDwochLiczb test;

        Console.Write("Po podaniu dwóch liczb program powie Ci która jest większa.\nPodaj pierwszą liczbę:  ");
        ciag = Console.ReadLine();
        liczba1 = Convert.ToInt32(ciag);
        Console.Write("Podaj drugą liczbę: ");
        ciag = Console.ReadLine();
        liczba2 = Convert.ToInt32(ciag);

        test = new wartoscMaxZDwochLiczb(liczba1, liczba2);
        Console.WriteLine("Większa wartośc to: {0}", test.wartoscMax());

        Console.Write("Podaj dlugość tabeli: ");
        ciag = Console.ReadLine();
        dlugosc = int.Parse(ciag);
        wartoscMaxZArray tablica = new wartoscMaxZArray(dlugosc);
        tablica.ustawienieWartosci();
        Console.WriteLine("Maksymalna wartość z tablicy to: {0}", tablica.wartoscMax());
    }
}
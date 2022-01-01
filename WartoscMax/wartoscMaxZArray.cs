class wartoscMaxZArray
{
    private int[] tablica;
    private int dlugosc;
    private int max;

    public wartoscMaxZArray(int a)
    {
            dlugosc = a;
            tablica = new int[dlugosc];
    }

    public void ustawienieWartosci()
    {
        string ciag;
        int liczbaOdczytana;
        for(int i = 0; i < dlugosc; i++)
        {
            Console.Write("Podaj wartosc tablicy na miejscu {0}: ", i);
            ciag = Console.ReadLine();
            liczbaOdczytana = int.Parse(ciag);
            tablica[i] = liczbaOdczytana;
        }
    }

    public int wartoscMax()
    {
        max = tablica.Max();
        return max;
    }
}
        /*int liczba1, liczba2;
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

        int dlugosc;
        Console.Write("Podaj dlugość tabeli: ");
        ciag = Console.ReadLine();
        dlugosc = int.Parse(ciag);
        wartoscMaxZArray tablica = new wartoscMaxZArray(dlugosc);
        tablica.ustawienieWartosci();
        Console.WriteLine("Maksymalna wartość z tablicy to: {0}", tablica.wartoscMax());



    }
}
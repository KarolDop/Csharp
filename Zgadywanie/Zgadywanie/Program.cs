using System;

class Zgadywanie
{
    static void Main(string[] args)
    {
        int liczbaDoZgadniecia = new Random().Next(100);
        int iloscOdpowiedzi = 0;
        String odpowiedzString = new String("");
        int odpowiedz;

        do
        {
            Console.Write("Zgadij liczbę z przedziału od o do 100: ");
            odpowiedzString = Console.ReadLine();
            
            while(!Int32.TryParse(odpowiedzString, out odpowiedz))
            {
                Console.WriteLine("Nie podałeś liczby. Spróbuj raz jeszcze.");
                Console.Write("Zgadij liczbę z przedziału od o do 100: ");
                odpowiedzString = Console.ReadLine();
            }

            if(odpowiedz < 0 || odpowiedz > 100)
            {
                Console.WriteLine("Podałeś liczbę spoza zakresu spróbuj raz jeszcze.");
            }
            else
            {
                iloscOdpowiedzi++;
                if (liczbaDoZgadniecia > odpowiedz)
                    Console.WriteLine("Podałeś zbyt małą liczbę");
                else if (liczbaDoZgadniecia < odpowiedz)
                    Console.WriteLine("Podałeś zbyt dużą liczbę");
            }

        } while (odpowiedz != liczbaDoZgadniecia);

        Console.WriteLine("Gratuluje! Udało ci się zgadnąc liczbę!");
        Console.WriteLine($"Zajeło ci to tylko {iloscOdpowiedzi} prób.");
        
    }
}
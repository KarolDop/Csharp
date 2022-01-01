class Program
{
    static void Main(string[] args)
    {
        bool isNumber = true;
        bool isContinue = true;
        string odczyt;
        int liczba = 0;

        Console.Write("Wprowadż liczbę od 1 do 10. Aby zakończyć działanie programu wpisz q. ");
        odczyt = Console.ReadLine();
        do
        {
            if (odczyt.Length == 1 && odczyt.ToLower() == "q")
                isContinue = false;

            if(isContinue)
            {
                try
                {
                    isNumber = true;
                    liczba = int.Parse(odczyt);
                }
                catch (Exception)
                {
                    Console.WriteLine("Wprowadziłeś inne znak niż liczba. Spróbuj raz jeszcze");
                    isNumber = false;
                }
            }


            if (isNumber && isContinue && (liczba > 0 && liczba < 11))
                Console.WriteLine("Gratuluje wpisałeś liczbę: {0}", liczba);
            else if (isNumber && isContinue && liczba < 1)
                Console.WriteLine("Wprowadziłeś zbyt małą liczbę. Spróbuj raz jeszcze");
            else if (isNumber && isContinue && liczba > 10)
                Console.WriteLine("Wprowadziłeś zbyt duzą liczbę. Spróbuj raz jeszcze");

            if (isContinue)
            {
                Console.Write("Wprowadż liczbę od 1 do 10. Aby zakończyć działanie programu wpisz q. ");
                odczyt = Console.ReadLine();
            }
        } while (isContinue); 
    }
}
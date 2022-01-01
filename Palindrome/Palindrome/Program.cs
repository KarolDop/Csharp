using System;
using System.Text;

class Palindrome
{
    static void Main(string[] args)
    {
        string ciagPalindrome;
        Boolean exit = true;
        do
        {
            Console.Write("Wprowadź ciąg znaków: ");
            ciagPalindrome = Console.ReadLine();
            if (ciagPalindrome.Equals("exit", StringComparison.OrdinalIgnoreCase))
                exit = false;
            else
            {
                (Boolean, int)palindrome = IsPalindrome(ciagPalindrome);
                Console.WriteLine("Palindrome: {0}, Ilość znaków: {1}", palindrome.Item1, palindrome.Item2);
            }
        } while (exit);

        }

    static (Boolean, int) IsPalindrome (string ciag)
    {
        Boolean test = false;
        int iloscZnakow = 0;
        char znakPierwszy, znakDrugi;
        var ignore = new StringBuilder();

        foreach(char c in ciag)
        {
            if(!char.IsPunctuation(c))
                ignore.Append(c);
        }
        
        ciag = ignore.ToString();
        ciag = ciag.Replace(" ", String.Empty);

        int dlugosc = ciag.Length;

        for (int i = 0, j = dlugosc - 1; i < dlugosc;)
        {
            znakPierwszy = ciag[i];
            znakDrugi = ciag[j];
            i++;
            j--;
            znakPierwszy = char.ToUpper(znakPierwszy);
            znakDrugi = char.ToUpper(znakDrugi);

            if (znakPierwszy.Equals(znakDrugi))
                iloscZnakow++;
        }
        if (iloscZnakow == dlugosc)
            test = true;

        return(test, iloscZnakow);
    }
}

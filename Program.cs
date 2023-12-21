using System;
class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Wprowadź słowo:");
            string slowo = Console.ReadLine();
            // Usunięcie spacji z puli znaków specjalnych
            slowo = UsunSpacjeZeZnakowSpecjalnych(slowo);

            // Usunięcie wykrzyknika z puli znaków specjalnych
            slowo = UsunZnakSpecjalny(slowo, '!');

            bool zawieraZnakSpecjalny = CzyZawieraZnakSpecjalny(slowo);
            bool zawieraDuzaLitere = CzyZawieraDuzaLitere(slowo);

            if (!zawieraZnakSpecjalny)
            {
                if (!zawieraDuzaLitere)
                {
                    Console.WriteLine("Słowo nie zawiera ani znaku specjalnego ani wielkiej litery");
                }
                else
                {
                    Console.WriteLine("Słowo nie zawiera znaku specjalnego");
                }
            }
            else
            {
                if (!zawieraDuzaLitere)
                {
                    Console.WriteLine("Słowo nie zawiera wielkiej litery");
                }
                else
                {
                    Console.WriteLine("OK");
                    break;
                }
            }
        }
    }
    static bool CzyZawieraZnakSpecjalny(string slowo)
    {
        foreach (char znak in slowo)
        {
            if (!char.IsLetterOrDigit(znak))
            {
                return true;
            }
        }
        return false;
    }
    static bool CzyZawieraDuzaLitere(string slowo)
    {
        foreach (char znak in slowo)
        {
            if (char.IsUpper(znak))
            {
                return true;
            }
        }
        return false;
    }
    static string UsunSpacjeZeZnakowSpecjalnych(string slowo)
    {
        // Usunięcie spacji z puli znaków specjalnych
        return slowo.Replace(" ", "");
    }


    static string UsunZnakSpecjalny(string slowo, char znakSpecjalny)
    {
        // Usunięcie określonego znaku specjalnego
        return slowo.Replace(znakSpecjalny.ToString(), "");
    }
}
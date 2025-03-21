using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj kwotę w PLN: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal pln))
        {
            Console.Write("Podaj kurs wymiany PLN na USD: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal kurs) && kurs > 0)
            {
                Console.WriteLine($"Kwota w USD: {pln / kurs:f2}");
            }
            else
            {
                Console.WriteLine("cos zle zrobiles");
            }
        }
        else 
        {
            Console.WriteLine("zle wpisales kwote");
        }
    }
}

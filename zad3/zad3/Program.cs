using System;
using System.IO;

class Program
{
    static void Main()
    {
        string[] imiona = { "Ania", "Kasia", "Basia", "Zosia" };
        string[] nazwiska = { "Kowalska", "Nowak" };
        Random random = new Random();

        string userFile = $@"C:\test\users_{DateTime.Now:yyyyMMdd_HHmm}.csv";

        using (StreamWriter writer = new StreamWriter(userFile))
        {
            writer.WriteLine("LP;Imie;Nazwisko;Rok_Urodzenia");
            for (int i = 1; i <= 100; i++)
            {
                string imie = imiona[random.Next(imiona.Length)];
                string nazwisko = nazwiska[random.Next(nazwiska.Length)];
                int rok = random.Next(1990, 2001);
                writer.WriteLine($"{i};{imie};{nazwisko};{rok}");
            }
        }
        Console.WriteLine($"plik: {userFile}");
    }
}

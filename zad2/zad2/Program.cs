using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        string plik = @"C:\test\bajo.txt";

        if (File.Exists(plik))
        {
            string content = File.ReadAllText(plik, Encoding.UTF8).Replace("praca", "job");
            string data = DateTime.Now.ToString("yyyyMMdd");
            string nowyplik = plik.Replace(".txt", $"_changed_{data}.txt");

            File.WriteAllText(nowyplik, content, Encoding.UTF8);
            Console.WriteLine($"Plik zapisany jako: {nowyplik}");
        }
        else
        {
            Console.WriteLine("nie znalazlo pliku");
        }
    }
}

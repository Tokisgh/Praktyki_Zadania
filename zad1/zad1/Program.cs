internal class Program
{
    private static void Main(string[] args)
    {
        string Imie = "Jakub";
        string Nazwisko = "Jędrusiak";

        string ImieNazwisko = MaleLiteryIbezPolskich(Imie.ToLower()) + "_" + MaleLiteryIbezPolskich(Nazwisko.ToLower());
        Console.WriteLine(ImieNazwisko);


        if (ImieNazwisko.Length > 15)
        {
            ImieNazwisko = Imie.Substring(0, 3).ToLower() + "_" + Nazwisko.Substring(0, 3).ToLower();
        }

        string sciezka = $"C:\\test\\test_{ImieNazwisko}.txt";

        if (File.Exists(sciezka))
        {
            Console.WriteLine("a");
        }
        else 
        {
            Console.WriteLine("nie znalazlo pliku");
        }
        
    }

    static string MaleLiteryIbezPolskich(string text)
    {
        string[] p = { "ą", "ć", "ę", "ł", "ń", "ó", "ś", "ź", "ż" };
        string[] r = { "a", "c", "e", "l", "n", "o", "s", "z", "z" };

        for (int i = 0; i < p.Length; i++)
        {
            text = text.Replace(p[i], r[i]);
        }

        return text; 
    }
}

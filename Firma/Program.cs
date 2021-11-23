using System;

namespace Firma
{
    public enum Plcie
    {
        K,
        M
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Plcie plcie = Plcie.K;
            Osoba mireczek = new Osoba("MirECZek","Kowalski", "2021-11-22","33333333333", plcie);
            Console.WriteLine(mireczek.wiek());
            Console.WriteLine(mireczek.ToString());
            mireczek.format_text();
            Console.WriteLine(mireczek.ToString());
            Console.WriteLine("Wpisz godzinę urodzenia: ");
            string uro = Console.ReadLine();
            mireczek.ile_godzin(uro);
            Console.WriteLine(mireczek.check());

        }
        
    }
}

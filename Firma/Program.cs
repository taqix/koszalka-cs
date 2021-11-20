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
            Osoba mireczek = new Osoba("MirECZek","Kowalski", "1973-03-21","33333333333", plcie);
            Console.WriteLine(mireczek.wiek());
            Console.WriteLine(mireczek.ToString());
            mireczek.format_text();
            Console.WriteLine(mireczek.ToString());

        }
        
    }
}

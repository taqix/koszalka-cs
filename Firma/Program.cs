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
            Osoba mireczek = new Osoba("Mireczek","Kowalski", "1973-03-21","33333333333", plcie);
            Console.WriteLine(mireczek.wiek());
            Console.WriteLine(mireczek.ToString());
            plcie = Plcie.M;
            Osoba ziombalk = new Osoba("ziombal", "Kowalski", "1978-03-21", "33333333333", plcie);
            Console.WriteLine(ziombalk.wiek());
            Console.WriteLine(ziombalk.ToString());

        }
        
    }
}

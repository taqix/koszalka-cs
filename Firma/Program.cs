using System;
using System.Globalization;
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
            Plcie plciekobieca = Plcie.K;
            Plcie plcieM = Plcie.M;
            CzlonekZespolu jan = new CzlonekZespolu("Jan","Janowski", "1992-03-15", "92031507772",plcieM, "01-cze-2019","Jankowski programista");
            Console.WriteLine(jan.ToString());
            KierownikZespolu adam = new KierownikZespolu("Adam", "Kowalski", "1990-07-01", "90070100211", plcieM, 5);
            Console.WriteLine(adam.ToString());
            Zespol grupaIt = new Zespol("Grupa IT",adam);
            grupaIt.dodajCzlonka(jan);
            Console.WriteLine(grupaIt.ToString());

        }
        
    }
}

using System;
using System.Globalization;
using System.Collections.Generic;
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
            CzlonekZespolu witold = new CzlonekZespolu("Witold", "Adamski", "1992-10-22", "92102266738", plcieM, "01-sty-2020", "sekretarz");
            CzlonekZespolu janek = new CzlonekZespolu("Jan", "But", "1992-03-15", "92051613915", plcieM, "01-cze-2019", "programista");
            CzlonekZespolu beata = new CzlonekZespolu("Beata", "Nowak", "1993-11-22", "93112225023", plciekobieca, "01-sty-2020", "projektant");
            CzlonekZespolu anna = new CzlonekZespolu("Anna", "Mysza", "1991-07-22", "91072235964", plciekobieca, "31-lip-2019", "projektant");
            Zespol grupaIt = new Zespol("Grupa IT",adam);
            grupaIt.dodajCzlonka(jan);
            grupaIt.dodajCzlonka(witold);
            grupaIt.dodajCzlonka(anna);
            grupaIt.dodajCzlonka(beata);
            grupaIt.dodajCzlonka(janek);
            Console.WriteLine(grupaIt.ToString());
            grupaIt.usunCzlonka("Jan","Janowsk");
            Console.WriteLine(grupaIt.ToString());
            List<CzlonekZespolu> range = grupaIt.WyszukajCzlonkow("Jankowski programista");
            foreach(CzlonekZespolu item in range)
            {
                Console.WriteLine(item);
            }



        }
        
    }
}

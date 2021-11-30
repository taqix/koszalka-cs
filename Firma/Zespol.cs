using System;
using System.Collections.Generic;
using System.Text;

namespace Firma
{
    class Zespol
    {
        private int liczbaCzlonkow;
        private string nazwa;
        private KierownikZespolu kierownik;
        private List<CzlonekZespolu> czlonkowie;
        public int LiczbaCzlonkow { get { return liczbaCzlonkow; } set { liczbaCzlonkow = value; } }
        public string Nazwa { get { return nazwa; } set { nazwa = value; } }
        public KierownikZespolu Kierownik { get { return kierownik; } set { kierownik = value; } }
        

        public Zespol() { liczbaCzlonkow = 0; nazwa = null;kierownik = null; }
        public Zespol(string _nazwa,KierownikZespolu _kierownik)
        {
            nazwa=_nazwa;
            kierownik = _kierownik;

        }
        public void dodajCzlonka(CzlonekZespolu c)
        {

            czlonkowie.Add(c);
            liczbaCzlonkow++;
        }
        public override string ToString()
        {
            string calosc = "";
            calosc = calosc + "Zespol: " + nazwa + "\n";
            calosc = calosc + "Kierownik: " + kierownik.ToString() + "\n";
            for(int i=0;i<czlonkowie.Count;i++)
            {
                calosc += czlonkowie[i].ToString() + "\n";
            }
            return calosc;
        }


    }
}

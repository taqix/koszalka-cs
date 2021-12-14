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
        private List<CzlonekZespolu> czlonkowie = new List<CzlonekZespolu>();
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
        public bool jestCzlonkiem(string PESEL)
        {
            bool test = false;
            foreach(CzlonekZespolu c in czlonkowie)
            {
                if(c.pesel==PESEL)
                {
                    test = true;
                }

            }
            return test;
        }
        public bool jestCzlonkiem(string _imie,string _nazwisko)
        {
            bool test = false;
            foreach(CzlonekZespolu c in czlonkowie)
            {
                if(c.Imie==_imie && c.Nazwisko==_nazwisko)
                {
                    test = true;
                }
            }
            return test;
        }
        public void usunCzlonka(string PESEL)
        {
            czlonkowie.RemoveAll(CzlonekZespolu => CzlonekZespolu.pesel == PESEL);
            liczbaCzlonkow -= 1;

        }
        public void usunCzlonka(string _imie, string _nazwisko)
        {
            czlonkowie.RemoveAll(CzlonekZespolu => CzlonekZespolu.Imie == _imie && CzlonekZespolu.Nazwisko==_nazwisko );
            liczbaCzlonkow -= 1;
        }
        public void usunCzlonkow()
        {
            czlonkowie.Clear();
            liczbaCzlonkow = 0;
        }
        public List<CzlonekZespolu> WyszukajCzlonkow(string _funkcja)
        {
            List<CzlonekZespolu> mordzia = new List<CzlonekZespolu>();
            foreach(CzlonekZespolu c in czlonkowie)
            {
                if(c.funkcja==_funkcja)
                {
                    mordzia.Add(c);
                }
            }
            return mordzia;
        }
        public List<CzlonekZespolu> WyszukajCzlonkow(int miesiac)
        {
            List<CzlonekZespolu> mordzia = new List<CzlonekZespolu>();
            foreach (CzlonekZespolu c in czlonkowie)
            {
                int pomoc=c.datazapisu.Month;
                if(pomoc==miesiac)
                {
                    mordzia.Add(c);
                }
                

            }
            return mordzia;
        }
        /*public void tescikt()
        {
            foreach(CzlonekZespolu c in czlonkowie)
            {
                Console.WriteLine( c.datazapisu.ToString());
            }
        }
        */
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

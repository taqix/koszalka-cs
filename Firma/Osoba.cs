using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace Firma
{
    class Osoba
    {
        private string imie;
        private string nazwisko;
        private DateTime dataUrodzenia;
        private string PESEL;
        private Plcie Plec;
        private CultureInfo cultures = CultureInfo.CreateSpecificCulture("pl-PL");
        public string Imie { get { return imie; } set { imie = value; } }
        public string Nazwisko { get { return nazwisko; } set { nazwisko = value; } }
        public DateTime DataUrodzenia { get => dataUrodzenia; set => dataUrodzenia = value; }



        
        public Osoba()
        {
            imie = "Miruś";
            nazwisko = "Kowalski";
            dataUrodzenia = DateTime.Today;
            PESEL = "00000000000";
        }
        public Osoba(string _imie, string _nazwisko)
        {
            imie = _imie;
            nazwisko = _nazwisko;
            dataUrodzenia = DateTime.Today;
            PESEL = "00000000000";
        }
        public Osoba(string _imie, string _nazwisko, string _data_urodzenia, string _Pesel, Plcie _plec)
        {
            imie = _imie;
            nazwisko = _nazwisko;
            DateTime.TryParseExact(_data_urodzenia, new[] { "yyyy-MM-dd", "yyyy/MM/dd", "MM/dd/yy", "dd-MMM-yy" }, null, DateTimeStyles.None, out dataUrodzenia); ;
            PESEL = _Pesel;
            Plec = _plec;
        }
        public int wiek()
        {
            
            DateTime todaysDate = DateTime.Today;
            TimeSpan result = todaysDate.Subtract(dataUrodzenia);
            int pomoc_wiek = (int)((result.TotalDays)/ 365);
            return pomoc_wiek;
        }
        public void format_text()
        {
            string pomoc_imie = imie.Substring(1);
            pomoc_imie = pomoc_imie.ToLower();
            string pomoc_naz = nazwisko.Substring(1);
            pomoc_naz = pomoc_naz.ToLower();
            if (!string.IsNullOrEmpty(imie))
            {
                imie = char.ToUpper(imie[0]) + pomoc_imie;
            }
            if (!string.IsNullOrEmpty(nazwisko))
            {
                nazwisko = char.ToUpper(nazwisko[0]) + pomoc_naz;
            }

        }
        override public string ToString()
        {
            return "imie: "+imie+" nazwisko: "+nazwisko+ "("+wiek()+") pesel: "+PESEL;
        }
    }
}

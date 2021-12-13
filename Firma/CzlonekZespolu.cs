using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Firma
{
    class CzlonekZespolu: Osoba
    {
        public DateTime datazapisu;
        public string funkcja;

        public CzlonekZespolu(string _imie, string _nazwisko, string _data_urodzenia, string _Pesel, Plcie _plec, string _datazapisu,string _funkcja) : base(_imie, _nazwisko, _data_urodzenia, _Pesel, _plec)
        {
            funkcja = _funkcja;
            DateTime.TryParseExact(_datazapisu, "dd-MMM-yyyy", null, DateTimeStyles.None, out datazapisu);
        }
        override public string ToString()
        {
            return Imie + " " + Nazwisko + " " + DataUrodzenia.ToString("dd-MM-yyyy") + " " + pesel + " " + plec + " " + funkcja + " (" + datazapisu.ToString("dd-MMM-yyyy") + ")";
        }
    }
}

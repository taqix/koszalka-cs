using System;
using System.Globalization;
using System.Collections.Generic;
using System.Text;

namespace Firma
{
    class KierownikZespolu: Osoba
    {
        public DateTime datazapisu;
        public int doswiadczenie;

        public KierownikZespolu(string _imie, string _nazwisko, string _data_urodzenia, string _Pesel, Plcie _plec,int _doswiadczenia):base(_imie,_nazwisko,_data_urodzenia,_Pesel,_plec)
        {
            doswiadczenie = _doswiadczenia;
            
        }
        public override string ToString()
        {
            return Imie +" " + Nazwisko +" " + DataUrodzenia.ToString("yyyy-MM-dd")+" " + pesel+" " +  plec+" "+doswiadczenie;
        }
    }
}

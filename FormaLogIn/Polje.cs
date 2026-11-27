using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace LogIn
{
    public class Polje
    {
         int indeks;
        string vrsta;
        string naziv;
        int cena;

        public int Cena { get; set; }
        public string Vrsta { get; set;
        }
        public int Indeks { get; set; }
        public string Naziv {  get; set; }
        public Polje (int indeks, string naziv, string vrsta, int cena)
        {
            Indeks = indeks;
            Naziv = naziv;
            Vrsta = vrsta;
            Cena = cena;//dodace se i vlasnik kasnije
        }
        
    }
}

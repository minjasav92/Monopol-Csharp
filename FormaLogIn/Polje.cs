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
        int cenaKucaIHotela;
        Igrac vlasnik;

        public int Cena { get; set; }
        public string Vrsta { get; set; }
        public int Indeks { get; set; }
        public string Naziv {  get; set; }
        public Igrac Vlasnik { get; set; }
        public Polje (int indeks, string naziv, string vrsta, int cena)
        {
            Indeks = indeks;
            Naziv = naziv;
            Vrsta = vrsta;
            Cena = cena;//dodace se i vlasnik kasnije
            if(naziv == "Nekretnina") cenaKucaIHotela = (indeks / 10 + 1) * 50;//za prvih deset je 50, 10-20 je 100 itd.
        }
    }
}

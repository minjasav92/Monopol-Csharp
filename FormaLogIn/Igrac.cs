using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
namespace LogIn
{
    public class Igrac
    {
        string ime;
        string figurica;
        Image slikaFigurice;
        int indexIgraca;
        Polje trenutnoPolje;
        static int brojIgraca = 0;
        int novac;
        List<Polje> nekretnine;
        public Igrac(string ime, string figurica, Image slikaFigurice)
        {
            this.ime = ime;
            this.figurica = figurica;
            this.slikaFigurice = slikaFigurice;
            indexIgraca = ++brojIgraca;
            novac = 1500;
        }
        public Igrac(string ime)
        {
            this.ime = ime;
            indexIgraca = ++brojIgraca;
            novac = 1500;
        }
        public string Figurica
        {
            get { return figurica; }
            set { figurica = value; }
        }
        public int Pozicija { get; set; } = 0;
        public PictureBox Pbx { get; set; }        
        public int Index { get { return indexIgraca; } }
        public string Ime { get { return ime; } }
        public Image SlikaFigurice
        {
            get { return slikaFigurice; }
            set { slikaFigurice = value; }
        }
        public List<string> Info
        {
            get
            {
                List<string> info = new List<string>();
                info.Add(indexIgraca.ToString());
                info.Add(ime);
                info.Add(figurica);
                return info;
            }
        }
        public Polje TrenutnoPolje { get { return trenutnoPolje; } set { trenutnoPolje = value; } }
        public int Novac { get { return novac; } set { novac = value; } }
        public void KupiPolje(Polje polje)
        {
            if (novac < polje.Cena)
            {
                throw new Exception("Nemate dovoljno novca!");
            }
            novac -= polje.Cena;
            if(nekretnine == null)
            {
                nekretnine = new List<Polje>();
            }
            nekretnine.Add(polje);
            polje.Vlasnik = this;
        }
    }
}

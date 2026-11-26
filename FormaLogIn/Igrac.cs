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
        static int brojIgraca = 0;
        public Igrac(string ime, string figurica, Image slikaFigurice)
        {
            this.ime = ime;
            this.figurica = figurica;
            this.slikaFigurice = slikaFigurice;
            indexIgraca = ++brojIgraca;
        }
        public Igrac(string ime)
        {
            this.ime = ime;
            indexIgraca = ++brojIgraca;
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

    }
}

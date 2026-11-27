using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LogIn
{

    public partial class frmIgra : Form
    {
        List<Igrac> igraci = new List<Igrac>();
        Point[] polja = new Point[40];
        int kocka1 = 1;
        int kocka2 = 1;
        int brojPromena = 0;
        Random rnd = new Random();
        int naPotezu = 0;
        int preostaliKoraci;
        int kolikoDuplih = 0;
        List<Polje> poljaTable = new List<Polje>();//NOVO


        public frmIgra() : this(new List<Igrac>())
        {
        } //sta je ovo? jel sme da se brise?
        //NE YASTO STO TI JE TO KONSTRUKTOR KOJI NE PRIMA NISTA VEC PROSLEDJUJE NOVU PRAYNU LISTU DA JE POPUNI 

        public frmIgra(List<Igrac> igraci)
        {//OVAJ KONSTRUKTOR PRIMA LISTU IGRACA
            InitializeComponent();
            this.igraci = igraci;

            pbxKocka1.Paint += pbxKocka1_Paint;
            pbxKocka2.Paint += pbxKocka2_Paint;
        }


        private void btnKocke_Click(object sender, EventArgs e)
        {
            btnKocke.Enabled = false;
            brojPromena = 0;
            tmrKocka.Start();
        }

        private void frmIgra_Load(object sender, EventArgs e)
        {
            NapraviPolja();
            pbxKocka1.Refresh();
            pbxKocka2.Refresh();
           
            //polja na donjoj strani, s desna na levo
            int x = 1;
            for(int i = 0; i < 10; i++)
            {
                polja[i].X = pbxTabla.Width - 42 * x;
                polja[i].Y = pbxTabla.Height - 30;
                x++;
            }
            //polja na levoj strani, odozdo na gore
            x = 1;
            for (int i = 10; i < 20; i++)
            {
                polja[i].X = 30;
                polja[i].Y = pbxTabla.Height - 42 * x;
                x++;
            }
            //polja na gornjoj strani, s leva na desno
            x = 1;
            for (int i = 20; i < 30; i++)
            {
                polja[i].X = 42 * x;
                polja[i].Y = 30;
                x++;
            }
            //polja na desnoj strani, odozgo na dole
            x = 1;
            for (int i = 30; i < 40; i++)
            {
                polja[i].X = pbxTabla.Width - 30;
                polja[i].Y = 42 * x;
                x++;
            }
            foreach (Igrac i in igraci)
            {
                i.Pozicija = 0;
                PictureBox pbx = new PictureBox();
                pbx.Image = i.SlikaFigurice;
                pbx.SizeMode = PictureBoxSizeMode.Zoom;
                pbx.Size = new Size(30, 30);
                pbx.BackColor = Color.Transparent;
                pbxTabla.Controls.Add(pbx);     // dete table => providnost radi preko slike
                i.Pbx = pbx;
                PostaviFiguricu(i);
            }
            PrikaziNaPotezu();
        }
        void PomeriIgraca(int koraka)//
        {
            preostaliKoraci = koraka;
            tmrKretanje.Start();
        }
        private void tmrKretanje_Tick(object sender, EventArgs e)//
        {
            Igrac igrac = igraci[naPotezu];
            igrac.Pozicija = (igrac.Pozicija + 1) % 40;
            PostaviFiguricu(igrac);
            preostaliKoraci--;

            if (preostaliKoraci == 0)
            {
                tmrKretanje.Stop();
                krajPoteza();
            }
        }
        void PostaviFiguricu(Igrac igrac)
        {
            Point p = polja[igrac.Pozicija];
            /*int pomeraj = (igrac.Index - 1) * 6;   // da se figurice na istom polju ne poklope <- ne radi
            igrac.Pbx.Location = new Point(p.X - 15 + pomeraj, p.Y - 15 + pomeraj);*///ya sada neka bude zakomentarisano dok ne smislimo nesto pamento
        }
        void NacrtajKocku(PictureBox pbx, int kocka, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int sirina = pbx.Width;
            int visina = pbx.Height;
            g.Clear(Color.White);
            g.DrawRectangle(new Pen(Color.Black, 5), 1, 1, sirina - 3, visina - 3);
            Point[] tacke =
                {
                    new Point(sirina / 4, visina / 4),//gore levo
                    new Point(sirina * 3 / 4, visina / 4),//gore desno
                    new Point(sirina / 4, visina / 2),//sredina levo
                    new Point(sirina / 2, visina / 2),//sredina
                    new Point(sirina * 3 / 4, visina / 2),//desno sredina
                    new Point(sirina / 4, visina * 3 / 4),//dole levo
                    new Point(sirina * 3 / 4, visina * 3 / 4)//dole desno
                };

            switch (kocka)
            {
                case 1: NacrtajTackicu(g, tacke[3]); break;
                case 2: NacrtajTackicu(g, tacke[0]); NacrtajTackicu(g, tacke[6]); break;
                case 3: NacrtajTackicu(g, tacke[3]); NacrtajTackicu(g, tacke[0]); NacrtajTackicu(g, tacke[6]); break;
                case 4: NacrtajTackicu(g, tacke[0]); NacrtajTackicu(g, tacke[1]); NacrtajTackicu(g, tacke[5]); NacrtajTackicu(g, tacke[6]); break;
                case 5: NacrtajTackicu(g, tacke[0]); NacrtajTackicu(g, tacke[1]); NacrtajTackicu(g, tacke[5]); NacrtajTackicu(g, tacke[6]); NacrtajTackicu(g, tacke[3]); break;
                case 6:
                    for (int i = 0; i < tacke.Length; i++)
                    {
                        if (i == 3) continue;
                        NacrtajTackicu(g, tacke[i]);
                    }
                    break;
            }
        }
        void NacrtajTackicu(Graphics g, Point tacka)
        {
            g.FillEllipse(Brushes.Black,
                tacka.X - 5,
                tacka.Y - 5,
                10, 10);
        }
        private void tmrKocka_Tick(object sender, EventArgs e)
        {
            kocka1 = rnd.Next(1, 7);
            kocka2 = rnd.Next(1, 7);
            pbxKocka1.Invalidate();
            pbxKocka2.Invalidate();
            brojPromena++;
            if (brojPromena >= 15)
            {
                tmrKocka.Stop();
                btnKocke.Enabled = true;
                PomeriIgraca(kocka1 + kocka2);//
            }
        }
        private void pbxKocka1_Paint(object sender, PaintEventArgs e)
        {
            NacrtajKocku(pbxKocka1, kocka1, e);
        }

        private void pbxKocka2_Paint(object sender, PaintEventArgs e)
        {
            NacrtajKocku(pbxKocka2, kocka2, e);
        }
        void krajPoteza()
        {
            // Dodati sta treba - ako je stao na neko polje itd...
            if (kocka1 != kocka2)
                naPotezu = (naPotezu + 1) % igraci.Count;
            else
            {
                kolikoDuplih++;
                if(kolikoDuplih>2) naPotezu = (naPotezu + 1) % igraci.Count;
            }
            btnKocke.Enabled = true;
        }
        void NapraviPolja() //sta da radim sa vodovom i tim glupostima
        {
            poljaTable.Add(new Polje(0, "START", "Start", 180));

            poljaTable.Add(new Polje(1, "AVENIJA POPA JOCE", "Nekretnina", 60));
            poljaTable.Add(new Polje(2, "DRŽAVNA BLAGAJNA", "Državna Blagajna", 0));
            poljaTable.Add(new Polje(3, "AVENIJA POPA MIŠKA", "Nekretnina", 60));
            poljaTable.Add(new Polje(4, "POREZ NA PLATU", "Kazna", 150));
            poljaTable.Add(new Polje(5, "GLAVNA STANICA 110", "Stanica", 200));
            poljaTable.Add(new Polje(6, "ULICA KNEZA MILOŠA", "Nekretnina", 100));
            poljaTable.Add(new Polje(7, "ŠANSA", "Šansa", 0));
            poljaTable.Add(new Polje(8, "ŠIMANOVCI", "Nekretnina", 100));
            poljaTable.Add(new Polje(9, "TRG ZVONKO BOGDANA", "Nekretnina", 120));
            poljaTable.Add(new Polje(10, "POSETA ZATVORU", "Zatvor", 0));
            poljaTable.Add(new Polje(11, "BLOK KETOVIĆ", "Nekretnina", 140));
            poljaTable.Add(new Polje(12, "STRUJA", "Nekretnina", 150));
            poljaTable.Add(new Polje(13, "ANA ANŽUJSKA", "Nekretnina", 140));
            poljaTable.Add(new Polje(14, "CARICE SOFIJE", "Nekretnina", 160));
            poljaTable.Add(new Polje(15, "STANICA 207", "Stanica", 200));
            poljaTable.Add(new Polje(16, "KRALJA PETRA PRVOG", "Nekretnina", 180));
            poljaTable.Add(new Polje(17, "DRŽAVNA BLAGAJNA", "Državna Blagajna", 0));
            poljaTable.Add(new Polje(18, "CRKVA SVETOG LUKE", "Nekretnina",180));
            poljaTable.Add(new Polje(19, "BULEVAR MLADIĆA", "Nekretnina", 200));
            poljaTable.Add(new Polje(20, "BESPLATAN PARKING", "Parking", 180));
            poljaTable.Add(new Polje(21, "CRKVA SVETOG VASILIJA", "Nekretnina", 220));
            poljaTable.Add(new Polje(22, "ŠANSA", "Šansa", 0));
            poljaTable.Add(new Polje(23, "TRG ANDREJA VELIKOG", "Nekretnina", 220));
            poljaTable.Add(new Polje(24, "AVENIJA CARA PAVELA", "Nekretnina", 240));
            poljaTable.Add(new Polje(25, "STANICA 109", "Stanica", 200));
            poljaTable.Add(new Polje(26, "ULICA DJORDJA VUKLJE", "Nekretnina", 260));
            poljaTable.Add(new Polje(27, "MOST JOVANA ANTOVIĆA", "Nekretnina", 260));
            poljaTable.Add(new Polje(28, "GRADSKI VODOVOD", "Nekretnina", 150));//
            poljaTable.Add(new Polje(29, "BLOK IVANA", "Nekretnina", 280));
            poljaTable.Add(new Polje(30, "ZATVOR", "Zatvor", 0));
            poljaTable.Add(new Polje(31, "TOPOVI PUKOVNIKA MIHAJLA", "Nekretnina", 300));
            poljaTable.Add(new Polje(32, "TERENI SRETENA PETROVIĆA", "Nekretnina", 300));
            poljaTable.Add(new Polje(33, "DRŽAVNA BLAGAJNA", "Državna Blagajna", 0));
            poljaTable.Add(new Polje(34, "STADION LAZAR MAKSIMOVIĆA", "Nekretnina", 320));
            poljaTable.Add(new Polje(35, "STANICA 206", "Stanica", 200));
            poljaTable.Add(new Polje(36, "ŠANSA", "Šansa", 0));
            poljaTable.Add(new Polje(37, "GALERIJA SAVIĆA", "Nekretnina", 350));
            poljaTable.Add(new Polje(38, "DODATNI POREZ", "Kazna", 150));
            poljaTable.Add(new Polje(39, "BULEVAR KRALJICE MIONE", "Nekretnina",400));

        }
        void PrikaziNaPotezu()
        {
            lblIspis.Text = "Na potezu je: " + igraci[naPotezu].Ime;
        }
    }
}
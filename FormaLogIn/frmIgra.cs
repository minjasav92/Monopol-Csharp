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


        public frmIgra() : this(new List<Igrac>())
        {
        }

        public frmIgra(List<Igrac> igraci)
        {
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
            pbxKocka1.Refresh();
            pbxKocka2.Refresh();
            foreach (Igrac i in igraci)
            {
                PictureBox pbx = new PictureBox();
                pbx.Image = i.SlikaFigurice;
                pbx.SizeMode = PictureBoxSizeMode.Zoom;
                pbx.Size = new Size(30, 30);
                pbx.BackColor = Color.Transparent;
               // PictureBox1.Controls.Add(pbx);     // dete table => providnost radi preko slike
                i.Pbx = pbx;
                PostaviFiguricu(i);
            }
        }
       /* void PomeriIgraca(int koraka)
        {
            preostaliKoraci = koraka;
            tmrKretanje.Start();
        }

        private void tmrKretanje_Tick(object sender, EventArgs e)
        {
            Igrac igrac = igraci[naPotezu];
            igrac.Pozicija = (ig.Pozicija + 1) % 40;
            PostaviFiguricu(igrac);
            preostaloKoraci--;

            if (preostaiKoraci == 0)
            {
                tmrKretanje.Stop();
                krajPoteza();
            }
        }*/
        void PostaviFiguricu(Igrac igrac)
        {
            Point p = polja[igrac.Pozicija];
            int pomeraj = (igrac.Index - 1) * 6;   // da se figurice na istom polju ne poklope
            igrac.Pbx.Location = new Point(p.X - 15 + pomeraj, p.Y - 15 + pomeraj);
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
            //    PomeriIgraca(kocka1 + kocka2);
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
            btnKocke.Enabled = true;                  
        }
    }
}
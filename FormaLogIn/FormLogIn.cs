using LogIn;

namespace FormaLogIn
{
    public partial class frmLogIn : Form
    {
        public frmLogIn()
        {
            InitializeComponent();
        }
        PictureBox pbxTrenutni;
        bool nemaFiguricu = true;
        List<Igrac> listaIgraca = new List<Igrac>();
        public void btnDodajIgraca_Click(object sender, EventArgs e)
        {
            try
            {
                string imeIgraca = txtImeIgraca.Text;
                if (imeIgraca == "")
                {
                    Exception ex = new Exception("Niste uneli ime igraca!");
                    throw ex;
                }
                if (nemaFiguricu)
                {
                    Exception ex = new Exception("Niste izabrali figuricu!");
                    throw ex;
                }
                txtImeIgraca.Clear();
                Igrac noviIgrac = new Igrac(imeIgraca, pbxTrenutni.AccessibleName, pbxTrenutni.Image);
                listaIgraca.Add(noviIgrac);
                lvwIgraci.Items.Add(new ListViewItem(noviIgrac.Info.ToArray()));
                pbxTrenutni.BackColor = Color.LightGray;
                pbxTrenutni.Enabled = false;
                nemaFiguricu = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        void SelektujNovi(PictureBox pbxSad, PictureBox pbxProsli)
        {
            pbxProsli.BackColor = Color.Transparent;
            pbxSad.BackColor = Color.Green;
        }

        private void pbxAutic_Click(object sender, EventArgs e)
        {
            if (nemaFiguricu)
            {
                pbxTrenutni = pbxAutic;
                pbxAutic.BackColor = Color.Green;
                nemaFiguricu = false;
            }
            else
            {
                SelektujNovi(pbxAutic, pbxTrenutni);
                pbxTrenutni = pbxAutic;
            }
        }

        private void pbxBrodic_Click(object sender, EventArgs e)
        {
            if (nemaFiguricu)
            {
                pbxTrenutni = pbxBrodic;
                pbxBrodic.BackColor = Color.Green;
                nemaFiguricu = false;
            }
            else
            {
                SelektujNovi(pbxBrodic, pbxTrenutni);
                pbxTrenutni = pbxBrodic;
            }
        }

        private void pbxKuca_Click(object sender, EventArgs e)
        {
            if (nemaFiguricu)
            {
                pbxTrenutni = pbxKuca;
                pbxKuca.BackColor = Color.Green;
                nemaFiguricu = false;
            }
            else
            {
                SelektujNovi(pbxKuca, pbxTrenutni);
                pbxTrenutni = pbxKuca;
            }
        }

        private void pbxDino_Click(object sender, EventArgs e)
        {
            if (nemaFiguricu)
            {
                pbxTrenutni = pbxDino;
                pbxDino.BackColor = Color.Green;
                nemaFiguricu = false;
            }
            else
            {
                SelektujNovi(pbxDino, pbxTrenutni);
                pbxTrenutni = pbxDino;
            }
        }

        private void pbxSesir_Click(object sender, EventArgs e)
        {
            if (nemaFiguricu)
            {
                pbxTrenutni = pbxSesir;
                pbxSesir.BackColor = Color.Green;
                nemaFiguricu = false;
            }
            else
            {
                SelektujNovi(pbxSesir, pbxTrenutni);
                pbxTrenutni = pbxSesir;
            }
        }

        private void pbxPingvin_Click(object sender, EventArgs e)
        {
            if (nemaFiguricu)
            {
                pbxTrenutni = pbxPingvin;
                pbxPingvin.BackColor = Color.Green;
                nemaFiguricu = false;
            }
            else
            {
                SelektujNovi(pbxPingvin, pbxTrenutni);
                pbxTrenutni = pbxPingvin;
            }
        }

        private void pbxPatka_Click(object sender, EventArgs e)
        {
            if (nemaFiguricu)
            {
                pbxTrenutni = pbxPatka;
                pbxPatka.BackColor = Color.Green;
                nemaFiguricu = false;
            }
            else
            {
                SelektujNovi(pbxPatka, pbxTrenutni);
                pbxTrenutni = pbxPatka;
            }
        }

        private void pbxMaca_Click(object sender, EventArgs e)
        {
            if (nemaFiguricu)
            {
                pbxTrenutni = pbxMaca;
                pbxMaca.BackColor = Color.Green;
                nemaFiguricu = false;
            }
            else
            {
                SelektujNovi(pbxMaca, pbxTrenutni);
                pbxTrenutni = pbxMaca;
            }
        }
    }
}

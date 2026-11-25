namespace FormaLogIn
{
    partial class frmLogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDodajIgraca = new Button();
            txtImeIgraca = new TextBox();
            label2 = new Label();
            label3 = new Label();
            lvwIgraci = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            pbxAutic = new PictureBox();
            pbxBrodic = new PictureBox();
            pbxDino = new PictureBox();
            pbxKuca = new PictureBox();
            pbxMaca = new PictureBox();
            pbxPatka = new PictureBox();
            pbxPingvin = new PictureBox();
            pbxSesir = new PictureBox();
            pbxLogo = new PictureBox();
            btnPočetakIgre = new Button();
            ((System.ComponentModel.ISupportInitialize)pbxAutic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxBrodic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxDino).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxKuca).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxMaca).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxPatka).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxPingvin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxSesir).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).BeginInit();
            SuspendLayout();
            // 
            // btnDodajIgraca
            // 
            btnDodajIgraca.Location = new Point(346, 135);
            btnDodajIgraca.Margin = new Padding(3, 4, 3, 4);
            btnDodajIgraca.Name = "btnDodajIgraca";
            btnDodajIgraca.Size = new Size(126, 31);
            btnDodajIgraca.TabIndex = 2;
            btnDodajIgraca.Text = "Dodaj igraca";
            btnDodajIgraca.UseVisualStyleBackColor = true;
            btnDodajIgraca.Click += btnDodajIgraca_Click;
            // 
            // txtImeIgraca
            // 
            txtImeIgraca.Location = new Point(99, 135);
            txtImeIgraca.Margin = new Padding(3, 4, 3, 4);
            txtImeIgraca.Name = "txtImeIgraca";
            txtImeIgraca.Size = new Size(239, 27);
            txtImeIgraca.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(54, 137);
            label2.Name = "label2";
            label2.Size = new Size(42, 23);
            label2.TabIndex = 4;
            label2.Text = "ime:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(54, 187);
            label3.Name = "label3";
            label3.Size = new Size(70, 23);
            label3.TabIndex = 5;
            label3.Text = "figurica:";
            // 
            // lvwIgraci
            // 
            lvwIgraci.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvwIgraci.GridLines = true;
            lvwIgraci.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lvwIgraci.Location = new Point(545, 166);
            lvwIgraci.Margin = new Padding(3, 4, 3, 4);
            lvwIgraci.Name = "lvwIgraci";
            lvwIgraci.Size = new Size(313, 248);
            lvwIgraci.TabIndex = 7;
            lvwIgraci.UseCompatibleStateImageBehavior = false;
            lvwIgraci.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Igrac";
            columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ime";
            columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "figurica";
            // 
            // pbxAutic
            // 
            pbxAutic.AccessibleName = "Autic";
            pbxAutic.Image = LogIn.Properties.Resources.autic;
            pbxAutic.Location = new Point(54, 232);
            pbxAutic.Margin = new Padding(3, 4, 3, 4);
            pbxAutic.Name = "pbxAutic";
            pbxAutic.Size = new Size(80, 93);
            pbxAutic.SizeMode = PictureBoxSizeMode.Zoom;
            pbxAutic.TabIndex = 8;
            pbxAutic.TabStop = false;
            pbxAutic.Click += pbxAutic_Click;
            // 
            // pbxBrodic
            // 
            pbxBrodic.AccessibleName = "Brodic";
            pbxBrodic.Image = LogIn.Properties.Resources.brodic;
            pbxBrodic.Location = new Point(151, 232);
            pbxBrodic.Margin = new Padding(3, 4, 3, 4);
            pbxBrodic.Name = "pbxBrodic";
            pbxBrodic.Size = new Size(80, 93);
            pbxBrodic.SizeMode = PictureBoxSizeMode.Zoom;
            pbxBrodic.TabIndex = 9;
            pbxBrodic.TabStop = false;
            pbxBrodic.Click += pbxBrodic_Click;
            // 
            // pbxDino
            // 
            pbxDino.AccessibleName = "Dino";
            pbxDino.Image = LogIn.Properties.Resources.dino;
            pbxDino.Location = new Point(346, 232);
            pbxDino.Margin = new Padding(3, 4, 3, 4);
            pbxDino.Name = "pbxDino";
            pbxDino.Size = new Size(80, 93);
            pbxDino.SizeMode = PictureBoxSizeMode.Zoom;
            pbxDino.TabIndex = 11;
            pbxDino.TabStop = false;
            pbxDino.Click += pbxDino_Click;
            // 
            // pbxKuca
            // 
            pbxKuca.AccessibleName = "Kuca";
            pbxKuca.Image = LogIn.Properties.Resources.kuca;
            pbxKuca.Location = new Point(248, 232);
            pbxKuca.Margin = new Padding(3, 4, 3, 4);
            pbxKuca.Name = "pbxKuca";
            pbxKuca.Size = new Size(80, 93);
            pbxKuca.SizeMode = PictureBoxSizeMode.Zoom;
            pbxKuca.TabIndex = 10;
            pbxKuca.TabStop = false;
            pbxKuca.Click += pbxKuca_Click;
            // 
            // pbxMaca
            // 
            pbxMaca.AccessibleName = "Maca";
            pbxMaca.Image = LogIn.Properties.Resources.maca;
            pbxMaca.Location = new Point(346, 349);
            pbxMaca.Margin = new Padding(3, 4, 3, 4);
            pbxMaca.Name = "pbxMaca";
            pbxMaca.Size = new Size(80, 93);
            pbxMaca.SizeMode = PictureBoxSizeMode.Zoom;
            pbxMaca.TabIndex = 15;
            pbxMaca.TabStop = false;
            pbxMaca.Click += pbxMaca_Click;
            // 
            // pbxPatka
            // 
            pbxPatka.AccessibleName = "Patkica";
            pbxPatka.Image = LogIn.Properties.Resources.patkica;
            pbxPatka.Location = new Point(248, 349);
            pbxPatka.Margin = new Padding(3, 4, 3, 4);
            pbxPatka.Name = "pbxPatka";
            pbxPatka.Size = new Size(80, 93);
            pbxPatka.SizeMode = PictureBoxSizeMode.Zoom;
            pbxPatka.TabIndex = 14;
            pbxPatka.TabStop = false;
            pbxPatka.Click += pbxPatka_Click;
            // 
            // pbxPingvin
            // 
            pbxPingvin.AccessibleName = "Pingvin";
            pbxPingvin.Image = LogIn.Properties.Resources.pingvin;
            pbxPingvin.Location = new Point(151, 349);
            pbxPingvin.Margin = new Padding(3, 4, 3, 4);
            pbxPingvin.Name = "pbxPingvin";
            pbxPingvin.Size = new Size(80, 93);
            pbxPingvin.SizeMode = PictureBoxSizeMode.Zoom;
            pbxPingvin.TabIndex = 13;
            pbxPingvin.TabStop = false;
            pbxPingvin.Click += pbxPingvin_Click;
            // 
            // pbxSesir
            // 
            pbxSesir.AccessibleName = "Sesir";
            pbxSesir.Image = LogIn.Properties.Resources.sesir;
            pbxSesir.Location = new Point(54, 349);
            pbxSesir.Margin = new Padding(3, 4, 3, 4);
            pbxSesir.Name = "pbxSesir";
            pbxSesir.Size = new Size(80, 93);
            pbxSesir.SizeMode = PictureBoxSizeMode.Zoom;
            pbxSesir.TabIndex = 12;
            pbxSesir.TabStop = false;
            pbxSesir.Click += pbxSesir_Click;
            // 
            // pbxLogo
            // 
            pbxLogo.Image = LogIn.Properties.Resources.monopol_logo;
            pbxLogo.Location = new Point(201, -4);
            pbxLogo.Margin = new Padding(3, 4, 3, 4);
            pbxLogo.Name = "pbxLogo";
            pbxLogo.Size = new Size(512, 131);
            pbxLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxLogo.TabIndex = 16;
            pbxLogo.TabStop = false;
            // 
            // btnPočetakIgre
            // 
            btnPočetakIgre.Location = new Point(604, 477);
            btnPočetakIgre.Name = "btnPočetakIgre";
            btnPočetakIgre.Size = new Size(200, 29);
            btnPočetakIgre.TabIndex = 17;
            btnPočetakIgre.Text = "Započni igru";
            btnPočetakIgre.UseVisualStyleBackColor = true;
            btnPočetakIgre.Click += btnPočetakIgre_Click;
            // 
            // frmLogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(btnPočetakIgre);
            Controls.Add(pbxLogo);
            Controls.Add(pbxMaca);
            Controls.Add(pbxPatka);
            Controls.Add(pbxPingvin);
            Controls.Add(pbxSesir);
            Controls.Add(pbxDino);
            Controls.Add(pbxKuca);
            Controls.Add(pbxBrodic);
            Controls.Add(pbxAutic);
            Controls.Add(lvwIgraci);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtImeIgraca);
            Controls.Add(btnDodajIgraca);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmLogIn";
            Text = "Log In";
            ((System.ComponentModel.ISupportInitialize)pbxAutic).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxBrodic).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxDino).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxKuca).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxMaca).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxPatka).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxPingvin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxSesir).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnDodajIgraca;
        private TextBox txtImeIgraca;
        private Label label2;
        private Label label3;
        private ListView lvwIgraci;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private PictureBox pbxAutic;
        private PictureBox pbxBrodic;
        private PictureBox pbxDino;
        private PictureBox pbxKuca;
        private PictureBox pbxMaca;
        private PictureBox pbxPatka;
        private PictureBox pbxPingvin;
        private PictureBox pbxSesir;
        private PictureBox pbxLogo;
        private Button btnPočetakIgre;
    }
}

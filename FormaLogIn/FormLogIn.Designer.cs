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
            label1 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)pbxAutic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxBrodic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxDino).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxKuca).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxMaca).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxPatka).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxPingvin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxSesir).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(769, 45);
            label1.TabIndex = 1;
            label1.Text = "Dobro dosli u MONOPOL! Napisite igrace i krecemo!";
            // 
            // btnDodajIgraca
            // 
            btnDodajIgraca.Location = new Point(303, 101);
            btnDodajIgraca.Name = "btnDodajIgraca";
            btnDodajIgraca.Size = new Size(110, 23);
            btnDodajIgraca.TabIndex = 2;
            btnDodajIgraca.Text = "Dodaj igraca";
            btnDodajIgraca.UseVisualStyleBackColor = true;
            btnDodajIgraca.Click += btnDodajIgraca_Click;
            // 
            // txtImeIgraca
            // 
            txtImeIgraca.Location = new Point(87, 101);
            txtImeIgraca.Name = "txtImeIgraca";
            txtImeIgraca.Size = new Size(210, 23);
            txtImeIgraca.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(47, 103);
            label2.Name = "label2";
            label2.Size = new Size(34, 19);
            label2.TabIndex = 4;
            label2.Text = "ime:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(47, 140);
            label3.Name = "label3";
            label3.Size = new Size(56, 19);
            label3.TabIndex = 5;
            label3.Text = "figurica:";
            // 
            // lvwIgraci
            // 
            lvwIgraci.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvwIgraci.GridLines = true;
            lvwIgraci.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lvwIgraci.Location = new Point(477, 101);
            lvwIgraci.Name = "lvwIgraci";
            lvwIgraci.Size = new Size(274, 187);
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
            pbxAutic.Location = new Point(47, 174);
            pbxAutic.Name = "pbxAutic";
            pbxAutic.Size = new Size(70, 70);
            pbxAutic.SizeMode = PictureBoxSizeMode.Zoom;
            pbxAutic.TabIndex = 8;
            pbxAutic.TabStop = false;
            pbxAutic.Click += pbxAutic_Click;
            // 
            // pbxBrodic
            // 
            pbxBrodic.AccessibleName = "Brodic";
            pbxBrodic.Image = LogIn.Properties.Resources.brodic;
            pbxBrodic.Location = new Point(132, 174);
            pbxBrodic.Name = "pbxBrodic";
            pbxBrodic.Size = new Size(70, 70);
            pbxBrodic.SizeMode = PictureBoxSizeMode.Zoom;
            pbxBrodic.TabIndex = 9;
            pbxBrodic.TabStop = false;
            pbxBrodic.Click += pbxBrodic_Click;
            // 
            // pbxDino
            // 
            pbxDino.AccessibleName = "Dino";
            pbxDino.Image = LogIn.Properties.Resources.dino;
            pbxDino.Location = new Point(303, 174);
            pbxDino.Name = "pbxDino";
            pbxDino.Size = new Size(70, 70);
            pbxDino.SizeMode = PictureBoxSizeMode.Zoom;
            pbxDino.TabIndex = 11;
            pbxDino.TabStop = false;
            pbxDino.Click += pbxDino_Click;
            // 
            // pbxKuca
            // 
            pbxKuca.AccessibleName = "Kuca";
            pbxKuca.Image = LogIn.Properties.Resources.kuca;
            pbxKuca.Location = new Point(217, 174);
            pbxKuca.Name = "pbxKuca";
            pbxKuca.Size = new Size(70, 70);
            pbxKuca.SizeMode = PictureBoxSizeMode.Zoom;
            pbxKuca.TabIndex = 10;
            pbxKuca.TabStop = false;
            pbxKuca.Click += pbxKuca_Click;
            // 
            // pbxMaca
            // 
            pbxMaca.AccessibleName = "Maca";
            pbxMaca.Image = LogIn.Properties.Resources.maca;
            pbxMaca.Location = new Point(303, 262);
            pbxMaca.Name = "pbxMaca";
            pbxMaca.Size = new Size(70, 70);
            pbxMaca.SizeMode = PictureBoxSizeMode.Zoom;
            pbxMaca.TabIndex = 15;
            pbxMaca.TabStop = false;
            pbxMaca.Click += pbxMaca_Click;
            // 
            // pbxPatka
            // 
            pbxPatka.AccessibleName = "Patkica";
            pbxPatka.Image = LogIn.Properties.Resources.patkica;
            pbxPatka.Location = new Point(217, 262);
            pbxPatka.Name = "pbxPatka";
            pbxPatka.Size = new Size(70, 70);
            pbxPatka.SizeMode = PictureBoxSizeMode.Zoom;
            pbxPatka.TabIndex = 14;
            pbxPatka.TabStop = false;
            pbxPatka.Click += pbxPatka_Click;
            // 
            // pbxPingvin
            // 
            pbxPingvin.AccessibleName = "Pingvin";
            pbxPingvin.Image = LogIn.Properties.Resources.pingvin;
            pbxPingvin.Location = new Point(132, 262);
            pbxPingvin.Name = "pbxPingvin";
            pbxPingvin.Size = new Size(70, 70);
            pbxPingvin.SizeMode = PictureBoxSizeMode.Zoom;
            pbxPingvin.TabIndex = 13;
            pbxPingvin.TabStop = false;
            pbxPingvin.Click += pbxPingvin_Click;
            // 
            // pbxSesir
            // 
            pbxSesir.AccessibleName = "Sesir";
            pbxSesir.Image = LogIn.Properties.Resources.sesir;
            pbxSesir.Location = new Point(47, 262);
            pbxSesir.Name = "pbxSesir";
            pbxSesir.Size = new Size(70, 70);
            pbxSesir.SizeMode = PictureBoxSizeMode.Zoom;
            pbxSesir.TabIndex = 12;
            pbxSesir.TabStop = false;
            pbxSesir.Click += pbxSesir_Click;
            // 
            // frmLogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Controls.Add(label1);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
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
    }
}

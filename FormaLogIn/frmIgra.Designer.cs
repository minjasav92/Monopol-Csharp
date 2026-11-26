namespace LogIn
{
    partial class frmIgra
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pbxTabla = new PictureBox();
            tmrKocka = new System.Windows.Forms.Timer(components);
            btnKocke = new Button();
            pbxKocka1 = new PictureBox();
            pbxKocka2 = new PictureBox();
            tmrKretanje = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pbxTabla).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxKocka1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxKocka2).BeginInit();
            SuspendLayout();
            // 
            // pbxTabla
            // 
            pbxTabla.Image = Properties.Resources.tabla;
            pbxTabla.Location = new Point(226, 11);
            pbxTabla.Margin = new Padding(3, 2, 3, 2);
            pbxTabla.Name = "pbxTabla";
            pbxTabla.Size = new Size(500, 503);
            pbxTabla.SizeMode = PictureBoxSizeMode.StretchImage;
            pbxTabla.TabIndex = 0;
            pbxTabla.TabStop = false;
            // 
            // tmrKocka
            // 
            tmrKocka.Interval = 70;
            tmrKocka.Tick += tmrKocka_Tick;
            // 
            // btnKocke
            // 
            btnKocke.Location = new Point(880, 414);
            btnKocke.Margin = new Padding(3, 2, 3, 2);
            btnKocke.Name = "btnKocke";
            btnKocke.Size = new Size(82, 22);
            btnKocke.TabIndex = 1;
            btnKocke.Text = "Backi kocku";
            btnKocke.UseVisualStyleBackColor = true;
            btnKocke.Click += btnKocke_Click;
            // 
            // pbxKocka1
            // 
            pbxKocka1.BackColor = Color.White;
            pbxKocka1.Location = new Point(819, 314);
            pbxKocka1.Margin = new Padding(3, 2, 3, 2);
            pbxKocka1.Name = "pbxKocka1";
            pbxKocka1.Size = new Size(88, 75);
            pbxKocka1.TabIndex = 2;
            pbxKocka1.TabStop = false;
            // 
            // pbxKocka2
            // 
            pbxKocka2.BackColor = Color.White;
            pbxKocka2.Location = new Point(915, 314);
            pbxKocka2.Margin = new Padding(3, 2, 3, 2);
            pbxKocka2.Name = "pbxKocka2";
            pbxKocka2.Size = new Size(88, 75);
            pbxKocka2.TabIndex = 3;
            pbxKocka2.TabStop = false;
            // 
            // tmrKretanje
            // 
            tmrKretanje.Tick += tmrKretanje_Tick;
            // 
            // frmIgra
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(1013, 525);
            Controls.Add(pbxKocka2);
            Controls.Add(pbxKocka1);
            Controls.Add(btnKocke);
            Controls.Add(pbxTabla);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmIgra";
            Text = "frmIgra";
            Load += frmIgra_Load;
            ((System.ComponentModel.ISupportInitialize)pbxTabla).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxKocka1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxKocka2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pbxTabla;
        private System.Windows.Forms.Timer tmrKocka;
        private Button btnKocke;
        private PictureBox pbxKocka1;
        private PictureBox pbxKocka2;
        private System.Windows.Forms.Timer tmrKretanje;
    }
}
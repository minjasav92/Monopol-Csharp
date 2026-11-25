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
            pictureBox1 = new PictureBox();
            tmrKocka = new System.Windows.Forms.Timer(components);
            btnKocke = new Button();
            pbxKocka1 = new PictureBox();
            pbxKocka2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxKocka1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbxKocka2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.tabla;
            pictureBox1.Location = new Point(269, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(641, 569);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;

            // 
            // btnKocke
            // 
            btnKocke.Location = new Point(1006, 552);
            btnKocke.Name = "btnKocke";
            btnKocke.Size = new Size(94, 29);
            btnKocke.TabIndex = 1;
            btnKocke.Text = "Backi kocku";
            btnKocke.UseVisualStyleBackColor = true;
            btnKocke.Click += btnKocke_Click;
            // 
            // pbxKocka1
            // 
            pbxKocka1.BackColor = Color.White;
            pbxKocka1.Location = new Point(936, 419);
            pbxKocka1.Name = "pbxKocka1";
            pbxKocka1.Size = new Size(100, 100);
            pbxKocka1.TabIndex = 2;
            pbxKocka1.TabStop = false;                  // 
            // pbxKocka2
            // 
            pbxKocka2.BackColor = Color.White;
            pbxKocka2.Location = new Point(1046, 419);
            pbxKocka2.Name = "pbxKocka2";
            pbxKocka2.Size = new Size(100, 100);
            pbxKocka2.TabIndex = 3;
            pbxKocka2.TabStop = false;
            // 
            // frmIgra
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(1158, 677);
            Controls.Add(pbxKocka2);
            Controls.Add(pbxKocka1);
            Controls.Add(btnKocke);
            Controls.Add(pictureBox1);
            Name = "frmIgra";
            Text = "frmIgra";
            Load += frmIgra_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxKocka1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbxKocka2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer tmrKocka;
        private Button btnKocke;
        private PictureBox pbxKocka1;
        private PictureBox pbxKocka2;
    }
}
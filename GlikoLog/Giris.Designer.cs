namespace GlikoLog
{
    partial class Giris
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
            txtEmail = new TextBox();
            txtSifre = new TextBox();
            btnGiris = new Button();
            label2 = new Label();
            label = new Label();
            btnKayıtOl = new Button();
            pictureBox1 = new PictureBox();
            lblGirisYapiliyor = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(50, 183);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(179, 23);
            txtEmail.TabIndex = 1;
            txtEmail.TextChanged += txtEmail_TextChanged;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(50, 226);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '⚫';
            txtSifre.Size = new Size(179, 23);
            txtSifre.TabIndex = 2;
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(140, 270);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(89, 23);
            btnGiris.TabIndex = 3;
            btnGiris.Text = "Giriş";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F);
            label2.Location = new Point(50, 168);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 5;
            label2.Text = "Email";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 9F);
            label.Location = new Point(50, 211);
            label.Name = "label";
            label.Size = new Size(30, 15);
            label.TabIndex = 6;
            label.Text = "Şifre";
            // 
            // btnKayıtOl
            // 
            btnKayıtOl.Location = new Point(50, 270);
            btnKayıtOl.Name = "btnKayıtOl";
            btnKayıtOl.Size = new Size(84, 23);
            btnKayıtOl.TabIndex = 7;
            btnKayıtOl.Text = "KAYIT OL";
            btnKayıtOl.UseVisualStyleBackColor = true;
            btnKayıtOl.Click += btnKayıtOl_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = PL.Properties.Resources._1;
            pictureBox1.Location = new Point(-1, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(823, 476);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // lblGirisYapiliyor
            // 
            lblGirisYapiliyor.BackColor = Color.Black;
            lblGirisYapiliyor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblGirisYapiliyor.ForeColor = Color.WhiteSmoke;
            lblGirisYapiliyor.Location = new Point(-1, -2);
            lblGirisYapiliyor.Name = "lblGirisYapiliyor";
            lblGirisYapiliyor.Size = new Size(823, 21);
            lblGirisYapiliyor.TabIndex = 10;
            lblGirisYapiliyor.Text = "Giriş Yapılıyor..";
            lblGirisYapiliyor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Giris
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(821, 472);
            Controls.Add(lblGirisYapiliyor);
            Controls.Add(btnKayıtOl);
            Controls.Add(label);
            Controls.Add(label2);
            Controls.Add(btnGiris);
            Controls.Add(txtSifre);
            Controls.Add(txtEmail);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IsMdiContainer = true;
            MaximizeBox = false;
            Name = "Giris";
            Text = "Kullanıcı Giriş";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtEmail;
        private TextBox txtSifre;
        private Button btnGiris;
        private Label label2;
        private Label label;
        private Button btnKayıtOl;
        private PictureBox pictureBox1;
        private Label lblGirisYapiliyor;
    }
}

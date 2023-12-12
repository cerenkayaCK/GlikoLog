namespace GlikoLog.PL
{
    partial class AdminKullaniciIslemleriForm
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
            dgvKullanicilar = new DataGridView();
            groupBox1 = new GroupBox();
            txtYas = new TextBox();
            label11 = new Label();
            cmbKullaniciTur = new ComboBox();
            cmbCinsiyet = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            txtBoy = new TextBox();
            label6 = new Label();
            txtKilo = new TextBox();
            label5 = new Label();
            txtSoyadi = new TextBox();
            label4 = new Label();
            txtAdi = new TextBox();
            label3 = new Label();
            txtSifre = new TextBox();
            label2 = new Label();
            txtEmail = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            txtAdres = new TextBox();
            label10 = new Label();
            txtTelefonNo = new TextBox();
            label9 = new Label();
            btnKullaniciEkle = new Button();
            btnKullaniciGuncelle = new Button();
            btnKullaniciSil = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKullanicilar).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvKullanicilar
            // 
            dgvKullanicilar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKullanicilar.Location = new Point(12, 12);
            dgvKullanicilar.Name = "dgvKullanicilar";
            dgvKullanicilar.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKullanicilar.Size = new Size(776, 276);
            dgvKullanicilar.TabIndex = 0;
            dgvKullanicilar.SelectionChanged += dgvKullanicilar_SelectionChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtYas);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(cmbKullaniciTur);
            groupBox1.Controls.Add(cmbCinsiyet);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtBoy);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtKilo);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtSoyadi);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtAdi);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtSifre);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 294);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(320, 284);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kullanıcı Bilgileri";
            // 
            // txtYas
            // 
            txtYas.Location = new Point(92, 135);
            txtYas.Name = "txtYas";
            txtYas.Size = new Size(219, 23);
            txtYas.TabIndex = 4;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(59, 138);
            label11.Name = "label11";
            label11.Size = new Size(27, 15);
            label11.TabIndex = 16;
            label11.Text = "Yaş:";
            // 
            // cmbKullaniciTur
            // 
            cmbKullaniciTur.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKullaniciTur.FormattingEnabled = true;
            cmbKullaniciTur.Location = new Point(92, 251);
            cmbKullaniciTur.Name = "cmbKullaniciTur";
            cmbKullaniciTur.Size = new Size(219, 23);
            cmbKullaniciTur.TabIndex = 8;
            // 
            // cmbCinsiyet
            // 
            cmbCinsiyet.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCinsiyet.FormattingEnabled = true;
            cmbCinsiyet.Location = new Point(92, 222);
            cmbCinsiyet.Name = "cmbCinsiyet";
            cmbCinsiyet.Size = new Size(219, 23);
            cmbCinsiyet.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(4, 254);
            label8.Name = "label8";
            label8.Size = new Size(82, 15);
            label8.TabIndex = 14;
            label8.Text = "Kullanıcı Türü:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 225);
            label7.Name = "label7";
            label7.Size = new Size(52, 15);
            label7.TabIndex = 12;
            label7.Text = "Cinsiyet:";
            // 
            // txtBoy
            // 
            txtBoy.Location = new Point(92, 193);
            txtBoy.Name = "txtBoy";
            txtBoy.Size = new Size(219, 23);
            txtBoy.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(56, 196);
            label6.Name = "label6";
            label6.Size = new Size(30, 15);
            label6.TabIndex = 10;
            label6.Text = "Boy:";
            // 
            // txtKilo
            // 
            txtKilo.Location = new Point(92, 164);
            txtKilo.Name = "txtKilo";
            txtKilo.Size = new Size(219, 23);
            txtKilo.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 167);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 8;
            label5.Text = "Kilo:";
            // 
            // txtSoyadi
            // 
            txtSoyadi.Location = new Point(92, 106);
            txtSoyadi.Name = "txtSoyadi";
            txtSoyadi.Size = new Size(219, 23);
            txtSoyadi.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 109);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 6;
            label4.Text = "Soyad:";
            // 
            // txtAdi
            // 
            txtAdi.Location = new Point(92, 77);
            txtAdi.Name = "txtAdi";
            txtAdi.Size = new Size(219, 23);
            txtAdi.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 80);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 4;
            label3.Text = "Ad:";
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(92, 48);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(219, 23);
            txtSifre.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 51);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 2;
            label2.Text = "Şifre:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(92, 19);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(219, 23);
            txtEmail.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 22);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 0;
            label1.Text = "E-Mail Adresi:";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtAdres);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(txtTelefonNo);
            groupBox2.Controls.Add(label9);
            groupBox2.Location = new Point(338, 294);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(450, 214);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "İletişim Bilgileri";
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(92, 48);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(219, 105);
            txtAdres.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(46, 51);
            label10.Name = "label10";
            label10.Size = new Size(40, 15);
            label10.TabIndex = 4;
            label10.Text = "Adres:";
            // 
            // txtTelefonNo
            // 
            txtTelefonNo.Location = new Point(92, 19);
            txtTelefonNo.Name = "txtTelefonNo";
            txtTelefonNo.Size = new Size(219, 23);
            txtTelefonNo.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 22);
            label9.Name = "label9";
            label9.Size = new Size(67, 15);
            label9.TabIndex = 2;
            label9.Text = "Telefon No:";
            // 
            // btnKullaniciEkle
            // 
            btnKullaniciEkle.Location = new Point(338, 514);
            btnKullaniciEkle.Name = "btnKullaniciEkle";
            btnKullaniciEkle.Size = new Size(145, 64);
            btnKullaniciEkle.TabIndex = 0;
            btnKullaniciEkle.Text = "Kullanıcı Ekle";
            btnKullaniciEkle.UseVisualStyleBackColor = true;
            btnKullaniciEkle.Click += btnKullaniciEkle_Click;
            // 
            // btnKullaniciGuncelle
            // 
            btnKullaniciGuncelle.Location = new Point(489, 514);
            btnKullaniciGuncelle.Name = "btnKullaniciGuncelle";
            btnKullaniciGuncelle.Size = new Size(154, 64);
            btnKullaniciGuncelle.TabIndex = 1;
            btnKullaniciGuncelle.Text = "Kullanıcı Güncelle";
            btnKullaniciGuncelle.UseVisualStyleBackColor = true;
            btnKullaniciGuncelle.Click += btnKullaniciGuncelle_Click;
            // 
            // btnKullaniciSil
            // 
            btnKullaniciSil.ForeColor = Color.Red;
            btnKullaniciSil.Location = new Point(649, 514);
            btnKullaniciSil.Name = "btnKullaniciSil";
            btnKullaniciSil.Size = new Size(139, 64);
            btnKullaniciSil.TabIndex = 2;
            btnKullaniciSil.Text = "Seçili Kullanıcıyı Sil";
            btnKullaniciSil.UseVisualStyleBackColor = true;
            btnKullaniciSil.Click += btnKullaniciSil_Click;
            // 
            // AdminKullaniciIslemleriForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 585);
            Controls.Add(btnKullaniciSil);
            Controls.Add(btnKullaniciGuncelle);
            Controls.Add(btnKullaniciEkle);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dgvKullanicilar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AdminKullaniciIslemleriForm";
            Text = "Kullanıcı İşlemleri";
            ((System.ComponentModel.ISupportInitialize)dgvKullanicilar).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvKullanicilar;
        private GroupBox groupBox1;
        private Label label8;
        private Label label7;
        private TextBox txtBoy;
        private Label label6;
        private TextBox txtKilo;
        private Label label5;
        private TextBox txtSoyadi;
        private Label label4;
        private TextBox txtAdi;
        private Label label3;
        private TextBox txtSifre;
        private Label label2;
        private TextBox txtEmail;
        private Label label1;
        private ComboBox cmbKullaniciTur;
        private ComboBox cmbCinsiyet;
        private GroupBox groupBox2;
        private TextBox txtAdres;
        private Label label10;
        private TextBox txtTelefonNo;
        private Label label9;
        private Button btnKullaniciEkle;
        private Button btnKullaniciGuncelle;
        private Button btnKullaniciSil;
        private TextBox txtYas;
        private Label label11;
    }
}
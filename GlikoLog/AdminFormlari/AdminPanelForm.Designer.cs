namespace GlikoLog.PL
{
    partial class AdminPanelForm
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
            btnYemekIslemleri = new Button();
            btnRaporlar = new Button();
            btnKullaniciIslemleri = new Button();
            SuspendLayout();
            // 
            // btnYemekIslemleri
            // 
            btnYemekIslemleri.Location = new Point(96, 65);
            btnYemekIslemleri.Name = "btnYemekIslemleri";
            btnYemekIslemleri.Size = new Size(167, 58);
            btnYemekIslemleri.TabIndex = 0;
            btnYemekIslemleri.Text = "Yemek İşlemleri";
            btnYemekIslemleri.UseVisualStyleBackColor = true;
            btnYemekIslemleri.Click += btnYemekIslemleri_Click;
            // 
            // btnRaporlar
            // 
            btnRaporlar.Location = new Point(269, 65);
            btnRaporlar.Name = "btnRaporlar";
            btnRaporlar.Size = new Size(167, 58);
            btnRaporlar.TabIndex = 1;
            btnRaporlar.Text = "Raporlar";
            btnRaporlar.UseVisualStyleBackColor = true;
            btnRaporlar.Click += btnRaporlar_Click;
            // 
            // btnKullaniciIslemleri
            // 
            btnKullaniciIslemleri.Location = new Point(189, 129);
            btnKullaniciIslemleri.Name = "btnKullaniciIslemleri";
            btnKullaniciIslemleri.Size = new Size(167, 66);
            btnKullaniciIslemleri.TabIndex = 2;
            btnKullaniciIslemleri.Text = "Kullanıcı İşlemleri";
            btnKullaniciIslemleri.UseVisualStyleBackColor = true;
            btnKullaniciIslemleri.Click += btnKullaniciIslemleri_Click;
            // 
            // AdminPanelForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 267);
            Controls.Add(btnKullaniciIslemleri);
            Controls.Add(btnRaporlar);
            Controls.Add(btnYemekIslemleri);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AdminPanelForm";
            Text = "GlikoLog Admin Paneli";
            ResumeLayout(false);
        }

        #endregion

        private Button btnYemekIslemleri;
        private Button btnRaporlar;
        private Button btnKullaniciIslemleri;
    }
}
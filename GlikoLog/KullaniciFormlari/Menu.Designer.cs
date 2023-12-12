using System;

namespace GlikoLog.PL
{
    partial class Menu
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
            menuStrip1 = new MenuStrip();
            öğünToolStripMenuItem = new ToolStripMenuItem();
            saglikToolStripMenuItem = new ToolStripMenuItem();
            suIcmeToolStripMenuItem3 = new ToolStripMenuItem();
            egzersizToolStripMenuItem = new ToolStripMenuItem();
            iletisimBilgisiToolStripMenuItem = new ToolStripMenuItem();
            profilYonetimiToolStripMenuItem = new ToolStripMenuItem();
            raporlarToolStripMenuItem = new ToolStripMenuItem();
            cikisToolStripMenuItem = new ToolStripMenuItem();
            anaFormResim = new PictureBox();
            lblKullanici = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)anaFormResim).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.OliveDrab;
            menuStrip1.Dock = DockStyle.Left;
            menuStrip1.Items.AddRange(new ToolStripItem[] { öğünToolStripMenuItem, saglikToolStripMenuItem, suIcmeToolStripMenuItem3, egzersizToolStripMenuItem, iletisimBilgisiToolStripMenuItem, profilYonetimiToolStripMenuItem, raporlarToolStripMenuItem, cikisToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(126, 498);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // öğünToolStripMenuItem
            // 
            öğünToolStripMenuItem.BackColor = Color.Transparent;
            öğünToolStripMenuItem.Font = new Font("Malgun Gothic", 9.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            öğünToolStripMenuItem.ForeColor = Color.White;
            öğünToolStripMenuItem.Name = "öğünToolStripMenuItem";
            öğünToolStripMenuItem.Size = new Size(113, 21);
            öğünToolStripMenuItem.Text = "ÖĞÜN";
            öğünToolStripMenuItem.Click += öğünToolStripMenuItem_Click;
            // 
            // saglikToolStripMenuItem
            // 
            saglikToolStripMenuItem.BackColor = Color.Transparent;
            saglikToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            saglikToolStripMenuItem.ForeColor = Color.White;
            saglikToolStripMenuItem.Name = "saglikToolStripMenuItem";
            saglikToolStripMenuItem.Size = new Size(113, 19);
            saglikToolStripMenuItem.Text = "SAĞLIK";
            saglikToolStripMenuItem.Click += saglikToolStripMenuItem_Click;
            // 
            // suIcmeToolStripMenuItem3
            // 
            suIcmeToolStripMenuItem3.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            suIcmeToolStripMenuItem3.ForeColor = Color.White;
            suIcmeToolStripMenuItem3.Name = "suIcmeToolStripMenuItem3";
            suIcmeToolStripMenuItem3.Size = new Size(113, 19);
            suIcmeToolStripMenuItem3.Text = "SU İÇ!";
            suIcmeToolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // egzersizToolStripMenuItem
            // 
            egzersizToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            egzersizToolStripMenuItem.ForeColor = SystemColors.Info;
            egzersizToolStripMenuItem.Name = "egzersizToolStripMenuItem";
            egzersizToolStripMenuItem.Size = new Size(113, 19);
            egzersizToolStripMenuItem.Text = "EGZERSİZ";
            egzersizToolStripMenuItem.Click += egzersizToolStripMenuItem_Click;
            // 
            // iletisimBilgisiToolStripMenuItem
            // 
            iletisimBilgisiToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            iletisimBilgisiToolStripMenuItem.ForeColor = SystemColors.Info;
            iletisimBilgisiToolStripMenuItem.Name = "iletisimBilgisiToolStripMenuItem";
            iletisimBilgisiToolStripMenuItem.Size = new Size(113, 19);
            iletisimBilgisiToolStripMenuItem.Text = "İLETİŞİM BİLGİSİ";
            iletisimBilgisiToolStripMenuItem.Click += iLETİŞİMBİLGİSİToolStripMenuItem_Click;
            // 
            // profilYonetimiToolStripMenuItem
            // 
            profilYonetimiToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            profilYonetimiToolStripMenuItem.ForeColor = SystemColors.Info;
            profilYonetimiToolStripMenuItem.Name = "profilYonetimiToolStripMenuItem";
            profilYonetimiToolStripMenuItem.Size = new Size(113, 19);
            profilYonetimiToolStripMenuItem.Text = "PROFİL BİLGİLERİM";
            profilYonetimiToolStripMenuItem.Click += profilYonetimiToolStripMenuItem_Click;
            // 
            // raporlarToolStripMenuItem
            // 
            raporlarToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            raporlarToolStripMenuItem.ForeColor = SystemColors.Info;
            raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            raporlarToolStripMenuItem.Size = new Size(113, 19);
            raporlarToolStripMenuItem.Text = "RAPORLAR";
            raporlarToolStripMenuItem.Click += raporlarToolStripMenuItem_Click;
            // 
            // cikisToolStripMenuItem
            // 
            cikisToolStripMenuItem.BackColor = Color.Transparent;
            cikisToolStripMenuItem.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            cikisToolStripMenuItem.ForeColor = SystemColors.Info;
            cikisToolStripMenuItem.Name = "cikisToolStripMenuItem";
            cikisToolStripMenuItem.Size = new Size(113, 19);
            cikisToolStripMenuItem.Text = "ÇIKIŞ";
            cikisToolStripMenuItem.Click += cikisToolStripMenuItem_Click;
            // 
            // anaFormResim
            // 
            anaFormResim.BackColor = Color.Transparent;
            anaFormResim.Image = Properties.Resources.glikolog__2_;
            anaFormResim.Location = new Point(-28, -32);
            anaFormResim.Name = "anaFormResim";
            anaFormResim.Size = new Size(936, 533);
            anaFormResim.SizeMode = PictureBoxSizeMode.StretchImage;
            anaFormResim.TabIndex = 8;
            anaFormResim.TabStop = false;
            // 
            // lblKullanici
            // 
            lblKullanici.AutoSize = true;
            lblKullanici.BackColor = SystemColors.ActiveCaptionText;
            lblKullanici.Location = new Point(138, 474);
            lblKullanici.Name = "lblKullanici";
            lblKullanici.Size = new Size(0, 15);
            lblKullanici.TabIndex = 10;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(908, 498);
            Controls.Add(lblKullanici);
            Controls.Add(menuStrip1);
            Controls.Add(anaFormResim);
            ForeColor = SystemColors.ButtonHighlight;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Menu";
            Text = "Menu";
            TransparencyKey = Color.Transparent;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)anaFormResim).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox anaFormResim;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem öğünToolStripMenuItem;
        private ToolStripMenuItem saglikToolStripMenuItem;
        private ToolStripMenuItem egzersizToolStripMenuItem;
        private ToolStripMenuItem iletisimBilgisiToolStripMenuItem;
        private ToolStripMenuItem profilYonetimiToolStripMenuItem;
        private ToolStripMenuItem raporlarToolStripMenuItem;
        private ToolStripMenuItem suIcmeToolStripMenuItem3;
        private ToolStripMenuItem cikisToolStripMenuItem;
        private PictureBox pictureBox2;
        private PictureBox AnaformResim;
        private Label lblKullanici;
    }
}
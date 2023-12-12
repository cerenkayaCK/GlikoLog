using GlikoLog.DAL.Context;
using GlikoLog.PL.KullaniciFormlari;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GlikoLog.PL
{
    public partial class Menu : Form
    {

        public Menu()
        {
            InitializeComponent();
            this.DoubleBuffered = true; //Flicker önlenmesi için
            lblKullanici.Text = Giris.GirisYapanKullanici.Ad + " " + Giris.GirisYapanKullanici.Soyad;
            lblKullanici.BackColor = Color.SkyBlue;
            this.FormClosing += AnaForm_FormClosing;
           
        }

        public void FormGoster(Form secilenForm)
        {
            anaFormResim.Visible = false;
            secilenForm.StartPosition = 0;
            bool durum = false; 

            foreach (Form form in this.MdiChildren)
            {
                if (form.GetType() == secilenForm.GetType())
                {
                    durum = true;

                    form.Show(); 
                }
                else
                {
                    form.Close();
                }
            }
            if (!durum)
            {                    
                   secilenForm.MdiParent = this;
                   secilenForm.Show();
            }
        

        }

        private void iLETİŞİMBİLGİSİToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            IletisimBilgileri iletisimBilgisiForm = new IletisimBilgileri();
            iletisimBilgisiForm.FormBorderStyle = FormBorderStyle.None;
            FormGoster(iletisimBilgisiForm);
        }

        private void öğünToolStripMenuItem_Click(object sender, EventArgs e)
        {
       
            KullanıcıOgunEklemeForm kullaniciOgunEklemeForm = new KullanıcıOgunEklemeForm();
            kullaniciOgunEklemeForm.FormBorderStyle = FormBorderStyle.None;
            FormGoster(kullaniciOgunEklemeForm);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            SuBilgiForm suForm = new SuBilgiForm();
            suForm.FormBorderStyle = FormBorderStyle.None;
            FormGoster(suForm);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            SuBilgiForm suForm = new SuBilgiForm();
            suForm.FormBorderStyle = FormBorderStyle.None;
            FormGoster(suForm);
        }

        private void profilYonetimiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProfilYonetimi profilYonetimFormu = new ProfilYonetimi();
            profilYonetimFormu.FormBorderStyle = FormBorderStyle.None;
            FormGoster(profilYonetimFormu);
        }

        private void cikisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Giris girisForm = new Giris();
            girisForm.Show();
        }

        private void saglikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaglikBilgiForm saglikForm = new SaglikBilgiForm();
            saglikForm.FormBorderStyle = FormBorderStyle.None;
            FormGoster(saglikForm);
        }

        private void egzersizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EgzersizForm egzersizFormu = new EgzersizForm();
            egzersizFormu.FormBorderStyle = FormBorderStyle.None;
            FormGoster(egzersizFormu);
        }

        private void raporlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciRapor kullaniciRapor = new KullaniciRapor();
            kullaniciRapor.FormBorderStyle = FormBorderStyle.None;
            FormGoster(kullaniciRapor);
        }
        private void AnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Kullanıcı çarpı simgesine bastığında yapılacak işlemler
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Uygulamayı kapatmak istediğinize emin misiniz?", "Kapatma Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                   
                }
                else Application.Exit();
               

            }
        }
    }
}

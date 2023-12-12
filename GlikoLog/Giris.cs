using GlikoLog.BL.Repository;
using GlikoLog.DAL.Context;
using GlikoLog.DAL.Entities;
using GlikoLog.DAL.Kontroller;
using GlikoLog.PL;
using System.Diagnostics.Eventing.Reader;

namespace GlikoLog
{
    public partial class Giris : Form
    {
        public static Repository<Kullanici> KullaniciDb = new Repository<Kullanici>();
        public static Kullanici? GirisYapanKullanici = null;
        public Giris()
        {
            InitializeComponent();
            this.DoubleBuffered = true; //Flicker �nlenmesi i�in
            lblGirisYapiliyor.Visible = false;

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            try
            {
                lblGirisYapiliyor.Visible = true;
                lblGirisYapiliyor.Refresh();
                DbKontrol dbKontrol = new DbKontrol();
                Kullanici kullanici = KullaniciDb.FirstOrDefault(x => x.Email == txtEmail.Text);
                if (kullanici != null)
                {
                    GirisYapanKullanici = kullanici;

                }
                else
                {
                    lblGirisYapiliyor.Visible = false;
                    lblGirisYapiliyor.Refresh();
                    MessageBox.Show("Bu email sistemde kay�tl� de�il.");
                    return;
                }
                bool sonuc = dbKontrol.KullaniciGirisKontrolu(txtEmail.Text, txtSifre.Text);

                if (sonuc)
                {
                    bool adminMi = dbKontrol.AdminMi(GirisYapanKullanici);

                    if (adminMi == true)
                    {

                        AdminPanelForm AdminMenu = new AdminPanelForm();
                        AdminMenu.Show();
                        this.Hide();
                    }
                    else
                    {
                        Menu menu = new Menu();
                        menu.Show(this);
                        this.Hide();
                    }
                }

                else
                {
                    lblGirisYapiliyor.Visible = false;
                    lblGirisYapiliyor.Refresh();
                    MessageBox.Show("Hatal� E-mail veya �ifre!");

                    return;
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Bilinmeyen Hata! Tekrar Giri� Yap�n�z.");
                return;
            }
           
        }

        private void btnKay�tOl_Click(object sender, EventArgs e)
        {
            KayitOl kayitForm = new KayitOl();
            kayitForm.Show(this);
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

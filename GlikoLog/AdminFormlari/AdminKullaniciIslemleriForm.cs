using GlikoLog.BL.Repository;
using GlikoLog.DAL.Context;
using GlikoLog.DAL.Entities;
using GlikoLog.DAL.Enums;
using GlikoLog.DAL.Kontroller;
using Microsoft.EntityFrameworkCore;

namespace GlikoLog.PL
{
    public partial class AdminKullaniciIslemleriForm : Form
    {
        UygulamaDbContext db = new UygulamaDbContext();
        Repository<Kullanici> _kullanici = new Repository<Kullanici>();
        Repository<IletisimBilgi> _iletisimBilgisi = new Repository<IletisimBilgi>();

        public AdminKullaniciIslemleriForm()
        {
            InitializeComponent();
            KullanicilariGetir();
            cmbKullaniciTur.DataSource = Enum.GetValues(typeof(KullaniciTuru));
            cmbCinsiyet.DataSource = Enum.GetValues(typeof(Cinsiyet));
        }

        private void KullanicilariGetir()
        {
            dgvKullanicilar.DataSource = db.Kullanicilar
            .Select(a => new
            {
                Id = a.Id,
                Email = a.Email,
                Sifre = a.Sifre,
                KullaniciTuru = a.KullaniciTuru,
                Ad = a.Ad,
                Soyad = a.Soyad,
                Yas = a.Yas,
                Kilo = a.Kilo,
                Boy = a.Boy,
                Cinsiyet = a.Cinsiyet,
                Telefon = a.IletisimBilgisi.Telefon,
                Adres = a.IletisimBilgisi.Adres
            })
            .ToList();
        }

        private void btnKullaniciEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmail.Text == "" || txtSifre.Text == "" || txtAdi.Text == "" || txtSoyadi.Text == "" || txtYas.Text == "" || txtKilo.Text == "" || txtBoy.Text == "")
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                    return;
                }

                var yeniKullanici = new Kullanici()
                {

                    Email = txtEmail.Text,
                    Sifre = txtSifre.Text,
                    Ad = txtAdi.Text,
                    Soyad = txtSoyadi.Text,
                    Yas = Convert.ToInt32(txtYas.Text),
                    Kilo = Convert.ToInt32(txtKilo.Text),
                    Boy = Convert.ToInt32(txtBoy.Text),
                    Cinsiyet = (Cinsiyet)cmbCinsiyet.SelectedItem!,
                    KullaniciTuru = (KullaniciTuru)cmbKullaniciTur.SelectedItem!,
                    IletisimBilgisi = new IletisimBilgi()
                    {
                        Telefon = txtTelefonNo.Text,
                        Adres = txtAdres.Text
                    }
                };

                if (_kullanici.HepsiniGetirDbSet().FirstOrDefault(x => x.Email == txtEmail.Text) == null)
                {
                    // veritabanına kaydet
                    _kullanici.Ekle(yeniKullanici);
                }
                else
                {
                    MessageBox.Show("Bu Email Kullanımda!");

                }
                KullanicilariGetir();

            }
            catch (Exception)
            {
                MessageBox.Show("Hata! Tekrar deneyin!");
                return;
            }


        }

        private void btnKullaniciGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmail.Text == "" || txtAdi.Text == "" || txtSoyadi.Text == "" || txtYas.Text == "" || txtKilo.Text == "" || txtBoy.Text == "")
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                    return;
                }

                // tokat
                if (dgvKullanicilar.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen güncellemek istediğiniz kullanıcıyı seçiniz.");
                    return;
                }



                // seçili kullanıcıyı al
                int seciliKullaniciId = (int)dgvKullanicilar.SelectedRows[0].Cells[0].Value;
                Kullanici seciliKullanici = _kullanici.IdYeGoreGetir(seciliKullaniciId);

                // verileri al
                seciliKullanici.Email = txtEmail.Text;
                //eğer şifre değiştiyse şifreyi değiştir
                if (seciliKullanici.Sifre != txtSifre.Text)
                    seciliKullanici.Sifre = txtSifre.Text;


                seciliKullanici.Ad = txtAdi.Text;
                seciliKullanici.Soyad = txtSoyadi.Text;
                seciliKullanici.Yas = Convert.ToInt32(txtYas.Text);
                seciliKullanici.Kilo = Convert.ToInt32(txtKilo.Text);
                seciliKullanici.Boy = Convert.ToInt32(txtBoy.Text);
                seciliKullanici.Cinsiyet = (Cinsiyet)cmbCinsiyet.SelectedItem!;
                seciliKullanici.KullaniciTuru = (KullaniciTuru)cmbKullaniciTur.SelectedItem!;

                // iletişim bilgilerini bul ve güncelle
                //IletisimBilgi seciliBilgi = _iletisimBilgisi.IdYeGoreGetir(seciliKullanici.Id);

                IletisimBilgi seciliBilgi = _iletisimBilgisi.HepsiniGetir().Where(a => a.Id == seciliKullanici.IletisimBilgiId).FirstOrDefault()!;

                if (seciliBilgi != null)
                {
                    seciliBilgi.Telefon = txtTelefonNo.Text;
                    seciliBilgi.Adres = txtAdres.Text;

                }

                _kullanici.Guncelle();
                _iletisimBilgisi.Guncelle();

                KullanicilariGetir();


            }
            catch (Exception)
            {
                MessageBox.Show("Hata! Tekrar deneyin!");
                return;
            }


        }

        private void dgvKullanicilar_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvKullanicilar.SelectedRows.Count == 0) return;

                // seçili kullanıcıyı al
                int seciliKullaniciId = (int)dgvKullanicilar.SelectedRows[0].Cells[0].Value;
                Kullanici seciliKullanici = _kullanici.IdYeGoreGetir(seciliKullaniciId);

                // where ile iletisimbilgileri tablosundan kullanıcı id ye göre iletisimbilgi id yi al
                IletisimBilgi seciliKullaniciIletisimBilgisi = _iletisimBilgisi.HepsiniGetir().Where(a => a.Id == seciliKullanici.IletisimBilgiId).FirstOrDefault()!;

                if (seciliKullanici != null)
                {
                    // textboxlara yaz
                    txtEmail.Text = seciliKullanici.Email;
                    txtSifre.Text = seciliKullanici.Sifre;
                    txtAdi.Text = seciliKullanici.Ad;
                    txtSoyadi.Text = seciliKullanici.Soyad;
                    txtYas.Text = seciliKullanici.Yas.ToString();
                    txtKilo.Text = seciliKullanici.Kilo.ToString();
                    txtBoy.Text = seciliKullanici.Boy.ToString();
                    cmbCinsiyet.SelectedItem = seciliKullanici.Cinsiyet;
                    cmbKullaniciTur.SelectedItem = seciliKullanici.KullaniciTuru;

                    if (seciliKullanici.IletisimBilgisi != null)
                    {
                        txtTelefonNo.Text = seciliKullaniciIletisimBilgisi.Telefon;
                        txtAdres.Text = seciliKullaniciIletisimBilgisi.Adres;
                    }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata! Tekrar deneyin!");
                return;
            }


        }

        private async void btnKullaniciSil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("Silmek istediğinize emin misiniz?", "Kullanıcı Silme", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.No) return;

                // tokat
                if (dgvKullanicilar.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen silmek istediğiniz kullanıcıyı seçiniz.");
                    return;
                }

                // seçili kullanıcıyı al
                int seciliKullaniciId = (int)dgvKullanicilar.SelectedRows[0].Cells[0].Value;

                Kullanici seciliKullanici = _kullanici.IdYeGoreGetir(seciliKullaniciId);

                if (seciliKullanici.IletisimBilgisi != null)
                {
                    await _iletisimBilgisi.SilAsync(seciliKullanici.IletisimBilgisi);
                }

                // kullanıcıyı sil

                await _kullanici.SilAsync(seciliKullanici);


                KullanicilariGetir();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata! Tekrar deneyin!");
                return;
            }



        }
    }
}

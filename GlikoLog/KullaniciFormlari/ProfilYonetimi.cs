using GlikoLog.BL.Repository;
using GlikoLog.DAL;
using GlikoLog.DAL.Context;
using GlikoLog.DAL.Entities;
using GlikoLog.DAL.Enums;
using GlikoLog.DAL.Kontroller;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlikoLog.PL.KullaniciFormlari
{
    public partial class ProfilYonetimi : Form
    {
        Repository<Kullanici> KullaniciDb = new Repository<Kullanici>();
        public ProfilYonetimi()
        {
            InitializeComponent();
            this.DoubleBuffered = true; //Flicker önlenmesi için
            BilgileriGetir();
        }

        private void BilgileriGetir()
        {
            txtAd.Text = Giris.GirisYapanKullanici.Ad;
            txtSoyad.Text = Giris.GirisYapanKullanici.Soyad;
            txtYas.Text = Giris.GirisYapanKullanici.Yas.ToString();
            txtKilo.Text = Giris.GirisYapanKullanici.Kilo.ToString();
            txtBoy.Text = Giris.GirisYapanKullanici.Boy.ToString();
            cmbCinsiyet.DataSource = Enum.GetValues(typeof(Cinsiyet));
            cmbCinsiyet.SelectedItem = Giris.GirisYapanKullanici.Cinsiyet;

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (KullaniciyiGuncelle())
            {
                KullaniciDb.Guncelle();
                MessageBox.Show("Değişiklikler kaydedildi");
            }
            else
                MessageBox.Show("Değişiklikler kaydedilemedi");

        }

        private bool KullaniciyiGuncelle()
        {
            bool GecerliMi = true;
            if (Giris.GirisYapanKullanici != null)
            {
                string s1 = Kontrol.IsimKontrolu(txtAd.Text);
                if (s1 == null) { Giris.GirisYapanKullanici.Ad = txtAd.Text.Trim(); }
                else { GecerliMi = false; lblAd.Text = s1; }


                string s2 = Kontrol.SoyisimKontrolu(txtSoyad.Text);
                if (s2 == null) { Giris.GirisYapanKullanici.Soyad = txtSoyad.Text.Trim(); }
                else { GecerliMi = false; lblSoyad.Text = s2; }


                string s3 = Kontrol.BoyKontrolu(txtBoy.Text);
                if (s3 == null) { Giris.GirisYapanKullanici.Boy = double.Parse(txtBoy.Text.Trim()); }
                else { GecerliMi = false; lblBoy.Text = s3; }


                string s4 = Kontrol.KiloKontrolu(txtKilo.Text);
                if (s4 == null) { Giris.GirisYapanKullanici.Kilo = double.Parse(txtKilo.Text.Trim()); }
                else { GecerliMi = false; lblKilo.Text = s4; }


                string s6 = Kontrol.YasKontrolu(txtYas.Text);
                if (s6 == null) { Giris.GirisYapanKullanici.Yas = Convert.ToInt32(txtYas.Text.Trim()); }
                else { GecerliMi = false; lblYas.Text = s6; }


                if (cmbCinsiyet.SelectedItem != null)
                    Giris.GirisYapanKullanici.Cinsiyet = (Cinsiyet)cmbCinsiyet.SelectedItem;
                else
                {
                    lblCinsiyet.Text = "Cinsiyet seçilmelidir.";
                    GecerliMi = false;
                }
              
            }  return GecerliMi;

        }
    }
}


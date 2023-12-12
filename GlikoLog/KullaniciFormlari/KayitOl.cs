using GlikoLog.BL.Interfaces;
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

namespace GlikoLog.PL
{
    public partial class KayitOl : Form
    {
        Kullanici yeniKullanici = new Kullanici();
        Repository<Kullanici> Kullanicirepository = new Repository<Kullanici>();

        public string Mesaj;
        public KayitOl()
        {
            InitializeComponent();
            this.DoubleBuffered = true; //Flicker önlenmesi için
            cmbCinsiyet.DataSource = Enum.GetValues(typeof(Cinsiyet));
            cmbCinsiyet.SelectedItem = null;

        }
        private void btnYeniKayit_Click(object sender, EventArgs e)
        {
            UyarilariTemizle();

            if (KullaniciOlustur(yeniKullanici))
            {
                Kullanicirepository.Ekle(yeniKullanici);
                this.Close();
                UyarilariTemizle();
            }

        }
        private void UyarilariTemizle()
        {
            TemizleLabel(lblAd);
            TemizleLabel(lblSoyad);
            TemizleLabel(lblKilo);
            TemizleLabel(lblCinsiyet);
            TemizleLabel(lblYas);
            TemizleLabel(lblBoy);
            TemizleLabel(lblEmail);
            TemizleLabel(lblBilgi);
            SifreKontrol.UyariMesaj = null;
        }
        private void TemizleLabel(Label label)
        {
            label.Text = string.Empty;
        }

        private bool KullaniciOlustur(Kullanici kullanici)
        {

            bool GecerliMi = true;

            string s1 = Kontrol.IsimKontrolu(txtAd.Text);
            if (s1 == null) { kullanici.Ad = txtAd.Text.Trim(); }
            else { GecerliMi = false; lblAd.Text = s1; }


            string s2 = Kontrol.SoyisimKontrolu(txtSoyad.Text);
            if (s2 == null) { kullanici.Soyad = txtSoyad.Text.Trim(); }
            else { GecerliMi = false; lblSoyad.Text = s2; }


            string s3 = Kontrol.BoyKontrolu(txtBoy.Text);
            if (s3 == null) { kullanici.Boy = double.Parse(txtBoy.Text.Trim()); }
            else { GecerliMi = false; lblBoy.Text = s3; }


            string s4 = Kontrol.KiloKontrolu(txtKilo.Text);
            if (s4 == null) { kullanici.Kilo = double.Parse(txtKilo.Text.Trim()); }
            else { GecerliMi = false; lblKilo.Text = s4; }

            string girilenEmail = txtEmail.Text;
            string s5 = Kontrol.EmailKontrolu(girilenEmail);
            if (s5 == null)
            {
                if (Kullanicirepository.HepsiniGetirDbSet().FirstOrDefault(x => x.Email == girilenEmail) == null) // email kullanımda mı?
                {
                    kullanici.Email = txtEmail.Text.Trim();
                }
                else GecerliMi=false; lblEmail.Text = "Bu Email kullanımda!";

            }
            else { GecerliMi = false; lblEmail.Text = s5; }

            string s6 = Kontrol.YasKontrolu(txtYas.Text);
            if (s6 == null) { kullanici.Yas = Convert.ToInt32(txtYas.Text.Trim()); }
            else { GecerliMi = false; lblYas.Text = s6; }


            if (cmbCinsiyet.SelectedItem != null)
                kullanici.Cinsiyet = (Cinsiyet)cmbCinsiyet.SelectedItem;
            else
            {
                lblCinsiyet.Text = "Cinsiyet seçilmelidir.";
                GecerliMi = false;
            }


            if (!SifreKontrol.SifreKompleksMi(txtSifre.Text))
            {
                lblBilgi.Text = SifreKontrol.UyariMesaj;
                GecerliMi = false;
            }
            else { kullanici.Sifre = txtSifre.Text; }

            return GecerliMi;


        }

    }
}

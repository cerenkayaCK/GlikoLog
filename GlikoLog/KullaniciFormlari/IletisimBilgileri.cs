using GlikoLog.BL;
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
using Kontrol = GlikoLog.DAL.Kontroller.Kontrol;

namespace GlikoLog.PL
{
    public partial class IletisimBilgileri : Form
    {
        Repository<IletisimBilgi> IletisimBilgiDb = new Repository<IletisimBilgi>();
        Repository<Kullanici> KullaniciDb = new Repository<Kullanici>();

        public IletisimBilgileri()
        {
            InitializeComponent();
            this.DoubleBuffered = true; //Flicker önlenmesi için
            BilgileriGetir();
        }

        private void BilgileriGetir()
        {
            var Kullanici_iletisim_Bilgi = KullaniciDb.HepsiniGetirDbSet().
                Include(x => x.IletisimBilgisi).FirstOrDefault(x => x.Id == Giris.GirisYapanKullanici.Id);

            if (Giris.GirisYapanKullanici.IletisimBilgisi != null)
            {
                txtTelefon.Text = Kullanici_iletisim_Bilgi.IletisimBilgisi.Telefon;

                txtAdres.Text = Kullanici_iletisim_Bilgi.IletisimBilgisi.Adres;
            }



        }
        private async void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                IletisimBilgi iletisimBilgi = new IletisimBilgi();
                Kullanici? girisYapanKullanici = Giris.GirisYapanKullanici;
                if (txtTelefon.Text != null)
                {
                    if (Kontrol.TelefonNumarasiKontrol(txtTelefon.Text) == null)
                    {
                        if (girisYapanKullanici != null)
                        {
                            iletisimBilgi.Telefon = txtTelefon.Text;
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        lblBilgi.Text = Kontrol.TelefonNumarasiKontrol(txtTelefon.Text); //hata mesajı
                        return;
                    }
                }
                else return;

                iletisimBilgi.Adres = txtAdres.Text;


                await IletisimBilgiDb.EkleAsync(iletisimBilgi);


                int iletisimBilgiId = iletisimBilgi.Id;


                girisYapanKullanici.IletisimBilgiId = iletisimBilgiId;
                girisYapanKullanici.IletisimBilgisi = iletisimBilgi;

                await KullaniciDb.GuncelleAsync();

                txtAdres = null;
                txtTelefon = null;
                MessageBox.Show("iletişim Bilgisi Güncellendi");
            }


            catch (Exception)
            {
                MessageBox.Show("Hata! Tekrar Deneyin!");
            }

        }

    }
}
using GlikoLog.BL.Repository;
using GlikoLog.DAL.Entities;
using GlikoLog.DAL.Enums;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace GlikoLog.PL.KullaniciFormlari
{
    public partial class Rapor : Form
    {
        Repository<KullaniciEgzersizler> dbKullaniciEgzersiz = new Repository<KullaniciEgzersizler>();
        Repository<KullaniciYemekOgun> dbKullaniciYemekOgun = new Repository<KullaniciYemekOgun>();
        Repository<SuIcmeBilgisi> dbSuIcmeBilgisi = new Repository<SuIcmeBilgisi>();

        public string SecilenRapor { get; set; }
        public Rapor(string secilenRapor)
        {
            SecilenRapor = secilenRapor;
            InitializeComponent();
            this.DoubleBuffered = true; //Flicker önlenmesi için

            if (secilenRapor == "Günlük Rapor") { RaporuGoster(1); lblBaslikRapor.Text = "Günlük Rapor"; }
            else if (secilenRapor == "Haftalık Rapor") { RaporuGoster(7); lblBaslikRapor.Text = "Haftalık Rapor"; }
        }
        private void RaporuGoster(int gunSayisi)
        {
            lblBaslikRapor.Font = new Font("Perpetua", 14);
            lblBaslikRapor.ForeColor = Color.DarkGreen;
            var kullanicininEgzersizleri = dbKullaniciEgzersiz
            .HepsiniGetirDbSet()
            .Include(a => a.Egzersiz) // İlgili egzersiz bilgilerini navigation prop ile çek.
            .Where(x => x.kullanici == Giris.GirisYapanKullanici)
            .ToList();

            int toplamKalori = 0;

            foreach (var item in kullanicininEgzersizleri)
            {
                if ((DateTime.Now.Date - item.Egzersiz.EgzersizTarihi.Date).Days <= gunSayisi)
                {
                    int kalori = (int)item.Egzersiz.EgzersizTuru;
                    int sure = (int)item.Egzersiz.EgzersizSuresi;
                    int egzersizKalori = kalori * sure;
                    toplamKalori += egzersizKalori;
                }
            }

            var kullanicininyemekleri = dbKullaniciYemekOgun.HepsiniGetirDbSet()
                .Include(x => x.Yemek).ThenInclude(b => b.BesinDegeri)
                .Where(x => x.KullaniciId == Giris.GirisYapanKullanici.Id)
                .ToList();

            double toplamKaloriHesapla = 0;
            foreach (var item in kullanicininyemekleri)
            {
                if (item.Tarih.Date == DateTime.Now.Date)
                {                 
                    double kalori = (double)item.Yemek.BesinDegeri.Kalori;
                    toplamKaloriHesapla += kalori;
                }
            }

            var kullanicininSuIcmeBilgisi = dbSuIcmeBilgisi.HepsiniGetirDbSet()
                .Where(x => x.KullaniciId == Giris.GirisYapanKullanici.Id)
                .ToList();

            int toplamSuMiktari = 0;
            foreach (var item in kullanicininSuIcmeBilgisi)
            {
                if (item.Tarih.Date == DateTime.Now.Date)
                {
                    int suMiktari = item.MiktarMl;
                    toplamSuMiktari += suMiktari;
                }
            }

            string raporOzet = Environment.NewLine + " ➩ Bazal Metabolizmanız : " + BazalMetabolizmaHesapla(Giris.GirisYapanKullanici).ToString();

            if (gunSayisi == 1)
            {
                raporOzet += Environment.NewLine + " ➩ Gün İçerisinde Yaktığınız Toplam Kalori: " + toplamKalori;
                raporOzet += Environment.NewLine + " ➩ Gün içerisinde İçtiğiniz Su Miktarı(Ml):  " + toplamSuMiktari;
                raporOzet += Environment.NewLine + " ➩ Gün içerisinde Aldığınız Kalori Miktarı:  " + toplamKaloriHesapla;

            }
            else
            {
                raporOzet += Environment.NewLine + " ➩ Günlük Ortalama Yaktığınız Toplam Kalori: " + toplamKalori;
                raporOzet += Environment.NewLine + " ➩ İçtiğiniz ortalama Su Miktarı(Ml):  " + toplamSuMiktari / gunSayisi;
                raporOzet += Environment.NewLine + " ➩ Günlük Ortalama Aldığınız Kalori Miktarı:  " + toplamKaloriHesapla / gunSayisi;
            }

            if (BazalMetabolizmaHesapla(Giris.GirisYapanKullanici) * gunSayisi + toplamKalori < toplamKaloriHesapla)
            {
                raporOzet += Environment.NewLine + " ➩ Fazladan " + (BazalMetabolizmaHesapla(Giris.GirisYapanKullanici) * gunSayisi + toplamKalori - toplamKaloriHesapla).ToString() + " kalori aldınız. ";
            }
            else if (BazalMetabolizmaHesapla(Giris.GirisYapanKullanici) * gunSayisi + toplamKalori > toplamKaloriHesapla)
            {
                raporOzet += Environment.NewLine + "➩ " + (BazalMetabolizmaHesapla(Giris.GirisYapanKullanici) * gunSayisi + toplamKalori - toplamKaloriHesapla).ToString() + " kalori açığınız var. ";
            }
            else raporOzet += Environment.NewLine + " ➩ Bugün aldığınız ve yaktığınız kalori miktarı eşit.";
            lblBilgiRapor.Font = new Font("Perpetua", 14);
            lblBilgiRapor.Text = raporOzet;
        }
        private double BazalMetabolizmaHesapla(Kullanici kullanici)
        {
            double bazalMetabolizma;

            if (kullanici.Cinsiyet == 0)
            {
                bazalMetabolizma = 10 * kullanici.Kilo + 6.25 * kullanici.Boy - 5 * kullanici.Yas + 5;
                return bazalMetabolizma;
            }
            else
            {
                bazalMetabolizma = 10 * kullanici.Kilo + 6.25 * kullanici.Boy - 5 * kullanici.Yas - 161;
                return bazalMetabolizma;
            }

        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }


}



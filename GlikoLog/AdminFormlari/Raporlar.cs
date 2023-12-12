using GlikoLog.BL.Repository;
using GlikoLog.DAL.Context;
using GlikoLog.DAL.Entities;
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

namespace GlikoLog.PL.AdminFormlari
{
    public partial class Raporlar : Form
    {
        UygulamaDbContext db = new UygulamaDbContext();
        Repository<KullaniciYemekOgun> _kyo = new Repository<KullaniciYemekOgun>();
        Repository<Kullanici> _kullanici = new Repository<Kullanici>();
        Repository<Yemek> _yemek = new Repository<Yemek>();
        public Raporlar()
        {
            InitializeComponent();
            KullanicilariGetir();
            YemekleriGetir();
        }

        private void KullanicilariGetir()
        {
            cmbKullanici1.DataSource = _kullanici.HepsiniGetir();
            cmbKullanici2.DataSource = _kullanici.HepsiniGetir();
        }

        private void YemekleriGetir()
        {
            cmbYemekRapor.DataSource = _yemek.HepsiniGetir();
        }

        private void btnKiyasla_Click(object sender, EventArgs e)
        {
            try
            {
                Kullanici kullanici1 = (Kullanici)cmbKullanici1.SelectedItem!;
                Kullanici kullanici2 = (Kullanici)cmbKullanici2.SelectedItem!;

                var kyo1 = db.KullaniciYemekleri.Where(x => x.KullaniciId == kullanici1.Id).Include(x => x.Ogun).Include(x => x.Yemek).Include(x => x.Kullanici).OrderByDescending(x => x.Tarih).ToList();
                var kyo2 = db.KullaniciYemekleri.Where(x => x.KullaniciId == kullanici2.Id).Include(x => x.Ogun).Include(x => x.Yemek).Include(x => x.Kullanici).OrderByDescending(x => x.Tarih).ToList();

                txtKullanici1.Text = "";
                txtKullanici2.Text = "";

                txtKullanici1.Text = "Tarih\t\tÖğün\tYemek" + Environment.NewLine;
                foreach (var item in kyo1)
                    txtKullanici1.Text += $"{item.Tarih}\t{item.Ogun.Ad}\t{item.Yemek.Ad}" + Environment.NewLine;

                txtKullanici2.Text = "Tarih\t\tÖğün\tYemek" + Environment.NewLine;
                foreach (var item in kyo2)
                    txtKullanici2.Text += $"{item.Tarih}\t{item.Ogun.Ad}\t{item.Yemek.Ad}" + Environment.NewLine;
            }
            catch (Exception)
            {
                MessageBox.Show("Hata! Tekrar deneyin");
            }
        
        }

        private void btnRaporuGoster_Click(object sender, EventArgs e)
        {
            try
            {
                Yemek secilenYemek = (Yemek)cmbYemekRapor.SelectedItem!;
                var kyo = db.KullaniciYemekleri.Where(x => x.YemekId == secilenYemek.Id).Include(x => x.Ogun).Include(x => x.Yemek).Include(x => x.Kullanici).OrderByDescending(x => x.Tarih).ToList();

                txtRapor.Text = "";
                txtRapor.Text = "Tarih\t\tÖğün\tYemek\t\tKullanıcı" + Environment.NewLine;
                foreach (var item in kyo)
                    txtRapor.Text += $"{item.Tarih}\t{item.Ogun.Ad}\t{item.Yemek.Ad}\t{item.Kullanici.Ad} {item.Kullanici.Soyad}" + Environment.NewLine;
            }
            catch (Exception)
            {
                MessageBox.Show("Hata! Tekrar deneyin");
            }
          
        }
    }
}

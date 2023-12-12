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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GlikoLog.PL
{
    public partial class EgzersizForm : Form
    {
        Repository<Kullanici> kullaniciDb = new Repository<Kullanici>();
        Repository<Egzersiz> egzersizRepository = new Repository<Egzersiz>();
        Repository<KullaniciEgzersizler> kullaniciEgzersizDb = new Repository<KullaniciEgzersizler>();
        KullaniciEgzersizler kullaniciEgzersiz = new KullaniciEgzersizler();
        public EgzersizForm()
        {

            InitializeComponent();
            this.DoubleBuffered = true; //Flicker önlenmesi için
            EgzersizleriListele();
            YapilanEgzersizleriListele();
        }

        private void YapilanEgzersizleriListele()
        {
            Egzersiz egzersiz = new Egzersiz();
            var egzersizTurleri = kullaniciEgzersizDb.HepsiniGetirDbSet()
           .Where(b => b.kullaniciId == Giris.GirisYapanKullanici.Id)
           .Select(a => new
           {
               egzersizId = a.EgzersizId,
               EgzersizTuru = a.Egzersiz.EgzersizTuru.ToString(),
               EgzersizSuresi = a.Egzersiz.EgzersizSuresi,
               Kullanıcı = a.kullanici.Ad + " " + a.kullanici.Soyad,
               EgzersizTarihi = a.Egzersiz.EgzersizTarihi
           }
           )
        .ToList();

            dgvEgzersizler.DataSource = egzersizTurleri;

        }

        private void sonsatiriSec(DataGridView data)
        {

            data.ClearSelection();

            int sonSatirIndex = data.Rows.Count - 1;

            if (sonSatirIndex >= 0)
            {
                dgvEgzersizler.Rows[sonSatirIndex].Selected = true;
            }

        }

        private void EgzersizleriListele()
        {
            var egzersizTurValues = Enum.GetNames(typeof(EgzersizTur)).ToList();

            cmbEgzersizCesidi.DataSource = egzersizTurValues;


        }
        private async void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                Egzersiz egzersiz = new Egzersiz();
                KullaniciEgzersizler kullaniciEgzersiz = new KullaniciEgzersizler();

                if (cmbEgzersizCesidi.SelectedIndex >= 0 && cmbEgzersizCesidi.SelectedItem != null)
                {
                    string selectedEgzersizTur = cmbEgzersizCesidi.SelectedItem.ToString();

                    if (Enum.TryParse(selectedEgzersizTur, out EgzersizTur egzersizTur))
                    {
                        egzersiz.EgzersizTuru = egzersizTur;
                    }
                    else
                    {
                        lblHata.Text = "Egzersiz Türü Seçmediniz.";
                        return;
                    }
                    int egzersizSure;
                    if (string.IsNullOrWhiteSpace(txtZaman.Text.Trim()))
                    {
                        lblZamanHata.Text = "Zaman Boş Bırakılamaz.";
                        return;
                    }

                    if (!int.TryParse(txtZaman.Text.Trim(), out egzersizSure))
                    {
                        lblZamanHata.Text = "Geçerli bir sayı giriniz.";
                        return;
                    }

                    if (egzersizSure <= 0)
                    {
                        lblZamanHata.Text = "Egzersiz Süresi 0 dan küçük olamaz";
                        return;
                    }

                    egzersiz.EgzersizSuresi = egzersizSure;

                    DateTime selectedDate = dtpTarih.Value;

                    egzersiz.EgzersizTarihi = selectedDate;

                    await egzersizRepository.EkleAsync(egzersiz);

                    kullaniciEgzersiz.kullaniciId = Giris.GirisYapanKullanici.Id;
                    kullaniciEgzersiz.EgzersizId = egzersiz.Id;


                    await kullaniciEgzersizDb.EkleAsync(kullaniciEgzersiz);


                    YapilanEgzersizleriListele();
                    sonsatiriSec(dgvEgzersizler);

                    txtZaman.Text = null;

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata! Tekrar deneyin");
            }

        }
        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvEgzersizler.SelectedRows.Count > 0)
                {
                    DataGridViewRow selectedRow = dgvEgzersizler.SelectedRows[0];

                    int selectedEgzersizId = (int)selectedRow.Cells[0].Value;

                    var silinecekEgzersiz = egzersizRepository.HepsiniGetirDbSet().FirstOrDefault(x => x.Id == selectedEgzersizId);

                    egzersizRepository.Sil(silinecekEgzersiz);

                    YapilanEgzersizleriListele();
                }
                else
                {
                    MessageBox.Show("Lütfen bir satır seçin.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata. Tekrar Giriş Yapın.");
            }
        }

        private void cmbEgzersizCesidi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

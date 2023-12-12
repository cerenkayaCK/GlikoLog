using GlikoLog.BL.Repository;
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

namespace GlikoLog.PL
{
    public partial class SaglikBilgiForm : Form
    {
        Repository<SaglikBilgisi> RepositorySaglik = new Repository<SaglikBilgisi>();
        Repository<Kullanici> RepositoryKullanici = new Repository<Kullanici>();
        Repository<SuBilgiForm> RepositorySuBilgiForm= new Repository<SuBilgiForm>();
        public SaglikBilgiForm()
        {
            InitializeComponent();
            Listele();
        }
        private void Listele()
        {
           lblSekerHata.Text = null;
            var veri = RepositorySaglik
           .HepsiniGetirDbSet().Where(b => b.KullaniciId == Giris.GirisYapanKullanici.Id)
           .Include
           (x => x.Kullanici);
          
           dgvSaglikBilgiForm.DataSource = veri.Select(item => new
            {
                Id = item.Id,
                IlacAd = item.İlacAd,
                InsulinMi = (bool)item.InsulinMi ? "Evet" : "Hayır",
                Tarih = item.Tarih,
                KanSekeri = item.KanSekeri,
                IlacAdet = item.IlacAdet,
                KullaniciAdi = item.Kullanici
            }).ToList();             
        }

        private void btnBilgiEkle_Click(object sender, EventArgs e)
        {
            try
            {
                SaglikBilgisi SaglikBilgi = new SaglikBilgisi();
                if (!string.IsNullOrWhiteSpace(txtIlacAd.Text))
                {
                    SaglikBilgi.İlacAd = txtIlacAd.Text;
                }
                else
                {
                    lblIlacHata.Text = "İlac İsmi girmediniz.";
                    return;
                }
                SaglikBilgi.InsulinMi = chbInsulin.Checked;

                SaglikBilgi.Tarih = dtpTarih.Value;
                string kansekeri = txtKanSekeri.Text;
                if (double.TryParse(kansekeri, out double kanSekeri))
                {
                    SaglikBilgi.KanSekeri = Convert.ToDouble(txtKanSekeri.Text);
                }
                else
                {
                    lblSekerHata.Text = "Kan şekerini hatalı girdiniz.";
                    return;
                }

                decimal numericUpDownValue = numAdet.Value;
                int intValue = Convert.ToInt32(numericUpDownValue);
                SaglikBilgi.IlacAdet = intValue;

                if (Giris.GirisYapanKullanici != null)
                {
                    SaglikBilgi.KullaniciId = (Giris.GirisYapanKullanici.Id);
                }

                RepositorySaglik.Ekle(SaglikBilgi);

                txtIlacAd.Text = null;
                txtKanSekeri.Text = null;
                chbInsulin.Checked = false;
                dtpTarih.Checked = false;
                Listele();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata! Tekrar Deneyin.!");
                return; 
            }
          
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var seciliSatir = dgvSaglikBilgiForm.SelectedRows;
            try
            {
                DataGridViewRow selectedRow = dgvSaglikBilgiForm.SelectedRows[0];

                int SaglikBilgisiSilId = Convert.ToInt32(selectedRow.Cells[0].Value);

                SaglikBilgisi silinecekSaglikBilgisi = RepositorySaglik.IdYeGoreGetir(SaglikBilgisiSilId);

                RepositorySaglik.Sil(silinecekSaglikBilgisi);
                Listele();
            }

            catch (Exception)
            {
                MessageBox.Show("Hata. Tekrar Giriş Yapın.");

            }
        }
    }
}

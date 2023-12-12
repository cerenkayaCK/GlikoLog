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
    public partial class SuBilgiForm : Form
    {
        Repository<Kullanici> KullaniciDb = new Repository<Kullanici>();
        Repository<SuIcmeBilgisi> SuDb;
        SuIcmeBilgisi secilenSuBilgisi;
        public SuBilgiForm()
        {
            SuDb = new Repository<SuIcmeBilgisi>();
            InitializeComponent();

            Listele();
        }
        private void Listele()
        {
            var brilesik = SuDb.HepsiniGetirDbSet()
                .Include(secilenSuBilgisi => secilenSuBilgisi.Kullanici)
                .Where(b => b.KullaniciId==Giris.GirisYapanKullanici.Id)
                .ToList();
            dgvSu.DataSource = brilesik;
        }

        private void SuBilgiForm_Load(object sender, EventArgs e)
        {

        }
        private void btnSuEkle_Click(object sender, EventArgs e)
        {
            try
            {
                SuIcmeBilgisi suIcmeBilgisi = new SuIcmeBilgisi();
                suIcmeBilgisi.Tarih = dateTimePickerSu.Value;
                suIcmeBilgisi.MiktarMl = Convert.ToInt32(nudSuMiktar.Value);

                suIcmeBilgisi.KullaniciId = Giris.GirisYapanKullanici.Id;

                SuDb.Ekle(suIcmeBilgisi);
                secilenSuBilgisi = suIcmeBilgisi;

                Listele();
            }
            catch (Exception)
            {

                MessageBox.Show("Bilinmeyen Hata! Tekrar deneyin.");
                return;
            }
          

        }

        private void btnSuSil_Click(object sender, EventArgs e)
        {

            var seciliSatir = dgvSu.SelectedRows;
            try
            {
                DataGridViewRow selectedRow = dgvSu.SelectedRows[0];

                int suIcmeBilgisiId = Convert.ToInt32(selectedRow.Cells[0].Value);

                SuIcmeBilgisi silinecekSuIcmeBilgisi = SuDb.IdYeGoreGetir(suIcmeBilgisiId);

                SuDb.Sil(silinecekSuIcmeBilgisi);
                Listele();

            }
            catch (Exception)
            {
                MessageBox.Show("Hata. Tekrar Giriş Yapın.");

            }


        }

        private void btnSuGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                var seciliSatir = dgvSu.SelectedRows;
                SuIcmeBilgisi guncellenecekSuBilgisi;
                foreach (DataGridViewRow row in seciliSatir)
                {
                    int suIcmeBilgisiId = Convert.ToInt32(row.Cells["Id"].Value);
                    guncellenecekSuBilgisi = SuDb.IdYeGoreGetir(suIcmeBilgisiId);
                }

                secilenSuBilgisi.Tarih = dateTimePickerSu.Value;
                secilenSuBilgisi.MiktarMl = Convert.ToInt32(nudSuMiktar.Value);
                SuDb.Guncelle();
                Listele();

            }
            catch (Exception)
            {
                MessageBox.Show("Hata. Tekrar deneyin.");
            }

        }
    }
}

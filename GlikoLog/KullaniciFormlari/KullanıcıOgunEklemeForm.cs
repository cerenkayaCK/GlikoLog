using GlikoLog.BL.Repository;
using GlikoLog.DAL.Context;
using GlikoLog.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using GlikoLog.BL;

namespace GlikoLog.PL
{
    public partial class KullanıcıOgunEklemeForm : Form
    {
        KullaniciYemekOgun kullaniciYemekOgun;
        Repository<KullaniciYemekOgun> kulaniciYemekOgunDb = new Repository<KullaniciYemekOgun>();
        Repository<Yemek> YemeklerDb = new Repository<Yemek>();
        Repository<Ogun> OgunlerDb = new Repository<Ogun>();


        public KullanıcıOgunEklemeForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            VerileriYukle();
            dateTimeTarih.Format = DateTimePickerFormat.Long;
            dateTimeTarih.CustomFormat = "dd MMMM yyyy HH:mm:ss";

        }
        private void VerileriYukle()
        {
            try
            {
                cboOgunler.DataSource = OgunlerDb.HepsiniGetirDbSet().Include(x => x.KullaniciYemekleri).ToList();
                cboOgunler.DisplayMember = "Ad";
                cboOgunler.ValueMember = "Id";

                cboYemekler.DataSource = YemeklerDb.HepsiniGetir().ToList();
                cboYemekler.DisplayMember = "Ad";
                cboYemekler.ValueMember = "Id";

                dgvKullaniciOgunleri.DataSource = kulaniciYemekOgunDb.HepsiniGetirDbSet()
                    .Where(x => x.KullaniciId == Giris.GirisYapanKullanici.Id)
                    .Include(x => x.Ogun).Include(x => x.Yemek)
                    .Select(k => new
                    {
                        k.Id,
                        Öğün = k.Ogun.Ad,
                        Yemek = k.Yemek.Ad,
                        Tarih = k.Tarih.ToString("dd MM yyyy HH:mm"),
                        Resim = k.Yemek.Gorsel
                    })
                    .ToList();

                var idColumn = dgvKullaniciOgunleri.Columns["Id"];

                if (idColumn != null)
                {
                    idColumn.Visible = false;
                }

            }
            catch (Exception)
            {
                return;
            }
        }
        private void dgvKullaniciOgunleri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Seçili satırın index
                int seciliSatirIndeks = e.RowIndex;

                var seciliOgun = dgvKullaniciOgunleri.Rows[seciliSatirIndeks].Cells["Öğün"].Value;
                var seciliYemek = dgvKullaniciOgunleri.Rows[seciliSatirIndeks].Cells["Yemek"].Value;
                string seciliTarih = (string)dgvKullaniciOgunleri.Rows[seciliSatirIndeks].Cells["Tarih"].Value;

                //ComboBox'ı güncelle
                if (seciliOgun != null && seciliYemek != null && seciliTarih != null)
                {
                    foreach (Ogun ogun in cboOgunler.Items)
                    {
                        if (ogun.Ad == seciliOgun.ToString())
                        {
                            cboOgunler.SelectedItem = ogun;
                            break;
                        }
                    }
                    foreach (Yemek Yemek in cboYemekler.Items)
                    {
                        if (Yemek.Ad == seciliYemek.ToString())
                        {
                            cboYemekler.SelectedItem = Yemek;
                            break;
                        }
                    }

                    if (DateTime.TryParseExact(seciliTarih, "d MMMM yyyy", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime cevirilmisTarih))
                    {
                        dtpTarih.Value = cevirilmisTarih;
                    }

                }
            }
        }
        private void btnEkle_Click_1(object sender, EventArgs e)
        {
            try
            {
                Kullanici? seciliKullanici = Giris.GirisYapanKullanici;

                // cboOgunler ve cboYemekler null değilse devam et
                if (cboOgunler.SelectedValue != null && cboYemekler.SelectedValue != null)
                {
                    // Seçilen öğün ve yemeği al
                    int seciliOgunId = (int)cboOgunler.SelectedValue;
                    int seciliYemekId = (int)cboYemekler.SelectedValue;

                    // KullaniciYemekOgun nesnesi oluştur
                    var kullaniciYemekOgun = new KullaniciYemekOgun
                    {
                        KullaniciId = Giris.GirisYapanKullanici.Id,
                        YemekId = seciliYemekId,
                        OgunId = seciliOgunId,
                        Tarih = dateTimeTarih.Value,
                    };

                    kulaniciYemekOgunDb.Ekle(kullaniciYemekOgun);
                    VerileriYukle();

                    MessageBox.Show("Kayıt başarıyla eklendi.");
                }
                else
                {
                    // Hata durumunda kullanıcıya bilgi ver veya uygun bir işlem yap
                    MessageBox.Show("Lütfen geçerli bir öğün ve yemek seçin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnGuıncelle_Click_1(object sender, EventArgs e)
        {
            // DataGridView'de hiçbir hücre seçilmediyse işlemi durdur
            if (dgvKullaniciOgunleri.SelectedCells.Count == 0)
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz satırı seçin.");
                return;
            }

            // Seçilen satırın indisi
            int satirIndeks = dgvKullaniciOgunleri.SelectedCells[0].RowIndex;

            // Seçilen satırdaki veriler
            var selectedRow = dgvKullaniciOgunleri.Rows[satirIndeks];
            int guncellenecekId = (int)selectedRow.Cells["Id"].Value;

            var guncellenecekKullaniciYemekOgun = kulaniciYemekOgunDb.FirstOrDefault(x => x.Id == guncellenecekId);

            if (guncellenecekKullaniciYemekOgun == null)
            {
                MessageBox.Show("Güncellenmek istenen satır veritabanında bulunamadı.");
                return;
            }
            try
            {
                int seciliOgunId = (int)cboOgunler.SelectedValue!;
                int seciliYemekId = (int)cboYemekler.SelectedValue!;

                guncellenecekKullaniciYemekOgun.Tarih = dateTimeTarih.Value;
                guncellenecekKullaniciYemekOgun.OgunId = seciliOgunId;
                guncellenecekKullaniciYemekOgun.YemekId = seciliYemekId;

                kulaniciYemekOgunDb.Guncelle();
                VerileriYukle();


                MessageBox.Show("Seçilen satır başarıyla güncellendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme sırasında bir hata oluştu: " + ex.Message);
            }
        }

        private void btnDgvSil_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (dgvKullaniciOgunleri.SelectedCells.Count == 0)
                {
                    MessageBox.Show("Lütfen silmek istediğiniz satırı seçin.");
                    return;
                }

                // Seçilen satırın indisi
                int satirIndeks = dgvKullaniciOgunleri.SelectedCells[0].RowIndex;

                // Seçilen satırdaki verileri
                var seciliSatir = dgvKullaniciOgunleri.Rows[satirIndeks];
                int kullaniciYemekOgunId = (int)seciliSatir.Cells[0].Value;

                var silinecekYemekOgun = kulaniciYemekOgunDb.HepsiniGetirDbSet().Find(kullaniciYemekOgunId);

                if (silinecekYemekOgun != null)
                {
                    kulaniciYemekOgunDb.Sil(silinecekYemekOgun);
                    VerileriYukle();

                    MessageBox.Show("Seçilen satır başarıyla silindi.");
                }
                else
                {
                    MessageBox.Show("Seçilen satır veritabanında bulunamadı.");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Hata!. Tekrar Deneyin!");

            }

        }

        private void dgvKullaniciOgunleri_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    // Seçili satırın index
                    int seciliSatirIndeks = e.RowIndex;

                    var seciliOgun = dgvKullaniciOgunleri.Rows[seciliSatirIndeks].Cells["Öğün"].Value;
                    var seciliYemek = dgvKullaniciOgunleri.Rows[seciliSatirIndeks].Cells["Yemek"].Value;
                    string seciliTarih = (string)dgvKullaniciOgunleri.Rows[seciliSatirIndeks].Cells["Tarih"].Value;

                    //ComboBox'ı güncelle
                    if (seciliOgun != null && seciliYemek != null && seciliTarih != null)
                    {
                        foreach (Ogun ogun in cboOgunler.Items)
                        {
                            if (ogun.Ad == seciliOgun.ToString())
                            {
                                cboOgunler.SelectedItem = ogun;
                                break;
                            }
                        }
                        foreach (Yemek Yemek in cboYemekler.Items)
                        {
                            if (Yemek.Ad == seciliYemek.ToString())
                            {
                                cboYemekler.SelectedItem = Yemek;
                                break;
                            }
                        }

                        if (DateTime.TryParseExact(seciliTarih, "d MMMM yyyy", CultureInfo.CurrentCulture, DateTimeStyles.None, out DateTime cevirilmisTarih))
                        {
                            dtpTarih.Value = cevirilmisTarih;
                        }

                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hata!. Tekrar Deneyin!");

            }
           
        }
    }
}


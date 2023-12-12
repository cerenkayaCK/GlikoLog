using GlikoLog.BL.Repository;
using GlikoLog.DAL.Context;
using GlikoLog.DAL.Entities;
using GlikoLog.DAL.Enums;
using System.Data;

namespace GlikoLog.PL
{
    public partial class YemekIslemleriForm : Form
    {
        UygulamaDbContext db = new UygulamaDbContext();
        Repository<Yemek> _yemek = new Repository<Yemek>();
        Repository<BesinDegeri> _besinDegeri = new Repository<BesinDegeri>();
        Repository<Ogun> _ogun = new Repository<Ogun>();
        byte[]? Resim;

        public YemekIslemleriForm()
        {
            InitializeComponent();
            YemekleriGetir();
            OgunleriGetir();
            KategorileriGetir();
            cmbKategori.SelectedIndex = 0;
        }

        private void KategorileriGetir()
        {
            cmbKategori.DataSource = Enum.GetValues(typeof(Kategori));
        }

        private void OgunleriGetir()
        {
            dgvOgunler.DataSource = _ogun.HepsiniGetir();
        }

        private void YemekleriGetir()
        {
            dgvYemekler.DataSource = db.Yemekler
            .Select(a => new
            {
                Id = a.Id,
                Ad = a.Ad,
                Kategori = a.KategoriId.ToString(),
                Resim = a.Gorsel,
                Seker = a.BesinDegeri!.Seker,
                Protein = a.BesinDegeri!.Protein,
                Karbonhidrat = a.BesinDegeri.Karbonhidrat,
                Yağ = a.BesinDegeri.Yag,
                Kalori = a.BesinDegeri.Kalori
            })
            .ToList();
        }


        private void dgvYemekler_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvYemekler.SelectedRows.Count == 0) return;

                // seçili yemeği bul
                int seciliYemekId = (int)dgvYemekler.SelectedRows[0].Cells[0].Value;

                // seçili yemeğin besin değerlerini bul
                Yemek seciliYemek = _yemek.IdYeGoreGetir(seciliYemekId);

                // seçili yemeğin besin değerlerini yemeğin idsine göre getir
                int seciliBesinDegeriId = (int)seciliYemek.BesinDegeriId!;

                // seçili yemeğin besin değerlerini bul
                BesinDegeri seciliBesinDegeri = _besinDegeri.IdYeGoreGetir(seciliBesinDegeriId);

                // textboxlara yaz
                txtYemekAdi.Text = seciliYemek.Ad;
                txtKarb.Text = seciliBesinDegeri.Karbonhidrat.ToString();
                txtYag.Text = seciliBesinDegeri.Yag.ToString();
                txtKalori.Text = seciliBesinDegeri.Kalori.ToString();
                txtProtein.Text = seciliBesinDegeri.Protein.ToString();
                txtSeker.Text = seciliBesinDegeri.Seker.ToString();


                Resim = seciliYemek.Gorsel;
                // resmi göster
                using (MemoryStream ms = new MemoryStream(Resim))
                {
                    pbResim.SizeMode = PictureBoxSizeMode.Zoom;
                    pbResim.Image = Image.FromStream(ms);
                }

                // kategoriyi seçili yap
                cmbKategori.SelectedItem = seciliYemek.KategoriId;
            }
            catch (Exception)
            {

                MessageBox.Show("Hata! Tekrar deneyin!");
            }

        }

        private void btnResimYukle_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog resimPenceresi = new OpenFileDialog())
                    if (resimPenceresi.ShowDialog() == DialogResult.OK)
                        Resim = File.ReadAllBytes(resimPenceresi.FileName);

                if (Resim != null)
                {
                    using (MemoryStream ms = new MemoryStream(Resim))
                    {
                        pbResim.SizeMode = PictureBoxSizeMode.Zoom;
                        pbResim.Image = Image.FromStream(ms);
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Hata! Tekrar deneyin!");
            }

        }

        private void btnYemekEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (Resim == null)
                {
                    MessageBox.Show("Lütfen önce bir resim seçiniz.");
                    return;
                }

                // textboxları validate et
                if (txtYemekAdi.Text == "" || txtKalori.Text == "" || txtKarb.Text == "" || txtProtein.Text == "" || txtSeker.Text == "" || txtYag.Text == "")
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                    return;
                }

                // seçili kategoriyi getir
                var seciliKategori = (Kategori)cmbKategori.SelectedItem!;
                // kategori enum'ının değerini al
                int kategoriDegeri = (int)seciliKategori;

                string YemekAdi = txtYemekAdi.Text;

                var yeniYemek = new Yemek
                {
                    Ad = YemekAdi,
                    Gorsel = Resim,
                    Porsiyon = Porsiyon.tam,
                    KategoriId = seciliKategori,
                    BesinDegeri = new BesinDegeri
                    {
                        Karbonhidrat = Convert.ToInt32(txtKarb.Text),
                        Protein = Convert.ToInt32(txtProtein.Text),
                        Yag = Convert.ToInt32(txtYag.Text),
                        Kalori = Convert.ToInt32(txtKalori.Text),
                        Seker = Convert.ToInt32(txtSeker.Text)
                    }
                };

                //yeni yemek ekle
                _yemek.Ekle(yeniYemek);
                YemekleriGetir();
            }
            catch (Exception)
            {

                MessageBox.Show("Hata! Tekrar deneyin!");
            }


        }

        private void btnYemekGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                // textboxları validate et
                if (txtYemekAdi.Text == "" || txtKalori.Text == "" || txtKarb.Text == "" || txtProtein.Text == "" || txtSeker.Text == "" || txtYag.Text == "")
                {
                    MessageBox.Show("Lütfen tüm alanları doldurunuz.");
                    return;
                }

                // tokat
                if (dgvYemekler.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen güncellemek istediğiniz yemeği seçiniz.");
                    return;
                }

                // seçili yemeği bul
                int seciliYemekId = (int)dgvYemekler.SelectedRows[0].Cells[0].Value;
                Yemek seciliYemek = _yemek.IdYeGoreGetir(seciliYemekId);

                // yemeği güncelle
                seciliYemek.Ad = txtYemekAdi.Text.Trim();



                if (Resim == null)
                {
                    MessageBox.Show("Lütfen resim ekleyiniz.");
                    return;
                }
                seciliYemek.Gorsel = Resim;

                // besin değerlerini bul ve güncelle
                var seciliBesinDegeri = _besinDegeri.IdYeGoreGetir((int)seciliYemek.BesinDegeriId!);

                seciliBesinDegeri.Kalori = Convert.ToInt32(txtKalori.Text);
                seciliBesinDegeri.Karbonhidrat = Convert.ToInt32(txtKarb.Text);
                seciliBesinDegeri.Protein = Convert.ToInt32(txtProtein.Text);
                seciliBesinDegeri.Yag = Convert.ToInt32(txtYag.Text);
                seciliBesinDegeri.Seker = Convert.ToInt32(txtSeker.Text);

                // kategoriyi güncelle
                seciliYemek.KategoriId = (Kategori)cmbKategori.SelectedItem!;

                // güncelle
                _yemek.Guncelle();
                _besinDegeri.Guncelle();

                YemekleriGetir();
            }
            catch (Exception)
            {

                MessageBox.Show("Hata! Tekrar deneyin!");
                return;
            }


        }

        private void btnYemekSil_Click(object sender, EventArgs e)
        {
            try
            {
                // silmeden önce onay al
                DialogResult cevap = MessageBox.Show("Silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (cevap == DialogResult.No)return;
                   
                if (dgvYemekler.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen silmek istediğiniz kullanıcıyı seçiniz.");
                    return;
                }
                // seçili yemeği bul
                int seciliYemekId = (int)dgvYemekler.SelectedRows[0].Cells[0].Value;
                Yemek seciliYemek = _yemek.IdYeGoreGetir(seciliYemekId);

                //yemeği sil
                _yemek.Sil(seciliYemek);


                // bağlı olduğu besin değerini de sil
                var seciliBesinDegeri = _besinDegeri.IdYeGoreGetir((int)seciliYemek.BesinDegeriId!);
                _besinDegeri.Sil(seciliBesinDegeri);

                YemekleriGetir();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata! Tekrar deneyin!");
                return;
            }
        }


        private void dgvOgunler_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgvOgunler.SelectedRows.Count == 0) return;

                // seçili öğünü bul
                int seciliOgunId = (int)dgvOgunler.SelectedRows[0].Cells[0].Value;
                Ogun seciliOgun = _ogun.IdYeGoreGetir(seciliOgunId);

                txtOgunAdi.Text = seciliOgun.Ad;
            }
            catch (Exception)
            {
                MessageBox.Show("Hata! Tekrar deneyin!");
                return;
            }
        
            
        }

        private void btnOgunEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtOgunAdi.Text == "")
                {
                    MessageBox.Show("Lütfen öğün adını giriniz.");
                    return;
                }

                // öğün adını al
                string ogunAdi = txtOgunAdi.Text;

                // yeni öğün oluştur
                var yeniOgun = new Ogun
                {
                    Ad = ogunAdi
                };

                // öğünü ekle
                _ogun.Ekle(yeniOgun);
                OgunleriGetir();

            }
            catch (Exception)
            {
                MessageBox.Show("Hata! Tekrar deneyin!");
                return;
            }
      


        }

        private void btnOgunGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvOgunler.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen güncellemek istediğiniz öğünü seçiniz.");
                    return;
                }
                if (txtOgunAdi.Text == "")
                {
                    MessageBox.Show("Lütfen öğün adını giriniz.");
                    return;
                }

                int seciliOgunId = (int)dgvOgunler.SelectedRows[0].Cells[0].Value;
                Ogun seciliOgun = _ogun.IdYeGoreGetir(seciliOgunId);

                seciliOgun.Ad = txtOgunAdi.Text;

                _ogun.Guncelle();

                OgunleriGetir();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata! Tekrar deneyin!");
                return;
            }


        }

        private void btnOgunSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvOgunler.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Lütfen silmek istediğiniz öğünü seçiniz.");
                    return;
                }

                // silmeden önce onay al
                DialogResult cevap = MessageBox.Show("Silmek istediğinize emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (cevap == DialogResult.No)
                    return;

                // seçili öğünü bul
                int seciliOgunId = (int)dgvOgunler.SelectedRows[0].Cells[0].Value;
                Ogun seciliOgun = _ogun.IdYeGoreGetir(seciliOgunId);

                // öğünü sil
                _ogun.Sil(seciliOgun);

                // öğünleri getir
                OgunleriGetir();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata! Tekrar deneyin!");
                return;
            }

         

        }
    }
}

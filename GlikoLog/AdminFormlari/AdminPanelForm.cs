using GlikoLog.PL.AdminFormlari;
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
    public partial class AdminPanelForm : Form
    {
        public AdminPanelForm()
        {
            InitializeComponent();
            this.FormClosing += AnaForm_FormClosing;
        }

        private void btnYemekIslemleri_Click(object sender, EventArgs e)
        {
            YemekIslemleriForm yemekIslemleriForm = new YemekIslemleriForm();
            yemekIslemleriForm.Show();
        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            Raporlar raporlarForm = new Raporlar();
            raporlarForm.Show();
        }

        private void btnKullaniciIslemleri_Click(object sender, EventArgs e)
        {
            AdminKullaniciIslemleriForm kullaniciIslemleriForm = new AdminKullaniciIslemleriForm();
            kullaniciIslemleriForm.Show();
        }
        private void AnaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Kullanıcı çarpı simgesine bastığında yapılacak işlemler
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Uygulamayı kapatmak istediğinize emin misiniz?", "Kapatma Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    e.Cancel = true;

                }
                else Application.Exit();
            }
        }
    }
}

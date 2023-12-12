using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlikoLog.PL.KullaniciFormlari
{
    public partial class KullaniciRapor : Form
    {
        public string secilenRapor;
        public KullaniciRapor()
        {
            InitializeComponent();
            this.DoubleBuffered = true; //Flicker önlenmesi için
            cmbRaporSec.Items.Add("Günlük Rapor");
            cmbRaporSec.Items.Add("Haftalık Rapor");
        }
        private void btnGoster_Click(object sender, EventArgs e)
        {
            if (cmbRaporSec.SelectedItem != null)
            {
                secilenRapor = (string)cmbRaporSec.SelectedItem;
             
                Rapor rapor = new Rapor(secilenRapor);

                rapor.StartPosition = FormStartPosition.CenterScreen;
                rapor.Show();
            }
            else { MessageBox.Show("istediğiniz Raporu Seçin"); }
        }

     
    }
}

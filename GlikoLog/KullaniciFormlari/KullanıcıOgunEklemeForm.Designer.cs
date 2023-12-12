namespace GlikoLog.PL
{
    partial class KullanıcıOgunEklemeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            btnDgvSil = new Button();
            label3 = new Label();
            btnGuıncelle = new Button();
            label2 = new Label();
            cboYemekler = new ComboBox();
            cboOgunler = new ComboBox();
            label1 = new Label();
            btnEkle = new Button();
            dateTimeTarih = new DateTimePicker();
            dgvKullaniciOgunleri = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvKullaniciOgunleri).BeginInit();
            SuspendLayout();
            // 
            // btnDgvSil
            // 
            btnDgvSil.BackColor = Color.WhiteSmoke;
            btnDgvSil.ForeColor = Color.Black;
            btnDgvSil.Location = new Point(565, 382);
            btnDgvSil.Name = "btnDgvSil";
            btnDgvSil.Size = new Size(101, 51);
            btnDgvSil.TabIndex = 23;
            btnDgvSil.Text = "Seçileni Sil";
            btnDgvSil.UseVisualStyleBackColor = false;
            btnDgvSil.Click += btnDgvSil_Click_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(115, 385);
            label3.Name = "label3";
            label3.Size = new Size(37, 19);
            label3.TabIndex = 22;
            label3.Text = "Tarih";
            // 
            // btnGuıncelle
            // 
            btnGuıncelle.ForeColor = Color.Black;
            btnGuıncelle.Location = new Point(565, 328);
            btnGuıncelle.Name = "btnGuıncelle";
            btnGuıncelle.Size = new Size(101, 48);
            btnGuıncelle.TabIndex = 21;
            btnGuıncelle.Text = "Seçileni Güncelle";
            btnGuıncelle.UseVisualStyleBackColor = true;
            btnGuıncelle.Click += btnGuıncelle_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(115, 332);
            label2.Name = "label2";
            label2.Size = new Size(64, 19);
            label2.TabIndex = 19;
            label2.Text = "Yemekler";
            // 
            // cboYemekler
            // 
            cboYemekler.FormattingEnabled = true;
            cboYemekler.Location = new Point(115, 354);
            cboYemekler.Name = "cboYemekler";
            cboYemekler.Size = new Size(221, 23);
            cboYemekler.TabIndex = 18;
            // 
            // cboOgunler
            // 
            cboOgunler.FormattingEnabled = true;
            cboOgunler.Location = new Point(115, 292);
            cboOgunler.Name = "cboOgunler";
            cboOgunler.Size = new Size(221, 23);
            cboOgunler.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(115, 270);
            label1.Name = "label1";
            label1.Size = new Size(59, 19);
            label1.TabIndex = 16;
            label1.Text = "Öğünler";
            // 
            // btnEkle
            // 
            btnEkle.ForeColor = Color.Black;
            btnEkle.Location = new Point(565, 270);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(101, 55);
            btnEkle.TabIndex = 13;
            btnEkle.Text = "Ekle";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click_1;
            // 
            // dateTimeTarih
            // 
            dateTimeTarih.CustomFormat = "dd/MM/yyyy";
            dateTimeTarih.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dateTimeTarih.Format = DateTimePickerFormat.Custom;
            dateTimeTarih.Location = new Point(115, 407);
            dateTimeTarih.Name = "dateTimeTarih";
            dateTimeTarih.Size = new Size(221, 26);
            dateTimeTarih.TabIndex = 24;
            // 
            // dgvKullaniciOgunleri
            // 
            dgvKullaniciOgunleri.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKullaniciOgunleri.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dgvKullaniciOgunleri.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvKullaniciOgunleri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKullaniciOgunleri.Location = new Point(95, 24);
            dgvKullaniciOgunleri.Name = "dgvKullaniciOgunleri";
            dataGridViewCellStyle4.ForeColor = Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            dgvKullaniciOgunleri.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvKullaniciOgunleri.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvKullaniciOgunleri.Size = new Size(571, 227);
            dgvKullaniciOgunleri.TabIndex = 25;
            dgvKullaniciOgunleri.CellMouseClick += dgvKullaniciOgunleri_CellMouseClick;
            // 
            // KullanıcıOgunEklemeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.Adsız_tasarım__1_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(775, 491);
            Controls.Add(dgvKullaniciOgunleri);
            Controls.Add(dateTimeTarih);
            Controls.Add(btnDgvSil);
            Controls.Add(label3);
            Controls.Add(btnGuıncelle);
            Controls.Add(label2);
            Controls.Add(cboYemekler);
            Controls.Add(cboOgunler);
            Controls.Add(label1);
            Controls.Add(btnEkle);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "KullanıcıOgunEklemeForm";
            Text = "KullanıcıOgunEklemeForm";
            ((System.ComponentModel.ISupportInitialize)dgvKullaniciOgunleri).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDgvSil;
        private Label label3;
        private Button btnGuıncelle;
        private Label label2;
        private ComboBox cboYemekler;
        private ComboBox cboOgunler;
        private Label label1;
        private DateTimePicker dtpTarih;
        private Button btnEkle;
        private DateTimePicker dateTimeTarih;
        private DataGridView dgvKullaniciOgunleri;
    }
}
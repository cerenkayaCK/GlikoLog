namespace GlikoLog.PL
{
    partial class YemekIslemleriForm
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
            dgvYemekler = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewImageColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtYemekAdi = new TextBox();
            txtKarb = new TextBox();
            label2 = new Label();
            txtYag = new TextBox();
            label3 = new Label();
            label4 = new Label();
            cmbKategori = new ComboBox();
            txtKalori = new TextBox();
            label5 = new Label();
            btnYemekEkle = new Button();
            groupBox1 = new GroupBox();
            txtSeker = new TextBox();
            label9 = new Label();
            btnResimYukle = new Button();
            pbResim = new PictureBox();
            label7 = new Label();
            txtProtein = new TextBox();
            btnYemekGuncelle = new Button();
            label6 = new Label();
            btnYemekSil = new Button();
            groupBox2 = new GroupBox();
            btnOgunSil = new Button();
            btnOgunGuncelle = new Button();
            btnOgunEkle = new Button();
            txtOgunAdi = new TextBox();
            label8 = new Label();
            dgvOgunler = new DataGridView();
            Column10 = new DataGridViewTextBoxColumn();
            Column11 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvYemekler).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbResim).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOgunler).BeginInit();
            SuspendLayout();
            // 
            // dgvYemekler
            // 
            dgvYemekler.AllowUserToAddRows = false;
            dgvYemekler.AllowUserToDeleteRows = false;
            dgvYemekler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvYemekler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvYemekler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvYemekler.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9 });
            dgvYemekler.Location = new Point(12, 12);
            dgvYemekler.Name = "dgvYemekler";
            dgvYemekler.ReadOnly = true;
            dgvYemekler.Size = new Size(658, 227);
            dgvYemekler.TabIndex = 0;
            dgvYemekler.SelectionChanged += dgvYemekler_SelectionChanged;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Id";
            Column1.HeaderText = "Id";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 42;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "Ad";
            Column2.HeaderText = "Yemek Adı";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Width = 88;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "Kategori";
            Column3.HeaderText = "Kategori";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 76;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            Column4.DataPropertyName = "Resim";
            Column4.HeaderText = "Resim";
            Column4.ImageLayout = DataGridViewImageCellLayout.Zoom;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Resizable = DataGridViewTriState.False;
            Column4.SortMode = DataGridViewColumnSortMode.Automatic;
            Column4.Width = 64;
            // 
            // Column5
            // 
            Column5.DataPropertyName = "Seker";
            Column5.HeaderText = "Şeker";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 60;
            // 
            // Column6
            // 
            Column6.DataPropertyName = "Protein";
            Column6.HeaderText = "Protein";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 70;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "Karbonhidrat";
            Column7.HeaderText = "Karbonhidrat";
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 101;
            // 
            // Column8
            // 
            Column8.DataPropertyName = "Yağ";
            Column8.HeaderText = "Yağ";
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            Column8.Width = 51;
            // 
            // Column9
            // 
            Column9.DataPropertyName = "Kalori";
            Column9.HeaderText = "Kalori";
            Column9.Name = "Column9";
            Column9.ReadOnly = true;
            Column9.Width = 62;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 59);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 1;
            label1.Text = "Yemek Adı:";
            // 
            // txtYemekAdi
            // 
            txtYemekAdi.Location = new Point(101, 56);
            txtYemekAdi.Name = "txtYemekAdi";
            txtYemekAdi.Size = new Size(132, 23);
            txtYemekAdi.TabIndex = 1;
            // 
            // txtKarb
            // 
            txtKarb.Location = new Point(101, 85);
            txtKarb.Name = "txtKarb";
            txtKarb.Size = new Size(132, 23);
            txtKarb.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 88);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 3;
            label2.Text = "Karbonhidrat:";
            // 
            // txtYag
            // 
            txtYag.Location = new Point(101, 114);
            txtYag.Name = "txtYag";
            txtYag.Size = new Size(132, 23);
            txtYag.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 117);
            label3.Name = "label3";
            label3.Size = new Size(29, 15);
            label3.TabIndex = 5;
            label3.Text = "Yağ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 30);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 7;
            label4.Text = "Kategori:";
            // 
            // cmbKategori
            // 
            cmbKategori.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(101, 27);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(132, 23);
            cmbKategori.TabIndex = 0;
            // 
            // txtKalori
            // 
            txtKalori.Location = new Point(101, 143);
            txtKalori.Name = "txtKalori";
            txtKalori.Size = new Size(132, 23);
            txtKalori.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(55, 146);
            label5.Name = "label5";
            label5.Size = new Size(40, 15);
            label5.TabIndex = 9;
            label5.Text = "Kalori:";
            // 
            // btnYemekEkle
            // 
            btnYemekEkle.Location = new Point(16, 329);
            btnYemekEkle.Name = "btnYemekEkle";
            btnYemekEkle.Size = new Size(135, 46);
            btnYemekEkle.TabIndex = 8;
            btnYemekEkle.Text = "Yemek Ekle";
            btnYemekEkle.UseVisualStyleBackColor = true;
            btnYemekEkle.Click += btnYemekEkle_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtSeker);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(btnResimYukle);
            groupBox1.Controls.Add(pbResim);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtProtein);
            groupBox1.Controls.Add(btnYemekGuncelle);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnYemekEkle);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtYemekAdi);
            groupBox1.Controls.Add(txtKalori);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtKarb);
            groupBox1.Controls.Add(cmbKategori);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtYag);
            groupBox1.Location = new Point(12, 245);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(322, 391);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yemek Ekle";
            // 
            // txtSeker
            // 
            txtSeker.Location = new Point(101, 201);
            txtSeker.Name = "txtSeker";
            txtSeker.Size = new Size(132, 23);
            txtSeker.TabIndex = 6;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(57, 204);
            label9.Name = "label9";
            label9.Size = new Size(38, 15);
            label9.TabIndex = 20;
            label9.Text = "Şeker:";
            // 
            // btnResimYukle
            // 
            btnResimYukle.Location = new Point(239, 263);
            btnResimYukle.Name = "btnResimYukle";
            btnResimYukle.Size = new Size(72, 23);
            btnResimYukle.TabIndex = 7;
            btnResimYukle.Text = "Yükle..";
            btnResimYukle.UseVisualStyleBackColor = true;
            btnResimYukle.Click += btnResimYukle_Click;
            // 
            // pbResim
            // 
            pbResim.BorderStyle = BorderStyle.FixedSingle;
            pbResim.Location = new Point(101, 230);
            pbResim.Name = "pbResim";
            pbResim.Size = new Size(132, 93);
            pbResim.TabIndex = 18;
            pbResim.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(53, 267);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 17;
            label7.Text = "Resim:";
            // 
            // txtProtein
            // 
            txtProtein.Location = new Point(101, 172);
            txtProtein.Name = "txtProtein";
            txtProtein.Size = new Size(132, 23);
            txtProtein.TabIndex = 5;
            // 
            // btnYemekGuncelle
            // 
            btnYemekGuncelle.Location = new Point(157, 329);
            btnYemekGuncelle.Name = "btnYemekGuncelle";
            btnYemekGuncelle.Size = new Size(154, 46);
            btnYemekGuncelle.TabIndex = 9;
            btnYemekGuncelle.Text = "Yemek Güncelle";
            btnYemekGuncelle.UseVisualStyleBackColor = true;
            btnYemekGuncelle.Click += btnYemekGuncelle_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(47, 175);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 15;
            label6.Text = "Protein:";
            // 
            // btnYemekSil
            // 
            btnYemekSil.ForeColor = Color.Red;
            btnYemekSil.Location = new Point(341, 245);
            btnYemekSil.Name = "btnYemekSil";
            btnYemekSil.Size = new Size(329, 50);
            btnYemekSil.TabIndex = 1;
            btnYemekSil.Text = "Seçili Yemeği Sil";
            btnYemekSil.UseVisualStyleBackColor = true;
            btnYemekSil.Click += btnYemekSil_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnOgunSil);
            groupBox2.Controls.Add(btnOgunGuncelle);
            groupBox2.Controls.Add(btnOgunEkle);
            groupBox2.Controls.Add(txtOgunAdi);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(dgvOgunler);
            groupBox2.Location = new Point(341, 304);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(329, 332);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "Öğün İşlemleri";
            // 
            // btnOgunSil
            // 
            btnOgunSil.ForeColor = Color.Red;
            btnOgunSil.Location = new Point(158, 263);
            btnOgunSil.Name = "btnOgunSil";
            btnOgunSil.Size = new Size(165, 53);
            btnOgunSil.TabIndex = 3;
            btnOgunSil.Text = "Seçili Öğünü Sil";
            btnOgunSil.UseVisualStyleBackColor = true;
            btnOgunSil.Click += btnOgunSil_Click;
            // 
            // btnOgunGuncelle
            // 
            btnOgunGuncelle.Location = new Point(11, 263);
            btnOgunGuncelle.Name = "btnOgunGuncelle";
            btnOgunGuncelle.Size = new Size(141, 53);
            btnOgunGuncelle.TabIndex = 2;
            btnOgunGuncelle.Text = "Öğün Güncelle";
            btnOgunGuncelle.UseVisualStyleBackColor = true;
            btnOgunGuncelle.Click += btnOgunGuncelle_Click;
            // 
            // btnOgunEkle
            // 
            btnOgunEkle.Location = new Point(11, 216);
            btnOgunEkle.Name = "btnOgunEkle";
            btnOgunEkle.Size = new Size(312, 41);
            btnOgunEkle.TabIndex = 1;
            btnOgunEkle.Text = "Öğün Ekle";
            btnOgunEkle.UseVisualStyleBackColor = true;
            btnOgunEkle.Click += btnOgunEkle_Click;
            // 
            // txtOgunAdi
            // 
            txtOgunAdi.Location = new Point(78, 187);
            txtOgunAdi.Name = "txtOgunAdi";
            txtOgunAdi.Size = new Size(245, 23);
            txtOgunAdi.TabIndex = 0;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 190);
            label8.Name = "label8";
            label8.Size = new Size(61, 15);
            label8.TabIndex = 17;
            label8.Text = "Öğün Adı:";
            // 
            // dgvOgunler
            // 
            dgvOgunler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOgunler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvOgunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOgunler.Columns.AddRange(new DataGridViewColumn[] { Column10, Column11 });
            dgvOgunler.Location = new Point(6, 22);
            dgvOgunler.Name = "dgvOgunler";
            dgvOgunler.Size = new Size(316, 159);
            dgvOgunler.TabIndex = 0;
            dgvOgunler.SelectionChanged += dgvOgunler_SelectionChanged;
            // 
            // Column10
            // 
            Column10.DataPropertyName = "Id";
            Column10.HeaderText = "Id";
            Column10.Name = "Column10";
            // 
            // Column11
            // 
            Column11.DataPropertyName = "Ad";
            Column11.HeaderText = "Öğün Adı";
            Column11.Name = "Column11";
            // 
            // YemekIslemleriForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(685, 648);
            Controls.Add(groupBox2);
            Controls.Add(btnYemekSil);
            Controls.Add(groupBox1);
            Controls.Add(dgvYemekler);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "YemekIslemleriForm";
            Text = "Yemek İşlemleri";
            ((System.ComponentModel.ISupportInitialize)dgvYemekler).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbResim).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvOgunler).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvYemekler;
        private Label label1;
        private TextBox txtYemekAdi;
        private TextBox txtKarb;
        private Label label2;
        private TextBox txtYag;
        private Label label3;
        private Label label4;
        private ComboBox cmbKategori;
        private TextBox txtKalori;
        private Label label5;
        private Button btnYemekEkle;
        private GroupBox groupBox1;
        private Button btnYemekGuncelle;
        private Button btnYemekSil;
        private TextBox txtProtein;
        private Label label6;
        private Button btnResimYukle;
        private PictureBox pbResim;
        private Label label7;
        private GroupBox groupBox2;
        private Button btnOgunSil;
        private Button btnOgunGuncelle;
        private Button btnOgunEkle;
        private TextBox txtOgunAdi;
        private Label label8;
        private DataGridView dgvOgunler;
        private TextBox txtSeker;
        private Label label9;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewImageColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column11;
    }
}
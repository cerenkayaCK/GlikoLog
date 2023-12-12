namespace GlikoLog.PL
{
    partial class SaglikBilgiForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            btnBilgiEkle = new Button();
            txtIlacAd = new TextBox();
            label2 = new Label();
            txtKanSekeri = new TextBox();
            label3 = new Label();
            chbInsulin = new CheckBox();
            dtpTarih = new DateTimePicker();
            label4 = new Label();
            dgvSaglikBilgiForm = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            lblIlacHata = new Label();
            numAdet = new NumericUpDown();
            lblSekerHata = new Label();
            btnSil = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSaglikBilgiForm).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numAdet).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(71, 121);
            label1.Name = "label1";
            label1.Size = new Size(56, 19);
            label1.TabIndex = 0;
            label1.Text = "İlaç Adı:";
            // 
            // btnBilgiEkle
            // 
            btnBilgiEkle.ForeColor = Color.Black;
            btnBilgiEkle.Location = new Point(68, 351);
            btnBilgiEkle.Name = "btnBilgiEkle";
            btnBilgiEkle.Size = new Size(78, 34);
            btnBilgiEkle.TabIndex = 5;
            btnBilgiEkle.Text = "Bilgileri Ekle";
            btnBilgiEkle.UseVisualStyleBackColor = true;
            btnBilgiEkle.Click += btnBilgiEkle_Click;
            // 
            // txtIlacAd
            // 
            txtIlacAd.ForeColor = Color.Black;
            txtIlacAd.Location = new Point(71, 145);
            txtIlacAd.Name = "txtIlacAd";
            txtIlacAd.Size = new Size(106, 23);
            txtIlacAd.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(183, 122);
            label2.Name = "label2";
            label2.Size = new Size(41, 19);
            label2.TabIndex = 3;
            label2.Text = "Adet:";
            // 
            // txtKanSekeri
            // 
            txtKanSekeri.ForeColor = Color.Black;
            txtKanSekeri.Location = new Point(71, 252);
            txtKanSekeri.Name = "txtKanSekeri";
            txtKanSekeri.Size = new Size(158, 23);
            txtKanSekeri.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(74, 228);
            label3.Name = "label3";
            label3.Size = new Size(72, 19);
            label3.TabIndex = 5;
            label3.Text = "Kan Şekeri";
            // 
            // chbInsulin
            // 
            chbInsulin.AutoSize = true;
            chbInsulin.BackColor = Color.Transparent;
            chbInsulin.Location = new Point(77, 316);
            chbInsulin.Name = "chbInsulin";
            chbInsulin.Size = new Size(85, 19);
            chbInsulin.TabIndex = 4;
            chbInsulin.Text = "İnsülin ilacı";
            chbInsulin.UseVisualStyleBackColor = false;
            // 
            // dtpTarih
            // 
            dtpTarih.Format = DateTimePickerFormat.Short;
            dtpTarih.Location = new Point(74, 77);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(106, 23);
            dtpTarih.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(74, 53);
            label4.Name = "label4";
            label4.Size = new Size(40, 19);
            label4.TabIndex = 9;
            label4.Text = "Tarih:";
            // 
            // dgvSaglikBilgiForm
            // 
            dgvSaglikBilgiForm.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgvSaglikBilgiForm.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSaglikBilgiForm.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSaglikBilgiForm.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column6, Column3, Column4, Column5, Column7 });
            dgvSaglikBilgiForm.Location = new Point(254, 53);
            dgvSaglikBilgiForm.Name = "dgvSaglikBilgiForm";
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvSaglikBilgiForm.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvSaglikBilgiForm.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSaglikBilgiForm.Size = new Size(478, 360);
            dgvSaglikBilgiForm.TabIndex = 12;
            // 
            // Column1
            // 
            Column1.DataPropertyName = "Id";
            Column1.HeaderText = "Id";
            Column1.Name = "Column1";
            Column1.Visible = false;
            Column1.Width = 90;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "IlacAd";
            Column2.HeaderText = "İlaç Ad";
            Column2.Name = "Column2";
            // 
            // Column6
            // 
            Column6.DataPropertyName = "IlacAdet";
            Column6.HeaderText = "İlaç Adet";
            Column6.Name = "Column6";
            // 
            // Column3
            // 
            Column3.DataPropertyName = "InsulinMi";
            Column3.HeaderText = "İnsülin Mi?";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.DataPropertyName = "Tarih";
            Column4.HeaderText = "Tarih";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.DataPropertyName = "KanSekeri";
            Column5.HeaderText = "Kan Şekeri";
            Column5.Name = "Column5";
            Column5.Width = 50;
            // 
            // Column7
            // 
            Column7.DataPropertyName = "KullaniciAdi";
            Column7.HeaderText = "Kullanıcı";
            Column7.Name = "Column7";
            // 
            // lblIlacHata
            // 
            lblIlacHata.BackColor = Color.Transparent;
            lblIlacHata.ForeColor = Color.Black;
            lblIlacHata.Location = new Point(77, 172);
            lblIlacHata.Name = "lblIlacHata";
            lblIlacHata.Size = new Size(158, 56);
            lblIlacHata.TabIndex = 14;
            // 
            // numAdet
            // 
            numAdet.Location = new Point(183, 146);
            numAdet.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numAdet.Name = "numAdet";
            numAdet.Size = new Size(49, 23);
            numAdet.TabIndex = 2;
            numAdet.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblSekerHata
            // 
            lblSekerHata.BackColor = Color.Transparent;
            lblSekerHata.ForeColor = Color.Black;
            lblSekerHata.Location = new Point(74, 278);
            lblSekerHata.Name = "lblSekerHata";
            lblSekerHata.Size = new Size(158, 35);
            lblSekerHata.TabIndex = 19;
            // 
            // btnSil
            // 
            btnSil.ForeColor = Color.Black;
            btnSil.Location = new Point(154, 351);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(78, 34);
            btnSil.TabIndex = 20;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // SaglikBilgiForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.glikolog__1_;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(775, 491);
            Controls.Add(btnSil);
            Controls.Add(chbInsulin);
            Controls.Add(lblSekerHata);
            Controls.Add(label3);
            Controls.Add(numAdet);
            Controls.Add(lblIlacHata);
            Controls.Add(dgvSaglikBilgiForm);
            Controls.Add(label4);
            Controls.Add(dtpTarih);
            Controls.Add(txtKanSekeri);
            Controls.Add(label2);
            Controls.Add(txtIlacAd);
            Controls.Add(btnBilgiEkle);
            Controls.Add(label1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "SaglikBilgiForm";
            Text = "SaglikBilgiForm";
            ((System.ComponentModel.ISupportInitialize)dgvSaglikBilgiForm).EndInit();
            ((System.ComponentModel.ISupportInitialize)numAdet).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnBilgiEkle;
        private TextBox txtIlacAd;
        private Label label2;
        private TextBox txtKanSekeri;
        private Label label3;
        private CheckBox chbInsulin;
        private DateTimePicker dtpTarih;
        private Label label4;
        private DataGridView dgvSaglikBilgiForm;
        private Label lblIlacHata;
        private NumericUpDown numAdet;
        private Label lblSekerHata;
        private Button btnSil;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column7;
    }
}
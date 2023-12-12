namespace GlikoLog.PL
{
    partial class EgzersizForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EgzersizForm));
            cmbEgzersizCesidi = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            dgvEgzersizler = new DataGridView();
            btnEkle = new Button();
            lblHata = new Label();
            txtZaman = new TextBox();
            lblZamanHata = new Label();
            label3 = new Label();
            btnSil = new Button();
            dtpTarih = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvEgzersizler).BeginInit();
            SuspendLayout();
            // 
            // cmbEgzersizCesidi
            // 
            cmbEgzersizCesidi.BackColor = SystemColors.Info;
            cmbEgzersizCesidi.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbEgzersizCesidi.ForeColor = Color.Black;
            cmbEgzersizCesidi.FormattingEnabled = true;
            cmbEgzersizCesidi.Location = new Point(49, 111);
            cmbEgzersizCesidi.Name = "cmbEgzersizCesidi";
            cmbEgzersizCesidi.Size = new Size(204, 23);
            cmbEgzersizCesidi.TabIndex = 0;
            cmbEgzersizCesidi.SelectedIndexChanged += cmbEgzersizCesidi_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(49, 93);
            label1.Name = "label1";
            label1.Size = new Size(125, 15);
            label1.TabIndex = 1;
            label1.Text = "Egzersiz Çeşidi Seçiniz:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(49, 212);
            label2.Name = "label2";
            label2.Size = new Size(145, 15);
            label2.TabIndex = 3;
            label2.Text = "Egzersiz Zamanınızı Giriniz";
            // 
            // dgvEgzersizler
            // 
            dgvEgzersizler.AllowUserToOrderColumns = true;
            dgvEgzersizler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEgzersizler.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvEgzersizler.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvEgzersizler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEgzersizler.Location = new Point(293, 70);
            dgvEgzersizler.Name = "dgvEgzersizler";
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvEgzersizler.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvEgzersizler.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEgzersizler.Size = new Size(447, 347);
            dgvEgzersizler.TabIndex = 4;
            // 
            // btnEkle
            // 
            btnEkle.BackColor = SystemColors.ButtonFace;
            btnEkle.ForeColor = Color.Black;
            btnEkle.Location = new Point(50, 292);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(96, 26);
            btnEkle.TabIndex = 5;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // lblHata
            // 
            lblHata.BackColor = Color.Transparent;
            lblHata.Font = new Font("Segoe UI", 7F);
            lblHata.Location = new Point(50, 137);
            lblHata.Name = "lblHata";
            lblHata.Size = new Size(222, 23);
            lblHata.TabIndex = 6;
            // 
            // txtZaman
            // 
            txtZaman.Location = new Point(49, 178);
            txtZaman.Name = "txtZaman";
            txtZaman.Size = new Size(204, 23);
            txtZaman.TabIndex = 7;
            // 
            // lblZamanHata
            // 
            lblZamanHata.BackColor = Color.Transparent;
            lblZamanHata.Font = new Font("Segoe UI", 7F);
            lblZamanHata.ForeColor = Color.Red;
            lblZamanHata.Location = new Point(49, 204);
            lblZamanHata.Name = "lblZamanHata";
            lblZamanHata.Size = new Size(222, 23);
            lblZamanHata.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(49, 160);
            label3.Name = "label3";
            label3.Size = new Size(85, 15);
            label3.TabIndex = 9;
            label3.Text = "Egzersiz Süresi:";
            // 
            // btnSil
            // 
            btnSil.BackColor = SystemColors.ButtonFace;
            btnSil.ForeColor = Color.Black;
            btnSil.Location = new Point(152, 292);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(101, 26);
            btnSil.TabIndex = 10;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // dtpTarih
            // 
            dtpTarih.Location = new Point(50, 242);
            dtpTarih.Name = "dtpTarih";
            dtpTarih.Size = new Size(203, 23);
            dtpTarih.TabIndex = 11;
            // 
            // EgzersizForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.glikolog;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(775, 491);
            Controls.Add(dtpTarih);
            Controls.Add(btnSil);
            Controls.Add(label3);
            Controls.Add(lblZamanHata);
            Controls.Add(txtZaman);
            Controls.Add(lblHata);
            Controls.Add(btnEkle);
            Controls.Add(dgvEgzersizler);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbEgzersizCesidi);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "EgzersizForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EgzersizForm";
            ((System.ComponentModel.ISupportInitialize)dgvEgzersizler).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbEgzersizCesidi;
        private Label label1;
        private Label label2;
        private DataGridView dgvEgzersizler;
        private Button btnEkle;
        private Label lblHata;
        private TextBox txtZaman;
        private Label lblZamanHata;
        private Label label3;
        private Button btnSil;
        private DateTimePicker dtpTarih;
    }
}
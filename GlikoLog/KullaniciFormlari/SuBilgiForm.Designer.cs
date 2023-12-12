namespace GlikoLog.PL
{
    partial class SuBilgiForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuBilgiForm));
            label1 = new Label();
            dateTimePickerSu = new DateTimePicker();
            nudSuMiktar = new NumericUpDown();
            label2 = new Label();
            btnSuEkle = new Button();
            btnSuSil = new Button();
            dgvSu = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)nudSuMiktar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSu).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(36, 104);
            label1.Name = "label1";
            label1.Size = new Size(155, 19);
            label1.TabIndex = 2;
            label1.Text = "Su içtiğiniz tarihi  giriniz:";
            // 
            // dateTimePickerSu
            // 
            dateTimePickerSu.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dateTimePickerSu.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dateTimePickerSu.Format = DateTimePickerFormat.Custom;
            dateTimePickerSu.Location = new Point(36, 126);
            dateTimePickerSu.Name = "dateTimePickerSu";
            dateTimePickerSu.Size = new Size(228, 26);
            dateTimePickerSu.TabIndex = 0;
            // 
            // nudSuMiktar
            // 
            nudSuMiktar.AccessibleRole = AccessibleRole.TitleBar;
            nudSuMiktar.Font = new Font("Trebuchet MS", 12F);
            nudSuMiktar.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            nudSuMiktar.Location = new Point(36, 205);
            nudSuMiktar.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            nudSuMiktar.Minimum = new decimal(new int[] { 50, 0, 0, 0 });
            nudSuMiktar.Name = "nudSuMiktar";
            nudSuMiktar.Size = new Size(228, 26);
            nudSuMiktar.TabIndex = 1;
            nudSuMiktar.Value = new decimal(new int[] { 50, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(36, 183);
            label2.Name = "label2";
            label2.Size = new Size(246, 19);
            label2.TabIndex = 5;
            label2.Text = "İçmiş olduğunuz miktarınızı giriniz (mL)";
            // 
            // btnSuEkle
            // 
            btnSuEkle.BackColor = Color.WhiteSmoke;
            btnSuEkle.Font = new Font("Segoe UI", 10F);
            btnSuEkle.ForeColor = Color.Black;
            btnSuEkle.Location = new Point(160, 254);
            btnSuEkle.Name = "btnSuEkle";
            btnSuEkle.Size = new Size(104, 33);
            btnSuEkle.TabIndex = 2;
            btnSuEkle.Text = "Ekle";
            btnSuEkle.UseVisualStyleBackColor = false;
            btnSuEkle.Click += btnSuEkle_Click;
            // 
            // btnSuSil
            // 
            btnSuSil.BackColor = Color.WhiteSmoke;
            btnSuSil.Font = new Font("Segoe UI", 10F);
            btnSuSil.ForeColor = Color.Black;
            btnSuSil.Location = new Point(658, 430);
            btnSuSil.Name = "btnSuSil";
            btnSuSil.Size = new Size(81, 31);
            btnSuSil.TabIndex = 7;
            btnSuSil.Text = "Sil";
            btnSuSil.UseVisualStyleBackColor = false;
            btnSuSil.Click += btnSuSil_Click;
            // 
            // dgvSu
            // 
            dgvSu.BackgroundColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dgvSu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvSu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSu.Columns.AddRange(new DataGridViewColumn[] { Id });
            dgvSu.Location = new Point(301, 66);
            dgvSu.Name = "dgvSu";
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(192, 255, 192);
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dgvSu.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvSu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvSu.Size = new Size(452, 358);
            dgvSu.TabIndex = 13;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Column1";
            Id.Name = "Id";
            Id.Visible = false;
            // 
            // SuBilgiForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.glikolog;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(780, 493);
            Controls.Add(dgvSu);
            Controls.Add(btnSuSil);
            Controls.Add(btnSuEkle);
            Controls.Add(label2);
            Controls.Add(nudSuMiktar);
            Controls.Add(dateTimePickerSu);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "SuBilgiForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SuBilgiForm";
            Load += SuBilgiForm_Load;
            ((System.ComponentModel.ISupportInitialize)nudSuMiktar).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private DateTimePicker dateTimePickerSu;
        private NumericUpDown nudSuMiktar;
        private Label label2;
        private Button btnSuEkle;
        private Button btnSuSil;
        private DataGridView dgvSu;
        private DataGridViewTextBoxColumn Id;
    }
}
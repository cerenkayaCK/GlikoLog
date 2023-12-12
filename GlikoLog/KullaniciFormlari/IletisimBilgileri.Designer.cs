namespace GlikoLog.PL
{
    partial class IletisimBilgileri
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
            txtAdres = new TextBox();
            txtTelefon = new TextBox();
            btnGuncelle = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            lblBilgi = new Label();
            fontDialog1 = new FontDialog();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtAdres
            // 
            txtAdres.Location = new Point(310, 198);
            txtAdres.Multiline = true;
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new Size(183, 75);
            txtAdres.TabIndex = 1;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new Point(310, 143);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new Size(183, 23);
            txtTelefon.TabIndex = 0;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = SystemColors.Control;
            btnGuncelle.Font = new Font("Segoe UI", 10F);
            btnGuncelle.ForeColor = Color.Black;
            btnGuncelle.Location = new Point(376, 299);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(117, 28);
            btnGuncelle.TabIndex = 2;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnEkle_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = Properties.Resources.glikolog;
            pictureBox1.Location = new Point(-11, -7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(791, 500);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.White;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(235, 151);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 10;
            label3.Text = "Telefon :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(246, 201);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 11;
            label2.Text = "Adres:";
            // 
            // lblBilgi
            // 
            lblBilgi.BackColor = Color.White;
            lblBilgi.ForeColor = Color.Black;
            lblBilgi.Location = new Point(310, 169);
            lblBilgi.Name = "lblBilgi";
            lblBilgi.Size = new Size(183, 26);
            lblBilgi.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(215, 102);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(307, 249);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // IletisimBilgileri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(775, 491);
            Controls.Add(lblBilgi);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(btnGuncelle);
            Controls.Add(txtTelefon);
            Controls.Add(txtAdres);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "IletisimBilgileri";
            Text = "İLETİŞİM BİLGİSİ";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox iletisimresim;
        private TextBox txtTelefon;
        private TextBox txtAdres;
        private Label label1;
        private Button button2;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private Label lblBilgi;
        private Button btnGuncelle;
        private FontDialog fontDialog1;
        private GroupBox groupBox1;
    }
}
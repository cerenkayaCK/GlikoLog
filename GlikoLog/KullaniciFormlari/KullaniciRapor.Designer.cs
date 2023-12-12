namespace GlikoLog.PL.KullaniciFormlari
{
    partial class KullaniciRapor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciRapor));
            cmbRaporSec = new ComboBox();
            label1 = new Label();
            btnGoster = new Button();
            SuspendLayout();
            // 
            // cmbRaporSec
            // 
            cmbRaporSec.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRaporSec.FormattingEnabled = true;
            cmbRaporSec.Location = new Point(282, 149);
            cmbRaporSec.Name = "cmbRaporSec";
            cmbRaporSec.Size = new Size(225, 23);
            cmbRaporSec.TabIndex = 0;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Perpetua", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkGreen;
            label1.Location = new Point(282, 116);
            label1.Name = "label1";
            label1.Size = new Size(256, 30);
            label1.TabIndex = 1;
            label1.Text = "DİYET BİLGİLERİNİZ";
            // 
            // btnGoster
            // 
            btnGoster.ForeColor = Color.Black;
            btnGoster.Location = new Point(333, 203);
            btnGoster.Name = "btnGoster";
            btnGoster.Size = new Size(116, 26);
            btnGoster.TabIndex = 3;
            btnGoster.Text = "GÖSTER";
            btnGoster.UseVisualStyleBackColor = true;
            btnGoster.Click += btnGoster_Click;
            // 
            // KullaniciRapor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(775, 490);
            Controls.Add(btnGoster);
            Controls.Add(label1);
            Controls.Add(cmbRaporSec);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "KullaniciRapor";
            Text = "KullaniciRapor";
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Button btnGoster;
        public ComboBox cmbRaporSec;
    }
}
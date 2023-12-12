namespace GlikoLog.PL.KullaniciFormlari
{
    partial class Rapor
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
            lblBilgiRapor = new Label();
            btnTamam = new Button();
            lblBaslikRapor = new Label();
            SuspendLayout();
            // 
            // lblBilgiRapor
            // 
            lblBilgiRapor.BackColor = Color.Transparent;
            lblBilgiRapor.Font = new Font("Segoe UI", 12F);
            lblBilgiRapor.ForeColor = Color.Black;
            lblBilgiRapor.Location = new Point(104, 106);
            lblBilgiRapor.Name = "lblBilgiRapor";
            lblBilgiRapor.Size = new Size(358, 301);
            lblBilgiRapor.TabIndex = 0;
            // 
            // btnTamam
            // 
            btnTamam.Location = new Point(225, 410);
            btnTamam.Name = "btnTamam";
            btnTamam.Size = new Size(133, 33);
            btnTamam.TabIndex = 1;
            btnTamam.Text = "TAMAM";
            btnTamam.UseVisualStyleBackColor = true;
            btnTamam.Click += btnTamam_Click;
            // 
            // lblBaslikRapor
            // 
            lblBaslikRapor.BackColor = Color.Transparent;
            lblBaslikRapor.Font = new Font("Segoe UI", 15F);
            lblBaslikRapor.Location = new Point(104, 66);
            lblBaslikRapor.Name = "lblBaslikRapor";
            lblBaslikRapor.Size = new Size(358, 40);
            lblBaslikRapor.TabIndex = 2;
            // 
            // Rapor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            BackgroundImage = Properties.Resources.glikolog__3_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(556, 474);
            Controls.Add(lblBaslikRapor);
            Controls.Add(btnTamam);
            Controls.Add(lblBilgiRapor);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Rapor";
            Text = "Rapor";
            ResumeLayout(false);
        }

        #endregion

        private Label lblBilgiRapor;
        private Button btnTamam;
        private Label lblBaslikRapor;
    }
}
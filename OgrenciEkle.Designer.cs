namespace ObsApp
{
    partial class OgrenciEkle
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grp_OgrenciEkle = new GroupBox();
            combo_sinif = new ComboBox();
            txt__numara = new TextBox();
            txt_soyad = new TextBox();
            txt_ad = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btn_guncelle = new Button();
            btn_kaydet = new Button();
            btn_bul = new Button();
            btn_ders = new Button();
            grp_OgrenciEkle.SuspendLayout();
            SuspendLayout();
            // 
            // grp_OgrenciEkle
            // 
            grp_OgrenciEkle.Controls.Add(combo_sinif);
            grp_OgrenciEkle.Controls.Add(txt__numara);
            grp_OgrenciEkle.Controls.Add(txt_soyad);
            grp_OgrenciEkle.Controls.Add(txt_ad);
            grp_OgrenciEkle.Controls.Add(label4);
            grp_OgrenciEkle.Controls.Add(label3);
            grp_OgrenciEkle.Controls.Add(label2);
            grp_OgrenciEkle.Controls.Add(label1);
            grp_OgrenciEkle.Location = new Point(30, 17);
            grp_OgrenciEkle.Name = "grp_OgrenciEkle";
            grp_OgrenciEkle.Size = new Size(495, 258);
            grp_OgrenciEkle.TabIndex = 0;
            grp_OgrenciEkle.TabStop = false;
            grp_OgrenciEkle.Text = "Öğrenci Ekleme";
            // 
            // combo_sinif
            // 
            combo_sinif.FormattingEnabled = true;
            combo_sinif.Location = new Point(138, 158);
            combo_sinif.Name = "combo_sinif";
            combo_sinif.Size = new Size(250, 28);
            combo_sinif.TabIndex = 7;
            combo_sinif.SelectedIndexChanged += combo_sinif_SelectedIndexChanged;
            // 
            // txt__numara
            // 
            txt__numara.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt__numara.Location = new Point(138, 116);
            txt__numara.Name = "txt__numara";
            txt__numara.Size = new Size(250, 27);
            txt__numara.TabIndex = 6;
            txt__numara.TextChanged += text_changed;
            // 
            // txt_soyad
            // 
            txt_soyad.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_soyad.Location = new Point(138, 76);
            txt_soyad.Name = "txt_soyad";
            txt_soyad.Size = new Size(250, 27);
            txt_soyad.TabIndex = 5;
            txt_soyad.TextChanged += text_changed;
            // 
            // txt_ad
            // 
            txt_ad.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txt_ad.Location = new Point(138, 36);
            txt_ad.Name = "txt_ad";
            txt_ad.Size = new Size(250, 27);
            txt_ad.TabIndex = 4;
            txt_ad.TextChanged += text_changed;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 161);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 3;
            label4.Text = "Sınıf Seçiniz";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(16, 120);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 2;
            label3.Text = "Numara";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 77);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 1;
            label2.Text = "Soyad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 43);
            label1.Name = "label1";
            label1.Size = new Size(28, 20);
            label1.TabIndex = 0;
            label1.Text = "Ad";
            // 
            // btn_guncelle
            // 
            btn_guncelle.Location = new Point(60, 296);
            btn_guncelle.Name = "btn_guncelle";
            btn_guncelle.Size = new Size(111, 35);
            btn_guncelle.TabIndex = 1;
            btn_guncelle.Text = "Güncelle";
            btn_guncelle.UseVisualStyleBackColor = true;
            btn_guncelle.Click += btn_guncelle_Click;
            // 
            // btn_kaydet
            // 
            btn_kaydet.Location = new Point(189, 296);
            btn_kaydet.Name = "btn_kaydet";
            btn_kaydet.Size = new Size(184, 35);
            btn_kaydet.TabIndex = 2;
            btn_kaydet.Text = "Kaydet";
            btn_kaydet.UseVisualStyleBackColor = true;
            btn_kaydet.Click += btn_kaydet_Click;
            // 
            // btn_bul
            // 
            btn_bul.Location = new Point(393, 296);
            btn_bul.Name = "btn_bul";
            btn_bul.Size = new Size(113, 35);
            btn_bul.TabIndex = 3;
            btn_bul.Text = "Bul";
            btn_bul.UseVisualStyleBackColor = true;
            btn_bul.Click += btn_bul_Click;
            // 
            // btn_ders
            // 
            btn_ders.Location = new Point(205, 347);
            btn_ders.Name = "btn_ders";
            btn_ders.Size = new Size(151, 36);
            btn_ders.TabIndex = 4;
            btn_ders.Text = "Ders Seçimi";
            btn_ders.UseVisualStyleBackColor = true;
            btn_ders.Click += btn_ders_Click;
            // 
            // OgrenciEkle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(569, 419);
            Controls.Add(btn_ders);
            Controls.Add(btn_bul);
            Controls.Add(btn_kaydet);
            Controls.Add(btn_guncelle);
            Controls.Add(grp_OgrenciEkle);
            Name = "OgrenciEkle";
            Text = "Öğrenci Ekleme";
            Load += OgrenciEkle_Load;
            grp_OgrenciEkle.ResumeLayout(false);
            grp_OgrenciEkle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grp_OgrenciEkle;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox combo_sinif;
        private TextBox txt_soyad;
        private TextBox txt_ad;
        private Button btn_guncelle;
        private Button btn_kaydet;
        private Button btn_bul;
        private Button btn_ders;
        public TextBox txt__numara;
    }
}

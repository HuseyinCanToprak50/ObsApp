namespace ObsApp
{
    partial class Siniflar
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
            grp_sinifEkle = new GroupBox();
            combo_ID = new ComboBox();
            label3 = new Label();
            txt_kontenjan = new TextBox();
            txt_sinifAdi = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btn_ekle = new Button();
            btn_sil = new Button();
            btn_guncelle = new Button();
            button1 = new Button();
            grp_sinifEkle.SuspendLayout();
            SuspendLayout();
            // 
            // grp_sinifEkle
            // 
            grp_sinifEkle.Controls.Add(combo_ID);
            grp_sinifEkle.Controls.Add(label3);
            grp_sinifEkle.Controls.Add(txt_kontenjan);
            grp_sinifEkle.Controls.Add(txt_sinifAdi);
            grp_sinifEkle.Controls.Add(label2);
            grp_sinifEkle.Controls.Add(label1);
            grp_sinifEkle.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            grp_sinifEkle.Location = new Point(12, 12);
            grp_sinifEkle.Name = "grp_sinifEkle";
            grp_sinifEkle.Size = new Size(617, 191);
            grp_sinifEkle.TabIndex = 0;
            grp_sinifEkle.TabStop = false;
            grp_sinifEkle.Text = "Sınıf Ekle";
            // 
            // combo_ID
            // 
            combo_ID.FormattingEnabled = true;
            combo_ID.Location = new Point(160, 40);
            combo_ID.Name = "combo_ID";
            combo_ID.Size = new Size(223, 31);
            combo_ID.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(35, 43);
            label3.Name = "label3";
            label3.Size = new Size(31, 28);
            label3.TabIndex = 4;
            label3.Text = "ID";
            // 
            // txt_kontenjan
            // 
            txt_kontenjan.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_kontenjan.Location = new Point(160, 124);
            txt_kontenjan.Name = "txt_kontenjan";
            txt_kontenjan.Size = new Size(223, 30);
            txt_kontenjan.TabIndex = 3;
            txt_kontenjan.TextChanged += txt_TextChanged;
            // 
            // txt_sinifAdi
            // 
            txt_sinifAdi.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txt_sinifAdi.Location = new Point(160, 80);
            txt_sinifAdi.Name = "txt_sinifAdi";
            txt_sinifAdi.Size = new Size(223, 30);
            txt_sinifAdi.TabIndex = 2;
            txt_sinifAdi.TextChanged += txt_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(35, 122);
            label2.Name = "label2";
            label2.Size = new Size(101, 28);
            label2.TabIndex = 1;
            label2.Text = "Kontenjan";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(35, 78);
            label1.Name = "label1";
            label1.Size = new Size(85, 28);
            label1.TabIndex = 0;
            label1.Text = "Sınıf Adı";
            // 
            // btn_ekle
            // 
            btn_ekle.Location = new Point(69, 220);
            btn_ekle.Name = "btn_ekle";
            btn_ekle.Size = new Size(133, 37);
            btn_ekle.TabIndex = 1;
            btn_ekle.Text = "Ekle";
            btn_ekle.UseVisualStyleBackColor = true;
            btn_ekle.Click += btn_ekle_Click;
            // 
            // btn_sil
            // 
            btn_sil.Location = new Point(208, 220);
            btn_sil.Name = "btn_sil";
            btn_sil.Size = new Size(133, 37);
            btn_sil.TabIndex = 2;
            btn_sil.Text = "Sil";
            btn_sil.UseVisualStyleBackColor = true;
            btn_sil.Click += btn_sil_Click;
            // 
            // btn_guncelle
            // 
            btn_guncelle.Location = new Point(347, 220);
            btn_guncelle.Name = "btn_guncelle";
            btn_guncelle.Size = new Size(133, 37);
            btn_guncelle.TabIndex = 3;
            btn_guncelle.Text = "Güncelle";
            btn_guncelle.UseVisualStyleBackColor = true;
            btn_guncelle.Click += btn_guncelle_Click;
            // 
            // button1
            // 
            button1.Location = new Point(486, 220);
            button1.Name = "button1";
            button1.Size = new Size(119, 37);
            button1.TabIndex = 4;
            button1.Text = "Bul";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Siniflar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(641, 291);
            Controls.Add(button1);
            Controls.Add(btn_guncelle);
            Controls.Add(btn_sil);
            Controls.Add(btn_ekle);
            Controls.Add(grp_sinifEkle);
            Name = "Siniflar";
            Text = "Sınıf Ekle";
            Load += Siniflar_Load;
            grp_sinifEkle.ResumeLayout(false);
            grp_sinifEkle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grp_sinifEkle;
        private Label label2;
        private Label label1;
        private TextBox txt_kontenjan;
        private TextBox txt_sinifAdi;
        private Button btn_ekle;
        private Button btn_sil;
        private Button btn_guncelle;
        private Label label3;
        private ComboBox combo_ID;
        private Button button1;
    }
}
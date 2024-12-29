namespace ObsApp
{
    partial class DersSecimi
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
            lbl_ogrBilgisi = new Label();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            btn_DersKaydet = new Button();
            label1 = new Label();
            lbl_ogrencıID = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lbl_ogrBilgisi
            // 
            lbl_ogrBilgisi.AutoSize = true;
            lbl_ogrBilgisi.Location = new Point(33, 23);
            lbl_ogrBilgisi.Name = "lbl_ogrBilgisi";
            lbl_ogrBilgisi.Size = new Size(221, 20);
            lbl_ogrBilgisi.TabIndex = 0;
            lbl_ogrBilgisi.Text = "Öğrenci Bilgileri Buraya Gelecek";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 115);
            label2.Name = "label2";
            label2.Size = new Size(56, 20);
            label2.TabIndex = 1;
            label2.Text = "Dersler";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(33, 148);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(730, 227);
            dataGridView1.TabIndex = 2;
            // 
            // btn_DersKaydet
            // 
            btn_DersKaydet.Location = new Point(239, 393);
            btn_DersKaydet.Name = "btn_DersKaydet";
            btn_DersKaydet.Size = new Size(295, 45);
            btn_DersKaydet.TabIndex = 3;
            btn_DersKaydet.Text = "Öğrencinin Derslerini Kaydet";
            btn_DersKaydet.UseVisualStyleBackColor = true;
            btn_DersKaydet.Click += btn_DersKaydet_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(653, 23);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 4;
            label1.Text = "Öğrenci ID:";
            // 
            // lbl_ogrencıID
            // 
            lbl_ogrencıID.AutoSize = true;
            lbl_ogrencıID.Location = new Point(737, 23);
            lbl_ogrencıID.Name = "lbl_ogrencıID";
            lbl_ogrencıID.Size = new Size(17, 20);
            lbl_ogrencıID.TabIndex = 5;
            lbl_ogrencıID.Text = "0";
            // 
            // DersSecimi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_ogrencıID);
            Controls.Add(label1);
            Controls.Add(btn_DersKaydet);
            Controls.Add(dataGridView1);
            Controls.Add(label2);
            Controls.Add(lbl_ogrBilgisi);
            Name = "DersSecimi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DersSecimi";
            Load += DersSecimi_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_ogrBilgisi;
        private Label label2;
        private DataGridView dataGridView1;
        private Button btn_DersKaydet;
        private Label label1;
        private Label lbl_ogrencıID;
    }
}
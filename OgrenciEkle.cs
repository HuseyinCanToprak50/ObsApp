using Microsoft.EntityFrameworkCore;
using System.Drawing.Text;

namespace ObsApp
{
    public partial class OgrenciEkle : Form
    {
        Ogrenciler? ogrenci;
        public OgrenciEkle()
        {
            InitializeComponent();
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {

            bool kontrol = false;
            foreach (Control item in grp_OgrenciEkle.Controls)
            {
                if (item is TextBox && item.Text == String.Empty || item is ComboBox && item.Text == string.Empty)
                {
                    item.BackColor = Color.Red;
                    kontrol = true;


                }
            }
            if (kontrol)
            {
                MessageBox.Show("Tüm Alanlar Zorunludur");
                return;
            }



            Ogrenciler ogrenci = new Ogrenciler { Ad = txt_ad.Text, Soyad = txt_soyad.Text, Numara = txt__numara.Text };

            using (OkulDbContext ctx = new OkulDbContext())
            {

                
                var sinifId = ctx.Siniflar.Where(s => s.SinifAd == combo_sinif.Text).Select(s => s.SinifId).FirstOrDefault();

                var sinif = ctx.Siniflar.Where(s => s.SinifId == sinifId).FirstOrDefault();

                if (sinif != null)
                {
                 
                    int mevcutOgrenciSayisi = ctx.Ogrenciler.Count(o => o.SinifId == sinifId);

                    if (mevcutOgrenciSayisi >= sinif.Kontenjan)
                    {
                        
                        MessageBox.Show("Sýnýf kontenjaný dolmuþ. Öðrenci eklenemez.");
                    }
                    else
                    {

                        
                        ogrenci.Sinif = ctx.Siniflar.FirstOrDefault(s => s.SinifId == sinifId);
                        ctx.Ogrenciler.Add(ogrenci);
                        int sonuc = ctx.SaveChanges();
                        MessageBox.Show(sonuc > 0 ? "Öðrenci ekleme baþarýlý" : "Öðrenci Ekleme Baþarýsýz");
                    }
                }





            }
        }

        private void OgrenciEkle_Load(object sender, EventArgs e)
        {
            using (OkulDbContext ctx = new OkulDbContext())
            {
                var sinif = ctx.Siniflar.Select(s => s.SinifAd).ToList();
                foreach (var sinifAdi in sinif)
                {
                    combo_sinif.Items.Add(sinifAdi);
                }

            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {

            using (OkulDbContext ctx = new OkulDbContext())
            {
                var ogrenciler = ctx.Ogrenciler.Where(o => o.Numara == txt__numara.Text).FirstOrDefault();
                var sinifId = ctx.Siniflar.Where(s => s.SinifAd == combo_sinif.Text).Select(s => s.SinifId).FirstOrDefault();
                if (ogrenciler != null)
                {
                    this.ogrenci = ogrenciler;
                    ogrenci.Ad = txt_ad.Text;
                    ogrenci.Soyad = txt_soyad.Text;

                    ogrenci.Sinif = ctx.Siniflar.FirstOrDefault(s => s.SinifId == sinifId);

                    ctx.Entry(ogrenciler).State = EntityState.Modified;
                    int sonuc = ctx.SaveChanges();
                    MessageBox.Show(sonuc > 0 ? "Güncelleme Baþarýlý" : "Güncelleme Baþarýsýz");
                }
                else
                {
                    MessageBox.Show("Bu numarada bir öðrenci bulunamadý");
                }

            }
        }

        private void btn_bul_Click(object sender, EventArgs e)
        {
            string ogrencýNo = txt__numara.Text;

            using (OkulDbContext ctx = new OkulDbContext())
            {
                var ogrenciler = ctx.Ogrenciler.Where(o => o.Numara == txt__numara.Text).FirstOrDefault();


                var sinifAd = (from ogrenci in ctx.Ogrenciler
                               join sinif in ctx.Siniflar
                               on ogrenci.SinifId equals sinif.SinifId
                               where ogrenci.Numara == ogrencýNo
                               select sinif.SinifAd).FirstOrDefault();


                if (ogrenciler != null)
                {
                    this.ogrenci = ogrenciler;
                    txt_ad.Text = ogrenci.Ad;
                    txt_soyad.Text = ogrenci.Soyad;
                    combo_sinif.Text = sinifAd;

                }
                else
                {
                    MessageBox.Show("Öðrenci Bulunamadý!");
                }
            }
        }

        private void btn_ders_Click(object sender, EventArgs e)
        {
            string ogrNo = txt__numara.Text;
            DersSecimi dersSecim = new DersSecimi(ogrNo);
            dersSecim.Show();
        }

      
        private void text_changed(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;

            txt.BackColor = Color.White;

            if (txt.Text == String.Empty)
            {
                txt.BackColor = Color.Red;

            }

        }

        private void combo_sinif_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_sinif.Text == String.Empty)
            {
                combo_sinif.BackColor = Color.Red;
            }
            else
            {
                combo_sinif.BackColor = Color.White;
            }
        }
    }
}

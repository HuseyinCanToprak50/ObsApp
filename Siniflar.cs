using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObsApp    
{
    public partial class Siniflar : Form
    {
        tblSiniflar? sinif = null;
        public Siniflar()
        {
            InitializeComponent();
        }


        private void btn_ekle_Click(object sender, EventArgs e)
        {

            bool kontrol = false;
            foreach (Control item in grp_sinifEkle.Controls)
            {
                if (item is TextBox && item.Text == String.Empty) //item textbox ise ve texti boşsa
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



            tblSiniflar siniflar = new tblSiniflar { SinifAd = txt_sinifAdi.Text, Kontenjan = int.Parse(txt_kontenjan.Text) };
            using (OkulDbContext ctx = new OkulDbContext())
            {
                ctx.Siniflar.Add(siniflar);
                int sonuc = ctx.SaveChanges();
                MessageBox.Show(sonuc > 0 ? "Sınıf ekleme başarılı" : "Sınıf Ekleme Başarısız");
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            using (OkulDbContext ctx = new OkulDbContext())
            {
                var sinif = ctx.Siniflar.Where(s => s.SinifAd == txt_sinifAdi.Text).FirstOrDefault();


                ctx.Siniflar.Remove(sinif);
                int sonuc = ctx.SaveChanges();
                MessageBox.Show(sonuc > 0 ? "Silme Başarılı" : "Silme Başarısız");
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            using (OkulDbContext ctx = new OkulDbContext())
            {
                var sinif = ctx.Siniflar.Where(s => s.SinifAd == txt_sinifAdi.Text).FirstOrDefault();
                sinif.Kontenjan = int.Parse(txt_kontenjan.Text);
                ctx.Entry(sinif).State = EntityState.Modified;
                int sonuc = ctx.SaveChanges();
                MessageBox.Show(sonuc > 0 ? "Güncelleme Başarılı" : "Güncelleme Başarısız");

            }
        }



        private void Siniflar_Load(object sender, EventArgs e)
        {

            using (OkulDbContext ctx = new OkulDbContext())
            {
                var sinif = ctx.Siniflar.Select(s => s.SinifId).ToList();
                foreach (var id in sinif)
                {
                    combo_ID.Items.Add(id);
                }

            }
        }





        private void button1_Click(object sender, EventArgs e)
        {

            int sinifID = int.Parse(combo_ID.Text);
            using (OkulDbContext ctx = new OkulDbContext())
            {
                var sinif = ctx.Siniflar.Find(sinifID);
                if (sinif != null)
                {
                    this.sinif = sinif;
                    txt_kontenjan.Text = sinif.Kontenjan.ToString();  
                    txt_sinifAdi.Text = sinif.SinifAd; 
                }
                else
                {
                    MessageBox.Show("Sınıf bulunamadı!");
                }

            }
        }
        private void txt_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;

            txt.BackColor = Color.White;
            if (txt.Text == String.Empty)
            {
                txt.BackColor = Color.Red;
            }
        }
    }
}

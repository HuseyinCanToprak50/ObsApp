using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObsApp
{
    public partial class Dersler : Form
    {
        tblDersler? ders;
        public Dersler()
        {
            InitializeComponent();
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {


            bool kontrol = false;
            foreach (Control item in grp_dersEkle.Controls)
            {
                if (item is TextBox && item.Text == String.Empty) 
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


            tblDersler dersler = new tblDersler { DersAdi = txt_DersAdi.Text, DersKodu = txt_dersKodu.Text };
            using (OkulDbContext ctx = new OkulDbContext())
            {
                ctx.Dersler.Add(dersler);
                int sonuc = ctx.SaveChanges();
                MessageBox.Show(sonuc > 0 ? "Ders ekleme başarılı" : "Ders Ekleme Başarısız");
            }
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            using (OkulDbContext ctx = new OkulDbContext())
            {
                var dersler = ctx.Dersler.Where(d => d.DersKodu == txt_dersKodu.Text).FirstOrDefault();
                ctx.Dersler.Remove(dersler);
                int sonuc = ctx.SaveChanges();
                MessageBox.Show(sonuc > 0 ? "Silme Başarılı" : "Silme Başarısız");
            }
        }

        private void btn_bul_Click(object sender, EventArgs e)
        {

            using (OkulDbContext ctx = new OkulDbContext())
            {
                var dersler = ctx.Dersler.Where(d => d.DersKodu == txt_dersKodu.Text).FirstOrDefault();
                if (dersler != null)
                {
                    this.ders = dersler;
                    txt_DersAdi.Text = ders.DersAdi;
                    txt_dersKodu.Text = ders.DersKodu;  
                }
                else
                {
                    MessageBox.Show("Ders bulunamadı!");
                }
            }
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            using (OkulDbContext ctx = new OkulDbContext())
            {
                var ders = ctx.Dersler.Where(d => d.DersKodu == txt_dersKodu.Text).FirstOrDefault();
                ders.DersAdi = txt_DersAdi.Text;
                ctx.Entry(ders).State = EntityState.Modified;
                int sonuc = ctx.SaveChanges();
                MessageBox.Show(sonuc > 0 ? "Güncelleme Başarılı" : "Güncelleme Başarısız");

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

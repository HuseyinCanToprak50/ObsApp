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
    public partial class DersSecimi : Form
    {
        string ogrenciNo = null;
        
        public DersSecimi(string numara)
        {
            InitializeComponent();
            this.ogrenciNo = numara;
        }

        private void DersSecimi_Load(object sender, EventArgs e)
        {
            
            dataGridView1.MultiSelect = true;

         
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            using (OkulDbContext ctx = new OkulDbContext())
            {
                var ogrenciBilgiler = ctx.Ogrenciler.Where(o => o.Numara == ogrenciNo).FirstOrDefault();

                if (ogrenciBilgiler != null)
                {
                    lbl_ogrBilgisi.Text = $"Öğrenci No :{ogrenciBilgiler.Numara} \n Öğrenci Adı: {ogrenciBilgiler.Ad} \n Öğrenci Soyadı:{ogrenciBilgiler.Soyad} \n Öğrenci Sınıf: {ogrenciBilgiler.SinifId}";
                    lbl_ogrencıID.Text = $"{ogrenciBilgiler.OgrenciId}";
                }
                else
                {
                    MessageBox.Show("Böyle Bir Öğrenci Bulunamadı");
                    return;
                }

              
                var dersler = ctx.Dersler.Select(d => new { d.DersId, d.DersAdi, d.DersKodu }).ToList();
                dataGridView1.DataSource = dersler;



            }
        }

        private void btn_DersKaydet_Click(object sender, EventArgs e)
        {
            int Id = int.Parse(lbl_ogrencıID.Text);
            using (OkulDbContext ctx = new OkulDbContext())
            {
               
                var ogrenciDersler = new List<tblOgrenciDers>();
                
                foreach (DataGridViewRow satir in dataGridView1.SelectedRows)
                {
                    int dersId = Convert.ToInt32(satir.Cells["DersId"].Value);
                    ogrenciDersler.Add(new tblOgrenciDers { TempKey = Guid.NewGuid(), DersId = dersId, OgrenciId = Id   });


                }
                ctx.OgrenciDersler.AddRange(ogrenciDersler);
                int sonuc =ctx.SaveChanges();
                MessageBox.Show(sonuc>0 ?"Öğrenci Dersleri Başarıyla Kaydedilmiştir" :"Dersler Kayıt Edilemedi!");

            }

        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObsApp
{
    internal class Ogrenciler
    {
        public int OgrenciId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public string Numara { get; set; }
        public int SinifId { get; set; }
        public tblSiniflar Sinif { get; set; } 

 
        [NotMapped]
        public ICollection<tblOgrenciDers> OgrenciDersler { get; set; }
    }
}

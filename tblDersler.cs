using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObsApp
{
    internal class tblDersler
    {
        public int DersId { get; set; }
        public string DersKodu { get; set; }

        public string DersAdi { get; set; }

        [NotMapped]
        public ICollection<tblOgrenciDers> OgrenciDersler { get; set; }  
    }
}

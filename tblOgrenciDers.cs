using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObsApp
{
    internal class tblOgrenciDers
    {
        [Key]
        public Guid TempKey { get; set; }  = Guid.NewGuid();
        public int DersId { get; set; }
        public int OgrenciId { get; set; }
        
    }
}

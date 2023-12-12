using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace GlikoLog.DAL.Entities
{
    public class BesinDegeri
    {
        public int Id { get; set; }

        public double? Karbonhidrat { get; set; }

        public double? Protein { get; set; }

        public double? Yag { get; set; }
        public double? Seker { get; set; }

        public double? Kalori { get; set; }

        public Yemek Yemek { get; set; } = null!;

        public int? YemekId { get; set; } 

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlikoLog.DAL.Entities
{
    public class SaglikBilgisi
    {
        public int Id { get; set; }
        public string? İlacAd { get; set; } 
        public int? IlacAdet { get; set; }
        public bool? InsulinMi { get; set; }
        public double? KanSekeri { get; set; }
        public Kullanici? Kullanici { get; set; }
        public int? KullaniciId { get; set; }
        public DateTime? Tarih { get; set; }


    }
}

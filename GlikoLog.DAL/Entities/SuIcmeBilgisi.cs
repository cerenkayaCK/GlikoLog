
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlikoLog.DAL.Entities
{
    public class SuIcmeBilgisi
    {
        public int Id { get; set; }
        public DateTime Tarih { get; set; }
        public int KullaniciId { get; set; }
        public Kullanici? Kullanici { get; set; }
        public int MiktarMl { get; set; }

    }
}

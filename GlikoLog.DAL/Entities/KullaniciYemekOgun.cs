
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlikoLog.DAL.Entities
{
    public class KullaniciYemekOgun
    {
        public int Id { get; set; }
        public int KullaniciId { get; set; }
        public Kullanici Kullanici { get; set; }

        public int YemekId { get; set; }

        public Yemek Yemek { get; set; }

        public int OgunId { get; set; }

        public Ogun Ogun { get; set; }

        public DateTime Tarih { get; set; }


    }
}

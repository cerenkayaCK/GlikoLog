using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlikoLog.DAL.Entities
{
    public class KullaniciEgzersizler
    {
        public int Id { get; set; }

        public int EgzersizId { get; set; }

        public Egzersiz Egzersiz { get; set; } 

        public int kullaniciId { get; set; }

        public Kullanici kullanici { get; set; }


    }
}

using GlikoLog.DAL.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GlikoLog.DAL.Entities
{
    public class Egzersiz
    {  
        public int Id { get; set; }
    
        public int? EgzersizSuresi { get; set; }

        public EgzersizTur EgzersizTuru { get; set; }
        public DateTime EgzersizTarihi { get; set; }

        public List<KullaniciEgzersizler> KullaniciEgzersizler = new();
       
    }

    


}

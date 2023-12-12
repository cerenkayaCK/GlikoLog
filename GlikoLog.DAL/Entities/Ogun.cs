using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlikoLog.DAL.Entities;


namespace GlikoLog.DAL.Entities
{
    public class Ogun
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public List<KullaniciYemekOgun> KullaniciYemekleri { get; set; } = null!;


    }
}

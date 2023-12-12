using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlikoLog.DAL.Entities;
using GlikoLog.DAL.Enums;


namespace GlikoLog.DAL.Entities
{
    public class Yemek
    {
        public int Id { get; set; }
        public string Ad { get; set; } = null!;
        public byte[] Gorsel { get; set; } = null!;

        [ForeignKey("BesinDegeriId")]
        public BesinDegeri? BesinDegeri { get; set; } = null!;
        public int? BesinDegeriId { get; set; }
        public Porsiyon Porsiyon { get; set; }
        public Kategori KategoriId { get; set; }
        public List<KullaniciYemekOgun>? KullaniciYemekleri { get; set; }

        public override string ToString()
        {
            return Ad;
        }
    }
}

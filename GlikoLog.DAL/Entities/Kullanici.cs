using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using GlikoLog.DAL.Entities;
using GlikoLog.DAL.Enums;
using Microsoft.EntityFrameworkCore;


namespace GlikoLog.DAL.Entities
{
    public class Kullanici
    {
        public int Id { get; set; }

      
        public string Email { get; set; } = null!;

        private string _sifre;

        public string Sifre 
        {
            get { return _sifre; }
            set { _sifre = SifreKontrol.Sifrele(value); }
            
        }
        public string Ad { get; set; } = null!;

        public string Soyad { get; set; } = null!;

        public int Yas { get; set; }

        public double Kilo { get; set; }

        public double Boy { get; set; }

        public Cinsiyet Cinsiyet { get; set; }

        public IletisimBilgi? IletisimBilgisi{ get; set; }
  
        public int? IletisimBilgiId { get; set; }

        public List<KullaniciEgzersizler>? KullaniciEgzersizler = new();

        public List<SaglikBilgisi>? SaglikBilgisi {  get; set; } = new();

        public KullaniciTuru KullaniciTuru { get; set; } = KullaniciTuru.Kullanici;

        public List<SuIcmeBilgisi>? suIcmeBilgisi { get; set; }

        public List<KullaniciYemekOgun>? KullaniciYemekleri { get; set; }

        public override string ToString()
        {
            return Ad + " " + Soyad;
        }

    }
}

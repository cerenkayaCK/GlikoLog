using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using GlikoLog.DAL.Entities;
using GlikoLog.DAL.Enums;

namespace GlikoLog.DAL.Entities
{
    public class IletisimBilgi
    {
        public int Id { get; set; }
        [MaxLength(11)]
        public string? Telefon { get; set; }
        public string? Adres { get; set; }
        public Kullanici Kullanici { get; set; }

    }
}

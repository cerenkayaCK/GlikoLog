using GlikoLog.DAL.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GlikoLog.DAL.Entities
{
    public class SifreKontrol
    {

        public static string UyariMesaj { get; set; }

        public static bool SifreKompleksMi(string _Sifre)
        {
            char bulletPoint = '\u2022';
            bool GecerliMi = true;
            string? ozelKarakter = "% !@#$%^&*()?/>.<,:;'|}]{[_~`+=-";

            if (!_Sifre.Any(char.IsUpper))
            {
                UyariMesaj += bulletPoint + " Şifre büyük harf içermelidir.\n";
                GecerliMi = false;
            }

            if (!_Sifre.Any(char.IsDigit))
            {
                UyariMesaj += bulletPoint + " Şifre rakam içermelidir.\n";
                GecerliMi = false;
            }

            if (!_Sifre.Any(char.IsLower))
            {
                UyariMesaj += bulletPoint + " Şifre küçük harf içermelidir.\n";
                GecerliMi = false;
            }

            if (_Sifre.Length <= 8)
            {
                UyariMesaj += bulletPoint + " Şifre 8 karekterden fazla olmalıdır. \n";
                GecerliMi = false;
            }
            if (!_Sifre.Any(x => ozelKarakter.Contains(x)))
            {
                UyariMesaj += bulletPoint + " Şifre özel karekter içermelidir.\n";
                GecerliMi = false;
            }
            if (_Sifre.Contains(" "))
            {
                UyariMesaj += bulletPoint + " Şifre boşluk içeremez.\n";
                GecerliMi = false;
            }

            return GecerliMi;
        }

        public static string Sifrele(string sifre)
        {
             using (SHA256 hash = SHA256Managed.Create()) { return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2"))); } 
        }

    }
}

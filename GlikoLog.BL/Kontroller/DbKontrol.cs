using GlikoLog.BL.Repository;
using GlikoLog.DAL.Context;
using GlikoLog.DAL.Entities;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlikoLog.DAL.Kontroller
{
    public class DbKontrol
    {
        Repository<Kullanici> Kullanicirepository = new Repository<Kullanici>();

        public bool KullaniciGirisKontrolu(string girilenEmail, string girilenSifre)
        {
            if (Kullanicirepository == null)
            {
                return false;
            }

            var kullanici = Kullanicirepository.FirstOrDefault(k => k.Email == girilenEmail);

            if (kullanici != null)
            {

                if (SifreKontrol.Sifrele(girilenSifre) == kullanici.Sifre)
                {
                    return true;
                }
                return false;
            }
            return false;
        }
        public bool AdminMi(Kullanici kullanici)
        {

            if (kullanici != null)
            {
                if (kullanici.KullaniciTuru == 0)
                {
                    return true;
                }
                return false;

            }
            return false;
        }

    }
}


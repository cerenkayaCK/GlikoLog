using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace GlikoLog.DAL.Kontroller
{
    public class Kontrol
    {
        public static string IsimKontrolu(string isim)
        {
            // Boşluk kontrolü
            if (string.IsNullOrWhiteSpace(isim))         
             return "İsim boş bırakılamaz.";
            // Uzunluk kontrolü
            if (isim.Length > 30)
             return "İsim en fazla 30 karakter uzunluğunda olmalıdır.";
            if (isim.Length == 1) return "Geçerli bir isim giriniz.";
                // Her bir kelimenin alfabetik karakter kontrolü
                string[] kelimeler = isim.Split(' ');
            foreach (string kelime in kelimeler)
            {
                if (!IsAlfabetik(kelime))
                return "Her kelime sadece harf içermelidir.";               
            }
            // Kontrol başarılı ise null döndür
            return null;

        }
        public static string SoyisimKontrolu(string Soyisim)
        {
            // Boşluk kontrolü
            if (string.IsNullOrWhiteSpace(Soyisim))
            {
                return "soyisim boş bırakılamaz.";
            }
            if (Soyisim.Length == 1) return "Geçerli bir soyad giriniz.";
            // Alfabetik karakter kontrolü
            if (!IsAlfabetik(Soyisim))
            {
                return "Soyisim sadece harf içermelidir.";
            }

            // Uzunluk kontrolü
            if (Soyisim.Length > 50)
            {
                return "Soyisim en fazla 50 karakter uzunluğunda olmalıdır.";
            }

            // Kontrol başarılı ise null döndür
            return null;
        }

        public static string BoyKontrolu(string Boy)
        {
            string kontrolBoy = Boy.Trim();

            // Boş olup olmadığını kontrol et
            if (string.IsNullOrEmpty(kontrolBoy))
            {
                return "Boş bir değer girdiniz.";
            }

            // Sadece rakamlardan oluşup oluşmadığını kontrol et
            if (!double.TryParse(kontrolBoy, out double boy))
            {
                return "Geçerli bir sayı giriniz.";
            }

            // Belirli bir aralıkta olup olmadığını kontrol et
            if (!(boy >= 100.0 && boy <= 220.0))
            {
                return "Boy uygun aralıkta değil.";
            }

            // Kontrol başarılı ise null döndür
            return null;
        }

        public static string KiloKontrolu(string girilenKilo)
        {
            string bosluklariSil = girilenKilo.Trim();

            // Boş olup olmadığını kontrol et
            if (string.IsNullOrEmpty(bosluklariSil))
            {
                return "Boş bir değer girdiniz.";
            }

            // Sadece rakamlardan oluşup oluşmadığını kontrol et
            if (!IsNumeric(bosluklariSil))
            {
                return "Geçerli bir kilo giriniz.";
            }
            double kilo = double.Parse(bosluklariSil);

            if (!(kilo >= 30.0 && kilo <= 300.0))
            {
                return "Geçerli bir kilo giriniz.";
            }

            return null; // Geçerli bir kilo, hata olmadığına işaret etmek için null döndürülebilir.
        }

        public static string EmailKontrolu(string email)
        {
            string bosluksuz = email.Trim();


            if (string.IsNullOrEmpty(bosluksuz))
            {
                return "Boş bir e-posta adresi girdiniz.";
            }

            if (!EmailMi(bosluksuz))
            {
                return "Geçerli bir e-posta adresi giriniz.";
            }

            return null; // Geçerli bir e-posta adresi, hata olmadığına işaret etmek için null döndürülebilir.
        }

        private static bool EmailMi(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private static bool IsNumeric(string input)
        {
            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
        public static string YasKontrolu(string girilenYas)
        {

            string trimlenmisYas = girilenYas.Trim();

            // Boş olup olmadığını kontrol et
            if (string.IsNullOrEmpty(trimlenmisYas))
            {
                return "Geçerli bir yaş giriniz.";
            }
            if (!IsNumeric(trimlenmisYas))
            {
                return "Geçerli bir yaş giriniz.";
            }

            int yas = int.Parse(trimlenmisYas);
            if (!(yas >= 16 && yas <= 120))
            {
                return "Geçerli bir yaş giriniz.";
            }
            return null; // Geçerli bir yaş, hata olmadığına işaret etmek için null döndürülebilir.
        }
        private static bool IsAlfabetik(string str)
        {
            // String içinde sadece harf karakterlerinin olup olmadığını kontrol et
            foreach (char karakter in str)
            {
                if (!char.IsLetter(karakter))
                {
                    return false;
                }
            }
            return true;
        }
        public static string TelefonNumarasiKontrol(string telefonNumarasi)
        {
            if (telefonNumarasi.Length != 11)
            {
                return "Telefon numarası 11 haneli olmalıdır!";
            }
            if (!Regex.IsMatch(telefonNumarasi, "^[0-9]+$"))
            {
                return "Telefon numarası yalnızca rakamlardan oluşabilir.";
            }


            if (!(telefonNumarasi.StartsWith("05")))
            {
                return "Hatalı giriş yaptınız";
            }

            return null; //doğru giriş 
        }

    }
}

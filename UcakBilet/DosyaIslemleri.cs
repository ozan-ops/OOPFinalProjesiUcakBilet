using System.IO;
using System.Xml.Serialization;
namespace UcakBilet
{
    internal class DosyaIslemleri
    {
        private const string dosyaUcak = @"dosyalar\ucak.xml";
        private const string dosyaLokasyon = @"dosyalar\lokasyon.xml";
        public const string dosyaUcus = @"dosyalar\ucus.xml";
        public const string dosyaRezervasyon = @"dosyalar\rezervasyon.xml";
        private const string dosya = "dosyalar";
        private static void doysaKontrol(string dosyaYolu)
        {
            if (!Directory.Exists(dosya)) { Directory.CreateDirectory(dosya); }
            if (!File.Exists(dosyaYolu)) { File.Create(dosyaYolu).Close(); }
        }
        public static T[] dosyaOku<T>(string dosyaYolu)
        {
            using (FileStream nesne = new FileStream(dosyaYolu, FileMode.Open))
            {
                XmlSerializer veri = new XmlSerializer(typeof(T[]));
                return (T[])veri.Deserialize(nesne);
            }
        }
        public static void dosyaYaz<T>(string dosyaYolu, T[] veriler)
        {
            using (FileStream nesne = new FileStream(dosyaYolu, FileMode.Create))
            {
                XmlSerializer veri = new XmlSerializer(typeof(T[]));
                veri.Serialize(nesne, veriler);
            }
        }
        public static void olusturDosya()
        {
            doysaKontrol(dosyaUcak);
            Ucak.yeniUcak(0, "Airbus", "A319", "THYA319", 264);
            Ucak.yeniUcak(1, "Airbus", "A320", "THYA320", 330);
            Ucak.yeniUcak(2, "Boeing", "737-800", "THYB780", 302);
            Ucak.yeniUcak(3, "Boeing", "737 - 900ER", "THYB79E", 360);
            dosyaYaz(dosyaUcak, Ucak.ucaklar);
            doysaKontrol(dosyaLokasyon);
            Lokasyon.yeniLokasyon(0, "Türkiye", "Ankara", "Ankara Esenboğa Havalimanı", true);
            Lokasyon.yeniLokasyon(1, "Türkiye", "Antalya", "Antalya Havalimanı", false);
            Lokasyon.yeniLokasyon(2, "Türkiye", "Bursa", "Bursa Yenişehir Havalimanı", true);
            Lokasyon.yeniLokasyon(3, "Türkiye", "Denizli", "Denizli Çardak Havalimanı", false);
            Lokasyon.yeniLokasyon(4, "Türkiye", "İstanbul", "Atatürk Havalimanı", true);
            Lokasyon.yeniLokasyon(5, "Türkiye", "İzmir", "İzmir Adnan Menderes Havalimanı", true);
            dosyaYaz(dosyaLokasyon, Lokasyon.lokasyonlar);
            doysaKontrol(dosyaUcus);
            Ucus.yeniUcus();
            dosyaYaz(dosyaUcus, Ucus.ucuslar);
            doysaKontrol(dosyaRezervasyon);
        }
    }
}
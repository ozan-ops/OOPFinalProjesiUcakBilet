using System;
using System.Xml.Serialization;
namespace UcakBilet
{
    [Serializable]
    [XmlRoot("Ucus")]
    public class Ucus
    {
        [XmlElement("Ucak")]
        public Ucak ucak { get; set; }
        [XmlElement("Lokasyon")]
        public Lokasyon lokasyon { get; set; }
        [XmlElement("Tarih")]
        public DateTime tarih { get; set; }
        public static Ucus[] ucuslar = new Ucus[6];
        public static void yeniUcus()
        {
            Random rastgele = new Random();
            for (int i = 0; i < 6; i++)
            {
                Ucus ucus = new Ucus();
                ucus.ucak = Ucak.ucaklar[rastgele.Next(Ucak.ucaklar.Length)];
                ucus.lokasyon = Lokasyon.lokasyonlar[i];
                DateTime tarih = DateTime.Now;
                int gun = rastgele.Next(1, 30);
                ucus.tarih = tarih.AddDays(gun);
                ucuslar[i] = ucus;
            }
        }
    }
}
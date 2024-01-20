using System;
using System.Xml.Serialization;
namespace UcakBilet
{
    [Serializable]
    [XmlRoot("Lokasyon")]
    public class Lokasyon
    {
        [XmlElement("Ulke")]
        public string ulke { get; set; }
        [XmlElement("Sehir")]
        public string sehir { get; set; }
        [XmlElement("Havaalani")]
        public string havaalani { get; set; }
        [XmlElement("Durum")]
        public bool durum { get; set; }
        public static Lokasyon[] lokasyonlar = new Lokasyon[6];
        public static void yeniLokasyon(int indeks, string ulke, string sehir, string havaalani, bool durum)
        {
            Lokasyon lokasyon = new Lokasyon();
            lokasyon.ulke = ulke;
            lokasyon.sehir = sehir;
            lokasyon.havaalani = havaalani;
            lokasyon.durum = durum;
            lokasyonlar[indeks] = lokasyon;
        }
    }
}
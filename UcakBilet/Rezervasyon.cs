using System;
using System.Collections;
using System.Xml.Serialization;
namespace UcakBilet
{
    [Serializable]
    [XmlRoot("Rezervasyon")]
    public class Rezervasyon
    {
        [XmlElement("Ucus")]
        public Ucus ucus { get; set; }
        [XmlElement("Ad")]
        public string ad { get; set; }
        [XmlElement("Soyad")]
        public string soyad { get; set; }
        [XmlElement("Yas")]
        public int yas { get; set; }
        [XmlElement("Cinsiyet")]
        public string cinsiyet { get; set; }
        [XmlElement("Telefon No")]
        public string telefonNo { get; set; }
        public static ArrayList rezervasyonlar = new ArrayList();
        public static void yeniRezervasyon(Ucus ucus, string ad, string soyad, int yas, string cinsiyet, string telefonNo)
        {
            Rezervasyon rezervasyon = new Rezervasyon();
            rezervasyon.ucus = ucus;
            rezervasyon.ad = ad;
            rezervasyon.soyad = soyad;
            rezervasyon.yas = yas;
            rezervasyon.cinsiyet = cinsiyet;
            rezervasyon.telefonNo = telefonNo;
            rezervasyonlar.Add(rezervasyon);
            DosyaIslemleri.dosyaYaz(DosyaIslemleri.dosyaRezervasyon, dondurRezervasyon());
        }
        public static Rezervasyon[] dondurRezervasyon()
        {
            if (rezervasyonlar != null)
            {
                Rezervasyon[] rezervasyonDizi = new Rezervasyon[rezervasyonlar.Count];;
                for (int sayac = 0; sayac < rezervasyonlar.Count; sayac++)
                {
                    rezervasyonDizi[sayac] = (Rezervasyon)rezervasyonlar[sayac];
                } return rezervasyonDizi;
            } return null;
        }
    }
}
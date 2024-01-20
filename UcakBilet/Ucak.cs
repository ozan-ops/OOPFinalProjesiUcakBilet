using System;
using System.Xml.Serialization;
namespace UcakBilet
{
    [Serializable]
    [XmlRoot("Ucak")]
    public class Ucak
    {
        [XmlElement("Marka")]
        public string marka { get; set; }
        [XmlElement("Model")]
        public string model { get; set; }
        [XmlElement("Seri No")]
        public string seriNo { get; set; }
        [XmlElement("Kapasite")]
        public int kapasite { get; set; }
        public static Ucak[] ucaklar = new Ucak[4];
        public static void yeniUcak(int indeks, string marka, string model, string seriNo, int kapasite)
        {
            Ucak ucak = new Ucak();
            ucak.marka = marka;
            ucak.model = model;
            ucak.seriNo = seriNo;
            ucak.kapasite = kapasite;
            ucaklar[indeks] = ucak;
        }
    }
}
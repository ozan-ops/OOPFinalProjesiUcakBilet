using System;
using System.Text.RegularExpressions;
namespace UcakBilet
{
    internal class Program
    {
        public static int listesayaci;
        static void Main(string[] args)
        {
            DosyaIslemleri.olusturDosya();
            Ucus[] ucusDizisi = DosyaIslemleri.dosyaOku<Ucus>(DosyaIslemleri.dosyaUcus);
            while (true)
            {
                listesayaci = 0;
                Console.WriteLine("Aktif Uçuşlar\n");
                foreach (Ucus nesne in ucusDizisi)
                {
                    if (nesne.lokasyon.durum && nesne.ucak.kapasite > 0)
                    {
                        ++listesayaci;
                        Console.WriteLine($"{listesayaci}. Uçuş:");
                        Console.WriteLine($"Uçak: {nesne.ucak.marka} - {nesne.ucak.model} - {nesne.ucak.seriNo} - {nesne.ucak.kapasite}");
                        Console.WriteLine($"Lokasyon: {nesne.lokasyon.ulke} - {nesne.lokasyon.sehir} - {nesne.lokasyon.havaalani}");
                        Console.WriteLine($"Tarih: {nesne.tarih} \n");
                    }
                }
                int secilenUcus = 0;
                secilenUcus = sayiKontrol(secilenUcus, "Bir Uçuş Seçin: ", 0);
                Ucus secilmisUcus = ucusDizisi[secilenUcus - 1];
                string ad = string.Empty, soyad = string.Empty, telefonNo = string.Empty, cinsiyet = string.Empty;
                ad = metinKontrol(ad, "Ad Giriniz: ");
                soyad = metinKontrol(soyad, "Soyad Giriniz: ");
                int yas = 0;
                yas = sayiKontrol(yas, "Yaş Giriniz: ", 1);
                cinsiyet = cinsiyetKontrol(cinsiyet, "Cinsiyet Giriniz (k/e/d): ");
                telefonNo = telefonNoKontrol(telefonNo, "Telefon Numarası Giriniz: ");
                --ucusDizisi[secilenUcus].ucak.kapasite;
                Rezervasyon.yeniRezervasyon(secilmisUcus, ad, soyad, yas, cinsiyet, telefonNo);
                Console.Write("Yeni Kayıt İster Misiniz? (e/h): ");
                string devam = Console.ReadLine().Trim().ToUpper();
                if (devam[0].ToString() == "E")
                {
                    Console.WriteLine();
                    Console.Clear();
                } else { break; }
            }
            Console.ReadKey();
        }
        public static string metinKontrol(string veri, string mesaj)
        {
            while (true)
            {
                Console.Write(mesaj);
                veri = Console.ReadLine();
                foreach (char k in veri)
                {
                    if (!char.IsLetter(k)) { Console.WriteLine("Sadece Harf Giriniz!\n"); break; }
                    else { Console.WriteLine(); return veri; }
                }
            }
        }
        public static int sayiKontrol(int veri, string mesaj, int secim)
        {
            while (true)
            {
                try
                {
                    Console.Write(mesaj);
                    veri = Convert.ToInt32(Console.ReadLine());
                    if (secim == 0)
                    {
                        if (veri >= 1 && veri <= Program.listesayaci)
                        {
                            ++veri;
                            Console.WriteLine();
                            break;
                        }
                        else { Console.WriteLine("Uçuş Sıra Numarası Giriniz!\n"); }
                    }
                    if (secim == 1)
                    {
                        if (veri > 0 && veri < 101)
                        {
                            Console.WriteLine();
                            break;
                        }
                        else { Console.WriteLine("1 - 100 Arası Bir Değer Giriniz!\n"); }
                    }
                }
                catch (FormatException) { Console.WriteLine("Sadece Sayı Giriniz!\n"); }
            }
            return veri;
        }
        public static string cinsiyetKontrol(string veri, string mesaj)
        {
            while (true)
            {
                Console.Write(mesaj);
                veri = Console.ReadLine().ToUpper();
                veri.ToLower();
                if (veri == "K" || veri == "E" || veri == "D") { Console.WriteLine(); break; }
                else { Console.WriteLine("Sadece (k - K, e - E, d - D) Değerlerinden Birisini Giriniz!\n"); }
            }
            return veri;
        }
        public static string telefonNoKontrol(string veri, string mesaj)
        {
            while (true)
            {
                Console.Write(mesaj);
                veri = Console.ReadLine();
                string sekil = @"^\d{11}$";
                if (Regex.IsMatch(veri, sekil)) { Console.WriteLine(); break; }
                else { Console.WriteLine("Telefon Numarası 11 Hanelidir ve Rakamlardan Olusur!\n"); }
            }
            return veri;
        }
    }
}
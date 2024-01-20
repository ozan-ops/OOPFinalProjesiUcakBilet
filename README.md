# Uçak Bileti Rezervasyon Uygulaması

* Bu proje, uçak bileti rezervasyon bilgilerini XML dosyasına kaydetme projesidir.
* Visual Studio 2022 (.Net Framework 4.8) ile yapılmıştır.

## Nasıl Çalışır

1. Program başlatıldığında, uçak, lokasyon ve uçuş bilgileri oluşturulur ve bilgiler ayrı ayrı XML dosyalarına yazdırılır.
2. Aktif uçuşlar listelenir ve aktif uçuş seçilir.
3. Müşteri bilgileri girilir ve rezervasyon yapılır.

## Sınıflar

- DosyaIslemleri: Dosya işlemlerini gerçekleştiren sınıftır.
- Lokasyon: Lokasyon bilgilerini tutan ve lokasyon verilerini işleyen sınıftır.
- Program: Programın ana sınıfıdır. Girilen verileri kontrol eden metotlar içerir.
- Rezervasyon: Rezervasyon bilgilerini tutan ve rezervasyon verilerini işleyen sınıftır.
- Ucak: Uçak bilgilerini tutan ve uçak verilerini işleyen sınıftır.
- Ucus: Uçuş bilgilerini tutan ve uçuş verilerini işleyen sınıftır.

## Alanlar

* DosyaIslemleri
- dosyaUcak: Uçak XML belgesinin adını ve dosya yolunu tutan alandır.
- dosyaLokasyon: Lokasyon XML belgesinin adını ve dosya yolunu tutan alandır.
- dosyaUcus: Uçuş XML belgesinin adını ve dosya yolunu tutan alandır.
- dosyaRezervasyon: Rezervasyon XML belgesinin adını ve dosya yolunu tutan alandır.
- dosya: XML belgelerinin oluşturulacağı dosya adını tutan alandır.

* Lokasyon
- ulke: Lokasyon ülke bilgisini tutan alandır.
- sehir: Lokasyon şehir bilgisini tutan alandır.
- havaalani: Lokasyon havaalanı bilgisini tutan alandır.
- durum: Lokasyonun aktif olup olmadığının bilgisini tutan alandır.
- lokasyonlar: Lokasyon bilgilerini tutan dizidir.

* Rezervasyon
- ucus: Uçuş bilgilerini (nesnesini) tutan alandır.
- ad: Müşteri ad bilgisini tutan alandır.
- soyad: Müşteri soyad bilgisini tutan alandır.
- yas: Müşteri yaş bilgisini tutan alandır.
- cinsiyet: Müşteri cinsiyet bilgisini tutan alandır.
- telefonNo: Müşteri telefon numarası bilgisini tutan alandır.
- rezervasyonlar: Rezervasyon bilgilerini tutan dizidir.

* Ucak
- marka: Uçak marka bilgisini tutan alandır.
- model: Uçak model bilgisini tutan alandır.
- seriNo: Uçak seri numarası bilgisini tutan alandır.
- kapasite: Uçak yolcu kapasitesi bilgisini tutan alandır.
- ucaklar: Uçak bilgilerini tutan dizidir.

* Ucus
- ucak: Uçak bilgilerini (nesnesini) tutan alandır.
- lokasyon: Lokasyon bilgilerini (nesnesini) tutan alandır.
- tarih: Tarih bilgilerini tutan alandır.
- ucuslar: Uçuş bilgilerini tutan dizidir.

## Metotlar

* DosyaIslemleri
- doysaKontrol: Parametre olarak belirtilen belge var mı yok mu kontrol eder, yok ise belgeyi oluşturur.
- dosyaOku: XML dosyasının içeriğini okur ve belirtilen sınıf nesnesine çevirerek geri döndürür.
- dosyaYaz: Parametre olarak belirtilen belgeye parametre olarak belirtilen veriyi yazdırır.
- olusturDosya: Uçak, lokasyon ve uçuş bilgilerinin XML dosyalarına yazdırır.

* Lokasyon
- yeniLokasyon: Lokasyon bilgilerini parametre olarak alan, verileri uygun alanlara aktaran ve lokasyon dizisine verileri ekleyen metotdur.

* Program
- Main: Ana metotdur. Aktif uçuş listesini konsol ekranına yazdırır. Kullanıcıya uçuş seçtirir ve müşteri bilgilerini girdi olarak alır. Rezervasyon oluşturulduktan sonra uçak yolcu kapasitesini azaltır. While döngüsü ile {e - E} değeri girilene kadar rezervasyon yaptırır.
- metinKontrol: Parametre olarak belirtilen verinin harflerden oluşup oluşmadığını kontrol eder.
- sayiKontrol: Parametre olarak belirtilen verinin rakamlardan oluşup oluşmadığını kontrol eder. Part değeri 0 ise; parametre olarak belirtilen verinin 1 ile uçuş liste sıra numarası arasında olup olmadığını, part değeri 1 ise; 0 ile 101 arasında olup olmadığını kontrol eder.
- cinsiyetKontrol: Parametre olarak belirtilen veriyi kontrol eder. Verinin {k - K, e - E veya d - D} harflerinden birisi olması gerekir.
- telefonNoKontrol: Parametre olarak belirtilen veriyi kontrol eder. Verinin 11 haneli bir sayı olması gerekir.

* Rezervasyon
- yeniRezervasyon: Rezervasyon bilgilerini parametre olarak alan, verileri uygun alanlara aktaran ve rezervasyonlar dizisine verileri ekleyen metotdur. DosyaIslemleri sınıfının dosyaYaz metodu ile rezervasyon bilgisini XML dosyasına yazdırır.
- dondurRezervasyon: rezervasyonlar dizisini geri döndüren metotdur.

* Ucak
- yeniUcak: Uçak bilgilerini parametre olarak alan, verileri uygun alanlara aktaran ve ucaklar dizisine verileri ekleyen metotdur.

* Ucus
- yeniUcus: Rastgele uçuş oluşturan ve ucuslar dizisine verileri ekleyen metotdur.
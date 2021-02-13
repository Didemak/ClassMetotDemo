using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Derya";
            musteri1.Soyad = "Akça";
            musteri1.Sehir = "İstanbul";
            musteri1.Tel = 0535451212;
            musteri1.Islemler = "Kredi Çekme";


            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Gizem";
            musteri2.Soyad = "Akça";
            musteri2.Sehir = "Tokat";
            musteri2.Tel = 05354552545;
            musteri2.Islemler = "Kart Başvurusu";


            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Ad = "Esranur  Betül";
            musteri3.Soyad = "Öz";
            musteri3.Sehir = "Edirne";
            musteri3.Tel = 0554545484;
            musteri3.Islemler = "Para Çekme";


            Musteri musteri4 = new Musteri();
            musteri4.Id = 4;
            musteri4.Ad = "Ecem";
            musteri4.Soyad = "Odabaşı";
            musteri4.Sehir = "İstanbul";
            musteri4.Tel = 053555885;
            musteri4.Islemler = "Havale İşlemi";

            Musteri musteri5 = new Musteri();
            musteri5.Id = 5;
            musteri5.Ad = "Hayriye";
            musteri5.Soyad = "Ayşit";
            musteri5.Sehir = "Arap";
            musteri5.Tel = 0587845658;
            musteri5.Islemler = "Para Yatırma";

            MusteriManager musteriManager = new MusteriManager();
            //Musteri ekleme
            musteriManager.MusteriEkleme(musteri3);
            // Musteri Listeleme
            musteriManager.MusteriListeme(musteri5);
            // Musteri Silme
            musteriManager.MusteriSilme(musteri4);

        }
    }
}

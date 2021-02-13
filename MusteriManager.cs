using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkleme(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " adlı müsteri eklendi.\n");
        }
        public void MusteriListeme(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " adlı kişinin dökümanları listelendi");
            Console.WriteLine("Musteri Şehir : " + musteri.Sehir);
            Console.WriteLine("Musteri Telefon :" + musteri.Tel);
            Console.WriteLine("Seçilen İşlem :" + musteri.Islemler+"\n");
        }
        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine(musteri.Ad + " " + musteri.Soyad + " adlı müsterimiz silindi\n");
        }
    }
}

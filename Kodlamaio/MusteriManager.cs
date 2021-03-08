using System;
using System.Collections.Generic;
using System.Text;

namespace Kodlamaio
{
    class MusteriManager
    {
        public void musteriEkleme(Musteri musteri1)
        {
            Console.WriteLine("id giriniz\n");
            int id;
            id = Convert.ToInt32(Console.ReadLine());
            musteri1.SetId(id);

            Console.WriteLine("ad giriniz\n");
            string ad;
            ad = Console.ReadLine();
            musteri1.SetAd(ad);

            Console.WriteLine("soyad giriniz\n");
            string soyad;
            soyad = Console.ReadLine();
            musteri1.SetSoyad(soyad);

            Console.WriteLine("cinsiyet giriniz\n");
            char cinsiyet;
            cinsiyet = Convert.ToChar(Console.ReadLine());
            musteri1.SetCinsiyet(cinsiyet);

            Console.WriteLine("adres giriniz\n");
            string adres;
            adres = Console.ReadLine();
            musteri1.SetAdres(adres);
        }

        public void MusteriListele(Musteri musteri1)
        {
            Console.WriteLine(musteri1.GetId());
            Console.WriteLine(musteri1.GetAd());
            Console.WriteLine(musteri1.GetSoyad());
            Console.WriteLine(musteri1.GetCinsiyet());
            Console.WriteLine(musteri1.GetAdres());
        }
    }
}

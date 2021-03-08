using System;

namespace Kodlamaio
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            MusteriManager manager = new MusteriManager();

            musteri.SetId(5);
            musteri.SetAd("Bünyamin");
            musteri.SetSoyad("Şanlı");
            musteri.SetCinsiyet('E');
            musteri.SetAdres("Gaziantep");

            manager.MusteriListele(musteri);
        }
    }
}

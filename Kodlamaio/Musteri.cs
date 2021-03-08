using System;
using System.Collections.Generic;
using System.Text;

namespace Kodlamaio
{
    class Musteri
    {
        string ad;
        public string GetAd()
        {
            return ad;
        }
        public void SetAd(string ad)
        {
            this.ad = ad;
        }


        string soyad;
        public string GetSoyad()
        {
            return soyad;
        }
        public void SetSoyad(string soyad)
        {
            this.soyad = soyad;
        }


        string adres;
        public string GetAdres()
        {
            return adres;
        }
        public void SetAdres(string adres)
        {
            this.adres = adres;
        }


        char cinsiyet;
        public char GetCinsiyet()
        {
            return cinsiyet;
        }
        public void SetCinsiyet(char cinsiyet)
        {
            this.cinsiyet = cinsiyet;
        }


        int id;
        public int GetId()
        {
            return id;
        }
        public void SetId(int id)
        {
            this.id = id;
        }
    }
}

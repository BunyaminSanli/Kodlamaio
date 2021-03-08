using System;

namespace Kodlamaio
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.SetId(5);
            Console.WriteLine(musteri.GetId());
        }
    }
}

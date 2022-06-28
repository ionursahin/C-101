using System;

namespace _4.static_sinif_ve_uyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calisan Sayısı: {0}",Calisan.CalisanSayisi);
            //Yukarıda static olduğu için adıyla erisebiliyoruz. ama calisan.Ad yazamazdık mesela
            Calisan calisan1 = new Calisan("Ayşe", "Yılmaz", "İK");
            Console.WriteLine("Calisan Sayisi: {0}", Calisan.CalisanSayisi);
            Calisan calisan2 = new Calisan("Kübra", "Yılmaz", "İK");
            Console.WriteLine("Calisan Sayisi: {0}", Calisan.CalisanSayisi);

            //staticte nesne olmadan direkt sinifin adiyla erisebiliyoruz.

            Console.WriteLine("Toplama İşlemi Sonucu: {0}", Islemler.Topla(100,200));

            Console.WriteLine("Toplama İşlemi Sonucu: {0}", Islemler.Cikart(500,200));


            


            Console.ReadKey();
            
        }
    }
    class Calisan
    {
        private static int calisanSayisi;

        public static int CalisanSayisi{get => calisanSayisi;}
        private string Isim;
        private string Soyad;
        private string Departman;

        //

        //static constructor kurucu
        static Calisan()
        {
           calisanSayisi =0;
        }

        //constructor

        public Calisan(string isim, string soyad, string departman)
        {
            this.Isim=isim;
            this.Soyad=soyad;
            this.Departman = departman;
            //her calisan eklendiğinde calisansayisi bir artıyor.
            calisanSayisi ++;
        }
    }
    static class Islemler
    {
        public static long Topla(int sayi1, int sayi2)
        {
            return sayi1+sayi2;
        }
        public static long Cikart(int sayi1, int sayi2)
        {
            return sayi1-sayi2;
        }
    }
}

using System;

namespace _1.sinif_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            //Syntax-Söz Dizimi
            //class SinifAdi{
                // [Erisim Belirleyici] [VEri Tipi] OzellikAdi;
                //[Erisim Belirleyici] [Geri Donus Tipi] MetotAdi[Parametre Listesi]{
                    //Metot Komutlari
                //}
            //}
            
            //Erişim Belirleyiciler
            // * Public - Her Yerden Erişilebilir
            // * Private - Sadece tanımlandığı sınıf içerisinde erişilebilir
            // * Internal - Sadece kendi bulunduğu proje içerisinde erişilebilir.
            // * Protected - Sadece tanımlandığı sınıfta ve o sınıftan kalıtım alan sınıflarda erişilebilir.

            //calisan sinifindan calisan1 adında bir instance/ornek yarattik.
            Calisan calisan1 = new Calisan();

            //calisan sınıfından türettiğimiz calisan1 nesnesinin propertylerini/özelliklerini tanımladık.
            calisan1.Ad ="Onur";
            calisan1.Soyad = "Sahin";
            calisan1.No = 53795123;
            calisan1.Departman = "Arge";

            calisan1.CalisanBilgileri();

            Calisan calisan2 = new Calisan();
            calisan2.Ad ="Deniz";
            calisan2.Soyad = "Kara";
            calisan2.No = 55645895;
            calisan2.Departman = "İnsan Kaynakları";
            calisan2.CalisanBilgileri();
            Console.ReadKey();

        }
    }
    class Calisan{
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public void CalisanBilgileri(){
            Console.WriteLine("Çalışan Adı: {0}", Ad);
            Console.WriteLine("Çalışan Soyadı: {0}", Soyad);
            Console.WriteLine("Çalışan Numarası: {0}", No);
            Console.WriteLine("Çalışan Departmanı {0}", Departman);
        }
    }
}

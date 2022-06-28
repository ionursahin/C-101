using System;

namespace _2.kurucu_metotlar
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

            //kurucu metot ile yaptık.
            Calisan calisan1 = new Calisan("Onur", "Sahin", 53795123 ,"Arge");
            calisan1.CalisanBilgileri();

            Calisan calisan2 = new Calisan("Deniz", "Kara", 55645895 ,"İnsan Kaynakları");
            calisan2.CalisanBilgileri();

            Calisan calisan3 = new Calisan("Onur",
             "Şahin");
             calisan3.CalisanBilgileri();

            Console.ReadKey();

        }
    }
    class Calisan{
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;
        
        //kurucu fonksiyon/metot
        public Calisan(string ad, string soyad, int no, string departman){
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }
        //kurucu fonksiyonu overload ediyoruz.
        // no ve departmanı da yazdırıyor çünkü calisan bilgileri metodumuzda ikisi de var, onları boş döndürüyor.
        public Calisan(string ad, string soyad){
            this.Ad = ad;
            this.Soyad = soyad;
        }

        public Calisan(){}
        public void CalisanBilgileri(){
            Console.WriteLine("Çalışan Adı: {0}", Ad);
            Console.WriteLine("Çalışan Soyadı: {0}", Soyad);
            Console.WriteLine("Çalışan Numarası: {0}", No);
            Console.WriteLine("Çalışan Departmanı: {0}", Departman);
        }
    }
}

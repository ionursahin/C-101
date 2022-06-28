using System;

namespace _2.metotlar_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //out paremetresi bir fonksiyona bir iş yaptırıp değeri setlemesini istiyorsak out parametre yapabiliriz

            string sayi ="999";
            bool sonuc = int.TryParse(sayi, out int outSayi);
            if(sonuc){
                Console.WriteLine("Başarılı");
                Console.WriteLine(outSayi);
            }
            else{
                Console.WriteLine("Başarısız");
            }
            metotlar instance = new metotlar();
            instance.Topla(4, 5, out int toplamSonuc);
            Console.WriteLine(toplamSonuc);

            //metot Overloading
            //birden fazla metota aynı adı verip farklı farklı islem yaptırmak mesela aşağıdaki örnekte ifadeyi ekrana yazdırırken hem tostring kullandık hem de kullanmadık metotlardan birisi string birisi int çünkü. overloading yapınca uygun olan metottan sonucu alıyor.(?)
            int ifade = 999;
            instance.EkranaYazdir(Convert.ToString(ifade));
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("Onur", "Şahin");


            Console.ReadKey();

            

        }
    }
    class metotlar{
        public void Topla(int a, int b, out int toplam){
             toplam = a+b;
        }
        public void EkranaYazdir(string veri){
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(int veri){
            Console.WriteLine(veri);
        }
        public void EkranaYazdir(string veri, string veri2){
            Console.WriteLine(veri + veri2);
        }
    }
}

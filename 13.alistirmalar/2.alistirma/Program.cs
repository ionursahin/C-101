using System;
using System.Collections;
namespace _2.alistirma
{
    class Program
    {
        static void Main(string[] args)
        {
            //klavyeden girilen 20 sayının en büyük 3 ve en küçük 3 tanesini bulan, her iki grubun da kendi içerisindeki ortalamalarını ve toplamlarını yazdıran program.
            ArrayList sayilar = new ArrayList();
            ArrayList buyuksayilar = new ArrayList();
            ArrayList kucuksayilar = new ArrayList();
            int sayi;
            int bstoplam=0;
            int kstoplam=0;
            for (int i = 1; i <= 20; i++)
            {
                Console.Write("Lütfen "+i+". sayiyi giriniz: ");
                sayi = Convert.ToInt32(Console.ReadLine());
                sayilar.Add(sayi);
            }
            //sayilar sort ile sayilar listemizi küçükten büyüğe sıraladık. ve ilk 3 indexi kücük sayilar arraylistine ekledik
            sayilar.Sort();
            kucuksayilar.Add(sayilar[0]);
            kucuksayilar.Add(sayilar[1]);
            kucuksayilar.Add(sayilar[2]);            
            Console.WriteLine("Küçük Sayılar");
            foreach(var item in kucuksayilar){
                Console.WriteLine(item);
            }
            foreach(int item in kucuksayilar){
                kstoplam = kstoplam+item;
            }
            Console.WriteLine("Küçük Sayıların Toplamı: "+kstoplam);
            Console.WriteLine("Küçük Sayıların Ortalaması: "+kstoplam / kucuksayilar.Count);
                        
            //sayilar reverse ile küçükten büyüğe sıralı listemizi terse çevirdik. ilk 3 indexi bu sefer büyük sayilar arraylistine ekledik.
            sayilar.Reverse();
            buyuksayilar.Add(sayilar[0]);
            buyuksayilar.Add(sayilar[1]);
            buyuksayilar.Add(sayilar[2]);
            Console.WriteLine("Büyük Sayılar");
            foreach (var item in buyuksayilar)
            {
                Console.WriteLine(item);
            }                 
            foreach(int item in buyuksayilar){
                  bstoplam = bstoplam+item;
            }
            Console.WriteLine("Büyük Sayıların Toplamı: "+ bstoplam);
            Console.WriteLine("Büyük Sayıların Ortalaması: "+ bstoplam / buyuksayilar.Count);
            Console.ReadKey();
            
            

        }
    }
}

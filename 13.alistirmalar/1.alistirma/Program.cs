using System;
using System.Collections;


namespace _1.alistirma
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            //negatif ve numeric olmayan girisleri engelle. Henüz Yapamadım

            //Girilen 20 adet pozitif sayıyı asal veya asaldegil isimli 2 tane arrayliste atama.
            ArrayList asal = new ArrayList();
            ArrayList asaldegil = new ArrayList();
            int sayi;
            for (int i = 1; i <= 20; i++)
            {
                Console.Write(i+ ". sayiyi giriniz: ");
                sayi = Convert.ToInt32(Console.ReadLine());
                if(AsalMi(sayi)){
                    asal.Add(sayi);
                }
                else
                asaldegil.Add(sayi);
            }

            //2 dizinin de elemanlarının büyükten küçüğe sıralanması
            //önce sort methodu ile iki arraylist'i de artan bir sırayla sıraladık.
            asal.Sort();
            asaldegil.Sort();
            //daha sonra reverse ile arraylist'i aynaladık. baştaki eleman sona sondaki eleman başa gelecek sekilde. yani büyükten küçüğe oldu.
            asal.Reverse();
            asaldegil.Reverse();
            Console.WriteLine("Büyükten Küçüğe Asal Sayılar: ");
            foreach(var item in asal){
                
                Console.WriteLine(item);
            }
            Console.WriteLine("Büyükten Küçüğe Asal Olmayan Sayılar: ");
            foreach(var item in asaldegil){
                
                Console.WriteLine(item);
            }

            //2 dizinin de toplam eleman sayisini ve ortalamasini ekrana yazdir
            Console.WriteLine("Asal Sayıların Toplam Elemanı: "+asal.Count);
            Console.WriteLine("Asal Olmayan Sayıların Toplam Elemanı: "+asaldegil.Count);
            int asaltoplam=0;
            int asaldegiltoplam=0;
            foreach(int item in asal){
                asaltoplam= asaltoplam+item;
            }
            foreach(int item in asaldegil){
                asaldegiltoplam = asaldegiltoplam+item;
            }
            Console.WriteLine("Asal Sayıların Toplamı: "+asaltoplam);
            Console.WriteLine("Asal Olmayan Sayıların Toplamı: "+asaldegiltoplam);
            Console.WriteLine("Asal Sayıların Ortalaması: " + asaltoplam / asal.Count);
            Console.WriteLine("Asal Olmayan Sayıların Ortalaması: "+ asaldegiltoplam / asaldegil.Count);

            Console.ReadKey();

           
        }
        
        static bool AsalMi(int sayii){
            for (var i = 2; i < sayii; i++)
                if (sayii % i == 0) return false;
            return true;
        }
            
    }
}


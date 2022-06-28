using System;

namespace _2.while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
           //while
           //1den başlayarak consoledan girilen sayiya kadar (sayi dahil) ortalama hesaplayıp konsola yazdır
           Console.Write("Bir sayı giriniz: ");
           int sayi1 = int.Parse(Console.ReadLine());
           int sayac =1;
           int toplam = 0;
           while (sayac<=sayi1)
           {
                toplam += sayac;
                sayac ++; // sayac bir artıyor.
           }
           Console.WriteLine(toplam/sayi1);

           //a'dan z'ye kadar tüm harfleri console a yazdırma
           char karakter = 'a';
           while (karakter<'z')
           {
               Console.WriteLine(karakter);
               karakter++;
           }
           //foreach
            Console.WriteLine("ForEach Örneği");
            string[] arabalar = {"bmw", "ford", "toyota", "nissan"};//dizi
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }

           Console.ReadKey();
        }
    }
}

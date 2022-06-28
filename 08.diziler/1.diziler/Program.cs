using System;

namespace _1.diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //DİZİLER
            //Dizi tanımlama
            string[] renkler = new string[5];//5 tane string elemandan oluşan renkler adında bir dizi tanımladık. elemanları henüz belli değil.

            string[] hayvanlar = {"kedi","köpek","kuş"};
            //burada ise diziyi oluştururken elemanlarını da girdik.

            int[] dizi;
            dizi = new int[5];
            //bu şekilde de dizi tanımlayabiliriz

            //Dizilere değer atama ve erişim
            renkler[0] = "Mavi";
            dizi[3] =10;

            //dizinin getirmek istediğimiz indexini yazıyoruz.
            Console.WriteLine(hayvanlar[0]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(hayvanlar[1]);
            Console.WriteLine(renkler[0]);
            
            //Döngülerle Diziler.
            Console.WriteLine("****Döngülerle Dizi Kullanımı*****");
            //Klavyeden girilen n tane sayının ortalamasını alan program.
            Console.Write("Lütfen Dizinin eleman sayısını giriniz: ");
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];//girilen sayı dizinin boyutunu belirtiyor.
            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("Dizinin {0}. sayisini giriniz: ", i+1);//kullanıcı için 0. sayıyı girmek pek mantıklı değil indeximiz sıfırdan başladığı için ekrana bir arttırarak yazdırıyoruz o yüzden i+1
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }
            int toplam =0;
            foreach (var sayi in sayiDizisi)//foreach genelde dizilerle kullanılan bir döngüdür. burdaki mantık sayidizisindeki sayi'larin hepsi toplanana kadar sıra sıra döngünün dönmesi.
            {
                toplam+= sayi;
            }
            Console.WriteLine("Ortalama: "+ toplam/diziUzunlugu);

            Console.ReadKey();
       }
    }
}

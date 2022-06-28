using System;

namespace _1.for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ekrandan girilen sayıya kadar olan tek sayıları yazdır.
            Console.Write("Bir sayi giriniz: ");
            int sayac = int.Parse( Console.ReadLine());//int.Parse yapıyoruz çünkü Console.Readline ekrandan string okur.
            for (int i = 1;i<=sayac; i++)// i sıfırdan başlayarak her döngüde 1 arttırarak lenghten küçük olması koşuluyla çalıştır.
            {
                if(i %2 ==1)
                   Console.WriteLine(i);
            }

            //1 ile 1000 arasındaki tek ve çift sayıların kendi içlerindeki toplamlarını ekrana yazdır.
            int tektoplam = 0;
            int cifttoplam =0;
            for (int i = 1; i <= 1000; i++)
            {
                if(i%2==1)
                tektoplam+= i; //tektoplam = tektoplam +i;
                else
                cifttoplam+=i; // cifttoplam = cifttoplam +i;             
            }
            Console.WriteLine("tektoplam: "+tektoplam);
            Console.WriteLine("cifttoplam: "+cifttoplam); 

            //break, continue
            //break 
            for (int i = 1; i < 10; i++)
            {
                if(i==4)
                break;
                Console.WriteLine(i);
                //i 4 olunca döngüyü bitiriyor ve sadece 1,2,3'ü çıktı olarak yazıyor
            }
            // continue
            for (int i = 1; i < 10; i++)
            {
                if(i==4)
                continue;
                Console.WriteLine(i);
                //i 4 olunca döngüde onu atlayıp 4 hariç 1den 10a kadar olan sayıları yazıyor.
            }

            Console.ReadKey();
        }
    }
}

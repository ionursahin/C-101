using System;

namespace _2.calisma
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcının girdiği sayılardan bölünmesini istediği sayıya tam bölünenlerin listesi
            int adet, sayi, bolen;
            Console.WriteLine("Kaç Adet Sayı Girmek İstiyorsunuz?");
            adet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hangi Sayıya Bölünmesini İstiyorsunuz?");
            sayi = Convert.ToInt32(Console.ReadLine());
            int[] dizi = new int[adet];
            for (int i = 1; i <= adet; i++)
            {
                Console.Write("Hangi sayıyı bölmek istiyorsunuz: ");
                bolen = Convert.ToInt32(Console.ReadLine());
                dizi[i-1] = bolen;
            }
            Console.Write("Girdiğiniz sayılardan "+ sayi + " sayisina tam bölünenlerin listesi: ");
            foreach (var item in dizi)
            {
                if(item%sayi==0){
                    Console.Write(item+", ");
                }
            }
            Console.ReadKey();
        }
    }
}

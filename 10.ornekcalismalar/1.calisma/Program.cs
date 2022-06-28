using System;

namespace _1.calisma
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kullanıcının girdiği sayılardan çift olanları ekrana yazdırma.

            int adet, sayi;
            
            Console.Write("Kaç adet sayı girmek istiyorsunuz? ");
            adet = Convert.ToInt16(Console.ReadLine());
            int[] ciftsayilar = new int[adet];
            for (int i = 1; i <=adet; i++)
            {
                Console.Write("Lutfen sayiyi giriniz: ");
                sayi= Convert.ToInt16(Console.ReadLine());
                ciftsayilar[i-1] = sayi;
                
            }
            Console.Write("Girdiğiniz sayılar arasındaki çift sayilar: ");
             foreach (var item in ciftsayilar)
             {
                 if(item%2==0){
                    Console.Write(+item + ", ");
                 }
                 
             }
             
        Console.ReadKey();

        }
    }
}

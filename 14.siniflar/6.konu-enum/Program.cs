using System;

namespace _6.konu_enum
{
    class Program
    {
        static void Main(string[] args)
        {
            //değeri belli olan degiskenler icin, tek tek degisken tanımlamak yerine enum kullanmak çok daha mantıklı.

            //enumda degerleri string olarak yazsak da string olarak tutulmuyor. aslında enum'ın elemanının adını belirliyoruz aslında. mesela gunler enum'ının pazar elemanını string olarak pazar diye yazdırıyoruz aşağıda.

            Console.WriteLine(Gunler.Pazar);
            
            //numeric deger olarak yazdırıyoruz.
            Console.WriteLine((int)Gunler.Cumartesi);


            //havadurumu enum
            int sicaklik = 32;
            if(sicaklik <= (int)HavaDurumu.Normal)//(int) ile inte cast ediyoruz.
            Console.WriteLine("Dışarıya çıkmak için havanın biraz daha ısınmasını bekleyelim.");    

            else if(sicaklik >=(int)HavaDurumu.Sicak)
                Console.WriteLine("Dışarıya çıkmak için çok sıcak");        
                    
            else if(sicaklik>=(int)HavaDurumu.Normal && sicaklik<(int)HavaDurumu.CokSicak)
                Console.WriteLine("Hadi disariya cikalim.");
            
            Console.ReadKey();
        }
    }
    enum Gunler{
        //enum ilk değeri 0dan baslıyor, ardısık sekilde artıyor. pazartesiye 1 dedik bu sekilde 1den baslıyor.
        Pazartesi=1,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar
    }

    enum HavaDurumu{
        Soguk =5,
        Normal = 20,
        Sicak= 25,
        CokSicak=30
    }
}

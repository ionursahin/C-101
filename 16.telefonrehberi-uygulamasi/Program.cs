using System;

namespace _16.telefonrehberi_uygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            rehber kisi1 = new rehber();
            int islem=8;
            //islem gerekli çünkü switch case'de islem seçtirmek için kullanıdırıcaz. 8 olmasının bi anlamı yok random.
            while (islem!=0)
            {
                    Console.WriteLine("");
                    Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz");
                    Console.WriteLine("*******************************************");
                    Console.WriteLine("(1) Yeni Numara Kaydetmek");
                    Console.WriteLine("(2) Varolan Numarayı Silmek");
                    Console.WriteLine("(3) Varolan Numarayı Güncelleme");
                    Console.WriteLine("(4) Rehberi Listelemek");
                    Console.WriteLine("(5) Rehberde Arama Yapmak");
                    Console.WriteLine("(0) Çıkış yapmak.");
                    Console.Write("İslem: ");
                    islem= Convert.ToInt32(Console.ReadLine());

                switch (islem)
                {
                    case 1: kisi1.ekle1(); break;
                    case 2: kisi1.sil2();  break;                       
                    case 3: kisi1.guncelle3(); break; 
                    case 4: kisi1.listele4(); break;
                    case 5: kisi1.arama5(); break;  
                    case 0:  break;                           
                }
            }           
            
            Console.ReadKey();
            

        }
    }
}

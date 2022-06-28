using System;

namespace _5.try_catch_finally_ve_mantiksal_hatalar
{
    class Program
    {
        static void Main(string[] args)
        {
            try//hata alması muhtemel kod bloğunu giriyoruz
            {
             Console.WriteLine("Bir Sayi Giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sayi: "+sayi);
            }
            catch(Exception ex)//hata alınca ne yapılması gerektiğini
            {
              Console.WriteLine("Hata: "+ ex.Message.ToString());
            }
            finally{//optional ne olursa olsun islem tamamlandi mesajı veriyor.
              Console.WriteLine("İşlem tamamlandı.");
            }

            try
            {
                int a = int.Parse(null);
                
            }
            catch (ArgumentNullException ex)
            {
                
               Console.WriteLine("Boş değer girdiniz");
               Console.WriteLine(ex);
            }
            //ornek3
            try{
                int a2 = int.Parse("test");
            }
            catch(FormatException ex2){
                Console.WriteLine("Veri tipi uygun değil");
                Console.WriteLine(ex2);
            }
            //ornek4
            try{
                int a3 = int.Parse("-2000000000548");
            }
            catch(OverflowException ex3){
                Console.WriteLine("Çok küçük ya da çok büyük bir değer giridiniz");
                Console.WriteLine(ex3);
            }
            finally{
                Console.WriteLine("İşlem Başarılı.");
            }
            
            Console.ReadKey();
        }
    }
}

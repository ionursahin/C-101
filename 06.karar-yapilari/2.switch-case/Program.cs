using System;

namespace _6._2kararyapilari_switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int ay = DateTime.Now.Month;
            //expression-yani kontrol etmek istediğimiz koşul
            switch (ay)
            {
                case 1:
                  Console.WriteLine("Ocak"); break;
                case 2:
                  Console.WriteLine("Şubat"); break;
                case 3:
                  Console.WriteLine("Mart"); break;
                case 4:
                  Console.WriteLine("Nisan"); break;
                
                default:
                Console.WriteLine("Yanlış veri girdiniz!");
                break;
            }

            //Birden fazla case ifadesini tek bir kod bloğunda çalıştırmak.
            switch (ay)
            {
                case 12:
                case 1:
                case 2:
                  Console.WriteLine("Kış Mevsimindesiniz");
                break;
                case 3:
                case 4:
                case 5:
                Console.WriteLine("İlkbahar Mevsimindesiniz");
                break;
                case 6:
                case 7:
                case 8:
                Console.WriteLine("Yaz Mevsimindesiniz");
                break;
                case 9:
                case 10:
                case 11:
                Console.WriteLine("Sonbahar Mevsimindesiniz");
                break;
            }
            Console.ReadKey();
        }
    }
}

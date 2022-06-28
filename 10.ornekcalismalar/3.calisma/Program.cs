using System;

namespace _3.calisma
{
    class Program
    {
        static void Main(string[] args)
        {
            int uzunluk;
            string kelime;
            Console.WriteLine("Kaç adet kelime girmek istiyorsunuz?");
            uzunluk = Convert.ToInt32(Console.ReadLine());
            string[] dizi = new string[uzunluk];
            for (int i = 0; i < uzunluk; i++)
            {
                Console.Write("Lutfen Kelimeyi Giriniz: ");
                kelime = Console.ReadLine();
                dizi[i] = kelime;
            }

            Array.Reverse(dizi);
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }
    }
}

using System;

namespace _4.calisma
{
    class Program
    {
        static void Main(string[] args)
        {
            string cumle;
            int harfsayisi=0;
            int kelimesayisi=0;
            Console.Write("Lutfen bir cümle giriniz: ");
            cumle = Console.ReadLine();



            string[] kelimeler = cumle.Split(" ");
            kelimesayisi = kelimeler.Length;Console.WriteLine("Kelime sayısı: "+ kelimeler.Length);
            //split'i kullanarak boşlukları silip kelimeler dizisine tek tek ekledik.
            
            char[] harflerArray = cumle.ToCharArray(); //array kütüphanesindeki to.CharArray ile cümledeki her karakteri harflerArray dizisine tek tek ekledik
            foreach (var item in harflerArray)
            {
               if (char.IsLetter(item))
                    harfsayisi++;//isletter isimli hazır method ile de sadece harflerin sayısını hesapladık(boşluk soru isareti vb olmayacak sekilde.)
            }
            Console.WriteLine("Harf sayısı: "+ harfsayisi);
            Console.ReadKey();
        }
    }
}

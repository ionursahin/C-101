using System;
using System.Collections.Generic;
namespace _3.dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //system.collections.generic namespace
            //key ve valuedan olusular index ve dizideki eleman gibi düsünebiliriz ama aynı değil.
            //keyler unique olmalı.
            Dictionary<int, string> kullanicilar = new Dictionary<int, string>();
            kullanicilar.Add(10, "Ayşe Yılmaz");
            kullanicilar.Add(12, "Ahmet Yılmaz");
            kullanicilar.Add(18, "Deniz Arda");
            kullanicilar.Add(20, "Özcan Coşar");

            //Dizinin elemanlarına erişim
            Console.WriteLine("***Elemanlara Erişim***");
            Console.WriteLine(kullanicilar[12]);
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item);
            }

            //Count
            //Eleman sayısını sayma
            Console.WriteLine("***Count***");
            Console.WriteLine(kullanicilar.Count);

            //Contains
            //olup olmadığına bakar
            Console.WriteLine("***Contains***");
            //containskey key ile bakar
            Console.WriteLine(kullanicilar.ContainsKey(12));
            //containsvalue value ile bakar.
            Console.WriteLine(kullanicilar.ContainsValue("Onur Sahin"));

            //Remove
            //eleman çıkarma
            Console.WriteLine("***Remove***");
            kullanicilar.Remove(12);//12 keyine sahip value'yu sildik.
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item);
            }

            //Keys
            //Sadece keyleri listeleme
            Console.WriteLine("***Keys***");
            foreach (var item in kullanicilar.Keys)
            {
                Console.WriteLine(item);
            }
            //Values
            //sadece valueları listeleme.
            Console.WriteLine("***Values***");
            foreach(var item in kullanicilar.Values){
                Console.WriteLine(item);
            }
        }
    }
}

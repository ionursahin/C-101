using System;
using System.Collections;
using System.Collections.Generic;
namespace _2.array_list
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Collections namespace
            ArrayList liste = new ArrayList();
            liste.Add("Ayşe");//string atadık
            liste.Add(2);//int atadık
            liste.Add(true);//bool atadık
            liste.Add('A');//char atadık

            //içerisindeki verilere erişim
            Console.WriteLine(liste[1]);//1. indexdeki eleman

            foreach(var item in liste){
                Console.WriteLine(item);
            }

            //AddRange Methodu
            //birden fazla elemanı toplu halde eklemek
            Console.WriteLine("**AddRange**");
            string[] renkler = {"Kırmızı", "Sarı", "Yeşil"};
            List<int> sayilar = new List<int>(){1, 8, 3, 7, 9, 92, 5};
            liste.AddRange(sayilar);
            liste.AddRange(renkler);
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //Sort
            //Sıralama
            Console.WriteLine("**Sort**");
            liste.Sort();//runtimeda hata verir çünkü string, int vb var içerikte.
            
            //Binary Search
            Console.WriteLine("**Binary Search**");
            Console.WriteLine(liste.BinarySearch(9));

            //Reverse
            //listeyi aynalar yani baştaki eleman başa sondaki eleman sona şeklinde sıra sıra tüm elemanlar yer değiştirir.
            Console.WriteLine("**Reverse**");
            liste.Reverse();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }

            //Clear temizler
            Console.WriteLine("**Clear**");
            liste.Clear();
            foreach (var item in liste)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}

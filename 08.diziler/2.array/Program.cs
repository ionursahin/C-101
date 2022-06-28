using System;

namespace _2.array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Diziler Array sınıfından türüyor.Dizilerle kullanabilecegimiz bazi faydali methodları var Array'in.
            //Array Sınıfı Methodları

            //1.Sort diziyi sıralamak için kullanılıyor
            int[] sayiDizisi = {23,12,4,86,72,3,11,17};
            Console.WriteLine("***Sırasız Dizi***"); 
            foreach (var sayi in sayiDizisi)//sayiDizisi dizimizdeki elemanlarimizi "sayi" olarak tek tek yazdırıyoruz
            {
                Console.Write(" "+sayi);
            }
            Console.WriteLine("");
            Console.WriteLine("***Sıralı Dizi***");
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.Write(" "+sayi);
            }

            
            //2.Clear Dizi içerisinde verdiğimiz indexten başlayarak verdiğimiz eleman sayısı kadar değeri sıfırlıyor. Sıfır Atıyor.
            Console.WriteLine("");
            Console.WriteLine("***Array Clear**");
            //sayidizisi elemanlarını kullanarak 2. indexten itibaren 2 tane elemanı sıfırlar.
            Array.Clear(sayiDizisi,2,2);
            foreach (var sayi in sayiDizisi)
            {
                Console.Write(" "+sayi);
            }

            
            //3.Reverse
            Console.WriteLine("");
            Console.WriteLine("***Array Revers**");
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.Write(" "+sayi);
            }
            
            
            //4.IndexOf elemanın indexini gösteriyor.
            Console.WriteLine("");
            Console.WriteLine("**Array IndexOf**");
            Console.WriteLine(Array.IndexOf(sayiDizisi,23));
            //dizideki 23 elemanının indexini yazıyor.

            
            //5.Resize
            Console.WriteLine("**Array Resize**");
            Array.Resize<int>(ref sayiDizisi, 9);// int tipindeki sayiDizisinin boyutunu 9 yap. 8 elemanlı diziyi 9 elemanlı yaptı. int kısmına dizinin degisken türü yazılıyor.
            sayiDizisi[8]=99; //8. index yani 9. eleman
            foreach (var sayi in sayiDizisi)
            {
                Console.Write(" "+sayi);
            }
            
            //Console.WriteLine(""); yazmamın sebebi konsolda düzenli görüntü almak yine Console.Write(" "+sayi); seklinde yazmamın sebebi write ile yan yana yazdırdığım için aralarında boşluk olması. writeline yazsaydım alt alta yazacaktı.
            Console.ReadKey();


        }
    }
}

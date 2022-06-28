using System;

namespace _1.stringmethodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz Csharp, Hoşgeldiniz!";
            string degisken2 = "dersimiz Csharp";
            //length kaç karakter olduğunu öğrenebiliriz
            Console.WriteLine(degisken.Length);
            //ToUpper, ToLower tüm karakterleri büyütme küçütme
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());
            //Concat stringleri birlestirmeye yarıyor.
            Console.WriteLine(String.Concat(degisken, "Merhaba!"));
            //Compare, CompareTo 
            //CompareTo iki degiskeni karsilastiriyor. Eğer 1. degisken büyükse 1, küçükse -1, eşitse 0 döndürür.
            Console.WriteLine(degisken.CompareTo(""));

            //compare ayrıca bi arastır
            Console.WriteLine(String.Compare(degisken, degisken2, true));
            Console.WriteLine(String.Compare(degisken, degisken2, false)); //
             //true dersek büyük küçük harf duyarsız false dersek duyarlı olur.

             //Contains degisken 1in icinde degisken 2 varsa true döner yoksa false döner.
             Console.WriteLine(degisken.Contains(degisken2));
             //degisken "hoşgeldiniz!" ile bitiyor mu? Bitiyorsa true bitmiyorsa false döner
             Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));
             //Degisken "Merhaba" ile başlıyor mu? Başlıyorsa true başlamıyorsa false döner.
             Console.WriteLine(degisken.StartsWith("Merhaba"));

             //i karakterinin kullanıldığı son indexi getiriyor.
             Console.WriteLine(degisken.LastIndexOf("i"));

             //IndexOf degisken icerisinde "csharp" aricak ilk buldugu yerdeki indexi verir. Bulamazsa -1 döner. 0'dan başlıyor tabii ki
             Console.WriteLine(degisken.IndexOf("Csharp"));
             Console.WriteLine(degisken.IndexOf("onur"));

             //Insert 0. indexten itibaren Naber yazısını ekliyor 1 yazsaydık 1. index olurdu
             Console.WriteLine(degisken.Insert(0, "Naber!"));

             //PadLeft, PadRight
             //PadLeft degisken 2'nin sonuna 30'a tamamlanacak kadar boşluk ekler. degisken2'nin karakter sayısı 30 olması gerekiyor.

             Console.WriteLine(degisken + degisken2.PadLeft(30));
             Console.WriteLine(degisken.PadRight(50) + degisken2);

             //yıldız ekler

             Console.WriteLine(degisken + degisken2.PadLeft(30, '*'));
             Console.WriteLine(degisken.PadRight(50 , '-') + degisken2);

             //Remove
             
             //10. indexten başlayıp sonuna kadar siler. 10. indexten öncesini getirir
             Console.WriteLine(degisken.Remove(10));
             //5. indexten başlayıp 3 index siler
             Console.WriteLine(degisken.Remove(5, 3));
             // 0. indexten başlayıp 1 index siler.
             Console.WriteLine(degisken.Remove(0, 1));


             //Replace

             //csharp yazısını c# ile değiştirdi
             Console.WriteLine(degisken.Replace("Csharp", "C#"));

             // boşlukları yıldız ile değiştirdi.
             Console.WriteLine(degisken.Replace(" ", "*"));

             //Split
             Console.WriteLine(degisken.Split(' ')[1]); // boşlukları kesip cümledeki kelimeleri bi diziye atadı ve o diziden 1. indexi kelimeyi getirdi.

             //SubString

             //4. indexten baslayıp kalan karakterleri getirir.
             Console.WriteLine(degisken.Substring(4));

             //4. indexten baslayıp 6 karakter getir.
             Console.WriteLine(degisken.Substring(4, 6));
             

             Console.ReadKey();
        }
    }
}

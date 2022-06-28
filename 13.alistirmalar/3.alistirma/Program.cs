using System;
using System.Collections;
using System.Collections.Generic;

namespace _3.alistirma
{
    class Program
    {
        static void Main(string[] args)
        {
        
           //Klavyeden girilen cümledeki sesli harfleri bir diziye ekleyip. Daha sonra dizinin elemanlarını Sıralamak.
           string cumle;
           ArrayList sesliharfler = new ArrayList();
           //karşılaştırma yapmak için char veri tipinde sesliharf isimli bir array(dizi) oluşturup bütün sesli harfleri buraya ekledik.
           char[] sesliharf ={'a', 'e', 'i', 'o', 'u', 'ü', 'ö', 'ı', 'A', 'E', 'I', 'İ', 'Ö', 'O', 'U', 'Ü' };
           
           Console.WriteLine("Lütfen Bir Cümle Giriniz: ");
           cumle = Console.ReadLine();
           //harfler diye char veri tipinde bir dizi oluşturduk. Tochararray methodunu kullanarak cümledeki bütün karakterleri bu harfler dizisine ekledik.
           char[] harfler = cumle.ToCharArray();
           
           //for döngüsü içerisinde sesliharfler ve harfler isimli iki diziyi karşılaştırdık. Her ikisinde de bulunan elemanları yani sesli harfleri, Sesliharfler isimli Arraylistimize aktardık.
           for (int i=0; i< harfler.Length; i++)
           {
               for(int j=0; j< sesliharf.Length; j++){
                   if(harfler[i]== sesliharf[j]){
                    sesliharfler.Add(sesliharf[j]);
                   }
                }
           }

           foreach(var item in sesliharfler){
            Console.Write(item);
           }

           Console.ReadKey();
        }
    }
}

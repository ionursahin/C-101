using System;
using System.Collections.Generic;

namespace _1.generic_list
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Collections.Generic
            //List<T> class
            // T-> generic oldugunu belirtiyor. object türündedir. listelerin içerisindeki nesnelerin tipini ifade ediyor.
            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            //List Methodlar
            //Count
            //Eleman sayısını ogrenme
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            //foreach ve List.Foreach ile elemanlara erişmek
            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }

            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));

            //Listeden eleman çıkarma
            //remove: girilen elemanı çıkarma
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");
            // RemoveAt: girilen indexteki elemanı çıkarma
            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            //Liste İçerisinde Arama
            if(sayiListesi.Contains(10))
            {
                Console.WriteLine("10 Liste içerisinde bulundu.");
            }

            //Eleman ile index'e erişmek
            Console.WriteLine(renkListesi.BinarySearch("Turuncu"));

            //Diziyi List tipindeki bir listeye çevirmek
            string[] hayvanlar = {"kedi", "köpek", "fare", "kuş"};
            List<String> hayvanListesi = new List<string>(hayvanlar);

            //tüm Listeyi temizlemek
            hayvanListesi.Clear();

            //list içerisinde nesne tutmak
            //AŞAĞIDAKİ SINIFI BURASI İÇİN OLUSTURDUK.

            //kullanicilar classinin nesnelerinden oluşan kullanicilar tipinde bir listeme iki tane kullanici ekledik. bu kullanicilarin kendi içerisinde 3 tane propertysi var. isim,soyisim,yas
            List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();

            Kullanicilar kullanici1 = new Kullanicilar();
            kullanici1.Isim="Ayşe";
            kullanici1.Soyisim="Yılmaz";
            kullanici1.Yas=26;

            Kullanicilar kullanici2 = new Kullanicilar();
            kullanici2.Isim="Özcan";
            kullanici2.Soyisim="Çalışkan";
            kullanici2.Yas=26;

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);

            List<Kullanicilar> yeniListe = new List<Kullanicilar>();
            yeniListe.Add(new Kullanicilar(){Isim="Deniz", Soyisim="Arda", Yas=24});

            foreach (var kullanici in kullaniciListesi)
            {
                Console.WriteLine("Kullanıcı Adı: "+ kullanici.Isim);
                Console.WriteLine("Kullanıcı Soyadı: "+ kullanici.Soyisim);
                Console.WriteLine("Kullanıcı Yaşı: "+ kullanici.Yas);
            }

            
            Console.ReadKey(); 

        }
    }
    public class Kullanicilar{
        private string isim;
        private string soyisim;
        private int yas;

        //aşağıdakileri class dersinde ogrenicez. "Encapsulation"
        public string Isim { get => isim; set => isim = value;}
        public string Soyisim { get => soyisim; set => soyisim = value;}
        public int Yas { get => yas; set => yas = value;}
    }
}

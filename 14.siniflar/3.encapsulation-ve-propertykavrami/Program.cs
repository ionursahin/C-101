using System;

namespace _3.encapsulation_ve_propertykavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.Isim = "Ayşe";
            ogrenci1.Soyad = "Yılmaz";
            ogrenci1.Ogrno = 256;
            ogrenci1.Sinif = 3;
            ogrenci1.OgrenciBilgileriniGetir();
            

            ogrenci1.Sinifatla();
            ogrenci1.OgrenciBilgileriniGetir();
            //constructor kurucu sınıf ile nesne yarattık.
            Ogrenci ogrenci2 = new Ogrenci("Deniz", "Arda", 256, 1);
            ogrenci2.OgrenciBilgileriniGetir();
            ogrenci2.Sinifdusur();
            Console.ReadKey();
        }
    }
  
    class Ogrenci
    {
        private string isim;
        private string soyad;
        private int ogrno;
        private int sinif;       

        //bir alttakinin aynısını iki sekilde de kullanılabilir
        //public string Isim{get => isim; set => isim = value;}

        //aynı fieldın aynı isimde bir de public propertysini oluşturduk.
        public string Isim{
            get {return isim;} 
            set {isim = value;}
        }
        public string Soyad{
            get {return soyad;}
            set {soyad = value;}
        }
        public int Ogrno{
            get{return ogrno;}
            set{ogrno= value;}
        }
        public int Sinif{
            get{return sinif;}
            set{
                if(value <1){
                    Console.WriteLine("Sınıf En Az 1 Olabilir!"); // sinifa 1. sınıftan küçük bir sınıf setlenmesini engelledik.
                }
                  sinif = value;
            }
        }

        //constructor kurucu       

        //parametre alan kurucu
        public Ogrenci(string isim, string soyad, int ogrNo, int sinif)
        {
            Isim = isim;
            Soyad = soyad;
            Ogrno = ogrNo;
            Sinif = sinif;
        }
        public Ogrenci(){} //boş olan kurucu

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("***Ogrenci Bilgileri**");
            Console.WriteLine("Öğrenci Adı: {0} ", this.Isim);
            Console.WriteLine("Ogrenci Soyadı: {0}", this.Soyad);
            Console.WriteLine("Öğrenci No: {0}", this.Ogrno);
            Console.WriteLine("Ogrenci Sınıfı: {0}", this.Sinif);
        }

        public void Sinifatla()
        {
            this.Sinif = this.Sinif+1;
        }
        public void Sinifdusur()
        {
            this.Sinif = this.Sinif-1;
        }
    }
}


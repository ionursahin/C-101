using System;

namespace _16.telefonrehberi_uygulamasi
{
   public class kisi{
    private string ad;
    private string soyad;
    private long telno;

    public string Ad{
            get {return ad;} 
            set {ad = value;}
        }
        public string Soyad{
            get {return soyad;}
            set {soyad = value;}
        }
        public long Telno{
            get{return telno;}
            set{telno= value;}
        }

    public kisi(string Ad, string Soyad, long Telno){
        this.ad=Ad;
        this.soyad=Soyad;
        this.telno= Telno;
    }
    public kisi(){}


   }
}
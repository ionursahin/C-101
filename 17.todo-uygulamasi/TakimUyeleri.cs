using System;
using System.Collections.Generic;

namespace _17.todo_uygulamasi
{
    public class TakimUyeleri{     
        private string ad;
        private string soyad;
        private int id;    
              

        public string Ad{
            get {return ad;}
            set{ad=value;}
        }
        public string Soyad{
            get {return soyad;}
            set {soyad=value;}
        }
        public int Id{
            get {return id;}
            set {id=value;}
        }
        public TakimUyeleri(string Ad, string Soyad, int Id){
           this.ad=Ad;
           this.soyad=Soyad;
           this.id= Id;
        }     
    }
}
using System;
using System.Collections.Generic;


namespace _17.todo_uygulamasi
{
    public class Kart{
        string baslik;
        string icerik;
        string atanankisi;
        int buyuk;
        string line;
        
        

        public string Baslik{
            get {return baslik;}
            set{baslik=value;}
           }
        public string Icerik{
            get {return icerik;}
            set{icerik=value;}
           }
        public string Atanankisi{
            get{return atanankisi;}
            set{atanankisi=value;}
        }
        public int Buyuk{
            get{return buyuk;}
            set{buyuk=value;}
        }
        public string Line{
            get{return line;}
            set{line=value;}
        }
        public Kart(string Baslik, string Icerik, string Atanankisi, int Buyuk, string Line){
            this.baslik=Baslik;
            this.icerik=Icerik;
            this.atanankisi=Atanankisi;
            this.buyuk=Buyuk;
            this.line = Line;
        }
        public Kart(){}
    }
    enum buyukluk{
        XS=1,
        S=2,
        M=3,
        L=4,
        XL=5,       

    }
}
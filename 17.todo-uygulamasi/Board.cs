using System;
using System.Collections.Generic;

namespace _17.todo_uygulamasi
{
    public class Board    {
        
        
        List<Kart> kartlar = new List<Kart>();
        List<TakimUyeleri> uyeler = new List<TakimUyeleri>();  
                 
        public  Board(){
        kartlar.Add(new Kart("Dosya","Evrakları Diz.","Mahmut",3,"INPROGRESS"));
        kartlar.Add(new Kart("Program","Güncelleniyor.","Selin",3, "TODO"));
        kartlar.Add(new Kart("Toplantı","Toplantı Düzenlendi.","Sena",1,"DONE"));
        uyeler.Add(new TakimUyeleri("Mahmut", "Orhan", 457));
        uyeler.Add(new TakimUyeleri("Selin", "Dönmez", 253));
        uyeler.Add(new TakimUyeleri("Sena", "Kutlu", 654));   
        }       

        public void listele1(){
          Console.WriteLine("");
          Console.WriteLine("TODO Line");
          Console.WriteLine("**********");          
          string kolon1="TODO";
          string kolon2="INPROGRESS";
          string kolon3="DONE";
        foreach (var item in kartlar )
        {
            if( item.Line == kolon1){
               Console.WriteLine("Başlık: "+item.Baslik);
               Console.WriteLine("İçerik: "+item.Icerik);
               Console.WriteLine("Atanan Kişi: "+item.Atanankisi);
               Console.WriteLine("Büyüklük: "+item.Buyuk);
               Console.WriteLine("Line: "+ item.Line);
               Console.WriteLine("-");
            }
        }
        Console.WriteLine("INPROGRESS Line");
        Console.WriteLine("**********");
        foreach (var item in kartlar ){            
            if( item.Line == kolon2){
               Console.WriteLine("Başlık: "+item.Baslik);
               Console.WriteLine("İçerik: "+item.Icerik);
               Console.WriteLine("Atanan Kişi: "+item.Atanankisi);
               Console.WriteLine("Büyüklük: "+item.Buyuk);
               Console.WriteLine("Line: "+ item.Line);
               Console.WriteLine("-");
          }
        }
        Console.WriteLine("DONE Line");
        Console.WriteLine("**********");
        foreach (var item in kartlar ){
            
            if( item.Line == kolon3){
               Console.WriteLine("Başlık: "+item.Baslik);
               Console.WriteLine("İçerik: "+item.Icerik);
               Console.WriteLine("Atanan Kişi: "+item.Atanankisi);
               Console.WriteLine("Büyüklük: "+item.Buyuk);
               Console.WriteLine("Line: "+ item.Line);
               Console.WriteLine("-");
            }
        }
            
            
          
          
          
        }

        public void ekle(){
            int id=0;
            int kolon=0;
            Kart kart1 = new Kart();
            Console.Write("Başlık Giriniz: ");
            kart1.Baslik = Console.ReadLine();
            Console.Write("İçerik Giriniz: ");
            kart1.Icerik = Console.ReadLine();
            Console.Write("Büyüklük Seçiniz-> XS(1),S(2),M(3),L(4),XL(5): ");
            kart1.Buyuk = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kartı atamak istediğiniz kişinin ID'sini giriniz.");
            foreach (var item in uyeler)
            {
                Console.WriteLine("Ad    :"+item.Ad);
                Console.WriteLine("Soyad :"+item.Soyad);
                Console.WriteLine("ID    :"+item.Id);
                Console.WriteLine("----");
            }
            id = Convert.ToInt32(Console.ReadLine());
            foreach(var item in uyeler){              
               
                if((uyeler.IndexOf(item) == uyeler.Count -1) && !(id == item.Id)){
                    Console.WriteLine("Hatalı ID Girişi Yaptınız.");
                }
                else if((id == item.Id)){
                    kart1.Atanankisi = item.Ad;
                    kartlar.Add(kart1);
                    Console.WriteLine("Hangi Kolon'a Eklemek İstersiniz?");
                    Console.WriteLine("TODO Line       (1)");
                    Console.WriteLine("INPROGRESS Line (2)");
                    Console.WriteLine("DONE Line       (3)");
                    kolon = Convert.ToInt32(Console.ReadLine());
                    if(kolon==1){
                        kart1.Line="TODO";
                    }
                    else if(kolon ==2){
                        kart1.Line="INPROGRESS";
                    }
                    else if(kolon ==3){
                        kart1.Line="DONE";
                    }
                    else{
                        Console.WriteLine("Geçersiz Bir Sayı Girdiniz. İşlem İptal Ediliyor.");
                    }
                }
            }
        }
        public void sil(){
                
                string baslik;
                int deger=2;
                while (deger==2)
                {
                    Console.WriteLine("Silmek istediğiniz kartın başlığını yazınız.");
                    baslik = Console.ReadLine();
                    foreach (var item in kartlar)
                    {
                        if((kartlar.IndexOf(item) == kartlar.Count -1 ) && !( baslik.ToLower() == item.Baslik.ToLower()))
                        {
                            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                            Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                            Console.WriteLine("* Yeniden denemek için      : (2)");
                            deger = Convert.ToInt32(Console.ReadLine());
                        }
                        else if(baslik.ToLower() == item.Baslik.ToLower()){
                            Console.WriteLine("Başlık: "+item.Baslik);
                            Console.WriteLine("İçerik: "+item.Icerik);
                            Console.WriteLine("Atanan Kişi: "+item.Atanankisi);
                            Console.WriteLine("Büyüklük: "+item.Buyuk);
                            Console.WriteLine("Bu Kart Listeden Silindi");
                            kartlar.RemoveAt(kartlar.IndexOf(item));
                            deger=1;
                            break;
                        }
                        else{
                            continue;
                        }
                    }
                }
        }
        public void tasi(){
            
            string baslik;
            int deger=2;
            int kolon=0;
            while (deger==2){
                Console.WriteLine("Lütfen Taşımak İstediğiniz Kartın Başlığını Yazınız.");
                baslik = Console.ReadLine();

                foreach (var item in kartlar){
                    if((kartlar.IndexOf(item) == kartlar.Count -1 ) && !( baslik.ToLower() == item.Baslik.ToLower())){
                            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                            Console.WriteLine("* İşlemi sonlandırmak için : (1)");
                            Console.WriteLine("* Yeniden denemek için      : (2)");
                            deger = Convert.ToInt32(Console.ReadLine());
                    }

                    else if(baslik.ToLower() == item.Baslik.ToLower()){
                            Console.WriteLine("Bulunan Kart Bilgileri:");
                            Console.WriteLine("*****************");
                            Console.WriteLine("Başlık      :"+item.Baslik);
                            Console.WriteLine("İçerik      :"+item.Icerik);
                            Console.WriteLine("Atanan Kişi :"+item.Atanankisi);
                            Console.WriteLine("Büyüklük    :"+item.Buyuk);
                            Console.WriteLine("Line        :"+ item.Line);
                            Console.WriteLine("Lütfen Taşımak İstediğiniz Line'ı Seçin.");
                            Console.WriteLine("TODO Line       (1)");
                            Console.WriteLine("INPROGRESS Line (2)");
                            Console.WriteLine("DONE Line       (3)");
                            kolon = Convert.ToInt32(Console.ReadLine());
                        if(kolon==1){
                            item.Line="TODO";
                        }
                        else if(kolon ==2){                               
                            item.Line="INPROGRESS";
                        }
                        else if(kolon ==3){
                            item.Line="DONE";
                        }
                        else{
                            Console.WriteLine("Geçersiz Bir Sayı Girdiniz. İşlem İptal Ediliyor.");
                        }                            
                        deger=1;
                        break;
                    }

                    else{
                        continue;
                    }
                }
            }
        }
        /*public void guncelle(){

        }*/
    }
}

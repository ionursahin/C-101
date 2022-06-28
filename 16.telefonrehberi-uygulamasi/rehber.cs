using System;
using System.Collections.Generic;

namespace _16.telefonrehberi_uygulamasi
{
     public class rehber{
        //ArrayList<kisi> kisiler = new ArrayList();

        List<kisi> kisiler = new List<kisi>();

        public rehber(){
            kisiler.Add(new kisi("Mahmut", "Orhan", 555));
            kisiler.Add(new kisi("ahmet", "sankı", 5345648232));
            kisiler.Add(new kisi("Ambulans", "Acil", 112));
            kisiler.Add(new kisi("Polis", "Acil", 155));
            kisiler.Add(new kisi("İtfaiye", "Acil", 110));
        }
        public void ekle1(){

            kisi kisi1 = new kisi();
            Console.WriteLine("Lütfen isim giriniz: ");
            kisi1.Ad = Console.ReadLine();
            Console.WriteLine("Lütfen soyad giriniz: ");
            kisi1.Soyad = Console.ReadLine();
            Console.WriteLine("Lütfen telefon no giriniz: ");
            kisi1.Telno = long.Parse(Console.ReadLine());
            kisiler.Add(kisi1);
        }
        public void sil2(){
            string adsoyad;
            int deger=2;          
            while (deger==2)
            {
                Console.Write("Lütfen silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
                adsoyad = Console.ReadLine();
                foreach (var item in kisiler){
                    if((kisiler.IndexOf(item) == kisiler.Count -1) && !(adsoyad.ToLower() == item.Ad.ToLower() || adsoyad.ToLower() == item.Soyad.ToLower())){
                            Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                            Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                            Console.WriteLine("* Yeniden denemek için      : (2)");
                            deger = Convert.ToInt32(Console.ReadLine());
                    }
                    
                    else if(adsoyad.ToLower() == item.Ad.ToLower() || adsoyad.ToLower() == item.Soyad.ToLower()){
                            Console.WriteLine(item.Ad+" "+item.Soyad+" "+item.Telno+" rehberden silmek istiyor musunuz?(y/n)");
                            if(Convert.ToChar(Console.ReadLine()) == 'y'){
                                 Console.WriteLine(item.Ad+" "+item.Soyad+" "+item.Telno+" rehberden silindi");
                                 kisiler.RemoveAt(kisiler.IndexOf(item));
                                 Console.WriteLine("***");
                                 deger=1;
                                 break;
                            }
                            else{
                                 continue;
                            }
                    }                
                }
            }          
            
        }
        public void guncelle3(){
            string adsoyad;
            int deger=2;
            long yenino=0;
            while (deger==2){//anlamı şunun için simdi kullanıcının seçimi sonucunda aradığı veri bulunmazsa.devam edip etmeyeceğine karar vermesini istiyoruz 1 girirse islem bitiyor. 2 girerse islem devam ediyor. degeri iki tanımladık ve deger 2 oldugu sürece program isleyecek. asagida ise isi tamamladıktan sonra degeri 1 yapıp programdan çıkmasını sağladık.
                Console.Write("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
                adsoyad = Console.ReadLine();
                foreach (var item in kisiler)
                {
                    //eğer eşit değilse adsoyad=ad veya adsoyad=soyad
                    if((kisiler.IndexOf(item)==kisiler.Count -1)&& !(adsoyad.ToLower()==item.Ad.ToLower() || adsoyad.ToLower() == item.Soyad.ToLower() )){
                        Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                        Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                        Console.WriteLine("* Yeniden denemek için      : (2)");
                        deger = Convert.ToInt32(Console.ReadLine());
                    }
                    //eğer eşitse adsoyad=ad veya adsoyad=soyad
                    else if(adsoyad.ToLower() == item.Ad.ToLower() || adsoyad.ToLower() == item.Soyad.ToLower()){
                        Console.WriteLine(item.Ad+" "+item.Soyad+" kişisinin "+item.Telno+" nolu telefon numarasını güncellemek istiyor musunuz?(y/n)");
                        if(Convert.ToChar(Console.ReadLine()) == 'y'){//klavyeden y harfi girildiyse
                           Console.Write("Lütfen yeni numarayı giriniz: ");
                           yenino = long.Parse(Console.ReadLine());
                           item.Telno = yenino;
                           Console.WriteLine("***");
                           Console.WriteLine(item.Ad+" "+item.Soyad+" kişisinin eski telefon numarası şu şekilde güncellendi: "+item.Telno);
                           deger=1;
                           break;
                        }
                        else{
                            continue;
                        }

                    }
                }
            }
        }
        public void listele4(){
            Console.WriteLine("");
            Console.WriteLine("Telefon Rehberi");
            foreach (kisi item in kisiler)
            {             
             Console.WriteLine("**********************************************");
             Console.WriteLine("İsim: "+item.Ad);
             Console.WriteLine("Soyad: "+item.Soyad);
             Console.WriteLine("Telefon Numarası: "+item.Telno);
             Console.WriteLine("----");
            }
        }
        public void arama5(){
            int telno=0;
            int yontem=0;//ad soyad veya tel no için gerekli
            int deger=2;
            string adsoyad;
            while (deger==2)
            {
                Console.WriteLine("Lütfen arama yapmak istediğiniz yöntemi seçiniz: ");
                Console.WriteLine("**********************************************");
                Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
                Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
                yontem = Convert.ToInt32(Console.ReadLine());
                if(yontem==1){
                    Console.WriteLine("Lütfen arama yapmak istediğiniz kişinin adını veya soyismini giriniz: ");
                    adsoyad=Console.ReadLine();
                    foreach (var item in kisiler)
                    {
                        if((kisiler.IndexOf(item)==kisiler.Count-1) && !(adsoyad.ToLower()== item.Ad.ToLower() || adsoyad.ToLower()==item.Soyad.ToLower() )){
                        Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                        Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                        Console.WriteLine("* Yeniden denemek için      : (2)");
                        deger = Convert.ToInt32(Console.ReadLine());
                         
                        }
                        else if(adsoyad.ToLower()==item.Ad.ToLower() || adsoyad.ToLower() == item.Soyad.ToLower()){
                        Console.WriteLine("Aradığınız kişinin bilgileri: ");
                        Console.WriteLine("Ad: "+item.Ad+" Soyad: "+item.Soyad+" Telefon Numarası: "+item.Telno);
                        deger=1;
                        break;
                        }
                        else{
                            continue;
                        }                        
                    }
                }
                else{
                    Console.WriteLine("Lütfen arama yapmak istediğiniz kişinin telefon numarasını giriniz: ");
                    telno= Convert.ToInt32(Console.ReadLine());
                    foreach (var item in kisiler)
                    {
                        if((kisiler.IndexOf(item)==kisiler.Count -1) && !(telno==item.Telno)){
                           Console.WriteLine("Aradığını kriterlere uygun veri rehberde bulunumadı. Lütfen bir seçim yapınız.");
                           Console.WriteLine("* Aramayı sonlandırmak için : (1)");
                           Console.WriteLine("* Yeniden denemek için      : (2)");
                           deger = Convert.ToInt32(Console.ReadLine());
                        }
                        else if(telno==item.Telno){
                            Console.WriteLine("Aradığınız kişinin bilgiler: ");
                            Console.WriteLine("İsim: "+item.Ad);
                            Console.WriteLine("Soyad: "+item.Soyad);
                            Console.WriteLine("Telefon Numarası: "+item.Telno);
                            deger=1;
                            break;                      
                        }
                        else{
                            continue;
                        }
                    }
                }
            }
        }       
        
    }
}
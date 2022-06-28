using System;

namespace _1.metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //erisim_belirteci geri_donustipi metot_adi(parametrelistesi/arguman){
                //komutlar;
                //return; //geri dönüs icin
            //}
            //erisim_belirteci:metodun nerden erisilebildiği public,private vb.
            //geri_donustipi: metot iş yaptıktan sonra geri dönecek mi? her metodun geri dönüşü olmak zorunda değil o durumda void yazmak gerekiyor.
            //metot_adi: metodun isimlendirilmesi. metodun isimlendirilmesi onemli mesela koduna bakmadan ismine bakarak ne yapıp ne yapmadığını anlayabilmeyiz.
            //parametrelistesi:metodun is yaparken kullanacağı parametler. diğer adı argüman çarpma bölme geri donus vb.

            int a=2;
            int b=3;
            Console.WriteLine(a+b);
            int sonuc =Topla(a,b);
            Console.WriteLine(sonuc);
            metotlar ornek = new metotlar();//eğer başka classtan bir metoda erişmek istiyorsak o classın bir instance'ını oluşturmamız gerekiyor o yüzden ornek olusturduk.
            ornek.EkranaYazdir(Convert.ToString(sonuc));
            //
            int sonuc2 = ornek.ArttirVeTopla(ref a,ref b);//ref iyi ogren
            ornek.EkranaYazdir(Convert.ToString(sonuc2));


            Console.ReadKey();
        
        }
         static int Topla(int deger1, int deger2)
         {
            return(deger1 + deger2);
         }
    }
    class metotlar{
       public void EkranaYazdir(string veri)//void çünkü geri dönüşü yok sadece ekrana bir şey yazdırıyor. public çünkü başka sınıftan erişilmesini istiyoruz.
        {
            Console.WriteLine(veri);
        }
        public int ArttirVeTopla(ref int deger1,ref int deger2){
            deger1+=1;
            deger2+=1;
            return deger1+deger2;
        }
    }
}

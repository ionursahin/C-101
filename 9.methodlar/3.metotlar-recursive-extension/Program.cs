using System;

namespace _3.metotlar_recursive_extension
{
    class Program
    {
        static void Main(string[] args)
        {
            //recursive-öz yinelemeli(kendi kendini çağıran fonksiyon)
            //3^4 örneği = 3*3*3*3

            //for ile
            int sonuc =1;
            for (int i = 1; i < 5; i++)
            {
                sonuc = sonuc *3;
            }
            Console.WriteLine(sonuc);

            Islemler instance = new();
            //recursive metot ile
            Console.WriteLine(instance.Expo(3,4));

            //Extension Metotlar

            string ifade ="Onur Sahin";
            bool sonuc2 = ifade.boslukkontrol();
            Console.WriteLine(sonuc);
            if(sonuc2){
                Console.WriteLine(ifade.boslukkaldir());
            }
            Console.WriteLine(ifade.buyukharfyap());
            Console.WriteLine(ifade.kucukharfyap());

            //int diziyi sıralayan extension metot
            int[] dizi={9,3,6,1,5,0};
            foreach (int item in dizi)
            {
                Console.WriteLine(item);
            }//bu normal yazdırma sekli.
            
            dizi.SortArray();
            dizi.EkranaYazdir();

            //cift olup olmadığını gosteren method
            int sayi = 5;
            Console.WriteLine(sayi.ciftmi());
             
             
             Console.WriteLine(ifade.ilkkarakterial());


            Console.ReadKey();
        }
    }
    public class Islemler{
        public int Expo(int sayi, int üs){
            if(üs<2)
               return sayi;
            return Expo(sayi, üs-1) *sayi;
        }
        //Expo(3,4)
        //Expo(3,3) * 3;
        //Expo(3,2) * 3 * 3;
        //Expo(3-1) * 3 * 3 * 3;
        //3*3*3*3 = 3^4
    }
     public static class Extensions{
            public static bool boslukkontrol(this string param){
                return param.Contains(" ");
            }
            public static string boslukkaldir(this string param){
                string[] dizi = param.Split(" "); // " " bu sekilde bosluk varsa
                return string.Join("", dizi); // o boslukları "" yap yani sil.
                //join, contains, split bunlar string kütüphanesinin kendi metotları.
            }
            public static string buyukharfyap(this string param){
                return param.ToUpper();
            }
            public static string kucukharfyap(this string param){
                return param.ToLower();
            }
            public static int [] SortArray(this int[] param){
                Array.Sort(param);
                return param;
            }
            public static void  EkranaYazdir(this int[] param){
                foreach (int item in param)
                {
                    Console.WriteLine(item);
                }
            }
            public static bool ciftmi(this int param){
                return param%2==0;
            }
            public static string ilkkarakterial(this string param){
                return param.Substring(0,1);
            }
    }
}

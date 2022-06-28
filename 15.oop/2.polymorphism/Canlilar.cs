using System;

namespace _1.inheritance
{
    public class Canlilar //sealed yazarsak hiçbir sınıf bu sınıftan inheritance alamaz. "public sealed class Canlilar"
    { 
        //canlılar üst sınıf
        //temel özelliklerini yazıyoruz
        protected void Beslenme(){
            Console.WriteLine("Canlılar beslenir.");
        }
        protected void Solunum(){
            Console.WriteLine("Canlılar solunum yapar.");
        }
        protected void Bosaltim(){
            Console.WriteLine("Canlılar bosaltim yapar.");
        }


        //polymorphism ornegi
        public virtual void UyaranlaraTepki(){
            Console.WriteLine("Canlılar uyaranlara tepki verir");
        }
    }
}
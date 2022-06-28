using System;

namespace _1.inheritance
{
    public class Canlilar
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
    }
}
using System;

namespace _1.inheritance
{
    public class bitkiler:Canlilar //bitkiler canlılar sınıfından ozellik alıyor. artık.
    {
        //hayvanlardan ve insanlardan ayrıştıran özellikleri

        protected void Fotosentez(){
            Console.WriteLine("Fotosentez yaparlar.");
        }
    }
    //bitkilerin alt sınıfları
    public class TohumluBitkiler:bitkiler{

        public TohumluBitkiler(){
            base.Fotosentez();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            
        }
        public void TohumlaCogalma(){
            Console.WriteLine("Tohumlu bitkiler tohumla çoğalır.");
        }

    }
    public class TohumsuzBitkiler:bitkiler{

        public TohumsuzBitkiler(){
            base.Fotosentez();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }
        public void SporlaCogalma(){
            Console.WriteLine("Tohumsuz bitkiler sporlar çoğalırlar.");
        }
    }
}
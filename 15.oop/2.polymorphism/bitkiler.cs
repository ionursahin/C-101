using System;

namespace _1.inheritance
{
    public class bitkiler:Canlilar //bitkiler canlılar sınıfından ozellik alıyor. artık.
    {
        //hayvanlardan ve insanlardan ayrıştıran özellikleri

        protected void Fotosentez(){
            Console.WriteLine("Fotosentez yaparlar.");
        }
        //polymorphism
        public override void UyaranlaraTepki()
        {
            //base.UyaranlaraTepki(); bunu comment yaptık çünkü hayvanlar sınıfında yaptığımız gibi üst sınıftaki halini çağırmak istemiyorum. örnek işte
            Console.WriteLine("Bitkiler güneşe tepki verir");
        }
    }
    //bitkilerin alt sınıfları
    public class TohumluBitkiler:bitkiler{

        public TohumluBitkiler(){
            base.Fotosentez();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            base.UyaranlaraTepki();
            
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
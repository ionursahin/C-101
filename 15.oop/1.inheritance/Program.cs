using System;

namespace _1.inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
           /*                   Canlılar
                   Bitkiler                  Hayvanlar
            Tohumlu     Tohumsuz    Sürüngenler      Kuslar */

            //Inheritance bir üst sınıfın alt sınıfa miras vermesi anlamına geliyor. Alt sınıfın da üst sınıftan kalıtım alarak üst sınıfın bazı özelliklerini kendisinin de kullanabilmesi. Gerçek hayattaki miras alma miras verme durumuna benziyor.

            //tohumlubitkiler sınıfından tohumlu bitki diye sınıf ürettik daha sonra. tohumlubitkilerin kalıtım aldığı sınıftan ve kendi sınıfından gelen propertyleri kullanabildik.

            //constructor ile protected olanları base ile yazdırdık. bunu biraz detaylı oku arastir.
            TohumluBitkiler tohumluBitki = new TohumluBitkiler();            
            tohumluBitki.TohumlaCogalma();

            Console.WriteLine("*********");

            kuslar marti = new kuslar();
            
            marti.ucarak();



            Console.ReadKey();

        }
    }
}

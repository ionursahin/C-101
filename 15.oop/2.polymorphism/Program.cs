using System;

namespace _1.inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
           //inheritance orneginin üzerinden polymorphism calismasi.
            TohumluBitkiler tohumluBitki = new TohumluBitkiler();            
            tohumluBitki.TohumlaCogalma();

            Console.WriteLine("*********");

            kuslar marti = new kuslar();
            
            marti.ucarak();



            Console.ReadKey();

        }
    }
}

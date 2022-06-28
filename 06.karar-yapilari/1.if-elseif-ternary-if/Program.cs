using System;

namespace _6.karar_yapilari
{
    class Program
    {
        static void Main(string[] args)
        {

            int time = DateTime.Now.Hour;
            if(time>= 6 && time <11)
              Console.WriteLine("Günaydın!");
            else if (time <=18)
              Console.WriteLine("iyi Günler!");
            else
              Console.WriteLine("İyi Geceler!");
            
            //Ternary-If Ornek
            string sonuc = time<=18 ? "İyi Günler": "İyi Geceler";
            Console.WriteLine(sonuc);
            //Ternary-If Ornek2

            sonuc = time>=6 && time <=11 ? "Günaydın": time <=18 ? "İyi Günler": "İyi Geceler";
             Console.WriteLine(sonuc);
              Console.ReadKey();
        }
    }
}

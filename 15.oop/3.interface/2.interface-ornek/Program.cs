using System;

namespace _2.interface_ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            //ortak olan özellikleri interface üzerinde topladık ve classlara ondan kalıtım aldırdık.
            Focus focus = new Focus();
            Console.WriteLine(focus.Markası().ToString());
            Console.WriteLine(focus.tekerleksayisi());
            Console.WriteLine(focus.standartrengi());
            

            Civic civic = new Civic();
            Console.WriteLine(civic.Markası().ToString());
            Console.WriteLine(civic.tekerleksayisi());
            Console.WriteLine(civic.standartrengi());
    }
  }
  
}

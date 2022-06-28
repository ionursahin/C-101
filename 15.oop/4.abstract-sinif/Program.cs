using System;

namespace _2.interface_ornek
{
    class Program
    {
        static void Main(string[] args)
        {
            //Interface vs Abstract
            Console.WriteLine("***Interface***");
            Focus focus = new Focus();
            Console.WriteLine(focus.Markası().ToString());
            Console.WriteLine(focus.tekerleksayisi());
            Console.WriteLine(focus.standartrengi());            

            Civic civic = new Civic();
            Console.WriteLine(civic.Markası().ToString());
            Console.WriteLine(civic.tekerleksayisi());
            Console.WriteLine(civic.standartrengi());

            Console.WriteLine("***Abstract***");
            NewFocus focus1 = new NewFocus();
            Console.WriteLine(focus1.Markası().ToString());
            Console.WriteLine(focus1.tekerleksayisi());
            Console.WriteLine(focus1.standartrengi().ToString());
            //ilk ikisi to string çünkü değerleri enumdan geldiği için enum

            NewCivic civic1 = new NewCivic();
            Console.WriteLine(civic1.Markası().ToString());
            Console.WriteLine(civic1.tekerleksayisi());
            Console.WriteLine(civic1.standartrengi().ToString());
            Console.ReadKey();
    }
  }
  
}

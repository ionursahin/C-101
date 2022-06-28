using System;
using System.Collections.Generic;

namespace _17.todo_uygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {

          //ENUM EKSİK ONU YAP
          int islem=8;;          
          Board board1 = new Board();
          while (islem!=0)
          {
            Console.WriteLine("***********************");
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz.");
            Console.WriteLine("(1) Board Listelemek.");
            Console.WriteLine("(2) Board'a Kart Eklemek.");
            Console.WriteLine("(3) Board'dan Kart Silmek.");
            Console.WriteLine("(4) Kart Taşımak.");
            //Console.WriteLine("(5) Kart Güncellemek.");
            Console.WriteLine("(0) Çıkış Yapmak.");
            islem = Convert.ToInt32(Console.ReadLine());
            switch (islem)
            {
            case 1: board1.listele1(); break;
            case 2: board1.ekle(); break;
            case 3: board1.sil();  break;
            case 4: board1.tasi(); break;
            //case 5: board1.guncelle(); break;
            case 0: break;
            }
          }
          Console.ReadKey();
          
        }
    }
}

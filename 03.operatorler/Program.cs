using System;

namespace _3.operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********//Atama ve İşlemli Atama Operatörleri**********");
           //Atama ve İşlemli Atama
           int x = 3;
           int y =3;
           y = y+2;
           Console.WriteLine(y);
           //işlemli atama
           y += 2;
           Console.WriteLine(y);
           y /= 1;
           Console.WriteLine(y);
           x *= 2;
           Console.WriteLine(x);

           Console.WriteLine("*******Mantıksal Operatörler*******");
           //Mantıksal Operatörler
           // ||, &&, !
           // || veya demek
           // && ve demek
           // ,! değil demek
           bool isSuccess = true;
           bool isCompleted = false;
           if(isSuccess && isCompleted) 
           {
             Console.WriteLine("Perfect");
             // ikisi de true ise perfect yazdır
           }
           if(isSuccess || isCompleted)
           {
               Console.WriteLine("Great");
               //ikisinden biri(veya) true ise great yazdır.
           }
           if(isSuccess && ! isCompleted)
           {
               Console.WriteLine("Fine");
               //issuccess ise ve iscompleted değilse fine yazdır.
           }
        Console.WriteLine("****İlişkisel Operatorler****");
           //İlişkisel Operatörler
           // <, >, <=, >=, ==, !=
        int a = 3;
        int b = 4;
        bool sonuc;

        sonuc = a<b;
        Console.WriteLine(sonuc);
        sonuc = a>b;
        Console.WriteLine(sonuc);
        sonuc = a>=b;
        Console.WriteLine(sonuc);
        sonuc = a<=b;
        Console.WriteLine(sonuc);
        sonuc = a==b;
        Console.WriteLine(sonuc);
        sonuc = a!=b;
        Console.WriteLine(sonuc);
        
        Console.WriteLine("*****Aritmetik Operatörler*****");
        // /,*,+,-
        int sayi1 = 10;
        int sayi2 = 5;
        int sonuc1 = sayi1/sayi2;
        Console.WriteLine(sonuc1);
        sonuc1 = sayi1*sayi2;
        Console.WriteLine(sonuc1);
        sonuc1 = sayi1+sayi2;
        Console.WriteLine(sonuc1);
        sonuc1 = ++sayi1;
        Console.WriteLine(sonuc1);

        // %mod alır(kalanı)
        int sonuc2 = 20%3;
        Console.WriteLine(sonuc2);
        Console.ReadKey();
        }
    }
}

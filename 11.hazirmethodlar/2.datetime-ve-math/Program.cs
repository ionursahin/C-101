using System;

namespace _2.datetime_ve_math
{
    class Program
    {
        static void Main(string[] args)
        {
            //datetime kütüphanesi
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine(DateTime.Now.DayOfWeek);//hangi gün cuma vs vs
            Console.WriteLine(DateTime.Now.DayOfYear);//yılın hangi günü.
            Console.WriteLine(DateTime.Now.ToLongDateString()); //detaylı tarih
            Console.WriteLine(DateTime.Now.ToShortDateString());//detaysız tarih
            Console.WriteLine(DateTime.Now.ToLongTimeString());//detaylı saat
            Console.WriteLine(DateTime.Now.ToShortTimeString());//detaysız saat

            //add methodları

            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMilliseconds(150));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddYears(10));

            //Datetime Format
            Console.WriteLine(DateTime.Now.ToString("dd"));//ayın günü integer
            Console.WriteLine(DateTime.Now.ToString("ddd"));//sat
            Console.WriteLine(DateTime.Now.ToString("dddd"));//saturday

            Console.WriteLine(DateTime.Now.ToString("MM"));//ay sayı olarak 05
            Console.WriteLine(DateTime.Now.ToString("MMM"));//apr
            Console.WriteLine(DateTime.Now.ToString("mmmm"));//april

            Console.WriteLine(DateTime.Now.ToString("yy"));//22
            Console.WriteLine(DateTime.Now.ToString("yyyy"));//2022


            Console.WriteLine("****Math Kütüphanesi****");
            //Math Kütüphanesi
            Console.WriteLine(Math.Abs(-25));//mutlak alır 25
            Console.WriteLine(Math.Sin(10));//sinüs alır
            Console.WriteLine(Math.Cos(10));//cosinüs alır
            Console.WriteLine(Math.Tan(10));//tanjant alır


            Console.WriteLine(Math.Ceiling(22.3));//22.3ten büyük en küçük tam sayı 23 yani- her zaman yukarıya yuvarlar. 
            Console.WriteLine(Math.Round(22.3));//hangi tarafa yakınsa oraya yuvarlar 22. 22.7 olsa 23 verirdi.
            Console.WriteLine(Math.Floor(22.7));//22.7'den küçük en büyük tam sayıyı getirir yani 22- her zaman aşağıya yuvarlar
            
            //min max alır iki sayının
            Console.WriteLine(Math.Max(2, 6));
            Console.WriteLine(Math.Min(2, 6));

            Console.WriteLine(Math.Pow(3, 4));// üs alma 3^4ün sonucunu verir
            Console.WriteLine(Math.Sqrt(9));//karekök alır.
            Console.WriteLine(Math.Log(9)); // logaritma. 9un e tabanındaki logoritmik karsiligi
            Console.WriteLine(Math.Exp(3));// e üzeri 3 ü verir.
            Console.WriteLine(Math.Log10(10));// 10 un 10 tabanındaki logaritmik karsiligi
            Console.ReadKey();


        }
    }
}

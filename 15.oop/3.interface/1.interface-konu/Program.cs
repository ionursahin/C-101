using System;

namespace _1.interface_konu
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1-
            interface(arayüzler) oopnin en önemli özelliklerinden biridir. fazlaca soyut bir kavram o yüzden çok fazla pratik yapılmalı.
            2-sınıfların içermesi gereken methodların imzalarının yer aldığı özelliklerin tanımlandığı bir taslak diyebiliriz.
            3-interfaceler genel olarak"I" ile baslarlar. 
            4-interfaceler içerisindeki propertylere atama yapılmaz. methodların gövdesi yazılmaz.
            5-sadece implemente eden sınıfın ne iş yaptığının bir arayüzü olarak düşünebiliriz.
            6-interfaceden kalıtım alan sınıfın sorumluluğun yani çerçevenin çizilmesine yardımcı olur diyebiliriz. 
            */

            FileLogger filelogger = new FileLogger();
            filelogger.WriteLog();

            DatabaseLogger databaselogger = new DatabaseLogger();
            databaselogger.WriteLog();

            SmsLogger smslogger = new();//c#9 ile beraber bu sekilde de yazabiliyoruz.
            smslogger.WriteLog();

            Console.WriteLine("*******log manager ile******");

            LogManager logManager = new LogManager(new FileLogger());
            logManager.WriteLog();

            LogManager logManager2 = new LogManager(new DatabaseLogger());
            logManager2.WriteLog();

            LogManager logManager3 = new LogManager(new SmsLogger());
            logManager3.WriteLog();

            Console.ReadKey();
        }
    }
}

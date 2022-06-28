using System;

namespace _1.interface_konu
{
   public class SmsLogger:ILogger{
      public void WriteLog(){
        Console.WriteLine("Sms olarak yazar.");
      }
   }
}
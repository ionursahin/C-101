using System;

namespace _1.interface_konu
{
   public class DatabaseLogger:ILogger{
      public void WriteLog(){
        Console.WriteLine("Database'e yazar.");
      }
   }
}
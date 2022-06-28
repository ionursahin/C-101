using System;

namespace _1.interface_konu
{
   public class FileLogger:ILogger{
      public void WriteLog(){
        Console.WriteLine("Dosyaya log yazar.");
      }
   }
}
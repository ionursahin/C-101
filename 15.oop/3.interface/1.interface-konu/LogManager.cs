using System;

namespace _1.interface_konu
{
    //logmanager yaratma sebebimiz
    //Ekrana log atmak istediğimizde sürekli DatabaseLogger databaseLogger = new DatabaseLogger(); databaseLogger.writeLog(); (gibi) oluşturup göndermek yerine tek bir LogManager ile göndermek istedimiz logu içine yazıp ekrana yazdırdık yani işlemi kısatlmış olduk.
    public class LogManager:ILogger{
        public ILogger _logger; //instance yarattık. interfacein instance'ı
        public LogManager(ILogger logger){
            _logger = logger; //public olan logmanagerdan yarattığımı referansa "Logger"ı atıyoruz.
        }

        public void WriteLog(){
            _logger.WriteLog();
        }
    }
}
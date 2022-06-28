using System;

namespace _1.inheritance
{
    public class hayvanlar:Canlilar
    {
         //insanlardan ve bitkilerden ayrıştıran özellikleri.

         protected void Adaptasyon(){
            Console.WriteLine("Hayvanlar adaptasyon kurabilir.");
         }

         //polymorphism
         public override void UyaranlaraTepki(){
            base.UyaranlaraTepki(); //uyaranlara tepki metodunun sanal olarak yaratıldığı halini gel bi kere burda çalıştır demek üstteki
            Console.WriteLine("Hayvanlar temasa tepki verir.");
         }
         
    }
    public class surungenler:hayvanlar{
        //surungenler:hayvanlar yaparak surungenler sınıfının hayvanlar sınıfından kalıtım almasını sagladık yani surungenler de artık adaptasyon yapabilir.
        public surungenler(){
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltim();
            base.Solunum();
        }
        public void Surunerek(){
            Console.WriteLine("Sürüngenler sürünerek hareket eder.");
        }
    }
    public class kuslar:hayvanlar{

            public  kuslar(){
                base.Adaptasyon();
                base.Beslenme();
            base.Bosaltim();
            base.Solunum();
            base.UyaranlaraTepki();
            }
            public void ucarak(){
                Console.WriteLine("Ucarak hareket ederler.");
            }
        }
}
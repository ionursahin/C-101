using System;

namespace _5.struct_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            //sınıf vs struct farkı
            //sınıflar heapde structlar stackde 
            //sınıflar daha büyük islemler icin iyi. daha küçük daha basit küçük verili seyler için struct tanımlamak daha mantıklı.
            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.KisaKenar = 3;
            dikdortgen.UzunKenar = 4;
            Console.WriteLine("Class Alan Hesabı: {0}", dikdortgen.AlanHesapla());

            Dikdortgen_Struct dikdortgen_struct = new Dikdortgen_Struct();
            dikdortgen_struct.KisaKenar = 3;
            dikdortgen_struct.UzunKenar = 4;

            Console.WriteLine("Struct Alan Hesabı: {0}", dikdortgen_struct.AlanHesapla());

            Console.ReadKey();
        }
    }

    class Dikdortgen
    {
        public int KisaKenar;
        public int UzunKenar;
        
        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }
    }

    struct Dikdortgen_Struct
    {
        public int KisaKenar;
        public int UzunKenar;

        
        
        public long AlanHesapla()
        {
            return this.KisaKenar * this.UzunKenar;
        }
    }
}

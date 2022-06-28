using System;
namespace _2.interface_ornek
{
    public class Focus : IOtomobil
    {
        public Marka Markası()
        {
            return Marka.Ford;
        }

        public int tekerleksayisi()
        {
            return 4;
        }
        
        public Renk standartrengi()
        {
           return Renk.Kırmızı;
        }
    }
}
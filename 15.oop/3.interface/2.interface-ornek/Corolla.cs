using System;
namespace _2.interface_ornek
{
    public class Corolla : IOtomobil
    {
        public Marka Markası()
        {
            return Marka.Toyota;
        }

        public Renk standartrengi()
        {
            return Renk.Beyaz;
        }

        public int tekerleksayisi()
        {
            return 4;
        }
    }
}
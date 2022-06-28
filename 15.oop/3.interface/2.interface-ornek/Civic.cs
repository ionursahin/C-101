using System;
namespace _2.interface_ornek
{
    public class Civic : IOtomobil
    {
        public Marka Markası()
        {
            return Marka.Honda;
        }

        public Renk standartrengi()
        {
            return Renk.Gri;
        }

        public int tekerleksayisi()
        {
            return 4;
        }
    }
}
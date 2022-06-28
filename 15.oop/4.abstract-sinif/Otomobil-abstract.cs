using System;
namespace _2.interface_ornek
{
    public abstract class Otomobil{
        public int tekerleksayisi(){
            return 4;
        }
        public virtual Renk standartrengi(){
            return Renk.Beyaz;
        }
        public abstract Marka Markası();
    }
}
using System;
namespace _2.interface_ornek
{
    public class NewCivic : Otomobil{
        public override Marka Markası()
        {
            return Marka.Honda;
        }
        public override Renk standartrengi()
        {
            return Renk.Gri; // corolla ve focusun rengini beyaz olarak düşündük. ama civici gri yapmak için bunu yaptık
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
        //naming conveniton
        //sytax
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler, Sepete Eklendi! : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat)
        {
            Console.WriteLine("Tebrikler , Sepete eklendi! : " + urunAdi);
        }





    }
}

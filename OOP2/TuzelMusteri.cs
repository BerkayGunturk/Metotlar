using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Coorporate ingilizcesi;
    class TuzelMusteri : Musteri //inheritance = miras;
    {
        
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; } //Sayisal işlem barındırmadıgından (toplama,çıkarma vb) string olmalı
        //22 de geliyom

    }
}

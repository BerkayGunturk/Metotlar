using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //İndivudial ingilizcesi;
    class GercekMusteri : Musteri // Miras = inheritance
    {
        
        public string TcNo { get; set; } //Sayisal işlem barındırmadıgından (toplama,çıkarma vb) string olmalı
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}

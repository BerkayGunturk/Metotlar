using System;
using System.Collections.Generic;

namespace Koleksiyon1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Berkay", "Engin", "Ahmet", "Murat" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];//5 elemanlı YENİ bir dizi oluşturduk ! ve bellek sıfırlandı
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);// bellek yenilendiği için 0. elemanı tanımlamadıgımızdan boş kume olur.

            List<string> isimler2 = new List<string> { "Berkay", "Engin", "Ahmet", "Murat" };//Koleksiyonların avantajı!
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
            
        }
    }
}

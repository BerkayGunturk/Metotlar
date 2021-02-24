using System;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = new string[] {"Berkay","Engin","Ahmet","Murat"};
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);
            
            isimler = new string[5];//5 elemanlı YENİ bir dizi oluşturduk ! ve bellek sıfırlandı
            isimler[4] = "İlker";
            Console.WriteLine(isimler[4]);
            Console.WriteLine(isimler[0]);// bellek yenilendiği için 0. elemanı tanımlamadıgımızdan boş kume olur.



        }
    }

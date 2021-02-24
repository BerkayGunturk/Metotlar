using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string>isimler = new MyList<string>();
            isimler.Add("Berkay");

            List<string> liste = new List<string>(); //Ampulden 1.sine tıkla
            Console.WriteLine(liste.Count);


            Console.WriteLine("Hello World!");
        }
    }
}

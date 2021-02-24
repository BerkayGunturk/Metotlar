using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro //Çalışacağım özel tip
{
    class MyList<T> // T yerine ister int,string yazabilirsin tercih meselesi.
    {
        T[] items;
        //Constructor
        public MyList() //ctor yaz 2 kere tab'a bas 
        {
            items = new T[0]; //0 elamanlı dizimiz var
        }
        public void Add(T item)
        {
            T[] tempArray = items; //Geçici dizi oluşturduk.Diziye eleman eklerken eski elemanları tutmayı sağlar.
            items = new T[items.Length + 1]; //Eleman sayısını 1 arttır ! 
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;

        //constructor - metottur ve otomatik olarak çalışır
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;                  //items referans tutar değer değil
            items = new T[items.Length + 1];       // referans numarasını korumaya yarayan kod //  items.Length dizinin eleman sayısını belirtir 
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;
        }
        public int Length

        {
            get { return items.Length; }

        }
    }
}

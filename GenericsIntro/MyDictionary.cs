using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    class MyDictionary<T, A>
    {
        T[] _tempArray;
        A[] _tempArray2;
        T[] _array;
        A[] _array2;
        public MyDictionary()
        {
            _array = new T[0];
            _array2 = new A[0];
        }

        public void Add(T key, A value)
        {
            _tempArray= _array;
            _tempArray2 = _array2;

            _array = new T[_array.Length + 1];
            _array2 = new A[_array2.Length + 1];
            for (int i = 0; i < _tempArray.Length; i++)
            {
                _tempArray[i] = _array[i];
            }
            for (int i = 0; i < _tempArray2.Length; i++)
            {
                _tempArray2[i] = _array2[i];
            }

            _array[_array.Length - 1] = key;
            _array2[_array2.Length - 1] = value;

        }

        public int Length 
        
        {
            get { return _array.Length; }
            
        
        }

       

    }
}

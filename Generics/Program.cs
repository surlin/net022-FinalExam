using System;

namespace Generics
{
    class Program
    {
        public static void Main(string[] args)
        {

            GenericsCollection<int> intArray = new GenericsCollection<int>();
            intArray.Add(1);

            GenericsCollection<string> stringArray = new GenericsCollection<string>();
            stringArray.Add("Hello");

            
        }
    }


    public class GenericsCollection<T>
    {
        private T[] _items = new T[10];
        private int _numitems = 0;

        public void Add(T item)
        {
            if(_numitems + 1 < 10)
            {
                _items[_numitems] = item;
                _numitems++;
            }
        }

       
    }
}
